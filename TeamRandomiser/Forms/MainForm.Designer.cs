namespace TeamRandomiser.Forms
{
    partial class MainForm
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
            this.mainFormTabs = new System.Windows.Forms.TabControl();
            this.mainFormTabTeams = new System.Windows.Forms.TabPage();
            this.mainFormTabPlayers = new System.Windows.Forms.TabPage();
            this.playersContainerPnl = new System.Windows.Forms.Panel();
            this.playersSplitPanel = new System.Windows.Forms.SplitContainer();
            this.playersListHeaderPnl = new System.Windows.Forms.Panel();
            this.playersListContentPnl = new System.Windows.Forms.Panel();
            this.playersAddNewBtn = new System.Windows.Forms.Button();
            this.playersHeaderPnlLbl = new System.Windows.Forms.Label();
            this.playersListBox = new System.Windows.Forms.ListBox();
            this.playerDetailsGroup = new System.Windows.Forms.GroupBox();
            this.playerDeleteBtn = new System.Windows.Forms.Button();
            this.playerSaveBtn = new System.Windows.Forms.Button();
            this.playerRankComboLbl = new System.Windows.Forms.Label();
            this.playerRankCombo = new System.Windows.Forms.ComboBox();
            this.playerNameLbl = new System.Windows.Forms.Label();
            this.playerNameTxtBox = new System.Windows.Forms.TextBox();
            this.playerIgnLbl = new System.Windows.Forms.Label();
            this.playerIgnTxtBox = new System.Windows.Forms.TextBox();
            this.playerDetailsNameLbl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerPartnersLbl = new System.Windows.Forms.Label();
            this.playerPartnersListBox = new System.Windows.Forms.ListBox();
            this.playerPartnersAddBtn = new System.Windows.Forms.Button();
            this.teamsSplitContainer = new System.Windows.Forms.SplitContainer();
            this.teamsPlayerCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.teamsPlayerHeaderPnl = new System.Windows.Forms.Panel();
            this.teamsPlayerCheckListBoxPnl = new System.Windows.Forms.Panel();
            this.teamsPlayerHeaderLbl = new System.Windows.Forms.Label();
            this.teamsRandomiseBtn = new System.Windows.Forms.Button();
            this.teamDetailsSplitContainer = new System.Windows.Forms.SplitContainer();
            this.teamsSelectionContentPnl = new System.Windows.Forms.Panel();
            this.teamsSelectionHeaderPnl = new System.Windows.Forms.Panel();
            this.teamsSelectionHeaderLbl = new System.Windows.Forms.Label();
            this.teamsSelectionListBox = new System.Windows.Forms.ListBox();
            this.teamDetailsContentPnl = new System.Windows.Forms.Panel();
            this.teamDetailsListBox = new System.Windows.Forms.ListBox();
            this.teamDetailsHeaderPnl = new System.Windows.Forms.Panel();
            this.teamDetailsHeaderLbl = new System.Windows.Forms.Label();
            this.mainFormTabs.SuspendLayout();
            this.mainFormTabTeams.SuspendLayout();
            this.mainFormTabPlayers.SuspendLayout();
            this.playersContainerPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playersSplitPanel)).BeginInit();
            this.playersSplitPanel.Panel1.SuspendLayout();
            this.playersSplitPanel.Panel2.SuspendLayout();
            this.playersSplitPanel.SuspendLayout();
            this.playersListHeaderPnl.SuspendLayout();
            this.playersListContentPnl.SuspendLayout();
            this.playerDetailsGroup.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamsSplitContainer)).BeginInit();
            this.teamsSplitContainer.Panel1.SuspendLayout();
            this.teamsSplitContainer.Panel2.SuspendLayout();
            this.teamsSplitContainer.SuspendLayout();
            this.teamsPlayerHeaderPnl.SuspendLayout();
            this.teamsPlayerCheckListBoxPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamDetailsSplitContainer)).BeginInit();
            this.teamDetailsSplitContainer.Panel1.SuspendLayout();
            this.teamDetailsSplitContainer.Panel2.SuspendLayout();
            this.teamDetailsSplitContainer.SuspendLayout();
            this.teamsSelectionContentPnl.SuspendLayout();
            this.teamsSelectionHeaderPnl.SuspendLayout();
            this.teamDetailsContentPnl.SuspendLayout();
            this.teamDetailsHeaderPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainFormTabs
            // 
            this.mainFormTabs.Controls.Add(this.mainFormTabTeams);
            this.mainFormTabs.Controls.Add(this.mainFormTabPlayers);
            this.mainFormTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainFormTabs.Location = new System.Drawing.Point(0, 24);
            this.mainFormTabs.Name = "mainFormTabs";
            this.mainFormTabs.SelectedIndex = 0;
            this.mainFormTabs.Size = new System.Drawing.Size(800, 426);
            this.mainFormTabs.TabIndex = 0;
            // 
            // mainFormTabTeams
            // 
            this.mainFormTabTeams.Controls.Add(this.teamsSplitContainer);
            this.mainFormTabTeams.Location = new System.Drawing.Point(4, 22);
            this.mainFormTabTeams.Name = "mainFormTabTeams";
            this.mainFormTabTeams.Padding = new System.Windows.Forms.Padding(3);
            this.mainFormTabTeams.Size = new System.Drawing.Size(792, 400);
            this.mainFormTabTeams.TabIndex = 0;
            this.mainFormTabTeams.Text = "Teams";
            this.mainFormTabTeams.UseVisualStyleBackColor = true;
            // 
            // mainFormTabPlayers
            // 
            this.mainFormTabPlayers.Controls.Add(this.playersContainerPnl);
            this.mainFormTabPlayers.Location = new System.Drawing.Point(4, 22);
            this.mainFormTabPlayers.Name = "mainFormTabPlayers";
            this.mainFormTabPlayers.Padding = new System.Windows.Forms.Padding(3);
            this.mainFormTabPlayers.Size = new System.Drawing.Size(792, 400);
            this.mainFormTabPlayers.TabIndex = 1;
            this.mainFormTabPlayers.Text = "Players";
            this.mainFormTabPlayers.UseVisualStyleBackColor = true;
            // 
            // playersContainerPnl
            // 
            this.playersContainerPnl.Controls.Add(this.playersSplitPanel);
            this.playersContainerPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playersContainerPnl.Location = new System.Drawing.Point(3, 3);
            this.playersContainerPnl.Name = "playersContainerPnl";
            this.playersContainerPnl.Size = new System.Drawing.Size(786, 394);
            this.playersContainerPnl.TabIndex = 0;
            // 
            // playersSplitPanel
            // 
            this.playersSplitPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playersSplitPanel.Location = new System.Drawing.Point(0, 0);
            this.playersSplitPanel.Name = "playersSplitPanel";
            // 
            // playersSplitPanel.Panel1
            // 
            this.playersSplitPanel.Panel1.Controls.Add(this.playersListContentPnl);
            this.playersSplitPanel.Panel1.Controls.Add(this.playersListHeaderPnl);
            // 
            // playersSplitPanel.Panel2
            // 
            this.playersSplitPanel.Panel2.Controls.Add(this.playerDetailsGroup);
            this.playersSplitPanel.Size = new System.Drawing.Size(786, 394);
            this.playersSplitPanel.SplitterDistance = 262;
            this.playersSplitPanel.TabIndex = 0;
            // 
            // playersListHeaderPnl
            // 
            this.playersListHeaderPnl.Controls.Add(this.playersHeaderPnlLbl);
            this.playersListHeaderPnl.Controls.Add(this.playersAddNewBtn);
            this.playersListHeaderPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.playersListHeaderPnl.Location = new System.Drawing.Point(0, 0);
            this.playersListHeaderPnl.Name = "playersListHeaderPnl";
            this.playersListHeaderPnl.Size = new System.Drawing.Size(262, 30);
            this.playersListHeaderPnl.TabIndex = 0;
            // 
            // playersListContentPnl
            // 
            this.playersListContentPnl.Controls.Add(this.playersListBox);
            this.playersListContentPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playersListContentPnl.Location = new System.Drawing.Point(0, 30);
            this.playersListContentPnl.Name = "playersListContentPnl";
            this.playersListContentPnl.Size = new System.Drawing.Size(262, 364);
            this.playersListContentPnl.TabIndex = 1;
            // 
            // playersAddNewBtn
            // 
            this.playersAddNewBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.playersAddNewBtn.Location = new System.Drawing.Point(184, 4);
            this.playersAddNewBtn.Name = "playersAddNewBtn";
            this.playersAddNewBtn.Size = new System.Drawing.Size(75, 23);
            this.playersAddNewBtn.TabIndex = 0;
            this.playersAddNewBtn.Text = "New";
            this.playersAddNewBtn.UseVisualStyleBackColor = true;
            this.playersAddNewBtn.Click += new System.EventHandler(this.playersAddNewBtn_Click);
            // 
            // playersHeaderPnlLbl
            // 
            this.playersHeaderPnlLbl.AutoSize = true;
            this.playersHeaderPnlLbl.Location = new System.Drawing.Point(5, 9);
            this.playersHeaderPnlLbl.Name = "playersHeaderPnlLbl";
            this.playersHeaderPnlLbl.Size = new System.Drawing.Size(41, 13);
            this.playersHeaderPnlLbl.TabIndex = 1;
            this.playersHeaderPnlLbl.Text = "Players";
            // 
            // playersListBox
            // 
            this.playersListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playersListBox.FormattingEnabled = true;
            this.playersListBox.Location = new System.Drawing.Point(0, 0);
            this.playersListBox.Name = "playersListBox";
            this.playersListBox.Size = new System.Drawing.Size(262, 364);
            this.playersListBox.TabIndex = 0;
            this.playersListBox.SelectedIndexChanged += new System.EventHandler(this.playersListBox_SelectedIndexChanged);
            // 
            // playerDetailsGroup
            // 
            this.playerDetailsGroup.Controls.Add(this.playerPartnersAddBtn);
            this.playerDetailsGroup.Controls.Add(this.playerPartnersListBox);
            this.playerDetailsGroup.Controls.Add(this.playerPartnersLbl);
            this.playerDetailsGroup.Controls.Add(this.playerDetailsNameLbl);
            this.playerDetailsGroup.Controls.Add(this.playerDeleteBtn);
            this.playerDetailsGroup.Controls.Add(this.playerSaveBtn);
            this.playerDetailsGroup.Controls.Add(this.playerRankComboLbl);
            this.playerDetailsGroup.Controls.Add(this.playerRankCombo);
            this.playerDetailsGroup.Controls.Add(this.playerNameLbl);
            this.playerDetailsGroup.Controls.Add(this.playerNameTxtBox);
            this.playerDetailsGroup.Controls.Add(this.playerIgnLbl);
            this.playerDetailsGroup.Controls.Add(this.playerIgnTxtBox);
            this.playerDetailsGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playerDetailsGroup.Location = new System.Drawing.Point(0, 0);
            this.playerDetailsGroup.Name = "playerDetailsGroup";
            this.playerDetailsGroup.Size = new System.Drawing.Size(520, 394);
            this.playerDetailsGroup.TabIndex = 0;
            this.playerDetailsGroup.TabStop = false;
            this.playerDetailsGroup.Text = "Details";
            // 
            // playerDeleteBtn
            // 
            this.playerDeleteBtn.Location = new System.Drawing.Point(429, 50);
            this.playerDeleteBtn.Name = "playerDeleteBtn";
            this.playerDeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.playerDeleteBtn.TabIndex = 15;
            this.playerDeleteBtn.Text = "Delete";
            this.playerDeleteBtn.UseVisualStyleBackColor = true;
            this.playerDeleteBtn.Click += new System.EventHandler(this.playerDeleteBtn_Click);
            // 
            // playerSaveBtn
            // 
            this.playerSaveBtn.Location = new System.Drawing.Point(348, 50);
            this.playerSaveBtn.Name = "playerSaveBtn";
            this.playerSaveBtn.Size = new System.Drawing.Size(75, 23);
            this.playerSaveBtn.TabIndex = 14;
            this.playerSaveBtn.Text = "Save";
            this.playerSaveBtn.UseVisualStyleBackColor = true;
            this.playerSaveBtn.Click += new System.EventHandler(this.playerSaveBtn_Click);
            // 
            // playerRankComboLbl
            // 
            this.playerRankComboLbl.AutoSize = true;
            this.playerRankComboLbl.Location = new System.Drawing.Point(19, 92);
            this.playerRankComboLbl.Name = "playerRankComboLbl";
            this.playerRankComboLbl.Size = new System.Drawing.Size(33, 13);
            this.playerRankComboLbl.TabIndex = 13;
            this.playerRankComboLbl.Text = "Rank";
            // 
            // playerRankCombo
            // 
            this.playerRankCombo.FormattingEnabled = true;
            this.playerRankCombo.Location = new System.Drawing.Point(22, 108);
            this.playerRankCombo.Name = "playerRankCombo";
            this.playerRankCombo.Size = new System.Drawing.Size(150, 21);
            this.playerRankCombo.TabIndex = 12;
            // 
            // playerNameLbl
            // 
            this.playerNameLbl.AutoSize = true;
            this.playerNameLbl.Location = new System.Drawing.Point(186, 38);
            this.playerNameLbl.Name = "playerNameLbl";
            this.playerNameLbl.Size = new System.Drawing.Size(72, 13);
            this.playerNameLbl.TabIndex = 11;
            this.playerNameLbl.Text = "Display Name";
            // 
            // playerNameTxtBox
            // 
            this.playerNameTxtBox.Location = new System.Drawing.Point(189, 52);
            this.playerNameTxtBox.Name = "playerNameTxtBox";
            this.playerNameTxtBox.Size = new System.Drawing.Size(150, 20);
            this.playerNameTxtBox.TabIndex = 10;
            // 
            // playerIgnLbl
            // 
            this.playerIgnLbl.AutoSize = true;
            this.playerIgnLbl.Location = new System.Drawing.Point(19, 37);
            this.playerIgnLbl.Name = "playerIgnLbl";
            this.playerIgnLbl.Size = new System.Drawing.Size(26, 13);
            this.playerIgnLbl.TabIndex = 9;
            this.playerIgnLbl.Text = "IGN";
            // 
            // playerIgnTxtBox
            // 
            this.playerIgnTxtBox.Location = new System.Drawing.Point(22, 51);
            this.playerIgnTxtBox.Name = "playerIgnTxtBox";
            this.playerIgnTxtBox.Size = new System.Drawing.Size(150, 20);
            this.playerIgnTxtBox.TabIndex = 8;
            // 
            // playerDetailsNameLbl
            // 
            this.playerDetailsNameLbl.AutoSize = true;
            this.playerDetailsNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerDetailsNameLbl.Location = new System.Drawing.Point(19, 18);
            this.playerDetailsNameLbl.Name = "playerDetailsNameLbl";
            this.playerDetailsNameLbl.Size = new System.Drawing.Size(71, 13);
            this.playerDetailsNameLbl.TabIndex = 16;
            this.playerDetailsNameLbl.Text = "New Player";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teamsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.menuToolStripMenuItem.Text = "File";
            // 
            // teamsToolStripMenuItem
            // 
            this.teamsToolStripMenuItem.Name = "teamsToolStripMenuItem";
            this.teamsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.teamsToolStripMenuItem.Text = "Teams";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // playerPartnersLbl
            // 
            this.playerPartnersLbl.AutoSize = true;
            this.playerPartnersLbl.Location = new System.Drawing.Point(186, 92);
            this.playerPartnersLbl.Name = "playerPartnersLbl";
            this.playerPartnersLbl.Size = new System.Drawing.Size(46, 13);
            this.playerPartnersLbl.TabIndex = 18;
            this.playerPartnersLbl.Text = "Partners";
            // 
            // playerPartnersListBox
            // 
            this.playerPartnersListBox.FormattingEnabled = true;
            this.playerPartnersListBox.Location = new System.Drawing.Point(189, 108);
            this.playerPartnersListBox.Name = "playerPartnersListBox";
            this.playerPartnersListBox.Size = new System.Drawing.Size(150, 134);
            this.playerPartnersListBox.TabIndex = 19;
            // 
            // playerPartnersAddBtn
            // 
            this.playerPartnersAddBtn.Location = new System.Drawing.Point(348, 108);
            this.playerPartnersAddBtn.Name = "playerPartnersAddBtn";
            this.playerPartnersAddBtn.Size = new System.Drawing.Size(75, 23);
            this.playerPartnersAddBtn.TabIndex = 20;
            this.playerPartnersAddBtn.Text = "Manage";
            this.playerPartnersAddBtn.UseVisualStyleBackColor = true;
            this.playerPartnersAddBtn.Click += new System.EventHandler(this.playerPartnersAddBtn_Click);
            // 
            // teamsSplitContainer
            // 
            this.teamsSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teamsSplitContainer.Location = new System.Drawing.Point(3, 3);
            this.teamsSplitContainer.Name = "teamsSplitContainer";
            // 
            // teamsSplitContainer.Panel1
            // 
            this.teamsSplitContainer.Panel1.Controls.Add(this.teamsPlayerCheckListBoxPnl);
            this.teamsSplitContainer.Panel1.Controls.Add(this.teamsPlayerHeaderPnl);
            // 
            // teamsSplitContainer.Panel2
            // 
            this.teamsSplitContainer.Panel2.Controls.Add(this.teamDetailsSplitContainer);
            this.teamsSplitContainer.Size = new System.Drawing.Size(786, 394);
            this.teamsSplitContainer.SplitterDistance = 255;
            this.teamsSplitContainer.TabIndex = 0;
            // 
            // teamsPlayerCheckListBox
            // 
            this.teamsPlayerCheckListBox.CheckOnClick = true;
            this.teamsPlayerCheckListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teamsPlayerCheckListBox.FormattingEnabled = true;
            this.teamsPlayerCheckListBox.Location = new System.Drawing.Point(0, 0);
            this.teamsPlayerCheckListBox.Name = "teamsPlayerCheckListBox";
            this.teamsPlayerCheckListBox.Size = new System.Drawing.Size(255, 364);
            this.teamsPlayerCheckListBox.TabIndex = 0;
            // 
            // teamsPlayerHeaderPnl
            // 
            this.teamsPlayerHeaderPnl.Controls.Add(this.teamsPlayerHeaderLbl);
            this.teamsPlayerHeaderPnl.Controls.Add(this.teamsRandomiseBtn);
            this.teamsPlayerHeaderPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.teamsPlayerHeaderPnl.Location = new System.Drawing.Point(0, 0);
            this.teamsPlayerHeaderPnl.Name = "teamsPlayerHeaderPnl";
            this.teamsPlayerHeaderPnl.Size = new System.Drawing.Size(255, 30);
            this.teamsPlayerHeaderPnl.TabIndex = 0;
            // 
            // teamsPlayerCheckListBoxPnl
            // 
            this.teamsPlayerCheckListBoxPnl.Controls.Add(this.teamsPlayerCheckListBox);
            this.teamsPlayerCheckListBoxPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teamsPlayerCheckListBoxPnl.Location = new System.Drawing.Point(0, 30);
            this.teamsPlayerCheckListBoxPnl.Name = "teamsPlayerCheckListBoxPnl";
            this.teamsPlayerCheckListBoxPnl.Size = new System.Drawing.Size(255, 364);
            this.teamsPlayerCheckListBoxPnl.TabIndex = 1;
            // 
            // teamsPlayerHeaderLbl
            // 
            this.teamsPlayerHeaderLbl.AutoSize = true;
            this.teamsPlayerHeaderLbl.Location = new System.Drawing.Point(3, 8);
            this.teamsPlayerHeaderLbl.Name = "teamsPlayerHeaderLbl";
            this.teamsPlayerHeaderLbl.Size = new System.Drawing.Size(41, 13);
            this.teamsPlayerHeaderLbl.TabIndex = 3;
            this.teamsPlayerHeaderLbl.Text = "Players";
            // 
            // teamsRandomiseBtn
            // 
            this.teamsRandomiseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.teamsRandomiseBtn.Location = new System.Drawing.Point(177, 3);
            this.teamsRandomiseBtn.Name = "teamsRandomiseBtn";
            this.teamsRandomiseBtn.Size = new System.Drawing.Size(75, 23);
            this.teamsRandomiseBtn.TabIndex = 2;
            this.teamsRandomiseBtn.Text = "Randomise";
            this.teamsRandomiseBtn.UseVisualStyleBackColor = true;
            this.teamsRandomiseBtn.Click += new System.EventHandler(this.teamsRandomiseBtn_Click);
            // 
            // teamDetailsSplitContainer
            // 
            this.teamDetailsSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teamDetailsSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.teamDetailsSplitContainer.Name = "teamDetailsSplitContainer";
            // 
            // teamDetailsSplitContainer.Panel1
            // 
            this.teamDetailsSplitContainer.Panel1.Controls.Add(this.teamsSelectionContentPnl);
            this.teamDetailsSplitContainer.Panel1.Controls.Add(this.teamsSelectionHeaderPnl);
            // 
            // teamDetailsSplitContainer.Panel2
            // 
            this.teamDetailsSplitContainer.Panel2.Controls.Add(this.teamDetailsContentPnl);
            this.teamDetailsSplitContainer.Panel2.Controls.Add(this.teamDetailsHeaderPnl);
            this.teamDetailsSplitContainer.Size = new System.Drawing.Size(527, 394);
            this.teamDetailsSplitContainer.SplitterDistance = 175;
            this.teamDetailsSplitContainer.TabIndex = 0;
            // 
            // teamsSelectionContentPnl
            // 
            this.teamsSelectionContentPnl.Controls.Add(this.teamsSelectionListBox);
            this.teamsSelectionContentPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teamsSelectionContentPnl.Location = new System.Drawing.Point(0, 30);
            this.teamsSelectionContentPnl.Name = "teamsSelectionContentPnl";
            this.teamsSelectionContentPnl.Size = new System.Drawing.Size(175, 364);
            this.teamsSelectionContentPnl.TabIndex = 2;
            // 
            // teamsSelectionHeaderPnl
            // 
            this.teamsSelectionHeaderPnl.Controls.Add(this.teamsSelectionHeaderLbl);
            this.teamsSelectionHeaderPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.teamsSelectionHeaderPnl.Location = new System.Drawing.Point(0, 0);
            this.teamsSelectionHeaderPnl.Name = "teamsSelectionHeaderPnl";
            this.teamsSelectionHeaderPnl.Size = new System.Drawing.Size(175, 30);
            this.teamsSelectionHeaderPnl.TabIndex = 3;
            // 
            // teamsSelectionHeaderLbl
            // 
            this.teamsSelectionHeaderLbl.AutoSize = true;
            this.teamsSelectionHeaderLbl.Location = new System.Drawing.Point(3, 8);
            this.teamsSelectionHeaderLbl.Name = "teamsSelectionHeaderLbl";
            this.teamsSelectionHeaderLbl.Size = new System.Drawing.Size(39, 13);
            this.teamsSelectionHeaderLbl.TabIndex = 3;
            this.teamsSelectionHeaderLbl.Text = "Teams";
            // 
            // teamsSelectionListBox
            // 
            this.teamsSelectionListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teamsSelectionListBox.FormattingEnabled = true;
            this.teamsSelectionListBox.Location = new System.Drawing.Point(0, 0);
            this.teamsSelectionListBox.Name = "teamsSelectionListBox";
            this.teamsSelectionListBox.Size = new System.Drawing.Size(175, 364);
            this.teamsSelectionListBox.TabIndex = 0;
            this.teamsSelectionListBox.SelectedIndexChanged += new System.EventHandler(this.teamsSelectionListBox_SelectedIndexChanged);
            // 
            // teamDetailsContentPnl
            // 
            this.teamDetailsContentPnl.Controls.Add(this.teamDetailsListBox);
            this.teamDetailsContentPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teamDetailsContentPnl.Location = new System.Drawing.Point(0, 30);
            this.teamDetailsContentPnl.Name = "teamDetailsContentPnl";
            this.teamDetailsContentPnl.Size = new System.Drawing.Size(348, 364);
            this.teamDetailsContentPnl.TabIndex = 3;
            // 
            // teamDetailsListBox
            // 
            this.teamDetailsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teamDetailsListBox.FormattingEnabled = true;
            this.teamDetailsListBox.Location = new System.Drawing.Point(0, 0);
            this.teamDetailsListBox.Name = "teamDetailsListBox";
            this.teamDetailsListBox.Size = new System.Drawing.Size(348, 364);
            this.teamDetailsListBox.TabIndex = 0;
            // 
            // teamDetailsHeaderPnl
            // 
            this.teamDetailsHeaderPnl.Controls.Add(this.teamDetailsHeaderLbl);
            this.teamDetailsHeaderPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.teamDetailsHeaderPnl.Location = new System.Drawing.Point(0, 0);
            this.teamDetailsHeaderPnl.Name = "teamDetailsHeaderPnl";
            this.teamDetailsHeaderPnl.Size = new System.Drawing.Size(348, 30);
            this.teamDetailsHeaderPnl.TabIndex = 4;
            // 
            // teamDetailsHeaderLbl
            // 
            this.teamDetailsHeaderLbl.AutoSize = true;
            this.teamDetailsHeaderLbl.Location = new System.Drawing.Point(3, 8);
            this.teamDetailsHeaderLbl.Name = "teamDetailsHeaderLbl";
            this.teamDetailsHeaderLbl.Size = new System.Drawing.Size(65, 13);
            this.teamDetailsHeaderLbl.TabIndex = 3;
            this.teamDetailsHeaderLbl.Text = "Team Name";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainFormTabs);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Team Randomiser";
            this.mainFormTabs.ResumeLayout(false);
            this.mainFormTabTeams.ResumeLayout(false);
            this.mainFormTabPlayers.ResumeLayout(false);
            this.playersContainerPnl.ResumeLayout(false);
            this.playersSplitPanel.Panel1.ResumeLayout(false);
            this.playersSplitPanel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playersSplitPanel)).EndInit();
            this.playersSplitPanel.ResumeLayout(false);
            this.playersListHeaderPnl.ResumeLayout(false);
            this.playersListHeaderPnl.PerformLayout();
            this.playersListContentPnl.ResumeLayout(false);
            this.playerDetailsGroup.ResumeLayout(false);
            this.playerDetailsGroup.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.teamsSplitContainer.Panel1.ResumeLayout(false);
            this.teamsSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teamsSplitContainer)).EndInit();
            this.teamsSplitContainer.ResumeLayout(false);
            this.teamsPlayerHeaderPnl.ResumeLayout(false);
            this.teamsPlayerHeaderPnl.PerformLayout();
            this.teamsPlayerCheckListBoxPnl.ResumeLayout(false);
            this.teamDetailsSplitContainer.Panel1.ResumeLayout(false);
            this.teamDetailsSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teamDetailsSplitContainer)).EndInit();
            this.teamDetailsSplitContainer.ResumeLayout(false);
            this.teamsSelectionContentPnl.ResumeLayout(false);
            this.teamsSelectionHeaderPnl.ResumeLayout(false);
            this.teamsSelectionHeaderPnl.PerformLayout();
            this.teamDetailsContentPnl.ResumeLayout(false);
            this.teamDetailsHeaderPnl.ResumeLayout(false);
            this.teamDetailsHeaderPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl mainFormTabs;
        private System.Windows.Forms.TabPage mainFormTabTeams;
        private System.Windows.Forms.TabPage mainFormTabPlayers;
        private System.Windows.Forms.Panel playersContainerPnl;
        private System.Windows.Forms.SplitContainer playersSplitPanel;
        private System.Windows.Forms.Panel playersListContentPnl;
        private System.Windows.Forms.ListBox playersListBox;
        private System.Windows.Forms.Panel playersListHeaderPnl;
        private System.Windows.Forms.Label playersHeaderPnlLbl;
        private System.Windows.Forms.Button playersAddNewBtn;
        private System.Windows.Forms.GroupBox playerDetailsGroup;
        private System.Windows.Forms.Button playerDeleteBtn;
        private System.Windows.Forms.Button playerSaveBtn;
        private System.Windows.Forms.Label playerRankComboLbl;
        private System.Windows.Forms.ComboBox playerRankCombo;
        private System.Windows.Forms.Label playerNameLbl;
        private System.Windows.Forms.TextBox playerNameTxtBox;
        private System.Windows.Forms.Label playerIgnLbl;
        private System.Windows.Forms.TextBox playerIgnTxtBox;
        private System.Windows.Forms.Label playerDetailsNameLbl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teamsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button playerPartnersAddBtn;
        private System.Windows.Forms.ListBox playerPartnersListBox;
        private System.Windows.Forms.Label playerPartnersLbl;
        private System.Windows.Forms.SplitContainer teamsSplitContainer;
        private System.Windows.Forms.CheckedListBox teamsPlayerCheckListBox;
        private System.Windows.Forms.Panel teamsPlayerCheckListBoxPnl;
        private System.Windows.Forms.Panel teamsPlayerHeaderPnl;
        private System.Windows.Forms.Label teamsPlayerHeaderLbl;
        private System.Windows.Forms.Button teamsRandomiseBtn;
        private System.Windows.Forms.SplitContainer teamDetailsSplitContainer;
        private System.Windows.Forms.Panel teamsSelectionContentPnl;
        private System.Windows.Forms.ListBox teamsSelectionListBox;
        private System.Windows.Forms.Panel teamsSelectionHeaderPnl;
        private System.Windows.Forms.Label teamsSelectionHeaderLbl;
        private System.Windows.Forms.Panel teamDetailsContentPnl;
        private System.Windows.Forms.ListBox teamDetailsListBox;
        private System.Windows.Forms.Panel teamDetailsHeaderPnl;
        private System.Windows.Forms.Label teamDetailsHeaderLbl;
    }
}

