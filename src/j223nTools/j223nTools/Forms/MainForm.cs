using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace j223nTools.Forms
{
    /// <summary>
    /// MainForm
    /// </summary>
    public partial class MainForm : Form
    {

        #region Property

        /// <summary>
        /// NicSettings
        /// </summary>
        public List<Network.NicSetting> NicSettings { get; set; } = new List<Network.NicSetting>();

        #endregion

        #region Initialize

        /// <summary>
        /// Constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            InitializeEventHandler();
            InitializeGridView();
        }

        /// <summary>
        /// Initialize Event Handler
        /// </summary>
        private void InitializeEventHandler()
        {
            loadInfoToolStripMenuItem.Click += LoadInfoToolStripMenuItem_Click;
            aboudInfoToolStripMenuItem.Click += AboudInfoToolStripMenuItem_Click;
        }

        /// <summary>
        /// Initialize GridView
        /// </summary>
        private void InitializeGridView()
        {
            InitializeColNetworkInterfaceType();
            InitializeBindingSource();
        }

        /// <summary>
        /// Initialize colNetworkInterfaceType
        /// </summary>
        private void InitializeColNetworkInterfaceType()
        {
            var dt = new DataTable("NetworkInterfaceTypeTable");
            dt.Columns.Add("key", typeof(int));
            dt.Columns.Add("value", typeof(string));
            foreach (NetworkInterfaceType val in Enum.GetValues(typeof(NetworkInterfaceType)))
            {
                var name = Enum.GetName(typeof(NetworkInterfaceType), val);
                dt.Rows.Add(val, name);
            }
            colNetworkInterfaceType.DisplayMember = "value";
            colNetworkInterfaceType.ValueMember = "key";
            colNetworkInterfaceType.DataSource = dt;
        }

        /// <summary>
        /// Initialize GridView Datasource
        /// </summary>
        private void InitializeBindingSource()
        {
            mainBindingSource.DataSource = NicSettings;
            mainBindingSource.ResetBindings(false);
        }

        #endregion

        #region Event

        /// <summary>
        /// Click AboutInfo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboudInfoToolStripMenuItem_Click(object sender, EventArgs e) { using (var f = new AboutForm()) { f.ShowDialog(this); } }

        /// <summary>
        /// Click LoadNetworkInfo
        /// </summary>
        private void LoadInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadNicSettings();
            mainBindingSource.ResetBindings(false);
        }

        #endregion

        #region Method

        /// <summary>
        /// Load Network Info
        /// </summary>
        private void LoadNicSettings()
        {
            var nics = NetworkInterface.GetAllNetworkInterfaces();
            foreach (var adapter in nics)
            {
                var setting = NicSettings.Where(s => s.Id == adapter.Id).FirstOrDefault();
                if (setting == null)
                {
                    setting = new Network.NicSetting();
                    NicSettings.Add(setting);
                }
                setting.Id = adapter.Id;
                setting.Name = adapter.Name;
                setting.NetworkInterfaceType = (int)adapter.NetworkInterfaceType;
                setting.IPv4Address = string.Empty;
                setting.IPv4IsDHCP = false;
                if (adapter.Supports(NetworkInterfaceComponent.IPv4))
                {
                    var adapterProperties = adapter.GetIPProperties();
                    var ipv4Properties = adapterProperties.GetIPv4Properties();
                    if (ipv4Properties == null)
                        setting.IPv4Address = "No IPv4 Information.";
                    else
                    {
                        setting.IPv4IsDHCP = ipv4Properties.IsDhcpEnabled;
                        foreach (var ip in adapterProperties.UnicastAddresses.Where(ip => ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork))
                        {
                            setting.IPv4Address = ip.Address.ToString();
                            break;
                        }
                    }
                }
                else
                    setting.IPv4Address = "IPv4 Unsupport Adapter.";
            }
        }

        #endregion

    }
}
