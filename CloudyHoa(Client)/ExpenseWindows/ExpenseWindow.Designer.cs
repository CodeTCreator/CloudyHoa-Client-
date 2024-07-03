namespace CloudyHoa_Client_.ExpenseWindows
{
    partial class ExpenseWindow
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControlCategory = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl = new DevExpress.XtraEditors.PanelControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelControlResultCost = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.updateIEButton = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlInnerExpenses = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnCN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnEName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnResultCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateTimeOffsetEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateTimeOffsetEdit();
            this.labelControlInnerResult = new DevExpress.XtraEditors.LabelControl();
            this.addInnerExpenseButton = new DevExpress.XtraEditors.SimpleButton();
            this.deleteInnerExpenseButton = new DevExpress.XtraEditors.SimpleButton();
            this.editInnerExpenseButton = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlExternalExpenses = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateTimeOffsetEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateTimeOffsetEdit();
            this.gridColumnObjectId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnObjectName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnObjectNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.deleteExternalExpenseButton = new DevExpress.XtraEditors.SimpleButton();
            this.editExternalExpenseButton = new DevExpress.XtraEditors.SimpleButton();
            this.addExternalButton = new DevExpress.XtraEditors.SimpleButton();
            this.labelControlExternalResult = new DevExpress.XtraEditors.LabelControl();
            this.clearPeriodFilterButton = new DevExpress.XtraEditors.SimpleButton();
            this.periodEdit = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteCategoryButton = new DevExpress.XtraEditors.SimpleButton();
            this.editCategoryButton = new DevExpress.XtraEditors.SimpleButton();
            this.addCategoryButton = new DevExpress.XtraEditors.SimpleButton();
            this.updateEEButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).BeginInit();
            this.panelControl.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlInnerExpenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateTimeOffsetEdit1)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlExternalExpenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateTimeOffsetEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodEdit.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl1.Location = new System.Drawing.Point(396, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(235, 31);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Расходы Организации";
            // 
            // gridControlCategory
            // 
            this.gridControlCategory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControlCategory.Location = new System.Drawing.Point(3, 119);
            this.gridControlCategory.MainView = this.gridView1;
            this.gridControlCategory.Name = "gridControlCategory";
            this.gridControlCategory.Size = new System.Drawing.Size(259, 369);
            this.gridControlCategory.TabIndex = 1;
            this.gridControlCategory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControlCategory.Click += new System.EventHandler(this.gridControlCategory_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnName});
            this.gridView1.GridControl = this.gridControlCategory;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumnName
            // 
            this.gridColumnName.Caption = "Название";
            this.gridColumnName.FieldName = "name";
            this.gridColumnName.MinWidth = 25;
            this.gridColumnName.Name = "gridColumnName";
            this.gridColumnName.Visible = true;
            this.gridColumnName.VisibleIndex = 0;
            this.gridColumnName.Width = 94;
            // 
            // panelControl
            // 
            this.panelControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl.Controls.Add(this.groupBox2);
            this.panelControl.Controls.Add(this.groupBox1);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl.Location = new System.Drawing.Point(0, 70);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1108, 491);
            this.panelControl.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelControlResultCost);
            this.groupBox2.Controls.Add(this.xtraTabControl1);
            this.groupBox2.Controls.Add(this.clearPeriodFilterButton);
            this.groupBox2.Controls.Add(this.periodEdit);
            this.groupBox2.Controls.Add(this.labelControl2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(265, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(843, 491);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Расходы";
            // 
            // labelControlResultCost
            // 
            this.labelControlResultCost.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControlResultCost.Appearance.Options.UseFont = true;
            this.labelControlResultCost.Location = new System.Drawing.Point(341, 20);
            this.labelControlResultCost.Name = "labelControlResultCost";
            this.labelControlResultCost.Size = new System.Drawing.Size(191, 23);
            this.labelControlResultCost.TabIndex = 13;
            this.labelControlResultCost.Text = "Общая сумма расходов:";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.xtraTabControl1.Location = new System.Drawing.Point(3, 53);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(837, 435);
            this.xtraTabControl1.TabIndex = 12;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage2,
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.updateIEButton);
            this.xtraTabPage1.Controls.Add(this.gridControlInnerExpenses);
            this.xtraTabPage1.Controls.Add(this.labelControlInnerResult);
            this.xtraTabPage1.Controls.Add(this.addInnerExpenseButton);
            this.xtraTabPage1.Controls.Add(this.deleteInnerExpenseButton);
            this.xtraTabPage1.Controls.Add(this.editInnerExpenseButton);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(835, 405);
            this.xtraTabPage1.Text = "Внутренние расходы";
            // 
            // updateIEButton
            // 
            this.updateIEButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updateIEButton.ImageOptions.Image = global::CloudyHoa_Client_.Properties.Resources.refreshallpivottable_32x32;
            this.updateIEButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.updateIEButton.Location = new System.Drawing.Point(628, 4);
            this.updateIEButton.Name = "updateIEButton";
            this.updateIEButton.Size = new System.Drawing.Size(45, 45);
            this.updateIEButton.TabIndex = 11;
            this.updateIEButton.Click += new System.EventHandler(this.updateIEButton_Click);
            // 
            // gridControlInnerExpenses
            // 
            this.gridControlInnerExpenses.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControlInnerExpenses.Location = new System.Drawing.Point(0, 55);
            this.gridControlInnerExpenses.MainView = this.gridView2;
            this.gridControlInnerExpenses.Name = "gridControlInnerExpenses";
            this.gridControlInnerExpenses.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateTimeOffsetEdit1});
            this.gridControlInnerExpenses.Size = new System.Drawing.Size(835, 350);
            this.gridControlInnerExpenses.TabIndex = 2;
            this.gridControlInnerExpenses.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridControlInnerExpenses.Click += new System.EventHandler(this.gridControlInnerExpenses_Click);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnCN,
            this.gridColumnEName,
            this.gridColumnQuantity,
            this.gridColumnCost,
            this.gridColumnResultCost,
            this.gridColumnDate});
            this.gridView2.GridControl = this.gridControlInnerExpenses;
            this.gridView2.GroupCount = 1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.AllowGroupExpandAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.gridView2.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsPrint.ExpandAllDetails = true;
            this.gridView2.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumnCN, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumnCN
            // 
            this.gridColumnCN.Caption = "Категория";
            this.gridColumnCN.FieldName = "name1";
            this.gridColumnCN.MinWidth = 25;
            this.gridColumnCN.Name = "gridColumnCN";
            this.gridColumnCN.Visible = true;
            this.gridColumnCN.VisibleIndex = 0;
            this.gridColumnCN.Width = 94;
            // 
            // gridColumnEName
            // 
            this.gridColumnEName.Caption = "Название расхода";
            this.gridColumnEName.FieldName = "name";
            this.gridColumnEName.MinWidth = 25;
            this.gridColumnEName.Name = "gridColumnEName";
            this.gridColumnEName.Visible = true;
            this.gridColumnEName.VisibleIndex = 0;
            this.gridColumnEName.Width = 158;
            // 
            // gridColumnQuantity
            // 
            this.gridColumnQuantity.Caption = "Количество";
            this.gridColumnQuantity.FieldName = "quantity";
            this.gridColumnQuantity.MinWidth = 25;
            this.gridColumnQuantity.Name = "gridColumnQuantity";
            this.gridColumnQuantity.Visible = true;
            this.gridColumnQuantity.VisibleIndex = 2;
            this.gridColumnQuantity.Width = 100;
            // 
            // gridColumnCost
            // 
            this.gridColumnCost.Caption = "Стоимость единицы";
            this.gridColumnCost.FieldName = "cost";
            this.gridColumnCost.MinWidth = 25;
            this.gridColumnCost.Name = "gridColumnCost";
            this.gridColumnCost.Visible = true;
            this.gridColumnCost.VisibleIndex = 3;
            this.gridColumnCost.Width = 144;
            // 
            // gridColumnResultCost
            // 
            this.gridColumnResultCost.Caption = "Итоговая стоимость";
            this.gridColumnResultCost.FieldName = "result_cost";
            this.gridColumnResultCost.MinWidth = 25;
            this.gridColumnResultCost.Name = "gridColumnResultCost";
            this.gridColumnResultCost.Visible = true;
            this.gridColumnResultCost.VisibleIndex = 4;
            this.gridColumnResultCost.Width = 180;
            // 
            // gridColumnDate
            // 
            this.gridColumnDate.Caption = "Период";
            this.gridColumnDate.ColumnEdit = this.repositoryItemDateTimeOffsetEdit1;
            this.gridColumnDate.DisplayFormat.FormatString = "Y";
            this.gridColumnDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumnDate.FieldName = "date";
            this.gridColumnDate.MinWidth = 25;
            this.gridColumnDate.Name = "gridColumnDate";
            this.gridColumnDate.Visible = true;
            this.gridColumnDate.VisibleIndex = 1;
            this.gridColumnDate.Width = 103;
            // 
            // repositoryItemDateTimeOffsetEdit1
            // 
            this.repositoryItemDateTimeOffsetEdit1.AutoHeight = false;
            this.repositoryItemDateTimeOffsetEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateTimeOffsetEdit1.MaskSettings.Set("mask", "Y");
            this.repositoryItemDateTimeOffsetEdit1.Name = "repositoryItemDateTimeOffsetEdit1";
            // 
            // labelControlInnerResult
            // 
            this.labelControlInnerResult.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControlInnerResult.Appearance.Options.UseFont = true;
            this.labelControlInnerResult.Location = new System.Drawing.Point(3, 14);
            this.labelControlInnerResult.Name = "labelControlInnerResult";
            this.labelControlInnerResult.Size = new System.Drawing.Size(230, 23);
            this.labelControlInnerResult.TabIndex = 10;
            this.labelControlInnerResult.Text = "Сумма внутренних расходов:";
            // 
            // addInnerExpenseButton
            // 
            this.addInnerExpenseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addInnerExpenseButton.ImageOptions.Image = global::CloudyHoa_Client_.Properties.Resources.add_32x32;
            this.addInnerExpenseButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.addInnerExpenseButton.Location = new System.Drawing.Point(679, 4);
            this.addInnerExpenseButton.Name = "addInnerExpenseButton";
            this.addInnerExpenseButton.Size = new System.Drawing.Size(45, 45);
            this.addInnerExpenseButton.TabIndex = 6;
            this.addInnerExpenseButton.Click += new System.EventHandler(this.addExpenseButton_Click);
            // 
            // deleteInnerExpenseButton
            // 
            this.deleteInnerExpenseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteInnerExpenseButton.Enabled = false;
            this.deleteInnerExpenseButton.ImageOptions.Image = global::CloudyHoa_Client_.Properties.Resources.remove_32x32;
            this.deleteInnerExpenseButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.deleteInnerExpenseButton.Location = new System.Drawing.Point(781, 4);
            this.deleteInnerExpenseButton.Name = "deleteInnerExpenseButton";
            this.deleteInnerExpenseButton.Size = new System.Drawing.Size(45, 45);
            this.deleteInnerExpenseButton.TabIndex = 8;
            this.deleteInnerExpenseButton.Click += new System.EventHandler(this.deleteExpenseButton_Click);
            // 
            // editInnerExpenseButton
            // 
            this.editInnerExpenseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editInnerExpenseButton.Enabled = false;
            this.editInnerExpenseButton.ImageOptions.Image = global::CloudyHoa_Client_.Properties.Resources.edit_32x321;
            this.editInnerExpenseButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.editInnerExpenseButton.Location = new System.Drawing.Point(730, 4);
            this.editInnerExpenseButton.Name = "editInnerExpenseButton";
            this.editInnerExpenseButton.Size = new System.Drawing.Size(45, 45);
            this.editInnerExpenseButton.TabIndex = 7;
            this.editInnerExpenseButton.Click += new System.EventHandler(this.editExpenseButton_Click);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.updateEEButton);
            this.xtraTabPage2.Controls.Add(this.gridControlExternalExpenses);
            this.xtraTabPage2.Controls.Add(this.deleteExternalExpenseButton);
            this.xtraTabPage2.Controls.Add(this.editExternalExpenseButton);
            this.xtraTabPage2.Controls.Add(this.addExternalButton);
            this.xtraTabPage2.Controls.Add(this.labelControlExternalResult);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(835, 405);
            this.xtraTabPage2.Text = "Расходы";
            // 
            // gridControlExternalExpenses
            // 
            this.gridControlExternalExpenses.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControlExternalExpenses.Location = new System.Drawing.Point(0, 60);
            this.gridControlExternalExpenses.MainView = this.gridView3;
            this.gridControlExternalExpenses.Name = "gridControlExternalExpenses";
            this.gridControlExternalExpenses.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateTimeOffsetEdit2});
            this.gridControlExternalExpenses.Size = new System.Drawing.Size(835, 345);
            this.gridControlExternalExpenses.TabIndex = 15;
            this.gridControlExternalExpenses.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            this.gridControlExternalExpenses.Click += new System.EventHandler(this.gridControlExternalExpenses_Click);
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumnObjectId,
            this.gridColumnObjectName,
            this.gridColumnObjectNumber});
            this.gridView3.GridControl = this.gridControlExternalExpenses;
            this.gridView3.GroupCount = 1;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.AllowGroupExpandAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.gridView3.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.OptionsPrint.ExpandAllDetails = true;
            this.gridView3.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn1, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Категория";
            this.gridColumn1.FieldName = "name1";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 94;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Название расхода";
            this.gridColumn2.FieldName = "name";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 158;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Количество";
            this.gridColumn3.FieldName = "quantity";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 4;
            this.gridColumn3.Width = 100;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Стоимость единицы";
            this.gridColumn4.FieldName = "cost";
            this.gridColumn4.MinWidth = 25;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 5;
            this.gridColumn4.Width = 106;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Итоговая стоимость";
            this.gridColumn5.FieldName = "result_cost";
            this.gridColumn5.MinWidth = 25;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 6;
            this.gridColumn5.Width = 109;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Период";
            this.gridColumn6.ColumnEdit = this.repositoryItemDateTimeOffsetEdit2;
            this.gridColumn6.DisplayFormat.FormatString = "Y";
            this.gridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn6.FieldName = "date";
            this.gridColumn6.MinWidth = 25;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            this.gridColumn6.Width = 86;
            // 
            // repositoryItemDateTimeOffsetEdit2
            // 
            this.repositoryItemDateTimeOffsetEdit2.AutoHeight = false;
            this.repositoryItemDateTimeOffsetEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateTimeOffsetEdit2.MaskSettings.Set("mask", "Y");
            this.repositoryItemDateTimeOffsetEdit2.Name = "repositoryItemDateTimeOffsetEdit2";
            // 
            // gridColumnObjectId
            // 
            this.gridColumnObjectId.Caption = "object_id";
            this.gridColumnObjectId.MinWidth = 25;
            this.gridColumnObjectId.Name = "gridColumnObjectId";
            this.gridColumnObjectId.Width = 94;
            // 
            // gridColumnObjectName
            // 
            this.gridColumnObjectName.Caption = "Тип объекта";
            this.gridColumnObjectName.FieldName = "name2";
            this.gridColumnObjectName.MinWidth = 25;
            this.gridColumnObjectName.Name = "gridColumnObjectName";
            this.gridColumnObjectName.Visible = true;
            this.gridColumnObjectName.VisibleIndex = 1;
            this.gridColumnObjectName.Width = 94;
            // 
            // gridColumnObjectNumber
            // 
            this.gridColumnObjectNumber.Caption = "Номер";
            this.gridColumnObjectNumber.FieldName = "identificator";
            this.gridColumnObjectNumber.MinWidth = 25;
            this.gridColumnObjectNumber.Name = "gridColumnObjectNumber";
            this.gridColumnObjectNumber.Visible = true;
            this.gridColumnObjectNumber.VisibleIndex = 2;
            this.gridColumnObjectNumber.Width = 94;
            // 
            // deleteExternalExpenseButton
            // 
            this.deleteExternalExpenseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteExternalExpenseButton.Enabled = false;
            this.deleteExternalExpenseButton.ImageOptions.Image = global::CloudyHoa_Client_.Properties.Resources.remove_32x32;
            this.deleteExternalExpenseButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.deleteExternalExpenseButton.Location = new System.Drawing.Point(782, 9);
            this.deleteExternalExpenseButton.Name = "deleteExternalExpenseButton";
            this.deleteExternalExpenseButton.Size = new System.Drawing.Size(45, 45);
            this.deleteExternalExpenseButton.TabIndex = 14;
            this.deleteExternalExpenseButton.Click += new System.EventHandler(this.deleteExternalButton_Click);
            // 
            // editExternalExpenseButton
            // 
            this.editExternalExpenseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editExternalExpenseButton.Enabled = false;
            this.editExternalExpenseButton.ImageOptions.Image = global::CloudyHoa_Client_.Properties.Resources.edit_32x321;
            this.editExternalExpenseButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.editExternalExpenseButton.Location = new System.Drawing.Point(731, 9);
            this.editExternalExpenseButton.Name = "editExternalExpenseButton";
            this.editExternalExpenseButton.Size = new System.Drawing.Size(45, 45);
            this.editExternalExpenseButton.TabIndex = 13;
            this.editExternalExpenseButton.Click += new System.EventHandler(this.editExternalButton_Click);
            // 
            // addExternalButton
            // 
            this.addExternalButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addExternalButton.ImageOptions.Image = global::CloudyHoa_Client_.Properties.Resources.add_32x32;
            this.addExternalButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.addExternalButton.Location = new System.Drawing.Point(680, 9);
            this.addExternalButton.Name = "addExternalButton";
            this.addExternalButton.Size = new System.Drawing.Size(45, 45);
            this.addExternalButton.TabIndex = 12;
            this.addExternalButton.Click += new System.EventHandler(this.addExternalButton_Click);
            // 
            // labelControlExternalResult
            // 
            this.labelControlExternalResult.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControlExternalResult.Appearance.Options.UseFont = true;
            this.labelControlExternalResult.Location = new System.Drawing.Point(3, 19);
            this.labelControlExternalResult.Name = "labelControlExternalResult";
            this.labelControlExternalResult.Size = new System.Drawing.Size(134, 23);
            this.labelControlExternalResult.TabIndex = 11;
            this.labelControlExternalResult.Text = "Сумма расходов:";
            // 
            // clearPeriodFilterButton
            // 
            this.clearPeriodFilterButton.ImageOptions.Image = global::CloudyHoa_Client_.Properties.Resources.clear_32x32;
            this.clearPeriodFilterButton.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.clearPeriodFilterButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.clearPeriodFilterButton.Location = new System.Drawing.Point(229, 17);
            this.clearPeriodFilterButton.Name = "clearPeriodFilterButton";
            this.clearPeriodFilterButton.Size = new System.Drawing.Size(45, 30);
            this.clearPeriodFilterButton.TabIndex = 11;
            this.clearPeriodFilterButton.Click += new System.EventHandler(this.clearPeriodFilterButton_Click);
            // 
            // periodEdit
            // 
            this.periodEdit.EditValue = null;
            this.periodEdit.Location = new System.Drawing.Point(81, 17);
            this.periodEdit.Name = "periodEdit";
            this.periodEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.periodEdit.Properties.Appearance.Options.UseFont = true;
            this.periodEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.periodEdit.Properties.MaskSettings.Set("mask", "Y");
            this.periodEdit.Size = new System.Drawing.Size(142, 30);
            this.periodEdit.TabIndex = 9;
            this.periodEdit.EditValueChanged += new System.EventHandler(this.periodEdit_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(7, 22);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(68, 25);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Период:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteCategoryButton);
            this.groupBox1.Controls.Add(this.editCategoryButton);
            this.groupBox1.Controls.Add(this.gridControlCategory);
            this.groupBox1.Controls.Add(this.addCategoryButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 491);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Категории";
            // 
            // deleteCategoryButton
            // 
            this.deleteCategoryButton.ImageOptions.Image = global::CloudyHoa_Client_.Properties.Resources.remove_32x32;
            this.deleteCategoryButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.deleteCategoryButton.Location = new System.Drawing.Point(112, 68);
            this.deleteCategoryButton.Name = "deleteCategoryButton";
            this.deleteCategoryButton.Size = new System.Drawing.Size(45, 45);
            this.deleteCategoryButton.TabIndex = 5;
            this.deleteCategoryButton.Click += new System.EventHandler(this.deleteCategoryButton_Click);
            // 
            // editCategoryButton
            // 
            this.editCategoryButton.ImageOptions.Image = global::CloudyHoa_Client_.Properties.Resources.edit_32x321;
            this.editCategoryButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.editCategoryButton.Location = new System.Drawing.Point(61, 68);
            this.editCategoryButton.Name = "editCategoryButton";
            this.editCategoryButton.Size = new System.Drawing.Size(45, 45);
            this.editCategoryButton.TabIndex = 4;
            this.editCategoryButton.Click += new System.EventHandler(this.editCategoryButton_Click);
            // 
            // addCategoryButton
            // 
            this.addCategoryButton.ImageOptions.Image = global::CloudyHoa_Client_.Properties.Resources.add_32x32;
            this.addCategoryButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.addCategoryButton.Location = new System.Drawing.Point(10, 68);
            this.addCategoryButton.Name = "addCategoryButton";
            this.addCategoryButton.Size = new System.Drawing.Size(45, 45);
            this.addCategoryButton.TabIndex = 3;
            this.addCategoryButton.Click += new System.EventHandler(this.addCategoryButton_Click);
            // 
            // updateEEButton
            // 
            this.updateEEButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updateEEButton.ImageOptions.Image = global::CloudyHoa_Client_.Properties.Resources.refreshallpivottable_32x32;
            this.updateEEButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.updateEEButton.Location = new System.Drawing.Point(629, 9);
            this.updateEEButton.Name = "updateEEButton";
            this.updateEEButton.Size = new System.Drawing.Size(45, 45);
            this.updateEEButton.TabIndex = 16;
            this.updateEEButton.Click += new System.EventHandler(this.updateEEButton_Click);
            // 
            // ExpenseWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 561);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.labelControl1);
            this.Name = "ExpenseWindow";
            this.Text = "Расходы";
            this.Load += new System.EventHandler(this.ExpenseWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlInnerExpenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateTimeOffsetEdit1)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlExternalExpenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateTimeOffsetEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodEdit.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControlCategory;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton deleteCategoryButton;
        private DevExpress.XtraEditors.SimpleButton editCategoryButton;
        private DevExpress.XtraEditors.SimpleButton addCategoryButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl gridControlInnerExpenses;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton deleteInnerExpenseButton;
        private DevExpress.XtraEditors.SimpleButton editInnerExpenseButton;
        private DevExpress.XtraEditors.SimpleButton addInnerExpenseButton;
        private DevExpress.XtraEditors.DateTimeOffsetEdit periodEdit;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCN;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnEName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCost;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnResultCost;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDate;
        private DevExpress.XtraEditors.LabelControl labelControlInnerResult;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateTimeOffsetEdit repositoryItemDateTimeOffsetEdit1;
        private DevExpress.XtraEditors.SimpleButton clearPeriodFilterButton;
        private DevExpress.XtraEditors.LabelControl labelControlResultCost;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.LabelControl labelControlExternalResult;
        private DevExpress.XtraGrid.GridControl gridControlExternalExpenses;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateTimeOffsetEdit repositoryItemDateTimeOffsetEdit2;
        private DevExpress.XtraEditors.SimpleButton deleteExternalExpenseButton;
        private DevExpress.XtraEditors.SimpleButton editExternalExpenseButton;
        private DevExpress.XtraEditors.SimpleButton addExternalButton;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnObjectId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnObjectName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnObjectNumber;
        private DevExpress.XtraEditors.SimpleButton updateIEButton;
        private DevExpress.XtraEditors.SimpleButton updateEEButton;
    }
}