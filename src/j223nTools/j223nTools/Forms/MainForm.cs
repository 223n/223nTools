using System;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;

namespace j223nTools.Forms
{
    /// <summary>
    /// MainForm
    /// </summary>
    public partial class MainForm : Form
    {

        #region Property

        /// <summary>
        /// NIC Setting Helper
        /// </summary>
        public Network.NicSettingHelper SettingHelper { get; set; } = new Network.NicSettingHelper();

        /// <summary>
        /// NetworkInterfaceType Table
        /// </summary>
        public DataTable NetworkInterfaceTypeTable { get; set; }

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
            FormClosing += MainForm_FormClosing;
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
            NetworkInterfaceTypeTable = dt;
        }

        /// <summary>
        /// Initialize GridView Datasource
        /// </summary>
        private void InitializeBindingSource()
        {
            mainBindingSource.DataSource = SettingHelper.Table;
        }

        #endregion

        #region Release

        /// <summary>
        /// Release GridView DataSource
        /// </summary>
        private void ReleaseDataSource()
        {
            mainBindingSource.CancelEdit();
            mainBindingSource.DataSource = null;
            mainGrid.DataSource = null;
        }

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        /// <remarks>
        /// CA2213 is known bug in FxCop.
        /// Ref. Code Analysis Warning CA2213 - Call Dispose() on IDisposable backing field / stackoverflow
        /// * https://stackoverflow.com/questions/34583417/code-analysis-warning-ca2213-call-dispose-on-idisposable-backing-field
        /// </remarks>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2213:DisposableFieldsShouldBeDisposed", MessageId = "<SettingHelper>k__BackingField")]
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null) components.Dispose();
                if (SettingHelper != null)
                {
                    SettingHelper.Dispose();
                    SettingHelper = null;
                }
                if (NetworkInterfaceTypeTable != null)
                {
                    NetworkInterfaceTypeTable.Dispose();
                    NetworkInterfaceTypeTable = null;
                }
            }
            base.Dispose(disposing);
        }

        #endregion

        #region Event

        /// <summary>
        /// Closing Form
        /// </summary>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // IndexOutOfRangeException対策
            ReleaseDataSource();
        }

        /// <summary>
        /// Click AboutInfo
        /// </summary>
        private void AboudInfoToolStripMenuItem_Click(object sender, EventArgs e) { using (var f = new AboutForm()) { f.ShowDialog(this); } }

        /// <summary>
        /// Click LoadNetworkInfo
        /// </summary>
        private void LoadInfoToolStripMenuItem_Click(object sender, EventArgs e) { LoadNicSettings(); }

        #endregion

        #region Method

        /// <summary>
        /// Load Network Info
        /// </summary>
        private void LoadNicSettings()
        {
            var nics = NetworkInterface.GetAllNetworkInterfaces();
            foreach (var adapter in nics.Where(n => n.NetworkInterfaceType == NetworkInterfaceType.Ethernet || n.NetworkInterfaceType == NetworkInterfaceType.Wireless80211))
            {
                DataRow row;
                if (SettingHelper.Table.Rows.Contains(adapter.Id))
                    row = SettingHelper.Table.Rows.Find(adapter.Id);
                else
                {
                    row = SettingHelper.Table.NewRow();
                    row["Id"] = adapter.Id;
                    SettingHelper.Table.Rows.Add(row);
                }
                row["Name"] = adapter.Name;
                row["NetworkInterfaceType"] = (int)adapter.NetworkInterfaceType;
                row["ActiveIPv4Address"] = string.Empty;
                row["ActiveIPv4IsDHCP"] = false;
                if (adapter.Supports(NetworkInterfaceComponent.IPv4))
                {
                    var adapterProperties = adapter.GetIPProperties();
                    var ipv4Properties = adapterProperties.GetIPv4Properties();
                    if (ipv4Properties == null)
                        row["ActiveIPv4Address"] = "NO INFO";
                    else
                    {
                        row["ActiveIPv4IsDHCP"] = ipv4Properties.IsDhcpEnabled;
                        foreach (var ip in adapterProperties.UnicastAddresses.Where(ip => ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork))
                        {
                            row["ActiveIPv4Address"] = ip.Address.ToString();
                            row["ActiveIPv4Mask"] = ip.IPv4Mask.ToString();
                            break;
                        }
                    }
                    var dnsAddresses = new StringBuilder();
                    foreach (var dns in adapterProperties.DnsAddresses)
                        dnsAddresses.AppendLine(dns.ToString());
                    if (dnsAddresses.Length == 0)
                        row["ActiveDNS"] = string.Empty;
                    else
                        row["ActiveDNS"] = dnsAddresses.ToString().Trim();
                }
                else
                    row["ActiveIPv4Address"] = "UNSUPPORT";
            }
        }

        #endregion

    }
}
