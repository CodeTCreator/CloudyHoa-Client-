namespace CloudyHoa_Client_.ObjectWindow
{
    partial class ObjectWindow
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
            this.treeListObject = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.deleteButton = new DevExpress.XtraEditors.SimpleButton();
            this.editButton = new DevExpress.XtraEditors.SimpleButton();
            this.addButton = new DevExpress.XtraEditors.SimpleButton();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gridColumnTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCount = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.treeListObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.tabNavigationPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeListObject
            // 
            this.treeListObject.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2});
            this.treeListObject.KeyFieldName = "id";
            this.treeListObject.Location = new System.Drawing.Point(12, 16);
            this.treeListObject.Name = "treeListObject";
            this.treeListObject.ParentFieldName = "parent_id";
            this.treeListObject.Size = new System.Drawing.Size(595, 400);
            this.treeListObject.TabIndex = 0;
            this.treeListObject.SelectionChanged += new System.EventHandler(this.treeListObject_SelectionChanged);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Название";
            this.treeListColumn1.FieldName = "name";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 339;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "Идентификатор";
            this.treeListColumn2.FieldName = "identificator";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            this.treeListColumn2.Width = 226;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(14, 14);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(659, 414);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnTypeName,
            this.gridColumnCount});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(225, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(234, 31);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Объекты организации";
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Location = new System.Drawing.Point(12, 55);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2});
            this.tabPane1.RegularSize = new System.Drawing.Size(688, 472);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.ShowToolTips = DevExpress.Utils.DefaultBoolean.True;
            this.tabPane1.Size = new System.Drawing.Size(688, 472);
            this.tabPane1.TabIndex = 3;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Объекты";
            this.tabNavigationPage1.Controls.Add(this.panelControl1);
            this.tabNavigationPage1.Controls.Add(this.treeListObject);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(688, 431);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.deleteButton);
            this.panelControl1.Controls.Add(this.editButton);
            this.panelControl1.Controls.Add(this.addButton);
            this.panelControl1.Location = new System.Drawing.Point(613, 100);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(60, 181);
            this.panelControl1.TabIndex = 1;
            // 
            // deleteButton
            // 
            this.deleteButton.ImageOptions.Image = global::CloudyHoa_Client_.Properties.Resources.removepivotfield_32x32;
            this.deleteButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.deleteButton.Location = new System.Drawing.Point(5, 129);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(50, 45);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.ImageOptions.Image = global::CloudyHoa_Client_.Properties.Resources.editname_32x32;
            this.editButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.editButton.Location = new System.Drawing.Point(6, 68);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(50, 45);
            this.editButton.TabIndex = 1;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.ImageOptions.Image = global::CloudyHoa_Client_.Properties.Resources.add_32x32;
            this.addButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.addButton.Location = new System.Drawing.Point(6, 6);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(50, 45);
            this.addButton.TabIndex = 0;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "Общая информация";
            this.tabNavigationPage2.Controls.Add(this.gridControl1);
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(688, 431);
            // 
            // gridColumnTypeName
            // 
            this.gridColumnTypeName.Caption = "Тип объекта";
            this.gridColumnTypeName.FieldName = "name";
            this.gridColumnTypeName.MinWidth = 25;
            this.gridColumnTypeName.Name = "gridColumnTypeName";
            this.gridColumnTypeName.Visible = true;
            this.gridColumnTypeName.VisibleIndex = 0;
            this.gridColumnTypeName.Width = 94;
            // 
            // gridColumnCount
            // 
            this.gridColumnCount.Caption = "Количество";
            this.gridColumnCount.FieldName = "count";
            this.gridColumnCount.MinWidth = 25;
            this.gridColumnCount.Name = "gridColumnCount";
            this.gridColumnCount.Visible = true;
            this.gridColumnCount.VisibleIndex = 1;
            this.gridColumnCount.Width = 94;
            // 
            // ObjectWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 539);
            this.Controls.Add(this.tabPane1);
            this.Controls.Add(this.labelControl1);
            this.Name = "ObjectWindow";
            this.Text = "Объекты организации";
            this.Load += new System.EventHandler(this.ObjectWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeListObject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.tabNavigationPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeListObject;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton deleteButton;
        private DevExpress.XtraEditors.SimpleButton editButton;
        private DevExpress.XtraEditors.SimpleButton addButton;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCount;
    }
}