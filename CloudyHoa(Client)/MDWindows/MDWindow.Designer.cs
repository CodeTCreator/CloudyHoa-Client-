namespace CloudyHoa_Client_.MDWindows
{
    partial class MDWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDWindow));
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.treeListControl1 = new CloudyHoa_Client_.General.TreeListControl();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gridControlPA = new DevExpress.XtraGrid.GridControl();
            this.gridViewPA = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnPAId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnRegistered = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnLives = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnOwnerId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnAccount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnObjectId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControlMD = new DevExpress.XtraGrid.GridControl();
            this.gridViewMD = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnNumberMD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnVD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnIDMD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnServiceId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnServiceName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControlMain = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.deleteMDButton = new DevExpress.XtraEditors.SimpleButton();
            this.editMDButton = new DevExpress.XtraEditors.SimpleButton();
            this.addMDButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            this.tabNavigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).BeginInit();
            this.panelControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabPane1.Location = new System.Drawing.Point(2, 2);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2});
            this.tabPane1.RegularSize = new System.Drawing.Size(468, 472);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(468, 472);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Объекты";
            this.tabNavigationPage1.Controls.Add(this.treeListControl1);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(468, 431);
            // 
            // treeListControl1
            // 
            this.treeListControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeListControl1.Location = new System.Drawing.Point(0, 0);
            this.treeListControl1.Margin = new System.Windows.Forms.Padding(4);
            this.treeListControl1.Name = "treeListControl1";
            this.treeListControl1.Size = new System.Drawing.Size(468, 431);
            this.treeListControl1.TabIndex = 0;
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "Лицевые счета";
            this.tabNavigationPage2.Controls.Add(this.gridControlPA);
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(468, 431);
            // 
            // gridControlPA
            // 
            this.gridControlPA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPA.Location = new System.Drawing.Point(0, 0);
            this.gridControlPA.MainView = this.gridViewPA;
            this.gridControlPA.Name = "gridControlPA";
            this.gridControlPA.Size = new System.Drawing.Size(468, 431);
            this.gridControlPA.TabIndex = 0;
            this.gridControlPA.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPA});
            this.gridControlPA.Click += new System.EventHandler(this.gridControlPA_Click);
            // 
            // gridViewPA
            // 
            this.gridViewPA.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnPAId,
            this.gridColumnRegistered,
            this.gridColumnLives,
            this.gridColumnOwnerId,
            this.gridColumnAccount,
            this.gridColumnObjectId,
            this.gridColumnFullName});
            this.gridViewPA.GridControl = this.gridControlPA;
            this.gridViewPA.Name = "gridViewPA";
            // 
            // gridColumnPAId
            // 
            this.gridColumnPAId.Caption = "Id";
            this.gridColumnPAId.FieldName = "id";
            this.gridColumnPAId.MinWidth = 25;
            this.gridColumnPAId.Name = "gridColumnPAId";
            this.gridColumnPAId.Width = 94;
            // 
            // gridColumnRegistered
            // 
            this.gridColumnRegistered.Caption = "Зарегистрировано";
            this.gridColumnRegistered.FieldName = "registered";
            this.gridColumnRegistered.MinWidth = 25;
            this.gridColumnRegistered.Name = "gridColumnRegistered";
            this.gridColumnRegistered.Visible = true;
            this.gridColumnRegistered.VisibleIndex = 0;
            this.gridColumnRegistered.Width = 94;
            // 
            // gridColumnLives
            // 
            this.gridColumnLives.Caption = "Проживает";
            this.gridColumnLives.FieldName = "lives";
            this.gridColumnLives.MinWidth = 25;
            this.gridColumnLives.Name = "gridColumnLives";
            this.gridColumnLives.Visible = true;
            this.gridColumnLives.VisibleIndex = 1;
            this.gridColumnLives.Width = 94;
            // 
            // gridColumnOwnerId
            // 
            this.gridColumnOwnerId.Caption = "Ответственный id";
            this.gridColumnOwnerId.FieldName = "owner_id";
            this.gridColumnOwnerId.MinWidth = 25;
            this.gridColumnOwnerId.Name = "gridColumnOwnerId";
            this.gridColumnOwnerId.Width = 94;
            // 
            // gridColumnAccount
            // 
            this.gridColumnAccount.Caption = "Л/С";
            this.gridColumnAccount.FieldName = "account";
            this.gridColumnAccount.MinWidth = 25;
            this.gridColumnAccount.Name = "gridColumnAccount";
            this.gridColumnAccount.Visible = true;
            this.gridColumnAccount.VisibleIndex = 2;
            this.gridColumnAccount.Width = 94;
            // 
            // gridColumnObjectId
            // 
            this.gridColumnObjectId.Caption = "Объект Id";
            this.gridColumnObjectId.FieldName = "object_id";
            this.gridColumnObjectId.MinWidth = 25;
            this.gridColumnObjectId.Name = "gridColumnObjectId";
            this.gridColumnObjectId.Width = 94;
            // 
            // gridColumnFullName
            // 
            this.gridColumnFullName.Caption = "Ответственный";
            this.gridColumnFullName.FieldName = "full_name";
            this.gridColumnFullName.MinWidth = 25;
            this.gridColumnFullName.Name = "gridColumnFullName";
            this.gridColumnFullName.Visible = true;
            this.gridColumnFullName.VisibleIndex = 3;
            this.gridColumnFullName.Width = 94;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(409, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(98, 31);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Счетчики";
            // 
            // gridControlMD
            // 
            this.gridControlMD.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControlMD.Location = new System.Drawing.Point(2, 49);
            this.gridControlMD.MainView = this.gridViewMD;
            this.gridControlMD.Name = "gridControlMD";
            this.gridControlMD.Size = new System.Drawing.Size(599, 421);
            this.gridControlMD.TabIndex = 2;
            this.gridControlMD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMD});
            this.gridControlMD.Click += new System.EventHandler(this.gridControlMD_Click);
            // 
            // gridViewMD
            // 
            this.gridViewMD.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnId,
            this.gridColumnNumberMD,
            this.gridColumnVD,
            this.gridColumnIDMD,
            this.gridColumnServiceId,
            this.gridColumnServiceName,
            this.gridColumnPAI});
            this.gridViewMD.GridControl = this.gridControlMD;
            this.gridViewMD.Name = "gridViewMD";
            // 
            // gridColumnId
            // 
            this.gridColumnId.Caption = "Id";
            this.gridColumnId.FieldName = "id";
            this.gridColumnId.MinWidth = 25;
            this.gridColumnId.Name = "gridColumnId";
            this.gridColumnId.Width = 94;
            // 
            // gridColumnNumberMD
            // 
            this.gridColumnNumberMD.Caption = "Номер";
            this.gridColumnNumberMD.FieldName = "number";
            this.gridColumnNumberMD.MinWidth = 25;
            this.gridColumnNumberMD.Name = "gridColumnNumberMD";
            this.gridColumnNumberMD.Visible = true;
            this.gridColumnNumberMD.VisibleIndex = 0;
            this.gridColumnNumberMD.Width = 94;
            // 
            // gridColumnVD
            // 
            this.gridColumnVD.Caption = "Дата поверки";
            this.gridColumnVD.FieldName = "verification_date";
            this.gridColumnVD.MinWidth = 25;
            this.gridColumnVD.Name = "gridColumnVD";
            this.gridColumnVD.Visible = true;
            this.gridColumnVD.VisibleIndex = 1;
            this.gridColumnVD.Width = 94;
            // 
            // gridColumnIDMD
            // 
            this.gridColumnIDMD.Caption = "Дата установки";
            this.gridColumnIDMD.FieldName = "installation_date";
            this.gridColumnIDMD.MinWidth = 25;
            this.gridColumnIDMD.Name = "gridColumnIDMD";
            this.gridColumnIDMD.Visible = true;
            this.gridColumnIDMD.VisibleIndex = 2;
            this.gridColumnIDMD.Width = 94;
            // 
            // gridColumnServiceId
            // 
            this.gridColumnServiceId.Caption = "gridColumn5";
            this.gridColumnServiceId.FieldName = "service_id";
            this.gridColumnServiceId.MinWidth = 25;
            this.gridColumnServiceId.Name = "gridColumnServiceId";
            this.gridColumnServiceId.Width = 94;
            // 
            // gridColumnServiceName
            // 
            this.gridColumnServiceName.Caption = "Название услуги";
            this.gridColumnServiceName.FieldName = "property_name";
            this.gridColumnServiceName.MinWidth = 25;
            this.gridColumnServiceName.Name = "gridColumnServiceName";
            this.gridColumnServiceName.Visible = true;
            this.gridColumnServiceName.VisibleIndex = 3;
            this.gridColumnServiceName.Width = 94;
            // 
            // gridColumnPAI
            // 
            this.gridColumnPAI.Caption = "gridColumn1";
            this.gridColumnPAI.FieldName = "personal_account_id";
            this.gridColumnPAI.MinWidth = 25;
            this.gridColumnPAI.Name = "gridColumnPAI";
            this.gridColumnPAI.Width = 94;
            // 
            // panelControlMain
            // 
            this.panelControlMain.Controls.Add(this.panelControl2);
            this.panelControlMain.Controls.Add(this.tabPane1);
            this.panelControlMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControlMain.Location = new System.Drawing.Point(0, 63);
            this.panelControlMain.Name = "panelControlMain";
            this.panelControlMain.Size = new System.Drawing.Size(1081, 476);
            this.panelControlMain.TabIndex = 3;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.deleteMDButton);
            this.panelControl2.Controls.Add(this.editMDButton);
            this.panelControl2.Controls.Add(this.addMDButton);
            this.panelControl2.Controls.Add(this.gridControlMD);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl2.Location = new System.Drawing.Point(476, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(603, 472);
            this.panelControl2.TabIndex = 3;
            // 
            // deleteMDButton
            // 
            this.deleteMDButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteMDButton.Appearance.Options.UseFont = true;
            this.deleteMDButton.Enabled = false;
            this.deleteMDButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("deleteMDButton.ImageOptions.Image")));
            this.deleteMDButton.Location = new System.Drawing.Point(287, 3);
            this.deleteMDButton.Name = "deleteMDButton";
            this.deleteMDButton.Size = new System.Drawing.Size(135, 38);
            this.deleteMDButton.TabIndex = 5;
            this.deleteMDButton.Text = "Удалить";
            this.deleteMDButton.Click += new System.EventHandler(this.deleteMDButton_Click);
            // 
            // editMDButton
            // 
            this.editMDButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editMDButton.Appearance.Options.UseFont = true;
            this.editMDButton.Enabled = false;
            this.editMDButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("editMDButton.ImageOptions.Image")));
            this.editMDButton.Location = new System.Drawing.Point(146, 3);
            this.editMDButton.Name = "editMDButton";
            this.editMDButton.Size = new System.Drawing.Size(135, 38);
            this.editMDButton.TabIndex = 4;
            this.editMDButton.Text = "Изменить";
            this.editMDButton.Click += new System.EventHandler(this.editMDButton_Click);
            // 
            // addMDButton
            // 
            this.addMDButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addMDButton.Appearance.Options.UseFont = true;
            this.addMDButton.Enabled = false;
            this.addMDButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("addMDButton.ImageOptions.Image")));
            this.addMDButton.Location = new System.Drawing.Point(5, 3);
            this.addMDButton.Name = "addMDButton";
            this.addMDButton.Size = new System.Drawing.Size(135, 38);
            this.addMDButton.TabIndex = 3;
            this.addMDButton.Text = "Добавить";
            this.addMDButton.Click += new System.EventHandler(this.addMDButton_Click);
            // 
            // MDWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 539);
            this.Controls.Add(this.panelControlMain);
            this.Controls.Add(this.labelControl1);
            this.Name = "MDWindow";
            this.Text = "Счетчики";
            this.Load += new System.EventHandler(this.MDWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.tabNavigationPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).EndInit();
            this.panelControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControlMD;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMD;
        private DevExpress.XtraEditors.PanelControl panelControlMain;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridControlPA;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPA;
        private DevExpress.XtraEditors.SimpleButton deleteMDButton;
        private DevExpress.XtraEditors.SimpleButton editMDButton;
        private DevExpress.XtraEditors.SimpleButton addMDButton;
        private General.TreeListControl treeListControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPAId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnRegistered;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnLives;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnOwnerId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnAccount;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnObjectId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnFullName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnNumberMD;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnVD;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnIDMD;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnServiceId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnServiceName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPAI;
    }
}