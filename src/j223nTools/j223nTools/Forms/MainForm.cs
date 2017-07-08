using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace j223nTools.Forms
{
    /// <summary>
    /// MainForm
    /// </summary>
    public partial class MainForm : Form
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            InitializeEventHandler();
        }

        /// <summary>
        /// Initialize Event Handler
        /// </summary>
        private void InitializeEventHandler()
        {
            aboudInfoToolStripMenuItem.Click += AboudInfoToolStripMenuItem_Click;
        }

        #endregion

        #region Event

        private void AboudInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var f = new AboutForm()) { f.ShowDialog(this); }
        }

        #endregion

    }
}
