namespace BeatSaberModManager
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabPageCore = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.comboBox_gameVersions = new System.Windows.Forms.ComboBox();
            this.folderPathLabel = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxDirectory = new System.Windows.Forms.TextBox();
            this.browseInstallationButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.listViewMods = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAuthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderVersion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenu = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.viewInfoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.directDownloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageCredits = new System.Windows.Forms.TabPage();
            this.donateModdersBox = new System.Windows.Forms.PictureBox();
            this.donateModdersLabel = new MaterialSkin.Controls.MaterialLabel();
            this.pateronLabel = new MaterialSkin.Controls.MaterialLabel();
            this.patreonBox = new System.Windows.Forms.PictureBox();
            this.creditMaterialSkin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.creditContributors = new MaterialSkin.Controls.MaterialRaisedButton();
            this.creditUmbranox = new MaterialSkin.Controls.MaterialRaisedButton();
            this.creditVanZeben = new MaterialSkin.Controls.MaterialRaisedButton();
            this.creditBeatmods = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPageHelp = new System.Windows.Forms.TabPage();
            this.discordJoinButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.helpInfoLabel1 = new System.Windows.Forms.Label();
            this.tableLayoutPanelInfo = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPluginsPath = new System.Windows.Forms.TextBox();
            this.helpInfoLabel3 = new System.Windows.Forms.Label();
            this.tabControlSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabControlMain = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageOptions = new System.Windows.Forms.TabPage();
            this.extrasGroupBox = new System.Windows.Forms.GroupBox();
            this.platformLabel = new MaterialSkin.Controls.MaterialLabel();
            this.resetSettingsButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.openSettingsFolder = new MaterialSkin.Controls.MaterialFlatButton();
            this.oneClickGroupBox = new System.Windows.Forms.GroupBox();
            this.toggleRegisterOneClick = new MaterialSkin.Controls.MaterialCheckBox();
            this.themeGroupBox = new System.Windows.Forms.GroupBox();
            this.radioThemeRed = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioThemeBlue = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioThemeOrange = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioThemeGreen = new MaterialSkin.Controls.MaterialRadioButton();
            this.toggleTheme = new MaterialSkin.Controls.MaterialCheckBox();
            this.radioThemeBlueGrey = new MaterialSkin.Controls.MaterialRadioButton();
            this.buttonInstall = new MaterialSkin.Controls.MaterialFlatButton();
            this.buttonViewInfo = new MaterialSkin.Controls.MaterialFlatButton();
            this.labelStatus = new MaterialSkin.Controls.MaterialLabel();
            this.tabPageCore.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.tabPageCredits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donateModdersBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patreonBox)).BeginInit();
            this.tabPageHelp.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.tableLayoutPanelInfo.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageOptions.SuspendLayout();
            this.extrasGroupBox.SuspendLayout();
            this.oneClickGroupBox.SuspendLayout();
            this.themeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageCore
            // 
            this.tabPageCore.Controls.Add(this.tableLayoutPanel1);
            this.tabPageCore.Location = new System.Drawing.Point(4, 22);
            this.tabPageCore.Name = "tabPageCore";
            this.tabPageCore.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCore.Size = new System.Drawing.Size(860, 401);
            this.tabPageCore.TabIndex = 0;
            this.tabPageCore.Text = "Plugins";
            this.tabPageCore.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listViewMods, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(854, 395);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Controls.Add(this.comboBox_gameVersions);
            this.panel1.Controls.Add(this.folderPathLabel);
            this.panel1.Controls.Add(this.textBoxDirectory);
            this.panel1.Controls.Add(this.browseInstallationButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 64);
            this.panel1.TabIndex = 3;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(739, 7);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(104, 19);
            this.materialLabel3.TabIndex = 33;
            this.materialLabel3.Text = "Game Version";
            // 
            // comboBox_gameVersions
            // 
            this.comboBox_gameVersions.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_gameVersions.FormattingEnabled = true;
            this.comboBox_gameVersions.Location = new System.Drawing.Point(743, 28);
            this.comboBox_gameVersions.Name = "comboBox_gameVersions";
            this.comboBox_gameVersions.Size = new System.Drawing.Size(100, 27);
            this.comboBox_gameVersions.TabIndex = 32;
            this.comboBox_gameVersions.SelectedIndexChanged += new System.EventHandler(this.comboBox_gameVersions_SelectedIndexChanged);
            // 
            // folderPathLabel
            // 
            this.folderPathLabel.AutoSize = true;
            this.folderPathLabel.Depth = 0;
            this.folderPathLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.folderPathLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.folderPathLabel.Location = new System.Drawing.Point(5, 7);
            this.folderPathLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.folderPathLabel.Name = "folderPathLabel";
            this.folderPathLabel.Size = new System.Drawing.Size(165, 19);
            this.folderPathLabel.TabIndex = 31;
            this.folderPathLabel.Text = "Beat Saber Folder Path:";
            // 
            // textBoxDirectory
            // 
            this.textBoxDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.textBoxDirectory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDirectory.Enabled = false;
            this.textBoxDirectory.Font = new System.Drawing.Font("Consolas", 12F);
            this.textBoxDirectory.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxDirectory.Location = new System.Drawing.Point(8, 29);
            this.textBoxDirectory.Name = "textBoxDirectory";
            this.textBoxDirectory.Size = new System.Drawing.Size(681, 26);
            this.textBoxDirectory.TabIndex = 29;
            this.textBoxDirectory.TextChanged += new System.EventHandler(this.textBoxDirectory_TextChanged);
            // 
            // browseInstallationButton
            // 
            this.browseInstallationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseInstallationButton.Depth = 0;
            this.browseInstallationButton.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.browseInstallationButton.Location = new System.Drawing.Point(695, 28);
            this.browseInstallationButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.browseInstallationButton.Name = "browseInstallationButton";
            this.browseInstallationButton.Primary = true;
            this.browseInstallationButton.Size = new System.Drawing.Size(26, 26);
            this.browseInstallationButton.TabIndex = 30;
            this.browseInstallationButton.Text = "..";
            this.browseInstallationButton.UseVisualStyleBackColor = true;
            this.browseInstallationButton.Click += new System.EventHandler(this.BrowseInstallationButton_Click);
            // 
            // listViewMods
            // 
            this.listViewMods.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewMods.CheckBoxes = true;
            this.listViewMods.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderAuthor,
            this.columnHeaderVersion});
            this.listViewMods.ContextMenuStrip = this.contextMenu;
            this.listViewMods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewMods.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listViewMods.FullRowSelect = true;
            this.listViewMods.Location = new System.Drawing.Point(3, 73);
            this.listViewMods.Name = "listViewMods";
            this.listViewMods.Size = new System.Drawing.Size(848, 319);
            this.listViewMods.TabIndex = 2;
            this.listViewMods.UseCompatibleStateImageBehavior = false;
            this.listViewMods.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 544;
            // 
            // columnHeaderAuthor
            // 
            this.columnHeaderAuthor.Text = "Author";
            this.columnHeaderAuthor.Width = 152;
            // 
            // columnHeaderVersion
            // 
            this.columnHeaderVersion.Text = "Version";
            this.columnHeaderVersion.Width = 112;
            // 
            // contextMenu
            // 
            this.contextMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.contextMenu.Depth = 0;
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewInfoToolStripMenuItem1,
            this.directDownloadToolStripMenuItem});
            this.contextMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.contextMenu.Name = "materialContextMenuStrip1";
            this.contextMenu.Size = new System.Drawing.Size(163, 48);
            this.contextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenu_Opening);
            // 
            // viewInfoToolStripMenuItem1
            // 
            this.viewInfoToolStripMenuItem1.Name = "viewInfoToolStripMenuItem1";
            this.viewInfoToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.viewInfoToolStripMenuItem1.Text = "View Info";
            this.viewInfoToolStripMenuItem1.Click += new System.EventHandler(this.ViewInfoToolStripMenuItem1_Click);
            // 
            // directDownloadToolStripMenuItem
            // 
            this.directDownloadToolStripMenuItem.Name = "directDownloadToolStripMenuItem";
            this.directDownloadToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.directDownloadToolStripMenuItem.Text = "Direct Download";
            this.directDownloadToolStripMenuItem.Click += new System.EventHandler(this.directDownloadToolStripMenuItem_Click);
            // 
            // tabPageCredits
            // 
            this.tabPageCredits.Controls.Add(this.donateModdersBox);
            this.tabPageCredits.Controls.Add(this.donateModdersLabel);
            this.tabPageCredits.Controls.Add(this.pateronLabel);
            this.tabPageCredits.Controls.Add(this.patreonBox);
            this.tabPageCredits.Controls.Add(this.creditMaterialSkin);
            this.tabPageCredits.Controls.Add(this.creditContributors);
            this.tabPageCredits.Controls.Add(this.creditUmbranox);
            this.tabPageCredits.Controls.Add(this.creditVanZeben);
            this.tabPageCredits.Controls.Add(this.creditBeatmods);
            this.tabPageCredits.Controls.Add(this.materialLabel1);
            this.tabPageCredits.Location = new System.Drawing.Point(4, 22);
            this.tabPageCredits.Name = "tabPageCredits";
            this.tabPageCredits.Size = new System.Drawing.Size(860, 401);
            this.tabPageCredits.TabIndex = 1;
            this.tabPageCredits.Text = "Mod Manager Credits";
            this.tabPageCredits.UseVisualStyleBackColor = true;
            // 
            // donateModdersBox
            // 
            this.donateModdersBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.donateModdersBox.Image = ((System.Drawing.Image)(resources.GetObject("donateModdersBox.Image")));
            this.donateModdersBox.Location = new System.Drawing.Point(572, 253);
            this.donateModdersBox.Name = "donateModdersBox";
            this.donateModdersBox.Size = new System.Drawing.Size(217, 51);
            this.donateModdersBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.donateModdersBox.TabIndex = 19;
            this.donateModdersBox.TabStop = false;
            this.donateModdersBox.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // donateModdersLabel
            // 
            this.donateModdersLabel.AutoSize = true;
            this.donateModdersLabel.Depth = 0;
            this.donateModdersLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.donateModdersLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.donateModdersLabel.Location = new System.Drawing.Point(528, 222);
            this.donateModdersLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.donateModdersLabel.Name = "donateModdersLabel";
            this.donateModdersLabel.Size = new System.Drawing.Size(305, 19);
            this.donateModdersLabel.TabIndex = 18;
            this.donateModdersLabel.Text = "Donate to the modders that make the mods!";
            // 
            // pateronLabel
            // 
            this.pateronLabel.AutoSize = true;
            this.pateronLabel.Depth = 0;
            this.pateronLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.pateronLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pateronLabel.Location = new System.Drawing.Point(43, 222);
            this.pateronLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.pateronLabel.Name = "pateronLabel";
            this.pateronLabel.Size = new System.Drawing.Size(270, 19);
            this.pateronLabel.TabIndex = 16;
            this.pateronLabel.Text = "Help offset server costs for BeatMods!";
            this.pateronLabel.Click += new System.EventHandler(this.materialLabel3_Click);
            // 
            // patreonBox
            // 
            this.patreonBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.patreonBox.Image = ((System.Drawing.Image)(resources.GetObject("patreonBox.Image")));
            this.patreonBox.Location = new System.Drawing.Point(69, 253);
            this.patreonBox.Name = "patreonBox";
            this.patreonBox.Size = new System.Drawing.Size(217, 51);
            this.patreonBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.patreonBox.TabIndex = 14;
            this.patreonBox.TabStop = false;
            this.patreonBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // creditMaterialSkin
            // 
            this.creditMaterialSkin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.creditMaterialSkin.Depth = 0;
            this.creditMaterialSkin.Location = new System.Drawing.Point(684, 353);
            this.creditMaterialSkin.MouseState = MaterialSkin.MouseState.HOVER;
            this.creditMaterialSkin.Name = "creditMaterialSkin";
            this.creditMaterialSkin.Primary = true;
            this.creditMaterialSkin.Size = new System.Drawing.Size(147, 35);
            this.creditMaterialSkin.TabIndex = 13;
            this.creditMaterialSkin.Text = "MaterialSkin";
            this.creditMaterialSkin.UseVisualStyleBackColor = true;
            this.creditMaterialSkin.Click += new System.EventHandler(this.CreditMaterialSkin_Click);
            // 
            // creditContributors
            // 
            this.creditContributors.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.creditContributors.Depth = 0;
            this.creditContributors.Location = new System.Drawing.Point(520, 353);
            this.creditContributors.MouseState = MaterialSkin.MouseState.HOVER;
            this.creditContributors.Name = "creditContributors";
            this.creditContributors.Primary = true;
            this.creditContributors.Size = new System.Drawing.Size(147, 35);
            this.creditContributors.TabIndex = 12;
            this.creditContributors.Text = "Contributors";
            this.creditContributors.UseVisualStyleBackColor = true;
            this.creditContributors.Click += new System.EventHandler(this.CreditContributors_Click);
            // 
            // creditUmbranox
            // 
            this.creditUmbranox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.creditUmbranox.Depth = 0;
            this.creditUmbranox.Location = new System.Drawing.Point(356, 353);
            this.creditUmbranox.MouseState = MaterialSkin.MouseState.HOVER;
            this.creditUmbranox.Name = "creditUmbranox";
            this.creditUmbranox.Primary = true;
            this.creditUmbranox.Size = new System.Drawing.Size(147, 35);
            this.creditUmbranox.TabIndex = 11;
            this.creditUmbranox.Text = "Umbranox";
            this.creditUmbranox.UseVisualStyleBackColor = true;
            this.creditUmbranox.Click += new System.EventHandler(this.CreditUmbranox_Click);
            // 
            // creditVanZeben
            // 
            this.creditVanZeben.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.creditVanZeben.Depth = 0;
            this.creditVanZeben.Location = new System.Drawing.Point(192, 353);
            this.creditVanZeben.MouseState = MaterialSkin.MouseState.HOVER;
            this.creditVanZeben.Name = "creditVanZeben";
            this.creditVanZeben.Primary = true;
            this.creditVanZeben.Size = new System.Drawing.Size(147, 35);
            this.creditVanZeben.TabIndex = 10;
            this.creditVanZeben.Text = "vanZeben";
            this.creditVanZeben.UseVisualStyleBackColor = true;
            this.creditVanZeben.Click += new System.EventHandler(this.CreditVanZeben_Click);
            // 
            // creditBeatmods
            // 
            this.creditBeatmods.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.creditBeatmods.Depth = 0;
            this.creditBeatmods.Location = new System.Drawing.Point(28, 353);
            this.creditBeatmods.MouseState = MaterialSkin.MouseState.HOVER;
            this.creditBeatmods.Name = "creditBeatmods";
            this.creditBeatmods.Primary = true;
            this.creditBeatmods.Size = new System.Drawing.Size(147, 35);
            this.creditBeatmods.TabIndex = 9;
            this.creditBeatmods.Text = "BeatMods";
            this.creditBeatmods.UseVisualStyleBackColor = true;
            this.creditBeatmods.Click += new System.EventHandler(this.CreditBeatmods_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(202, 81);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(447, 57);
            this.materialLabel1.TabIndex = 8;
            this.materialLabel1.Text = "Mod hosting platform provided by BeatMods created by vanZeben\r\nMod Installer crea" +
    "ted by Umbranox\r\nMaterialSkin created by IgnaceMaes";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPageHelp
            // 
            this.tabPageHelp.Controls.Add(this.discordJoinButton);
            this.tabPageHelp.Controls.Add(this.materialLabel2);
            this.tabPageHelp.Controls.Add(this.panelInfo);
            this.tabPageHelp.Location = new System.Drawing.Point(4, 22);
            this.tabPageHelp.Name = "tabPageHelp";
            this.tabPageHelp.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHelp.Size = new System.Drawing.Size(860, 401);
            this.tabPageHelp.TabIndex = 2;
            this.tabPageHelp.Text = "Help";
            this.tabPageHelp.UseVisualStyleBackColor = true;
            // 
            // discordJoinButton
            // 
            this.discordJoinButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.discordJoinButton.Depth = 0;
            this.discordJoinButton.Location = new System.Drawing.Point(318, 229);
            this.discordJoinButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.discordJoinButton.Name = "discordJoinButton";
            this.discordJoinButton.Primary = true;
            this.discordJoinButton.Size = new System.Drawing.Size(223, 41);
            this.discordJoinButton.TabIndex = 4;
            this.discordJoinButton.Text = "discord.gg/beatsabermods";
            this.discordJoinButton.UseVisualStyleBackColor = true;
            this.discordJoinButton.Click += new System.EventHandler(this.DiscordJoinButton_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(234, 183);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(391, 38);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Need more help?\r\nJoin us on the Beat Saber Modding Group Discord server!";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelInfo
            // 
            this.panelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInfo.BackColor = System.Drawing.SystemColors.Info;
            this.panelInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInfo.Controls.Add(this.helpInfoLabel1);
            this.panelInfo.Controls.Add(this.tableLayoutPanelInfo);
            this.panelInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.panelInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelInfo.Location = new System.Drawing.Point(8, 6);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(844, 80);
            this.panelInfo.TabIndex = 10;
            // 
            // helpInfoLabel1
            // 
            this.helpInfoLabel1.AutoSize = true;
            this.helpInfoLabel1.Location = new System.Drawing.Point(2, -1);
            this.helpInfoLabel1.Name = "helpInfoLabel1";
            this.helpInfoLabel1.Size = new System.Drawing.Size(273, 15);
            this.helpInfoLabel1.TabIndex = 0;
            this.helpInfoLabel1.Text = "Most mods will install a .dll into the Plugins folder:";
            // 
            // tableLayoutPanelInfo
            // 
            this.tableLayoutPanelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelInfo.BackColor = System.Drawing.SystemColors.Info;
            this.tableLayoutPanelInfo.ColumnCount = 1;
            this.tableLayoutPanelInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelInfo.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanelInfo.Controls.Add(this.textBoxPluginsPath, 0, 1);
            this.tableLayoutPanelInfo.Controls.Add(this.helpInfoLabel3, 0, 3);
            this.tableLayoutPanelInfo.Location = new System.Drawing.Point(-1, 3);
            this.tableLayoutPanelInfo.Name = "tableLayoutPanelInfo";
            this.tableLayoutPanelInfo.RowCount = 5;
            this.tableLayoutPanelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelInfo.Size = new System.Drawing.Size(844, 79);
            this.tableLayoutPanelInfo.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(387, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Right click on a mod in the list below to view more info about that mod.";
            // 
            // textBoxPluginsPath
            // 
            this.textBoxPluginsPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPluginsPath.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxPluginsPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPluginsPath.Location = new System.Drawing.Point(6, 17);
            this.textBoxPluginsPath.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.textBoxPluginsPath.Name = "textBoxPluginsPath";
            this.textBoxPluginsPath.ReadOnly = true;
            this.textBoxPluginsPath.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxPluginsPath.Size = new System.Drawing.Size(835, 16);
            this.textBoxPluginsPath.TabIndex = 5;
            this.textBoxPluginsPath.Click += new System.EventHandler(this.textBoxPluginsPath_Click);
            this.textBoxPluginsPath.Leave += new System.EventHandler(this.textBoxPluginsPath_Leave);
            // 
            // helpInfoLabel3
            // 
            this.helpInfoLabel3.AutoSize = true;
            this.helpInfoLabel3.Location = new System.Drawing.Point(3, 42);
            this.helpInfoLabel3.Name = "helpInfoLabel3";
            this.helpInfoLabel3.Size = new System.Drawing.Size(329, 14);
            this.helpInfoLabel3.TabIndex = 3;
            this.helpInfoLabel3.Text = "You can uninstall mods by removing the .dll from that folder.";
            // 
            // tabControlSelector
            // 
            this.tabControlSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlSelector.BaseTabControl = this.tabControlMain;
            this.tabControlSelector.Depth = 0;
            this.tabControlSelector.Location = new System.Drawing.Point(0, 64);
            this.tabControlSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControlSelector.Name = "tabControlSelector";
            this.tabControlSelector.Size = new System.Drawing.Size(864, 30);
            this.tabControlSelector.TabIndex = 14;
            this.tabControlSelector.Text = "tabControlSelector";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabPageCore);
            this.tabControlMain.Controls.Add(this.tabPageCredits);
            this.tabControlMain.Controls.Add(this.tabPageHelp);
            this.tabControlMain.Controls.Add(this.tabPageOptions);
            this.tabControlMain.Depth = 0;
            this.tabControlMain.Location = new System.Drawing.Point(-2, 91);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(868, 427);
            this.tabControlMain.TabIndex = 15;
            // 
            // tabPageOptions
            // 
            this.tabPageOptions.Controls.Add(this.extrasGroupBox);
            this.tabPageOptions.Controls.Add(this.oneClickGroupBox);
            this.tabPageOptions.Controls.Add(this.themeGroupBox);
            this.tabPageOptions.Location = new System.Drawing.Point(4, 22);
            this.tabPageOptions.Name = "tabPageOptions";
            this.tabPageOptions.Size = new System.Drawing.Size(860, 401);
            this.tabPageOptions.TabIndex = 3;
            this.tabPageOptions.Text = "Options";
            this.tabPageOptions.UseVisualStyleBackColor = true;
            // 
            // extrasGroupBox
            // 
            this.extrasGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.extrasGroupBox.Controls.Add(this.platformLabel);
            this.extrasGroupBox.Controls.Add(this.resetSettingsButton);
            this.extrasGroupBox.Controls.Add(this.openSettingsFolder);
            this.extrasGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extrasGroupBox.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.extrasGroupBox.Location = new System.Drawing.Point(16, 217);
            this.extrasGroupBox.Name = "extrasGroupBox";
            this.extrasGroupBox.Size = new System.Drawing.Size(829, 105);
            this.extrasGroupBox.TabIndex = 21;
            this.extrasGroupBox.TabStop = false;
            this.extrasGroupBox.Text = "Debugging";
            // 
            // platformLabel
            // 
            this.platformLabel.AutoSize = true;
            this.platformLabel.Depth = 0;
            this.platformLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.platformLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.platformLabel.Location = new System.Drawing.Point(17, 35);
            this.platformLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.platformLabel.Name = "platformLabel";
            this.platformLabel.Size = new System.Drawing.Size(123, 19);
            this.platformLabel.TabIndex = 22;
            this.platformLabel.Text = "Platform: Default";
            // 
            // resetSettingsButton
            // 
            this.resetSettingsButton.AutoSize = true;
            this.resetSettingsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resetSettingsButton.Depth = 0;
            this.resetSettingsButton.Location = new System.Drawing.Point(197, 60);
            this.resetSettingsButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.resetSettingsButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.resetSettingsButton.Name = "resetSettingsButton";
            this.resetSettingsButton.Primary = false;
            this.resetSettingsButton.Size = new System.Drawing.Size(203, 36);
            this.resetSettingsButton.TabIndex = 1;
            this.resetSettingsButton.Text = "Reset Settings to Default";
            this.resetSettingsButton.UseVisualStyleBackColor = true;
            this.resetSettingsButton.Click += new System.EventHandler(this.resetSettingsButton_Click);
            // 
            // openSettingsFolder
            // 
            this.openSettingsFolder.AutoSize = true;
            this.openSettingsFolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.openSettingsFolder.Depth = 0;
            this.openSettingsFolder.Location = new System.Drawing.Point(21, 60);
            this.openSettingsFolder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.openSettingsFolder.MouseState = MaterialSkin.MouseState.HOVER;
            this.openSettingsFolder.Name = "openSettingsFolder";
            this.openSettingsFolder.Primary = false;
            this.openSettingsFolder.Size = new System.Drawing.Size(168, 36);
            this.openSettingsFolder.TabIndex = 0;
            this.openSettingsFolder.Text = "Open Settings Folder";
            this.openSettingsFolder.UseVisualStyleBackColor = true;
            this.openSettingsFolder.Click += new System.EventHandler(this.openSettingsFolderButton_Click);
            // 
            // oneClickGroupBox
            // 
            this.oneClickGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oneClickGroupBox.Controls.Add(this.toggleRegisterOneClick);
            this.oneClickGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneClickGroupBox.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.oneClickGroupBox.Location = new System.Drawing.Point(16, 131);
            this.oneClickGroupBox.Name = "oneClickGroupBox";
            this.oneClickGroupBox.Size = new System.Drawing.Size(829, 80);
            this.oneClickGroupBox.TabIndex = 16;
            this.oneClickGroupBox.TabStop = false;
            this.oneClickGroupBox.Text = "OneClick Installer";
            // 
            // toggleRegisterOneClick
            // 
            this.toggleRegisterOneClick.AutoSize = true;
            this.toggleRegisterOneClick.Depth = 0;
            this.toggleRegisterOneClick.Font = new System.Drawing.Font("Roboto", 10F);
            this.toggleRegisterOneClick.Location = new System.Drawing.Point(21, 32);
            this.toggleRegisterOneClick.Margin = new System.Windows.Forms.Padding(0);
            this.toggleRegisterOneClick.MouseLocation = new System.Drawing.Point(-1, -1);
            this.toggleRegisterOneClick.MouseState = MaterialSkin.MouseState.HOVER;
            this.toggleRegisterOneClick.Name = "toggleRegisterOneClick";
            this.toggleRegisterOneClick.Ripple = true;
            this.toggleRegisterOneClick.Size = new System.Drawing.Size(297, 30);
            this.toggleRegisterOneClick.TabIndex = 20;
            this.toggleRegisterOneClick.Text = "Register as OneClick installer for BeatSaver";
            this.toggleRegisterOneClick.UseVisualStyleBackColor = true;
            this.toggleRegisterOneClick.CheckedChanged += new System.EventHandler(this.ToggleRegisterOneClick_CheckedChanged);
            // 
            // themeGroupBox
            // 
            this.themeGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.themeGroupBox.Controls.Add(this.radioThemeRed);
            this.themeGroupBox.Controls.Add(this.radioThemeBlue);
            this.themeGroupBox.Controls.Add(this.radioThemeOrange);
            this.themeGroupBox.Controls.Add(this.radioThemeGreen);
            this.themeGroupBox.Controls.Add(this.toggleTheme);
            this.themeGroupBox.Controls.Add(this.radioThemeBlueGrey);
            this.themeGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themeGroupBox.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.themeGroupBox.Location = new System.Drawing.Point(16, 3);
            this.themeGroupBox.Name = "themeGroupBox";
            this.themeGroupBox.Size = new System.Drawing.Size(829, 122);
            this.themeGroupBox.TabIndex = 15;
            this.themeGroupBox.TabStop = false;
            this.themeGroupBox.Text = "Theme";
            // 
            // radioThemeRed
            // 
            this.radioThemeRed.AutoSize = true;
            this.radioThemeRed.Depth = 0;
            this.radioThemeRed.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioThemeRed.Location = new System.Drawing.Point(499, 74);
            this.radioThemeRed.Margin = new System.Windows.Forms.Padding(0);
            this.radioThemeRed.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioThemeRed.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioThemeRed.Name = "radioThemeRed";
            this.radioThemeRed.Ripple = true;
            this.radioThemeRed.Size = new System.Drawing.Size(53, 30);
            this.radioThemeRed.TabIndex = 4;
            this.radioThemeRed.Text = "Red";
            this.radioThemeRed.UseVisualStyleBackColor = true;
            this.radioThemeRed.CheckedChanged += new System.EventHandler(this.RadioThemeRed_CheckedChanged);
            // 
            // radioThemeBlue
            // 
            this.radioThemeBlue.AutoSize = true;
            this.radioThemeBlue.Depth = 0;
            this.radioThemeBlue.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioThemeBlue.Location = new System.Drawing.Point(398, 74);
            this.radioThemeBlue.Margin = new System.Windows.Forms.Padding(0);
            this.radioThemeBlue.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioThemeBlue.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioThemeBlue.Name = "radioThemeBlue";
            this.radioThemeBlue.Ripple = true;
            this.radioThemeBlue.Size = new System.Drawing.Size(56, 30);
            this.radioThemeBlue.TabIndex = 3;
            this.radioThemeBlue.Text = "Blue";
            this.radioThemeBlue.UseVisualStyleBackColor = true;
            this.radioThemeBlue.CheckedChanged += new System.EventHandler(this.RadioThemeBlue_CheckedChanged);
            // 
            // radioThemeOrange
            // 
            this.radioThemeOrange.AutoSize = true;
            this.radioThemeOrange.Depth = 0;
            this.radioThemeOrange.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioThemeOrange.Location = new System.Drawing.Point(275, 74);
            this.radioThemeOrange.Margin = new System.Windows.Forms.Padding(0);
            this.radioThemeOrange.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioThemeOrange.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioThemeOrange.Name = "radioThemeOrange";
            this.radioThemeOrange.Ripple = true;
            this.radioThemeOrange.Size = new System.Drawing.Size(73, 30);
            this.radioThemeOrange.TabIndex = 2;
            this.radioThemeOrange.Text = "Orange";
            this.radioThemeOrange.UseVisualStyleBackColor = true;
            this.radioThemeOrange.CheckedChanged += new System.EventHandler(this.RadioThemeOrange_CheckedChanged);
            // 
            // radioThemeGreen
            // 
            this.radioThemeGreen.AutoSize = true;
            this.radioThemeGreen.Depth = 0;
            this.radioThemeGreen.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioThemeGreen.Location = new System.Drawing.Point(159, 74);
            this.radioThemeGreen.Margin = new System.Windows.Forms.Padding(0);
            this.radioThemeGreen.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioThemeGreen.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioThemeGreen.Name = "radioThemeGreen";
            this.radioThemeGreen.Ripple = true;
            this.radioThemeGreen.Size = new System.Drawing.Size(66, 30);
            this.radioThemeGreen.TabIndex = 1;
            this.radioThemeGreen.Text = "Green";
            this.radioThemeGreen.UseVisualStyleBackColor = true;
            this.radioThemeGreen.CheckedChanged += new System.EventHandler(this.RadioThemeGreen_CheckedChanged);
            // 
            // toggleTheme
            // 
            this.toggleTheme.AutoSize = true;
            this.toggleTheme.Depth = 0;
            this.toggleTheme.Font = new System.Drawing.Font("Roboto", 10F);
            this.toggleTheme.Location = new System.Drawing.Point(21, 32);
            this.toggleTheme.Margin = new System.Windows.Forms.Padding(0);
            this.toggleTheme.MouseLocation = new System.Drawing.Point(-1, -1);
            this.toggleTheme.MouseState = MaterialSkin.MouseState.HOVER;
            this.toggleTheme.Name = "toggleTheme";
            this.toggleTheme.Ripple = true;
            this.toggleTheme.Size = new System.Drawing.Size(140, 30);
            this.toggleTheme.TabIndex = 0;
            this.toggleTheme.Text = "Turn the lights off";
            this.toggleTheme.UseVisualStyleBackColor = true;
            this.toggleTheme.CheckedChanged += new System.EventHandler(this.ToggleTheme_CheckedChanged);
            // 
            // radioThemeBlueGrey
            // 
            this.radioThemeBlueGrey.AutoSize = true;
            this.radioThemeBlueGrey.Checked = true;
            this.radioThemeBlueGrey.Depth = 0;
            this.radioThemeBlueGrey.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioThemeBlueGrey.Location = new System.Drawing.Point(21, 74);
            this.radioThemeBlueGrey.Margin = new System.Windows.Forms.Padding(0);
            this.radioThemeBlueGrey.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioThemeBlueGrey.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioThemeBlueGrey.Name = "radioThemeBlueGrey";
            this.radioThemeBlueGrey.Ripple = true;
            this.radioThemeBlueGrey.Size = new System.Drawing.Size(88, 30);
            this.radioThemeBlueGrey.TabIndex = 0;
            this.radioThemeBlueGrey.TabStop = true;
            this.radioThemeBlueGrey.Text = "Blue Grey";
            this.radioThemeBlueGrey.UseVisualStyleBackColor = true;
            this.radioThemeBlueGrey.CheckedChanged += new System.EventHandler(this.RadioThemeBlueGrey_CheckedChanged);
            // 
            // buttonInstall
            // 
            this.buttonInstall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInstall.AutoSize = true;
            this.buttonInstall.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonInstall.Depth = 0;
            this.buttonInstall.Location = new System.Drawing.Point(722, 524);
            this.buttonInstall.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonInstall.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonInstall.Name = "buttonInstall";
            this.buttonInstall.Primary = false;
            this.buttonInstall.Size = new System.Drawing.Size(130, 36);
            this.buttonInstall.TabIndex = 16;
            this.buttonInstall.Text = "Install / Update";
            this.buttonInstall.UseVisualStyleBackColor = true;
            this.buttonInstall.Click += new System.EventHandler(this.ButtonInstall2_Click);
            // 
            // buttonViewInfo
            // 
            this.buttonViewInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonViewInfo.AutoSize = true;
            this.buttonViewInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonViewInfo.Depth = 0;
            this.buttonViewInfo.Enabled = false;
            this.buttonViewInfo.Location = new System.Drawing.Point(533, 524);
            this.buttonViewInfo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonViewInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonViewInfo.Name = "buttonViewInfo";
            this.buttonViewInfo.Primary = false;
            this.buttonViewInfo.Size = new System.Drawing.Size(181, 36);
            this.buttonViewInfo.TabIndex = 17;
            this.buttonViewInfo.Text = "View Selected Mod Info";
            this.buttonViewInfo.UseVisualStyleBackColor = true;
            this.buttonViewInfo.Click += new System.EventHandler(this.ButtonViewInfo2_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelStatus.Depth = 0;
            this.labelStatus.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelStatus.Location = new System.Drawing.Point(14, 533);
            this.labelStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(512, 19);
            this.labelStatus.TabIndex = 18;
            this.labelStatus.Text = "Status: NULL";
            this.labelStatus.DoubleClick += new System.EventHandler(this.LabelStatus_DoubleClick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 568);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonViewInfo);
            this.Controls.Add(this.buttonInstall);
            this.Controls.Add(this.tabControlSelector);
            this.Controls.Add(this.tabControlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beat Saber Mod Manager";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabPageCore.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenu.ResumeLayout(false);
            this.tabPageCredits.ResumeLayout(false);
            this.tabPageCredits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donateModdersBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patreonBox)).EndInit();
            this.tabPageHelp.ResumeLayout(false);
            this.tabPageHelp.PerformLayout();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.tableLayoutPanelInfo.ResumeLayout(false);
            this.tableLayoutPanelInfo.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageOptions.ResumeLayout(false);
            this.extrasGroupBox.ResumeLayout(false);
            this.extrasGroupBox.PerformLayout();
            this.oneClickGroupBox.ResumeLayout(false);
            this.oneClickGroupBox.PerformLayout();
            this.themeGroupBox.ResumeLayout(false);
            this.themeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabPage tabPageCore;
        private System.Windows.Forms.TabPage tabPageCredits;
        private System.Windows.Forms.TabPage tabPageHelp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPluginsPath;
        private System.Windows.Forms.Label helpInfoLabel3;
        private System.Windows.Forms.Label helpInfoLabel1;
        private System.Windows.Forms.Panel panelInfo;
        private MaterialSkin.Controls.MaterialTabSelector tabControlSelector;
        private MaterialSkin.Controls.MaterialTabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageOptions;
        private MaterialSkin.Controls.MaterialCheckBox toggleTheme;
        private MaterialSkin.Controls.MaterialFlatButton buttonInstall;
        private MaterialSkin.Controls.MaterialFlatButton buttonViewInfo;
        private MaterialSkin.Controls.MaterialLabel labelStatus;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton creditBeatmods;
        private MaterialSkin.Controls.MaterialRaisedButton creditVanZeben;
        private MaterialSkin.Controls.MaterialRaisedButton creditMaterialSkin;
        private MaterialSkin.Controls.MaterialRaisedButton creditContributors;
        private MaterialSkin.Controls.MaterialRaisedButton creditUmbranox;
        private MaterialSkin.Controls.MaterialRaisedButton discordJoinButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem viewInfoToolStripMenuItem1;
        private System.Windows.Forms.GroupBox themeGroupBox;
        private MaterialSkin.Controls.MaterialRadioButton radioThemeBlue;
        private MaterialSkin.Controls.MaterialRadioButton radioThemeOrange;
        private MaterialSkin.Controls.MaterialRadioButton radioThemeGreen;
        private MaterialSkin.Controls.MaterialRadioButton radioThemeBlueGrey;
        private MaterialSkin.Controls.MaterialRadioButton radioThemeRed;
        private System.Windows.Forms.ToolStripMenuItem directDownloadToolStripMenuItem;
        private System.Windows.Forms.PictureBox patreonBox;
        private MaterialSkin.Controls.MaterialLabel pateronLabel;
        private MaterialSkin.Controls.MaterialLabel donateModdersLabel;
        private System.Windows.Forms.PictureBox donateModdersBox;
        private System.Windows.Forms.GroupBox oneClickGroupBox;
        private MaterialSkin.Controls.MaterialCheckBox toggleRegisterOneClick;
        private System.Windows.Forms.GroupBox extrasGroupBox;
        private MaterialSkin.Controls.MaterialFlatButton openSettingsFolder;
        private MaterialSkin.Controls.MaterialFlatButton resetSettingsButton;
        private MaterialSkin.Controls.MaterialLabel platformLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.ComboBox comboBox_gameVersions;
        private MaterialSkin.Controls.MaterialLabel folderPathLabel;
        private System.Windows.Forms.TextBox textBoxDirectory;
        private MaterialSkin.Controls.MaterialRaisedButton browseInstallationButton;
        private System.Windows.Forms.ListView listViewMods;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderAuthor;
        private System.Windows.Forms.ColumnHeader columnHeaderVersion;
    }
}

