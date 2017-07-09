namespace j223nTools.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainGrid = new System.Windows.Forms.DataGridView();
            this.mainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.createSettingFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activeSettingFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboudInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNetworkInterfaceType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colIPv4DHCP = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colActiveIPv4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActiveIPv4Mask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActiveDNS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectSettingFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainGrid
            // 
            this.mainGrid.AllowUserToAddRows = false;
            this.mainGrid.AllowUserToDeleteRows = false;
            this.mainGrid.AutoGenerateColumns = false;
            this.mainGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.mainGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.mainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colNetworkInterfaceType,
            this.colIPv4DHCP,
            this.colActiveIPv4,
            this.colActiveIPv4Mask,
            this.colActiveDNS});
            this.mainGrid.DataSource = this.mainBindingSource;
            this.mainGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainGrid.Location = new System.Drawing.Point(0, 24);
            this.mainGrid.Name = "mainGrid";
            this.mainGrid.RowTemplate.Height = 21;
            this.mainGrid.Size = new System.Drawing.Size(649, 221);
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
            this.menuStrip1.Size = new System.Drawing.Size(649, 24);
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
            this.createSettingFileToolStripMenuItem,
            this.activeSettingFileToolStripMenuItem});
            this.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem";
            this.InfoToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.InfoToolStripMenuItem.Text = "情報(I)";
            // 
            // loadInfoToolStripMenuItem
            // 
            this.loadInfoToolStripMenuItem.Name = "loadInfoToolStripMenuItem";
            this.loadInfoToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.loadInfoToolStripMenuItem.Text = "最新情報を取得(&L)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(222, 6);
            // 
            // createSettingFileToolStripMenuItem
            // 
            this.createSettingFileToolStripMenuItem.Name = "createSettingFileToolStripMenuItem";
            this.createSettingFileToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.createSettingFileToolStripMenuItem.Text = "設定ファイルを作成(&C)";
            // 
            // activeSettingFileToolStripMenuItem
            // 
            this.activeSettingFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectSettingFileToolStripMenuItem,
            this.toolStripSeparator2});
            this.activeSettingFileToolStripMenuItem.Name = "activeSettingFileToolStripMenuItem";
            this.activeSettingFileToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.activeSettingFileToolStripMenuItem.Text = "設定ファイルから設定を反映(&O)";
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
            this.statusStrip1.Size = new System.Drawing.Size(649, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
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
            // colIPv4DHCP
            // 
            this.colIPv4DHCP.DataPropertyName = "ActiveIPv4IsDHCP";
            this.colIPv4DHCP.HeaderText = "DHCP";
            this.colIPv4DHCP.Name = "colIPv4DHCP";
            this.colIPv4DHCP.ReadOnly = true;
            this.colIPv4DHCP.Width = 42;
            // 
            // colActiveIPv4
            // 
            this.colActiveIPv4.DataPropertyName = "ActiveIPv4Address";
            this.colActiveIPv4.HeaderText = "IPv4";
            this.colActiveIPv4.MaxInputLength = 15;
            this.colActiveIPv4.Name = "colActiveIPv4";
            this.colActiveIPv4.ReadOnly = true;
            this.colActiveIPv4.Width = 52;
            // 
            // colActiveIPv4Mask
            // 
            this.colActiveIPv4Mask.DataPropertyName = "ActiveIPv4Mask";
            this.colActiveIPv4Mask.HeaderText = "IPMask";
            this.colActiveIPv4Mask.Name = "colActiveIPv4Mask";
            this.colActiveIPv4Mask.ReadOnly = true;
            this.colActiveIPv4Mask.Width = 67;
            // 
            // colActiveDNS
            // 
            this.colActiveDNS.DataPropertyName = "ActiveDNS";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colActiveDNS.DefaultCellStyle = dataGridViewCellStyle1;
            this.colActiveDNS.HeaderText = "DNS";
            this.colActiveDNS.Name = "colActiveDNS";
            this.colActiveDNS.ReadOnly = true;
            this.colActiveDNS.Width = 53;
            // 
            // selectSettingFileToolStripMenuItem
            // 
            this.selectSettingFileToolStripMenuItem.Name = "selectSettingFileToolStripMenuItem";
            this.selectSettingFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.selectSettingFileToolStripMenuItem.Text = "選択(&S)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 267);
            this.Controls.Add(this.mainGrid);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "223nTools";
            ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem createSettingFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activeSettingFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboudInfoToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.BindingSource mainBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewComboBoxColumn colNetworkInterfaceType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIPv4DHCP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActiveIPv4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActiveIPv4Mask;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActiveDNS;
        private System.Windows.Forms.ToolStripMenuItem selectSettingFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

