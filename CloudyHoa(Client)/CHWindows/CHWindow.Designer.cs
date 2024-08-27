namespace CloudyHoa_Client_.CHWindows
{
    partial class CHWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.panelControlMain = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.clearDateButton = new DevExpress.XtraEditors.SimpleButton();
            this.dateEditPeriod = new DevExpress.XtraEditors.DateEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clearServicesButton = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxServices = new System.Windows.Forms.ComboBox();
            this.gridControlEH = new DevExpress.XtraGrid.GridControl();
            this.gridViewMD = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPANum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPeriod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnServiceId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnServiceName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPAi = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).BeginInit();
            this.panelControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditPeriod.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditPeriod.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            this.tabNavigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPA)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(391, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "История расчетов";
            // 
            // panelControlMain
            // 
            this.panelControlMain.Controls.Add(this.panelControl2);
            this.panelControlMain.Controls.Add(this.tabPane1);
            this.panelControlMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControlMain.Location = new System.Drawing.Point(0, 102);
            this.panelControlMain.Name = "panelControlMain";
            this.panelControlMain.Size = new System.Drawing.Size(1063, 433);
            this.panelControlMain.TabIndex = 4;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.groupBox3);
            this.panelControl2.Controls.Add(this.groupBox1);
            this.panelControl2.Controls.Add(this.gridControlEH);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl2.Location = new System.Drawing.Point(458, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(603, 429);
            this.panelControl2.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.clearDateButton);
            this.groupBox3.Controls.Add(this.dateEditPeriod);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(300, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(301, 63);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Период";
            // 
            // clearDateButton
            // 
            this.clearDateButton.Enabled = false;
            this.clearDateButton.ImageOptions.Image = global::CloudyHoa_Client_.Properties.Resources.clear_32x32;
            this.clearDateButton.Location = new System.Drawing.Point(245, 18);
            this.clearDateButton.Name = "clearDateButton";
            this.clearDateButton.Size = new System.Drawing.Size(40, 39);
            this.clearDateButton.TabIndex = 3;
            this.clearDateButton.Text = " ";
            this.clearDateButton.Click += new System.EventHandler(this.clearDate_Click);
            // 
            // dateEditPeriod
            // 
            this.dateEditPeriod.EditValue = null;
            this.dateEditPeriod.Location = new System.Drawing.Point(6, 22);
            this.dateEditPeriod.Name = "dateEditPeriod";
            this.dateEditPeriod.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateEditPeriod.Properties.Appearance.Options.UseFont = true;
            this.dateEditPeriod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditPeriod.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditPeriod.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.dateEditPeriod.Properties.DisplayFormat.FormatString = "Y";
            this.dateEditPeriod.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEditPeriod.Properties.EditFormat.FormatString = "Y";
            this.dateEditPeriod.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEditPeriod.Properties.MaskSettings.Set("mask", "Y");
            this.dateEditPeriod.Properties.UseMaskAsDisplayFormat = true;
            this.dateEditPeriod.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dateEditPeriod.Size = new System.Drawing.Size(233, 30);
            this.dateEditPeriod.TabIndex = 0;
            this.dateEditPeriod.EditValueChanged += new System.EventHandler(this.dateEditPeriod_EditValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clearServicesButton);
            this.groupBox1.Controls.Add(this.comboBoxServices);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 63);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Услуга";
            // 
            // clearServicesButton
            // 
            this.clearServicesButton.Enabled = false;
            this.clearServicesButton.ImageOptions.Image = global::CloudyHoa_Client_.Properties.Resources.clear_32x32;
            this.clearServicesButton.Location = new System.Drawing.Point(199, 18);
            this.clearServicesButton.Name = "clearServicesButton";
            this.clearServicesButton.Size = new System.Drawing.Size(40, 39);
            this.clearServicesButton.TabIndex = 2;
            this.clearServicesButton.Text = " ";
            this.clearServicesButton.Click += new System.EventHandler(this.clearServicesButton_Click);
            // 
            // comboBoxServices
            // 
            this.comboBoxServices.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxServices.FormattingEnabled = true;
            this.comboBoxServices.Location = new System.Drawing.Point(6, 22);
            this.comboBoxServices.Name = "comboBoxServices";
            this.comboBoxServices.Size = new System.Drawing.Size(187, 31);
            this.comboBoxServices.TabIndex = 0;
            this.comboBoxServices.SelectionChangeCommitted += new System.EventHandler(this.comboBoxServices_SelectionChangeCommitted);
            // 
            // gridControlEH
            // 
            this.gridControlEH.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControlEH.Location = new System.Drawing.Point(2, 65);
            this.gridControlEH.MainView = this.gridViewMD;
            this.gridControlEH.Name = "gridControlEH";
            this.gridControlEH.Size = new System.Drawing.Size(599, 362);
            this.gridControlEH.TabIndex = 2;
            this.gridControlEH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMD});
            // 
            // gridViewMD
            // 
            this.gridViewMD.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnId,
            this.gridColumnPANum,
            this.gridColumnValue,
            this.gridColumnPeriod,
            this.gridColumnServiceId,
            this.gridColumnServiceName,
            this.gridColumnPAi});
            this.gridViewMD.GridControl = this.gridControlEH;
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
            // gridColumnPANum
            // 
            this.gridColumnPANum.Caption = "Л/С";
            this.gridColumnPANum.FieldName = "account";
            this.gridColumnPANum.MinWidth = 25;
            this.gridColumnPANum.Name = "gridColumnPANum";
            this.gridColumnPANum.Visible = true;
            this.gridColumnPANum.VisibleIndex = 0;
            this.gridColumnPANum.Width = 94;
            // 
            // gridColumnValue
            // 
            this.gridColumnValue.Caption = "Значение";
            this.gridColumnValue.FieldName = "value";
            this.gridColumnValue.MinWidth = 25;
            this.gridColumnValue.Name = "gridColumnValue";
            this.gridColumnValue.Visible = true;
            this.gridColumnValue.VisibleIndex = 3;
            this.gridColumnValue.Width = 94;
            // 
            // gridColumnPeriod
            // 
            this.gridColumnPeriod.Caption = "Период";
            this.gridColumnPeriod.FieldName = "period";
            this.gridColumnPeriod.MinWidth = 25;
            this.gridColumnPeriod.Name = "gridColumnPeriod";
            this.gridColumnPeriod.Visible = true;
            this.gridColumnPeriod.VisibleIndex = 2;
            this.gridColumnPeriod.Width = 94;
            // 
            // gridColumnServiceId
            // 
            this.gridColumnServiceId.Caption = "gridColumn5";
            this.gridColumnServiceId.FieldName = "metadata_id";
            this.gridColumnServiceId.MinWidth = 25;
            this.gridColumnServiceId.Name = "gridColumnServiceId";
            this.gridColumnServiceId.Width = 94;
            // 
            // gridColumnServiceName
            // 
            this.gridColumnServiceName.Caption = "Название показания";
            this.gridColumnServiceName.FieldName = "property_name";
            this.gridColumnServiceName.MinWidth = 25;
            this.gridColumnServiceName.Name = "gridColumnServiceName";
            this.gridColumnServiceName.Visible = true;
            this.gridColumnServiceName.VisibleIndex = 1;
            this.gridColumnServiceName.Width = 94;
            // 
            // gridColumnPAi
            // 
            this.gridColumnPAi.Caption = "gridColumn1";
            this.gridColumnPAi.FieldName = "personal_account_id";
            this.gridColumnPAi.MinWidth = 25;
            this.gridColumnPAi.Name = "gridColumnPAi";
            this.gridColumnPAi.Width = 94;
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
            this.tabPane1.RegularSize = new System.Drawing.Size(458, 429);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(458, 429);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Объекты";
            this.tabNavigationPage1.Controls.Add(this.treeListControl1);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(458, 388);
            // 
            // treeListControl1
            // 
            this.treeListControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeListControl1.Location = new System.Drawing.Point(0, 0);
            this.treeListControl1.Margin = new System.Windows.Forms.Padding(4);
            this.treeListControl1.Name = "treeListControl1";
            this.treeListControl1.Size = new System.Drawing.Size(458, 388);
            this.treeListControl1.TabIndex = 0;
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "Лицевые счета";
            this.tabNavigationPage2.Controls.Add(this.gridControlPA);
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(458, 388);
            // 
            // gridControlPA
            // 
            this.gridControlPA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPA.Location = new System.Drawing.Point(0, 0);
            this.gridControlPA.MainView = this.gridViewPA;
            this.gridControlPA.Name = "gridControlPA";
            this.gridControlPA.Size = new System.Drawing.Size(458, 388);
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
            // CHWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 535);
            this.Controls.Add(this.panelControlMain);
            this.Controls.Add(this.label1);
            this.Name = "CHWindow";
            this.Text = "История расчетов";
            this.Load += new System.EventHandler(this.CHWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).EndInit();
            this.panelControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateEditPeriod.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditPeriod.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.tabNavigationPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControlMain;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridControlEH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMD;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPANum;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnValue;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPeriod;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnServiceId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnServiceName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPAi;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private General.TreeListControl treeListControl1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DevExpress.XtraGrid.GridControl gridControlPA;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPA;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPAId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnRegistered;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnLives;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnOwnerId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnAccount;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnObjectId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnFullName;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton clearServicesButton;
        private System.Windows.Forms.ComboBox comboBoxServices;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.DateEdit dateEditPeriod;
        private DevExpress.XtraEditors.SimpleButton clearDateButton;
    }
}