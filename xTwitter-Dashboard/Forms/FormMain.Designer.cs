namespace xTwitter_Dashboard.Forms
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.radStatusStrip = new Telerik.WinControls.UI.RadStatusStrip();
			this.panel = new System.Windows.Forms.Panel();
			this.radDock = new Telerik.WinControls.UI.Docking.RadDock();
			this.documentWindow_Timeline = new Telerik.WinControls.UI.Docking.DocumentWindow();
			this.radCardView_Timeline = new Telerik.WinControls.UI.RadCardView();
			this.cardViewItem5 = new Telerik.WinControls.UI.CardViewItem();
			this.cardViewGroupItem1 = new Telerik.WinControls.UI.CardViewGroupItem();
			this.cardViewItem1 = new Telerik.WinControls.UI.CardViewItem();
			this.cardViewItem2 = new Telerik.WinControls.UI.CardViewItem();
			this.cardViewItem3 = new Telerik.WinControls.UI.CardViewItem();
			this.cardViewItem4 = new Telerik.WinControls.UI.CardViewItem();
			this.cardViewItem6 = new Telerik.WinControls.UI.CardViewItem();
			this.cardViewItem7 = new Telerik.WinControls.UI.CardViewItem();
			this.timelineObjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.documentContainer = new Telerik.WinControls.UI.Docking.DocumentContainer();
			this.documentTabStrip = new Telerik.WinControls.UI.Docking.DocumentTabStrip();
			this.materialTheme = new Telerik.WinControls.Themes.MaterialTheme();
			this.radRibbonBar = new Telerik.WinControls.UI.RadRibbonBar();
			this.ribbonTab_Home = new Telerik.WinControls.UI.RibbonTab();
			this.radRibbonBarGroup_Account = new Telerik.WinControls.UI.RadRibbonBarGroup();
			this.radButtonElement_Login = new Telerik.WinControls.UI.RadButtonElement();
			this.radRibbonBarButtonGroup_Profile = new Telerik.WinControls.UI.RadRibbonBarButtonGroup();
			this.radLabelElement_Profile = new Telerik.WinControls.UI.RadLabelElement();
			this.radRibbonBarButtonGroup_Name = new Telerik.WinControls.UI.RadRibbonBarButtonGroup();
			this.radLabelElement_Id = new Telerik.WinControls.UI.RadLabelElement();
			this.radLabelElement_ScreenName = new Telerik.WinControls.UI.RadLabelElement();
			this.ribbonTab_DB = new Telerik.WinControls.UI.RibbonTab();
			((System.ComponentModel.ISupportInitialize)(this.radStatusStrip)).BeginInit();
			this.panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.radDock)).BeginInit();
			this.radDock.SuspendLayout();
			this.documentWindow_Timeline.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.radCardView_Timeline)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radCardView_Timeline.CardTemplate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.timelineObjectBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.documentContainer)).BeginInit();
			this.documentContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.documentTabStrip)).BeginInit();
			this.documentTabStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.radRibbonBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			this.SuspendLayout();
			// 
			// radStatusStrip
			// 
			this.radStatusStrip.Location = new System.Drawing.Point(0, 570);
			this.radStatusStrip.Name = "radStatusStrip";
			this.radStatusStrip.Size = new System.Drawing.Size(792, 25);
			this.radStatusStrip.SizingGrip = false;
			this.radStatusStrip.TabIndex = 1;
			this.radStatusStrip.Text = "radStatusStrip1";
			this.radStatusStrip.ThemeName = "Material";
			// 
			// panel
			// 
			this.panel.Controls.Add(this.radDock);
			this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel.Location = new System.Drawing.Point(0, 245);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(792, 325);
			this.panel.TabIndex = 2;
			// 
			// radDock
			// 
			this.radDock.ActiveWindow = this.documentWindow_Timeline;
			this.radDock.Controls.Add(this.documentContainer);
			this.radDock.Dock = System.Windows.Forms.DockStyle.Fill;
			this.radDock.IsCleanUpTarget = true;
			this.radDock.Location = new System.Drawing.Point(0, 0);
			this.radDock.MainDocumentContainer = this.documentContainer;
			this.radDock.Name = "radDock";
			this.radDock.Padding = new System.Windows.Forms.Padding(0);
			// 
			// 
			// 
			this.radDock.RootElement.MinSize = new System.Drawing.Size(25, 25);
			this.radDock.Size = new System.Drawing.Size(792, 325);
			this.radDock.SplitterWidth = 8;
			this.radDock.TabIndex = 0;
			this.radDock.TabStop = false;
			this.radDock.Text = "radDock";
			this.radDock.ThemeName = "Material";
			// 
			// documentWindow_Timeline
			// 
			this.documentWindow_Timeline.Controls.Add(this.radCardView_Timeline);
			this.documentWindow_Timeline.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.documentWindow_Timeline.Location = new System.Drawing.Point(4, 54);
			this.documentWindow_Timeline.Name = "documentWindow_Timeline";
			this.documentWindow_Timeline.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument;
			this.documentWindow_Timeline.Size = new System.Drawing.Size(784, 267);
			this.documentWindow_Timeline.Text = "타임라인";
			// 
			// radCardView_Timeline
			// 
			// 
			// 
			// 
			this.radCardView_Timeline.CardTemplate.HiddenItems.AddRange(new Telerik.WinControls.RadItem[] {
            this.cardViewItem5});
			this.radCardView_Timeline.CardTemplate.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.cardViewGroupItem1});
			this.radCardView_Timeline.CardTemplate.Location = new System.Drawing.Point(0, 0);
			this.radCardView_Timeline.CardTemplate.Name = "radCardView_TimelineTemplate";
			this.radCardView_Timeline.CardTemplate.Size = new System.Drawing.Size(750, 250);
			this.radCardView_Timeline.CardTemplate.TabIndex = 0;
			this.radCardView_Timeline.DataSource = this.timelineObjectBindingSource;
			this.radCardView_Timeline.Dock = System.Windows.Forms.DockStyle.Fill;
			this.radCardView_Timeline.GroupItemSize = new System.Drawing.Size(200, 36);
			this.radCardView_Timeline.ItemSize = new System.Drawing.Size(750, 250);
			this.radCardView_Timeline.Location = new System.Drawing.Point(0, 0);
			this.radCardView_Timeline.Name = "radCardView_Timeline";
			this.radCardView_Timeline.Size = new System.Drawing.Size(784, 267);
			this.radCardView_Timeline.TabIndex = 0;
			this.radCardView_Timeline.Text = "radCardView_Timeline";
			this.radCardView_Timeline.ThemeName = "Material";
			// 
			// cardViewItem5
			// 
			this.cardViewItem5.Bounds = new System.Drawing.Rectangle(0, 139, 742, 26);
			this.cardViewItem5.FieldName = "StatusID";
			this.cardViewItem5.Name = "cardViewItem5";
			this.cardViewItem5.Text = "StatusID";
			// 
			// cardViewGroupItem1
			// 
			this.cardViewGroupItem1.Bounds = new System.Drawing.Rectangle(0, 0, 750, 250);
			this.cardViewGroupItem1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.cardViewItem1,
            this.cardViewItem2,
            this.cardViewItem3,
            this.cardViewItem4,
            this.cardViewItem6,
            this.cardViewItem7});
			this.cardViewGroupItem1.Name = "cardViewGroupItem1";
			// 
			// cardViewItem1
			// 
			this.cardViewItem1.Bounds = new System.Drawing.Rectangle(0, 0, 171, 52);
			this.cardViewItem1.FieldName = "Profile";
			this.cardViewItem1.Name = "cardViewItem1";
			this.cardViewItem1.Text = "Profile";
			// 
			// cardViewItem2
			// 
			this.cardViewItem2.Bounds = new System.Drawing.Rectangle(171, 0, 571, 26);
			this.cardViewItem2.FieldName = "Name";
			this.cardViewItem2.Name = "cardViewItem2";
			this.cardViewItem2.Text = "Name";
			// 
			// cardViewItem3
			// 
			this.cardViewItem3.Bounds = new System.Drawing.Rectangle(171, 26, 571, 26);
			this.cardViewItem3.FieldName = "ScreenName";
			this.cardViewItem3.Name = "cardViewItem3";
			this.cardViewItem3.Text = "ScreenName";
			// 
			// cardViewItem4
			// 
			this.cardViewItem4.Bounds = new System.Drawing.Rectangle(0, 52, 742, 124);
			this.cardViewItem4.FieldName = "Text";
			this.cardViewItem4.Name = "cardViewItem4";
			this.cardViewItem4.Text = "Text";
			// 
			// cardViewItem6
			// 
			this.cardViewItem6.Bounds = new System.Drawing.Rectangle(0, 176, 660, 46);
			this.cardViewItem6.FieldName = "RTCount";
			this.cardViewItem6.Name = "cardViewItem6";
			this.cardViewItem6.Text = "RTCount";
			// 
			// cardViewItem7
			// 
			this.cardViewItem7.Bounds = new System.Drawing.Rectangle(660, 176, 82, 46);
			this.cardViewItem7.FieldName = "FavoriteCount";
			this.cardViewItem7.Name = "cardViewItem7";
			this.cardViewItem7.Text = "FavoriteCount";
			// 
			// timelineObjectBindingSource
			// 
			this.timelineObjectBindingSource.DataSource = typeof(xTwitter_Dashboard.Models.TimelineObject);
			// 
			// documentContainer
			// 
			this.documentContainer.Controls.Add(this.documentTabStrip);
			this.documentContainer.Name = "documentContainer";
			// 
			// 
			// 
			this.documentContainer.RootElement.MinSize = new System.Drawing.Size(25, 25);
			this.documentContainer.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
			this.documentContainer.SplitterWidth = 8;
			this.documentContainer.ThemeName = "Material";
			// 
			// documentTabStrip
			// 
			this.documentTabStrip.CanUpdateChildIndex = true;
			this.documentTabStrip.Controls.Add(this.documentWindow_Timeline);
			this.documentTabStrip.Location = new System.Drawing.Point(0, 0);
			this.documentTabStrip.Name = "documentTabStrip";
			// 
			// 
			// 
			this.documentTabStrip.RootElement.MinSize = new System.Drawing.Size(25, 25);
			this.documentTabStrip.SelectedIndex = 0;
			this.documentTabStrip.Size = new System.Drawing.Size(792, 325);
			this.documentTabStrip.TabIndex = 0;
			this.documentTabStrip.TabStop = false;
			this.documentTabStrip.ThemeName = "Material";
			// 
			// radRibbonBar
			// 
			this.radRibbonBar.CommandTabs.AddRange(new Telerik.WinControls.RadItem[] {
            this.ribbonTab_Home,
            this.ribbonTab_DB});
			// 
			// 
			// 
			// 
			// 
			// 
			this.radRibbonBar.ExitButton.ButtonElement.ShowBorder = false;
			this.radRibbonBar.ExitButton.Text = "Exit";
			this.radRibbonBar.ExitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.radRibbonBar.Location = new System.Drawing.Point(0, 0);
			this.radRibbonBar.Name = "radRibbonBar";
			// 
			// 
			// 
			// 
			// 
			// 
			this.radRibbonBar.OptionsButton.ButtonElement.ShowBorder = false;
			this.radRibbonBar.OptionsButton.Text = "Options";
			this.radRibbonBar.OptionsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			// 
			// 
			// 
			this.radRibbonBar.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
			this.radRibbonBar.Size = new System.Drawing.Size(792, 245);
			this.radRibbonBar.StartButtonImage = ((System.Drawing.Image)(resources.GetObject("radRibbonBar.StartButtonImage")));
			this.radRibbonBar.TabIndex = 0;
			this.radRibbonBar.Text = "FormMain";
			this.radRibbonBar.ThemeName = "Material";
			// 
			// ribbonTab_Home
			// 
			this.ribbonTab_Home.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
			this.ribbonTab_Home.IsSelected = true;
			this.ribbonTab_Home.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarGroup_Account});
			this.ribbonTab_Home.Name = "ribbonTab_Home";
			this.ribbonTab_Home.Text = "홈";
			this.ribbonTab_Home.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
			this.ribbonTab_Home.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			// 
			// radRibbonBarGroup_Account
			// 
			this.radRibbonBarGroup_Account.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
			this.radRibbonBarGroup_Account.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement_Login,
            this.radRibbonBarButtonGroup_Profile,
            this.radRibbonBarButtonGroup_Name});
			this.radRibbonBarGroup_Account.MaxSize = new System.Drawing.Size(0, 144);
			this.radRibbonBarGroup_Account.MinSize = new System.Drawing.Size(70, 144);
			this.radRibbonBarGroup_Account.Name = "radRibbonBarGroup_Account";
			this.radRibbonBarGroup_Account.Text = "계정";
			// 
			// radButtonElement_Login
			// 
			this.radButtonElement_Login.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
			this.radButtonElement_Login.DisplayStyle = Telerik.WinControls.DisplayStyle.ImageAndText;
			this.radButtonElement_Login.Image = global::xTwitter_Dashboard.Properties.Resources.login_96;
			this.radButtonElement_Login.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
			this.radButtonElement_Login.Name = "radButtonElement_Login";
			this.radButtonElement_Login.Text = "로그인";
			this.radButtonElement_Login.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
			this.radButtonElement_Login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.radButtonElement_Login.Click += new System.EventHandler(this.radButtonElement_Login_Click);
			// 
			// radRibbonBarButtonGroup_Profile
			// 
			this.radRibbonBarButtonGroup_Profile.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
			this.radRibbonBarButtonGroup_Profile.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radLabelElement_Profile});
			this.radRibbonBarButtonGroup_Profile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.radRibbonBarButtonGroup_Profile.Name = "radRibbonBarButtonGroup_Profile";
			this.radRibbonBarButtonGroup_Profile.Padding = new System.Windows.Forms.Padding(1);
			this.radRibbonBarButtonGroup_Profile.ShowBorder = false;
			// 
			// radLabelElement_Profile
			// 
			this.radLabelElement_Profile.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
			this.radLabelElement_Profile.Image = global::xTwitter_Dashboard.Properties.Resources.profile_96;
			this.radLabelElement_Profile.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
			this.radLabelElement_Profile.Name = "radLabelElement_Profile";
			this.radLabelElement_Profile.Text = "";
			this.radLabelElement_Profile.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
			this.radLabelElement_Profile.TextWrap = true;
			// 
			// radRibbonBarButtonGroup_Name
			// 
			this.radRibbonBarButtonGroup_Name.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
			this.radRibbonBarButtonGroup_Name.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radLabelElement_Id,
            this.radLabelElement_ScreenName});
			this.radRibbonBarButtonGroup_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.radRibbonBarButtonGroup_Name.Name = "radRibbonBarButtonGroup_Name";
			this.radRibbonBarButtonGroup_Name.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.radRibbonBarButtonGroup_Name.Padding = new System.Windows.Forms.Padding(1);
			this.radRibbonBarButtonGroup_Name.ShowBorder = false;
			this.radRibbonBarButtonGroup_Name.Text = "";
			// 
			// radLabelElement_Id
			// 
			this.radLabelElement_Id.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
			this.radLabelElement_Id.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
			this.radLabelElement_Id.Name = "radLabelElement_Id";
			this.radLabelElement_Id.Text = "<html><strong>ID</strong></html>";
			this.radLabelElement_Id.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			this.radLabelElement_Id.TextWrap = true;
			// 
			// radLabelElement_ScreenName
			// 
			this.radLabelElement_ScreenName.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
			this.radLabelElement_ScreenName.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
			this.radLabelElement_ScreenName.Name = "radLabelElement_ScreenName";
			this.radLabelElement_ScreenName.Text = "<html><span style=\"color: #8080ff\">@ScreenName</span></html>";
			this.radLabelElement_ScreenName.TextWrap = true;
			// 
			// ribbonTab_DB
			// 
			this.ribbonTab_DB.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
			this.ribbonTab_DB.Name = "ribbonTab_DB";
			this.ribbonTab_DB.Text = "데이터베이스";
			this.ribbonTab_DB.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(792, 595);
			this.Controls.Add(this.panel);
			this.Controls.Add(this.radStatusStrip);
			this.Controls.Add(this.radRibbonBar);
			this.MainMenuStrip = null;
			this.Name = "FormMain";
			// 
			// 
			// 
			this.RootElement.ApplyShapeToControl = true;
			this.Text = "FormMain";
			this.ThemeName = "Material";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.radStatusStrip)).EndInit();
			this.panel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.radDock)).EndInit();
			this.radDock.ResumeLayout(false);
			this.documentWindow_Timeline.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.radCardView_Timeline.CardTemplate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radCardView_Timeline)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.timelineObjectBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.documentContainer)).EndInit();
			this.documentContainer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.documentTabStrip)).EndInit();
			this.documentTabStrip.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.radRibbonBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadRibbonBar radRibbonBar;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip;
        private System.Windows.Forms.Panel panel;
		private Telerik.WinControls.Themes.MaterialTheme materialTheme;
		private Telerik.WinControls.UI.RibbonTab ribbonTab_Home;
		private Telerik.WinControls.UI.RibbonTab ribbonTab_DB;
		private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup_Account;
		private Telerik.WinControls.UI.RadButtonElement radButtonElement_Login;
		private Telerik.WinControls.UI.RadRibbonBarButtonGroup radRibbonBarButtonGroup_Profile;
		private Telerik.WinControls.UI.RadLabelElement radLabelElement_Profile;
		private Telerik.WinControls.UI.RadRibbonBarButtonGroup radRibbonBarButtonGroup_Name;
		private Telerik.WinControls.UI.RadLabelElement radLabelElement_Id;
		private Telerik.WinControls.UI.RadLabelElement radLabelElement_ScreenName;
		private Telerik.WinControls.UI.Docking.RadDock radDock;
		private Telerik.WinControls.UI.Docking.DocumentContainer documentContainer;
		private Telerik.WinControls.UI.Docking.DocumentTabStrip documentTabStrip;
		private Telerik.WinControls.UI.Docking.DocumentWindow documentWindow_Timeline;
		private Telerik.WinControls.UI.RadCardView radCardView_Timeline;
		private Telerik.WinControls.UI.CardViewGroupItem cardViewGroupItem1;
		private Telerik.WinControls.UI.CardViewItem cardViewItem1;
		private Telerik.WinControls.UI.CardViewItem cardViewItem2;
		private Telerik.WinControls.UI.CardViewItem cardViewItem3;
		private Telerik.WinControls.UI.CardViewItem cardViewItem4;
		private Telerik.WinControls.UI.CardViewItem cardViewItem5;
		private Telerik.WinControls.UI.CardViewItem cardViewItem6;
		private Telerik.WinControls.UI.CardViewItem cardViewItem7;
		private System.Windows.Forms.BindingSource timelineObjectBindingSource;
	}
}
