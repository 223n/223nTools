namespace j223nTools.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainGrid = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveSettingFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSettingFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.activateSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboudInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNetworkInterfaceType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colIPv4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIPv4DHCP = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainGrid
            // 
            this.mainGrid.AllowUserToAddRows = false;
            this.mainGrid.AllowUserToDeleteRows = false;
            this.mainGrid.AutoGenerateColumns = false;
            this.mainGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.mainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colNetworkInterfaceType,
            this.colIPv4,
            this.colIPv4DHCP});
            this.mainGrid.DataSource = this.mainBindingSource;
            this.mainGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainGrid.Location = new System.Drawing.Point(0, 24);
            this.mainGrid.Name = "mainGrid";
            this.mainGrid.RowTemplate.Height = 21;
            this.mainGrid.Size = new System.Drawing.Size(472, 221);
            this.mainGrid.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.InfoToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(472, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.fileToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.exitToolStripMenuItem.Text = "終了(&X)";
            // 
            // InfoToolStripMenuItem
            // 
            this.InfoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadInfoToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveSettingFileToolStripMenuItem,
            this.openSettingFileToolStripMenuItem,
            this.toolStripSeparator2,
            this.activateSettingToolStripMenuItem});
            this.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem";
            this.InfoToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.InfoToolStripMenuItem.Text = "情報(I)";
            // 
            // loadInfoToolStripMenuItem
            // 
            this.loadInfoToolStripMenuItem.Name = "loadInfoToolStripMenuItem";
            this.loadInfoToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.loadInfoToolStripMenuItem.Text = "最新情報を取得(&L)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(176, 6);
            // 
            // saveSettingFileToolStripMenuItem
            // 
            this.saveSettingFileToolStripMenuItem.Name = "saveSettingFileToolStripMenuItem";
            this.saveSettingFileToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.saveSettingFileToolStripMenuItem.Text = "設定ファイルに保存(&S)";
            // 
            // openSettingFileToolStripMenuItem
            // 
            this.openSettingFileToolStripMenuItem.Name = "openSettingFileToolStripMenuItem";
            this.openSettingFileToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.openSettingFileToolStripMenuItem.Text = "設定ファイルを開く(&O)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(176, 6);
            // 
            // activateSettingToolStripMenuItem
            // 
            this.activateSettingToolStripMenuItem.Name = "activateSettingToolStripMenuItem";
            this.activateSettingToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.activateSettingToolStripMenuItem.Text = "設定を反映(&A)";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboudInfoToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.helpToolStripMenuItem.Text = "ヘルプ(&H)";
            // 
            // aboudInfoToolStripMenuItem
            // 
            this.aboudInfoToolStripMenuItem.Name = "aboudInfoToolStripMenuItem";
            this.aboudInfoToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.aboudInfoToolStripMenuItem.Text = "223nToolsのバージョン情報(&A)";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 245);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(472, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 39;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 59;
            // 
            // colNetworkInterfaceType
            // 
            this.colNetworkInterfaceType.DataPropertyName = "NetworkInterfaceType";
            this.colNetworkInterfaceType.HeaderText = "NetworkInterfaceType";
            this.colNetworkInterfaceType.Name = "colNetworkInterfaceType";
            this.colNetworkInterfaceType.ReadOnly = true;
            this.colNetworkInterfaceType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colNetworkInterfaceType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colNetworkInterfaceType.Width = 142;
            // 
            // colIPv4
            // 
            this.colIPv4.DataPropertyName = "IPv4Address";
            this.colIPv4.HeaderText = "IPv4";
            this.colIPv4.Name = "colIPv4";
            this.colIPv4.Width = 52;
            // 
            // colIPv4DHCP
            // 
            this.colIPv4DHCP.DataPropertyName = "IPv4IsDHCP";
            this.colIPv4DHCP.HeaderText = "IPv4 DHCP";
            this.colIPv4DHCP.Name = "colIPv4DHCP";
            this.colIPv4DHCP.Width = 68;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 267);
            this.Controls.Add(this.mainGrid);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "223nTools";
            ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView mainGrid;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveSettingFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSettingFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem activateSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboudInfoToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewComboBoxColumn colNetworkInterfaceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIPv4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIPv4DHCP;
        private System.Windows.Forms.BindingSource mainBindingSource;
    }
}

