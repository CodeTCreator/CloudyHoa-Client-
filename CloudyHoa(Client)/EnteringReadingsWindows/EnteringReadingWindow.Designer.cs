namespace CloudyHoa_Client_.EnteringReadingsWindows
{
    partial class EnteringReadingWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnteringReadingWindow));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControlMain = new DevExpress.XtraEditors.PanelControl();
            this.svgImageBoxWarningData = new DevExpress.XtraEditors.SvgImageBox();
            this.svgImageBoxWarningValue = new DevExpress.XtraEditors.SvgImageBox();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.comboBoxTypesObjects = new System.Windows.Forms.ComboBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit = new DevExpress.XtraEditors.DateEdit();
            this.comboBoxParentObject = new System.Windows.Forms.ComboBox();
            this.resetServicesButton = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxServices = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.gridControlReadings = new DevExpress.XtraGrid.GridControl();
            this.gridViewReadings = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnDPID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPropName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPrevPeriod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCurrPeriod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridColumnPrevValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCurrValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPAID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnObjectName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnObjectId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).BeginInit();
            this.panelControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBoxWarningData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBoxWarningValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlReadings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewReadings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(301, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(333, 37);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Ввод показаний счетчиков";
            // 
            // panelControlMain
            // 
            this.panelControlMain.Controls.Add(this.svgImageBoxWarningData);
            this.panelControlMain.Controls.Add(this.svgImageBoxWarningValue);
            this.panelControlMain.Controls.Add(this.panelControl2);
            this.panelControlMain.Controls.Add(this.saveButton);
            this.panelControlMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControlMain.Location = new System.Drawing.Point(0, 87);
            this.panelControlMain.Name = "panelControlMain";
            this.panelControlMain.Size = new System.Drawing.Size(1239, 567);
            this.panelControlMain.TabIndex = 7;
            // 
            // svgImageBoxWarningData
            // 
            this.svgImageBoxWarningData.Location = new System.Drawing.Point(963, 519);
            this.svgImageBoxWarningData.Name = "svgImageBoxWarningData";
            this.svgImageBoxWarningData.Size = new System.Drawing.Size(57, 39);
            this.svgImageBoxWarningData.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageBoxWarningData.SvgImage")));
            this.svgImageBoxWarningData.TabIndex = 4;
            this.svgImageBoxWarningData.ToolTip = "Дата предыдущего показания больше, тем текущего";
            this.svgImageBoxWarningData.ToolTipTitle = "Внимание!";
            this.svgImageBoxWarningData.Visible = false;
            // 
            // svgImageBoxWarningValue
            // 
            this.svgImageBoxWarningValue.Location = new System.Drawing.Point(1026, 519);
            this.svgImageBoxWarningValue.Name = "svgImageBoxWarningValue";
            this.svgImageBoxWarningValue.Size = new System.Drawing.Size(57, 39);
            this.svgImageBoxWarningValue.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageBoxWarningValue.SvgImage")));
            this.svgImageBoxWarningValue.TabIndex = 3;
            this.svgImageBoxWarningValue.ToolTip = "Текущие показания меньше предыдущих";
            this.svgImageBoxWarningValue.ToolTipTitle = "Внимание!";
            this.svgImageBoxWarningValue.Visible = false;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.comboBoxTypesObjects);
            this.panelControl2.Controls.Add(this.labelControl5);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.dateEdit);
            this.panelControl2.Controls.Add(this.comboBoxParentObject);
            this.panelControl2.Controls.Add(this.resetServicesButton);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.comboBoxServices);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Controls.Add(this.gridControlReadings);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1235, 514);
            this.panelControl2.TabIndex = 2;
            // 
            // comboBoxTypesObjects
            // 
            this.comboBoxTypesObjects.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxTypesObjects.FormattingEnabled = true;
            this.comboBoxTypesObjects.Location = new System.Drawing.Point(392, 9);
            this.comboBoxTypesObjects.Name = "comboBoxTypesObjects";
            this.comboBoxTypesObjects.Size = new System.Drawing.Size(176, 31);
            this.comboBoxTypesObjects.TabIndex = 11;
            this.comboBoxTypesObjects.SelectionChangeCommitted += new System.EventHandler(this.comboBoxTypesObjects_SelectionChangeCommitted);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(623, 15);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(41, 25);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "Дата:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(283, 13);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(103, 25);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Вывести все:";
            // 
            // dateEdit
            // 
            this.dateEdit.EditValue = new System.DateTime(2024, 5, 10, 12, 3, 15, 0);
            this.dateEdit.Location = new System.Drawing.Point(670, 12);
            this.dateEdit.Name = "dateEdit";
            this.dateEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateEdit.Properties.Appearance.Options.UseFont = true;
            this.dateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit.Size = new System.Drawing.Size(139, 30);
            this.dateEdit.TabIndex = 4;
            this.dateEdit.EditValueChanged += new System.EventHandler(this.dateEdit_EditValueChanged);
            // 
            // comboBoxParentObject
            // 
            this.comboBoxParentObject.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxParentObject.FormattingEnabled = true;
            this.comboBoxParentObject.Location = new System.Drawing.Point(101, 9);
            this.comboBoxParentObject.Name = "comboBoxParentObject";
            this.comboBoxParentObject.Size = new System.Drawing.Size(176, 31);
            this.comboBoxParentObject.TabIndex = 10;
            this.comboBoxParentObject.SelectionChangeCommitted += new System.EventHandler(this.comboBoxParentObject_SelectionChangeCommitted);
            // 
            // resetServicesButton
            // 
            this.resetServicesButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resetServicesButton.ImageOptions.Image")));
            this.resetServicesButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.resetServicesButton.Location = new System.Drawing.Point(1179, 10);
            this.resetServicesButton.Name = "resetServicesButton";
            this.resetServicesButton.Size = new System.Drawing.Size(40, 32);
            this.resetServicesButton.TabIndex = 3;
            this.resetServicesButton.Click += new System.EventHandler(this.resetServicesButton_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(10, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(85, 25);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "У объекта:";
            // 
            // comboBoxServices
            // 
            this.comboBoxServices.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxServices.FormattingEnabled = true;
            this.comboBoxServices.Location = new System.Drawing.Point(1010, 11);
            this.comboBoxServices.Name = "comboBoxServices";
            this.comboBoxServices.Size = new System.Drawing.Size(163, 31);
            this.comboBoxServices.TabIndex = 2;
            this.comboBoxServices.SelectionChangeCommitted += new System.EventHandler(this.comboBoxServices_SelectionChangeCommitted);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(940, 15);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(55, 23);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Услуга:";
            // 
            // gridControlReadings
            // 
            this.gridControlReadings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControlReadings.Location = new System.Drawing.Point(2, 50);
            this.gridControlReadings.MainView = this.gridViewReadings;
            this.gridControlReadings.Name = "gridControlReadings";
            this.gridControlReadings.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1});
            this.gridControlReadings.Size = new System.Drawing.Size(1231, 462);
            this.gridControlReadings.TabIndex = 0;
            this.gridControlReadings.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewReadings});
            // 
            // gridViewReadings
            // 
            this.gridViewReadings.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnDPID,
            this.gridColumnPropName,
            this.gridColumnPrevPeriod,
            this.gridColumnCurrPeriod,
            this.gridColumnPrevValue,
            this.gridColumnCurrValue,
            this.gridColumnPAID,
            this.gridColumnObjectName,
            this.gridColumnObjectId});
            this.gridViewReadings.GridControl = this.gridControlReadings;
            this.gridViewReadings.Name = "gridViewReadings";
            this.gridViewReadings.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridViewReadings_CustomDrawCell);
            this.gridViewReadings.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewReadings_CellValueChanged);
            // 
            // gridColumnDPID
            // 
            this.gridColumnDPID.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnDPID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnDPID.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnDPID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnDPID.Caption = "gridColumnId";
            this.gridColumnDPID.FieldName = "id";
            this.gridColumnDPID.MinWidth = 25;
            this.gridColumnDPID.Name = "gridColumnDPID";
            this.gridColumnDPID.Width = 94;
            // 
            // gridColumnPropName
            // 
            this.gridColumnPropName.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnPropName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnPropName.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnPropName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnPropName.Caption = "Услуга";
            this.gridColumnPropName.FieldName = "property_name";
            this.gridColumnPropName.MinWidth = 25;
            this.gridColumnPropName.Name = "gridColumnPropName";
            this.gridColumnPropName.Visible = true;
            this.gridColumnPropName.VisibleIndex = 1;
            this.gridColumnPropName.Width = 94;
            // 
            // gridColumnPrevPeriod
            // 
            this.gridColumnPrevPeriod.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnPrevPeriod.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnPrevPeriod.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnPrevPeriod.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnPrevPeriod.Caption = "Предыдущий период";
            this.gridColumnPrevPeriod.FieldName = "period";
            this.gridColumnPrevPeriod.MinWidth = 25;
            this.gridColumnPrevPeriod.Name = "gridColumnPrevPeriod";
            this.gridColumnPrevPeriod.Visible = true;
            this.gridColumnPrevPeriod.VisibleIndex = 2;
            this.gridColumnPrevPeriod.Width = 94;
            // 
            // gridColumnCurrPeriod
            // 
            this.gridColumnCurrPeriod.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnCurrPeriod.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnCurrPeriod.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnCurrPeriod.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnCurrPeriod.Caption = "Текущий период";
            this.gridColumnCurrPeriod.ColumnEdit = this.repositoryItemDateEdit1;
            this.gridColumnCurrPeriod.FieldName = "curr_period";
            this.gridColumnCurrPeriod.MinWidth = 25;
            this.gridColumnCurrPeriod.Name = "gridColumnCurrPeriod";
            this.gridColumnCurrPeriod.Visible = true;
            this.gridColumnCurrPeriod.VisibleIndex = 3;
            this.gridColumnCurrPeriod.Width = 94;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // gridColumnPrevValue
            // 
            this.gridColumnPrevValue.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnPrevValue.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnPrevValue.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnPrevValue.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnPrevValue.Caption = "Предыдущее показание";
            this.gridColumnPrevValue.FieldName = "value";
            this.gridColumnPrevValue.MinWidth = 25;
            this.gridColumnPrevValue.Name = "gridColumnPrevValue";
            this.gridColumnPrevValue.Visible = true;
            this.gridColumnPrevValue.VisibleIndex = 4;
            this.gridColumnPrevValue.Width = 94;
            // 
            // gridColumnCurrValue
            // 
            this.gridColumnCurrValue.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnCurrValue.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnCurrValue.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnCurrValue.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnCurrValue.Caption = "Текущее показание";
            this.gridColumnCurrValue.FieldName = "curr_value";
            this.gridColumnCurrValue.MinWidth = 25;
            this.gridColumnCurrValue.Name = "gridColumnCurrValue";
            this.gridColumnCurrValue.Visible = true;
            this.gridColumnCurrValue.VisibleIndex = 5;
            this.gridColumnCurrValue.Width = 94;
            // 
            // gridColumnPAID
            // 
            this.gridColumnPAID.Caption = "Л/С";
            this.gridColumnPAID.FieldName = "personal_account_id";
            this.gridColumnPAID.MinWidth = 25;
            this.gridColumnPAID.Name = "gridColumnPAID";
            this.gridColumnPAID.Visible = true;
            this.gridColumnPAID.VisibleIndex = 6;
            this.gridColumnPAID.Width = 94;
            // 
            // gridColumnObjectName
            // 
            this.gridColumnObjectName.Caption = "Объект";
            this.gridColumnObjectName.FieldName = "name";
            this.gridColumnObjectName.MinWidth = 25;
            this.gridColumnObjectName.Name = "gridColumnObjectName";
            this.gridColumnObjectName.Visible = true;
            this.gridColumnObjectName.VisibleIndex = 0;
            this.gridColumnObjectName.Width = 94;
            // 
            // gridColumnObjectId
            // 
            this.gridColumnObjectId.Caption = "Object_Id";
            this.gridColumnObjectId.FieldName = "object_id";
            this.gridColumnObjectId.MinWidth = 25;
            this.gridColumnObjectId.Name = "gridColumnObjectId";
            this.gridColumnObjectId.Width = 94;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Appearance.Options.UseFont = true;
            this.saveButton.Enabled = false;
            this.saveButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.ImageOptions.Image")));
            this.saveButton.Location = new System.Drawing.Point(1089, 519);
            this.saveButton.MaximumSize = new System.Drawing.Size(180, 40);
            this.saveButton.MinimumSize = new System.Drawing.Size(40, 40);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(145, 40);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Сохранить";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // EnteringReadingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 654);
            this.Controls.Add(this.panelControlMain);
            this.Controls.Add(this.labelControl1);
            this.Name = "EnteringReadingWindow";
            this.Text = "Ввод показаний";
            this.Load += new System.EventHandler(this.EnteringReadingWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).EndInit();
            this.panelControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBoxWarningData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBoxWarningValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlReadings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewReadings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControlMain;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridControlReadings;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewReadings;
        private System.Windows.Forms.ComboBox comboBoxServices;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton resetServicesButton;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit dateEdit;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDPID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPropName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPrevPeriod;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCurrPeriod;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPrevValue;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCurrValue;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPAID;
        private DevExpress.XtraEditors.SvgImageBox svgImageBoxWarningValue;
        private DevExpress.XtraEditors.SvgImageBox svgImageBoxWarningData;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnObjectName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnObjectId;
        private System.Windows.Forms.ComboBox comboBoxTypesObjects;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ComboBox comboBoxParentObject;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}