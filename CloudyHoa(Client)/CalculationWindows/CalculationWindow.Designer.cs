namespace CloudyHoa_Client_.CalculationWindows
{
    partial class CalculationWindow
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
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateEditPeriod = new DevExpress.XtraEditors.DateEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clearServicesButton = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxServices = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridControlTarrif = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTariffName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnValueTariff = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlCalculation = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.objectId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.calculateButton = new DevExpress.XtraEditors.SimpleButton();
            this.panelControlMain = new DevExpress.XtraEditors.PanelControl();
            this.treeListTO = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumnId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumnName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumnParentId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditPeriod.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditPeriod.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTarrif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCalculation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).BeginInit();
            this.panelControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListTO)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Appearance.Options.UseFont = true;
            this.saveButton.Enabled = false;
            this.saveButton.ImageOptions.Image = global::CloudyHoa_Client_.Properties.Resources.save_32x32;
            this.saveButton.Location = new System.Drawing.Point(586, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(145, 45);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Сохранить";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(495, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(150, 37);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Расчет услуг";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupBox3);
            this.panelControl1.Controls.Add(this.groupBox1);
            this.panelControl1.Controls.Add(this.groupBox2);
            this.panelControl1.Controls.Add(this.gridControlCalculation);
            this.panelControl1.Location = new System.Drawing.Point(283, 5);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(738, 593);
            this.panelControl1.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateEditPeriod);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(2, 490);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(275, 71);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Период";
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
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(2, 424);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 66);
            this.groupBox1.TabIndex = 1;
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
            this.comboBoxServices.Enabled = false;
            this.comboBoxServices.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxServices.FormattingEnabled = true;
            this.comboBoxServices.Location = new System.Drawing.Point(6, 22);
            this.comboBoxServices.Name = "comboBoxServices";
            this.comboBoxServices.Size = new System.Drawing.Size(187, 31);
            this.comboBoxServices.TabIndex = 0;
            this.comboBoxServices.SelectionChangeCommitted += new System.EventHandler(this.comboBoxServices_SelectionChangeCommitted);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridControlTarrif);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(277, 424);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 167);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Тарифы";
            // 
            // gridControlTarrif
            // 
            this.gridControlTarrif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlTarrif.EmbeddedNavigator.Enabled = false;
            this.gridControlTarrif.Enabled = false;
            this.gridControlTarrif.Location = new System.Drawing.Point(3, 19);
            this.gridControlTarrif.MainView = this.gridView2;
            this.gridControlTarrif.Name = "gridControlTarrif";
            this.gridControlTarrif.Size = new System.Drawing.Size(453, 145);
            this.gridControlTarrif.TabIndex = 0;
            this.gridControlTarrif.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn8,
            this.gridColumnTariffName,
            this.gridColumnValueTariff,
            this.gridColumn1});
            this.gridView2.GridControl = this.gridControlTarrif;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsCustomization.AllowFilter = false;
            this.gridView2.OptionsCustomization.AllowGroup = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Л/С";
            this.gridColumn8.FieldName = "account";
            this.gridColumn8.MinWidth = 25;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 0;
            this.gridColumn8.Width = 94;
            // 
            // gridColumnTariffName
            // 
            this.gridColumnTariffName.Caption = "Тариф";
            this.gridColumnTariffName.FieldName = "tariff_name";
            this.gridColumnTariffName.MinWidth = 25;
            this.gridColumnTariffName.Name = "gridColumnTariffName";
            this.gridColumnTariffName.Visible = true;
            this.gridColumnTariffName.VisibleIndex = 1;
            this.gridColumnTariffName.Width = 94;
            // 
            // gridColumnValueTariff
            // 
            this.gridColumnValueTariff.Caption = "Коэффициент";
            this.gridColumnValueTariff.FieldName = "tariff_value";
            this.gridColumnValueTariff.MinWidth = 25;
            this.gridColumnValueTariff.Name = "gridColumnValueTariff";
            this.gridColumnValueTariff.Visible = true;
            this.gridColumnValueTariff.VisibleIndex = 2;
            this.gridColumnValueTariff.Width = 94;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Итог";
            this.gridColumn1.FieldName = "result_tariff";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 94;
            // 
            // gridControlCalculation
            // 
            this.gridControlCalculation.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControlCalculation.Enabled = false;
            this.gridControlCalculation.Location = new System.Drawing.Point(2, 2);
            this.gridControlCalculation.MainView = this.gridView1;
            this.gridControlCalculation.Name = "gridControlCalculation";
            this.gridControlCalculation.Size = new System.Drawing.Size(734, 422);
            this.gridControlCalculation.TabIndex = 0;
            this.gridControlCalculation.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControlCalculation.Click += new System.EventHandler(this.gridControlCalculation_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.objectId,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.gridView1.GridControl = this.gridControlCalculation;
            this.gridView1.Name = "gridView1";
            // 
            // objectId
            // 
            this.objectId.Caption = "Object Id";
            this.objectId.FieldName = "id";
            this.objectId.MinWidth = 25;
            this.objectId.Name = "objectId";
            this.objectId.Width = 94;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Объект";
            this.gridColumn2.FieldName = "object_name";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 94;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "pa_id";
            this.gridColumn3.FieldName = "pa_id";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Width = 94;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Л/С";
            this.gridColumn4.FieldName = "account";
            this.gridColumn4.MinWidth = 25;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 94;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Начислено";
            this.gridColumn5.FieldName = "result_tariff";
            this.gridColumn5.MinWidth = 25;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            this.gridColumn5.Width = 94;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Льготы";
            this.gridColumn6.FieldName = "benefit_value";
            this.gridColumn6.MinWidth = 25;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            this.gridColumn6.Width = 94;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Итого";
            this.gridColumn7.FieldName = "result_value";
            this.gridColumn7.MinWidth = 25;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 4;
            this.gridColumn7.Width = 94;
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelControl2.Controls.Add(this.calculateButton);
            this.panelControl2.Controls.Add(this.saveButton);
            this.panelControl2.Location = new System.Drawing.Point(283, 599);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(736, 53);
            this.panelControl2.TabIndex = 4;
            // 
            // calculateButton
            // 
            this.calculateButton.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculateButton.Appearance.Options.UseFont = true;
            this.calculateButton.Enabled = false;
            this.calculateButton.ImageOptions.Image = global::CloudyHoa_Client_.Properties.Resources.calculatenow_32x32;
            this.calculateButton.Location = new System.Drawing.Point(5, 3);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(145, 45);
            this.calculateButton.TabIndex = 1;
            this.calculateButton.Text = "Расчитать";
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // panelControlMain
            // 
            this.panelControlMain.Controls.Add(this.treeListTO);
            this.panelControlMain.Controls.Add(this.panelControl2);
            this.panelControlMain.Controls.Add(this.panelControl1);
            this.panelControlMain.Location = new System.Drawing.Point(12, 86);
            this.panelControlMain.Name = "panelControlMain";
            this.panelControlMain.Size = new System.Drawing.Size(1029, 660);
            this.panelControlMain.TabIndex = 6;
            // 
            // treeListTO
            // 
            this.treeListTO.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumnId,
            this.treeListColumnName,
            this.treeListColumnParentId});
            this.treeListTO.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeListTO.Location = new System.Drawing.Point(2, 2);
            this.treeListTO.Name = "treeListTO";
            this.treeListTO.Size = new System.Drawing.Size(275, 656);
            this.treeListTO.TabIndex = 5;
            this.treeListTO.Click += new System.EventHandler(this.treeListTO_Click);
            // 
            // treeListColumnId
            // 
            this.treeListColumnId.Caption = "treeListColumn1";
            this.treeListColumnId.FieldName = "id";
            this.treeListColumnId.Name = "treeListColumnId";
            // 
            // treeListColumnName
            // 
            this.treeListColumnName.Caption = "Тип объекта";
            this.treeListColumnName.FieldName = "name";
            this.treeListColumnName.Name = "treeListColumnName";
            this.treeListColumnName.Visible = true;
            this.treeListColumnName.VisibleIndex = 0;
            // 
            // treeListColumnParentId
            // 
            this.treeListColumnParentId.Caption = "treeListColumn1";
            this.treeListColumnParentId.FieldName = "parent_type";
            this.treeListColumnParentId.Name = "treeListColumnParentId";
            // 
            // CalculationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 758);
            this.Controls.Add(this.panelControlMain);
            this.Controls.Add(this.labelControl1);
            this.Name = "CalculationWindow";
            this.Text = "Расчет услуг";
            this.Load += new System.EventHandler(this.CalculationWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateEditPeriod.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditPeriod.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTarrif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCalculation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).EndInit();
            this.panelControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeListTO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton calculateButton;
        private DevExpress.XtraEditors.SimpleButton clearServicesButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxServices;
        private DevExpress.XtraGrid.GridControl gridControlCalculation;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControlMain;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl gridControlTarrif;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.DateEdit dateEditPeriod;
        private DevExpress.XtraGrid.Columns.GridColumn objectId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraTreeList.TreeList treeListTO;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumnId;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumnName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumnParentId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTariffName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnValueTariff;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
    }
}