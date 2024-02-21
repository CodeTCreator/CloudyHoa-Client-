namespace CloudyHoa_Client_.PropertiesWindows
{
    partial class PropertiesWindow
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colproperty_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colchanging_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstart_period = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcase = new DevExpress.XtraGrid.Columns.GridColumn();
            this.deleteButton = new DevExpress.XtraEditors.SimpleButton();
            this.changeButton = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colproperty_name1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcase1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colchanging_date1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstart_period1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControlNameObject = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.treeListObjects = new DevExpress.XtraTreeList.TreeList();
            this.name = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.identificator = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.type_object = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.id = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListObjects)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.xtraTabControl1);
            this.groupBox2.Controls.Add(this.labelControlNameObject);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(357, 114);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(634, 526);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выбранный объект";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(8, 54);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage2;
            this.xtraTabControl1.Size = new System.Drawing.Size(619, 459);
            this.xtraTabControl1.TabIndex = 9;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.gridControl2);
            this.xtraTabPage2.Controls.Add(this.deleteButton);
            this.xtraTabPage2.Controls.Add(this.changeButton);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(617, 429);
            this.xtraTabPage2.Text = "Текущие характеристики";
            // 
            // gridControl2
            // 
            this.gridControl2.DataMember = "Query";
            this.gridControl2.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl2.Location = new System.Drawing.Point(10, 15);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(600, 400);
            this.gridControl2.TabIndex = 7;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colproperty_name,
            this.colchanging_date,
            this.colstart_period,
            this.colcase});
            this.gridView2.CustomizationFormBounds = new System.Drawing.Rectangle(929, 267, 308, 335);
            this.gridView2.DetailHeight = 431;
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // colproperty_name
            // 
            this.colproperty_name.Caption = "Название";
            this.colproperty_name.FieldName = "property_name";
            this.colproperty_name.MinWidth = 25;
            this.colproperty_name.Name = "colproperty_name";
            this.colproperty_name.Visible = true;
            this.colproperty_name.VisibleIndex = 0;
            this.colproperty_name.Width = 94;
            // 
            // colchanging_date
            // 
            this.colchanging_date.Caption = "Дата изменения";
            this.colchanging_date.FieldName = "changing_date";
            this.colchanging_date.MinWidth = 25;
            this.colchanging_date.Name = "colchanging_date";
            this.colchanging_date.Visible = true;
            this.colchanging_date.VisibleIndex = 2;
            this.colchanging_date.Width = 94;
            // 
            // colstart_period
            // 
            this.colstart_period.Caption = "Начальный период";
            this.colstart_period.FieldName = "start_period";
            this.colstart_period.MinWidth = 25;
            this.colstart_period.Name = "colstart_period";
            this.colstart_period.Visible = true;
            this.colstart_period.VisibleIndex = 3;
            this.colstart_period.Width = 94;
            // 
            // colcase
            // 
            this.colcase.Caption = "Значение";
            this.colcase.FieldName = "case";
            this.colcase.MinWidth = 25;
            this.colcase.Name = "colcase";
            this.colcase.Visible = true;
            this.colcase.VisibleIndex = 1;
            this.colcase.Width = 94;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(578, 575);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(88, 28);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Удалить";
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(482, 575);
            this.changeButton.Margin = new System.Windows.Forms.Padding(4);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(88, 28);
            this.changeButton.TabIndex = 3;
            this.changeButton.Text = "Изменить";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gridControl3);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(617, 429);
            this.xtraTabPage1.Text = "Старые характеристики";
            // 
            // gridControl3
            // 
            this.gridControl3.DataMember = "Query_1";
            this.gridControl3.Location = new System.Drawing.Point(10, 15);
            this.gridControl3.MainView = this.gridView3;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(600, 400);
            this.gridControl3.TabIndex = 0;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colproperty_name1,
            this.colcase1,
            this.colchanging_date1,
            this.colstart_period1});
            this.gridView3.GridControl = this.gridControl3;
            this.gridView3.Name = "gridView3";
            // 
            // colproperty_name1
            // 
            this.colproperty_name1.Caption = "Название";
            this.colproperty_name1.FieldName = "property_name";
            this.colproperty_name1.MinWidth = 25;
            this.colproperty_name1.Name = "colproperty_name1";
            this.colproperty_name1.Visible = true;
            this.colproperty_name1.VisibleIndex = 0;
            this.colproperty_name1.Width = 94;
            // 
            // colcase1
            // 
            this.colcase1.Caption = "Значение";
            this.colcase1.FieldName = "case";
            this.colcase1.MinWidth = 25;
            this.colcase1.Name = "colcase1";
            this.colcase1.Visible = true;
            this.colcase1.VisibleIndex = 1;
            this.colcase1.Width = 94;
            // 
            // colchanging_date1
            // 
            this.colchanging_date1.Caption = "Дата изменения";
            this.colchanging_date1.FieldName = "changing_date";
            this.colchanging_date1.MinWidth = 25;
            this.colchanging_date1.Name = "colchanging_date1";
            this.colchanging_date1.Visible = true;
            this.colchanging_date1.VisibleIndex = 2;
            this.colchanging_date1.Width = 94;
            // 
            // colstart_period1
            // 
            this.colstart_period1.Caption = "Начальный период";
            this.colstart_period1.FieldName = "start_period";
            this.colstart_period1.MinWidth = 25;
            this.colstart_period1.Name = "colstart_period1";
            this.colstart_period1.Visible = true;
            this.colstart_period1.VisibleIndex = 3;
            this.colstart_period1.Width = 94;
            // 
            // labelControlNameObject
            // 
            this.labelControlNameObject.Appearance.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControlNameObject.Appearance.Options.UseFont = true;
            this.labelControlNameObject.Location = new System.Drawing.Point(8, 12);
            this.labelControlNameObject.Margin = new System.Windows.Forms.Padding(4);
            this.labelControlNameObject.Name = "labelControlNameObject";
            this.labelControlNameObject.Size = new System.Drawing.Size(82, 35);
            this.labelControlNameObject.TabIndex = 8;
            this.labelControlNameObject.Text = "Объект: ";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(308, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(321, 37);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Характеристики объектов";
            // 
            // treeListObjects
            // 
            this.treeListObjects.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.name,
            this.identificator,
            this.type_object,
            this.id});
            this.treeListObjects.Location = new System.Drawing.Point(12, 126);
            this.treeListObjects.Name = "treeListObjects";
            this.treeListObjects.Size = new System.Drawing.Size(334, 515);
            this.treeListObjects.TabIndex = 11;
            // 
            // name
            // 
            this.name.Caption = "Тип объекта";
            this.name.FieldName = "Тип объекта";
            this.name.Name = "name";
            this.name.Visible = true;
            this.name.VisibleIndex = 0;
            // 
            // identificator
            // 
            this.identificator.Caption = "Номер";
            this.identificator.FieldName = "Номер";
            this.identificator.Name = "identificator";
            this.identificator.Visible = true;
            this.identificator.VisibleIndex = 1;
            // 
            // type_object
            // 
            this.type_object.Caption = "treeListColumn3";
            this.type_object.FieldName = "type_object";
            this.type_object.Name = "type_object";
            // 
            // id
            // 
            this.id.Caption = "treeListColumn4";
            this.id.FieldName = "id";
            this.id.Name = "id";
            // 
            // PropertiesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 653);
            this.Controls.Add(this.treeListObjects);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.groupBox2);
            this.Name = "PropertiesWindow";
            this.Text = "Характеристики объектов";
            this.Load += new System.EventHandler(this.PropertiesWindow_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListObjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colproperty_name;
        private DevExpress.XtraGrid.Columns.GridColumn colchanging_date;
        private DevExpress.XtraGrid.Columns.GridColumn colstart_period;
        private DevExpress.XtraGrid.Columns.GridColumn colcase;
        private DevExpress.XtraEditors.SimpleButton deleteButton;
        private DevExpress.XtraEditors.SimpleButton changeButton;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colproperty_name1;
        private DevExpress.XtraGrid.Columns.GridColumn colcase1;
        private DevExpress.XtraGrid.Columns.GridColumn colchanging_date1;
        private DevExpress.XtraGrid.Columns.GridColumn colstart_period1;
        private DevExpress.XtraEditors.LabelControl labelControlNameObject;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraTreeList.TreeList treeListObjects;
        private DevExpress.XtraTreeList.Columns.TreeListColumn name;
        private DevExpress.XtraTreeList.Columns.TreeListColumn identificator;
        private DevExpress.XtraTreeList.Columns.TreeListColumn type_object;
        private DevExpress.XtraTreeList.Columns.TreeListColumn id;
    }
}