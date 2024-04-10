namespace CloudyHoa_Client_.General
{
    partial class TreeListControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeListObjects = new DevExpress.XtraTreeList.TreeList();
            this.columnId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.columnName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.columnParentId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.columnIdentificator = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.columnTypeObject = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.treeListObjects)).BeginInit();
            this.SuspendLayout();
            // 
            // treeListObjects
            // 
            this.treeListObjects.Appearance.Caption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeListObjects.Appearance.Caption.Options.UseFont = true;
            this.treeListObjects.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeListObjects.Appearance.Row.Options.UseFont = true;
            this.treeListObjects.Appearance.Row.Options.UseTextOptions = true;
            this.treeListObjects.AppearancePrint.Caption.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeListObjects.AppearancePrint.Caption.Options.UseFont = true;
            this.treeListObjects.CaptionHeight = 30;
            this.treeListObjects.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.columnId,
            this.columnName,
            this.columnParentId,
            this.columnIdentificator,
            this.columnTypeObject});
            this.treeListObjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListObjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeListObjects.HorzScrollStep = 4;
            this.treeListObjects.KeyFieldName = "id";
            this.treeListObjects.Location = new System.Drawing.Point(0, 0);
            this.treeListObjects.Margin = new System.Windows.Forms.Padding(4);
            this.treeListObjects.MinWidth = 25;
            this.treeListObjects.Name = "treeListObjects";
            this.treeListObjects.ParentFieldName = "parent_id";
            this.treeListObjects.RowHeight = 20;
            this.treeListObjects.Size = new System.Drawing.Size(595, 515);
            this.treeListObjects.TabIndex = 0;
            this.treeListObjects.TreeLevelWidth = 22;
            this.treeListObjects.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeListObjects_FocusedNodeChanged);
            // 
            // columnId
            // 
            this.columnId.Caption = "treeListColumn1";
            this.columnId.FieldName = "id";
            this.columnId.MinWidth = 25;
            this.columnId.Name = "columnId";
            this.columnId.Width = 94;
            // 
            // columnName
            // 
            this.columnName.AllowIncrementalSearch = false;
            this.columnName.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.columnName.AppearanceCell.Options.UseFont = true;
            this.columnName.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.columnName.AppearanceHeader.Options.UseFont = true;
            this.columnName.AppearanceHeader.Options.UseTextOptions = true;
            this.columnName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.columnName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.columnName.Caption = "Тип объекта";
            this.columnName.FieldName = "name";
            this.columnName.MinWidth = 25;
            this.columnName.Name = "columnName";
            this.columnName.Visible = true;
            this.columnName.VisibleIndex = 0;
            this.columnName.Width = 340;
            // 
            // columnParentId
            // 
            this.columnParentId.Caption = "treeListColumn3";
            this.columnParentId.FieldName = "parentId";
            this.columnParentId.MinWidth = 25;
            this.columnParentId.Name = "columnParentId";
            this.columnParentId.Width = 94;
            // 
            // columnIdentificator
            // 
            this.columnIdentificator.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.columnIdentificator.AppearanceCell.Options.UseFont = true;
            this.columnIdentificator.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.columnIdentificator.AppearanceHeader.Options.UseFont = true;
            this.columnIdentificator.AppearanceHeader.Options.UseTextOptions = true;
            this.columnIdentificator.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.columnIdentificator.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.columnIdentificator.Caption = "Номер";
            this.columnIdentificator.FieldName = "identificator";
            this.columnIdentificator.MinWidth = 25;
            this.columnIdentificator.Name = "columnIdentificator";
            this.columnIdentificator.Visible = true;
            this.columnIdentificator.VisibleIndex = 1;
            this.columnIdentificator.Width = 225;
            // 
            // columnTypeObject
            // 
            this.columnTypeObject.Caption = "treeListColumn4";
            this.columnTypeObject.FieldName = "typeObject";
            this.columnTypeObject.MinWidth = 25;
            this.columnTypeObject.Name = "columnTypeObject";
            this.columnTypeObject.Width = 94;
            // 
            // TreeListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeListObjects);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TreeListControl";
            this.Size = new System.Drawing.Size(595, 515);
            ((System.ComponentModel.ISupportInitialize)(this.treeListObjects)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeListObjects;
        private DevExpress.XtraTreeList.Columns.TreeListColumn columnId;
        private DevExpress.XtraTreeList.Columns.TreeListColumn columnName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn columnParentId;
        private DevExpress.XtraTreeList.Columns.TreeListColumn columnIdentificator;
        private DevExpress.XtraTreeList.Columns.TreeListColumn columnTypeObject;
    }
}
