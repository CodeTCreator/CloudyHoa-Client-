namespace CloudyHoa_Client_.TariffWindows
{
    partial class TariffWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TariffWindow));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.treeListTO = new DevExpress.XtraTreeList.TreeList();
            this.typeObjectColumn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.columnId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.parentColumn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.backButton = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.typeObjectLabel = new DevExpress.XtraEditors.LabelControl();
            this.addButton = new DevExpress.XtraEditors.SimpleButton();
            this.changeButton = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl = new DevExpress.XtraEditors.PanelControl();
            this.gridControlTariffs = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.valueColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.metadataIdColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.propNameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.deleteColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryDeleteButton = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).BeginInit();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTariffs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDeleteButton)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(401, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(98, 37);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Тарифы";
            // 
            // treeListTO
            // 
            this.treeListTO.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.typeObjectColumn,
            this.columnId,
            this.parentColumn});
            this.treeListTO.KeyFieldName = "id";
            this.treeListTO.Location = new System.Drawing.Point(10, 10);
            this.treeListTO.Name = "treeListTO";
            this.treeListTO.ParentFieldName = "parent_type";
            this.treeListTO.Size = new System.Drawing.Size(229, 365);
            this.treeListTO.TabIndex = 6;
            this.treeListTO.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeListTO_FocusedNodeChanged);
            // 
            // typeObjectColumn
            // 
            this.typeObjectColumn.Caption = "Тип объекта";
            this.typeObjectColumn.FieldName = "name";
            this.typeObjectColumn.Name = "typeObjectColumn";
            this.typeObjectColumn.Visible = true;
            this.typeObjectColumn.VisibleIndex = 0;
            // 
            // columnId
            // 
            this.columnId.Caption = "treeListColumn1";
            this.columnId.FieldName = "id";
            this.columnId.Name = "columnId";
            // 
            // parentColumn
            // 
            this.parentColumn.Caption = "treeListColumn2";
            this.parentColumn.FieldName = "parent_type";
            this.parentColumn.Name = "parentColumn";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.backButton,
            this.barButtonItem1});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarAppearance.Normal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bar2.BarAppearance.Normal.Options.UseFont = true;
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.backButton)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // backButton
            // 
            this.backButton.Caption = "Назад";
            this.backButton.Id = 0;
            this.backButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("backButton.ImageOptions.Image")));
            this.backButton.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("backButton.ImageOptions.LargeImage")));
            this.backButton.Name = "backButton";
            this.backButton.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.backButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(870, 32);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 477);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(870, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 32);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 445);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(870, 32);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 445);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.typeObjectLabel);
            this.panelControl1.Controls.Add(this.addButton);
            this.panelControl1.Controls.Add(this.changeButton);
            this.panelControl1.Location = new System.Drawing.Point(245, 10);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(613, 50);
            this.panelControl1.TabIndex = 15;
            // 
            // typeObjectLabel
            // 
            this.typeObjectLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeObjectLabel.Appearance.Options.UseFont = true;
            this.typeObjectLabel.Location = new System.Drawing.Point(15, 13);
            this.typeObjectLabel.Name = "typeObjectLabel";
            this.typeObjectLabel.Size = new System.Drawing.Size(121, 24);
            this.typeObjectLabel.TabIndex = 14;
            this.typeObjectLabel.Text = "Тип объекта:";
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Appearance.BorderColor = System.Drawing.Color.Blue;
            this.addButton.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Appearance.Options.UseBorderColor = true;
            this.addButton.Appearance.Options.UseFont = true;
            this.addButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("addButton.ImageOptions.Image")));
            this.addButton.Location = new System.Drawing.Point(352, 5);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(125, 40);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "Добавить";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changeButton.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeButton.Appearance.Options.UseFont = true;
            this.changeButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("changeButton.ImageOptions.Image")));
            this.changeButton.Location = new System.Drawing.Point(483, 5);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(125, 40);
            this.changeButton.TabIndex = 12;
            this.changeButton.Text = "Изменить";
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // panelControl
            // 
            this.panelControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl.Controls.Add(this.gridControlTariffs);
            this.panelControl.Controls.Add(this.panelControl1);
            this.panelControl.Controls.Add(this.treeListTO);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl.Location = new System.Drawing.Point(0, 91);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(870, 386);
            this.panelControl.TabIndex = 21;
            // 
            // gridControlTariffs
            // 
            this.gridControlTariffs.Location = new System.Drawing.Point(245, 66);
            this.gridControlTariffs.MainView = this.gridView1;
            this.gridControlTariffs.MenuManager = this.barManager1;
            this.gridControlTariffs.Name = "gridControlTariffs";
            this.gridControlTariffs.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryDeleteButton});
            this.gridControlTariffs.Size = new System.Drawing.Size(613, 309);
            this.gridControlTariffs.TabIndex = 16;
            this.gridControlTariffs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdColumn,
            this.nameColumn,
            this.valueColumn,
            this.metadataIdColumn,
            this.propNameColumn,
            this.deleteColumn});
            this.gridView1.GridControl = this.gridControlTariffs;
            this.gridView1.Name = "gridView1";
            // 
            // IdColumn
            // 
            this.IdColumn.Caption = "gridColumn1";
            this.IdColumn.FieldName = "id";
            this.IdColumn.MinWidth = 25;
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.Width = 94;
            // 
            // nameColumn
            // 
            this.nameColumn.Caption = "Название";
            this.nameColumn.FieldName = "name";
            this.nameColumn.MinWidth = 25;
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.Visible = true;
            this.nameColumn.VisibleIndex = 1;
            this.nameColumn.Width = 94;
            // 
            // valueColumn
            // 
            this.valueColumn.Caption = "Значение";
            this.valueColumn.FieldName = "value";
            this.valueColumn.MinWidth = 25;
            this.valueColumn.Name = "valueColumn";
            this.valueColumn.Visible = true;
            this.valueColumn.VisibleIndex = 2;
            this.valueColumn.Width = 94;
            // 
            // metadataIdColumn
            // 
            this.metadataIdColumn.Caption = "gridColumn4";
            this.metadataIdColumn.FieldName = "metadataId";
            this.metadataIdColumn.MinWidth = 25;
            this.metadataIdColumn.Name = "metadataIdColumn";
            this.metadataIdColumn.Width = 94;
            // 
            // propNameColumn
            // 
            this.propNameColumn.Caption = "Показатель";
            this.propNameColumn.FieldName = "property_name";
            this.propNameColumn.MinWidth = 25;
            this.propNameColumn.Name = "propNameColumn";
            this.propNameColumn.Visible = true;
            this.propNameColumn.VisibleIndex = 0;
            this.propNameColumn.Width = 94;
            // 
            // deleteColumn
            // 
            this.deleteColumn.Caption = "Удалить";
            this.deleteColumn.ColumnEdit = this.repositoryDeleteButton;
            this.deleteColumn.MinWidth = 25;
            this.deleteColumn.Name = "deleteColumn";
            this.deleteColumn.Visible = true;
            this.deleteColumn.VisibleIndex = 3;
            this.deleteColumn.Width = 94;
            // 
            // repositoryDeleteButton
            // 
            this.repositoryDeleteButton.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.repositoryDeleteButton.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryDeleteButton.Name = "repositoryDeleteButton";
            this.repositoryDeleteButton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryDeleteButton.Click += new System.EventHandler(this.repositoryDeleteButton_Click);
            // 
            // TariffWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 497);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "TariffWindow";
            this.Text = "tariffWindow";
            this.Load += new System.EventHandler(this.TariffWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeListTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).EndInit();
            this.panelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTariffs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDeleteButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraTreeList.TreeList treeListTO;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem backButton;
        private DevExpress.XtraTreeList.Columns.TreeListColumn typeObjectColumn;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl typeObjectLabel;
        private DevExpress.XtraEditors.SimpleButton addButton;
        private DevExpress.XtraEditors.SimpleButton changeButton;
        private DevExpress.XtraEditors.PanelControl panelControl;
        private DevExpress.XtraGrid.GridControl gridControlTariffs;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn IdColumn;
        private DevExpress.XtraGrid.Columns.GridColumn nameColumn;
        private DevExpress.XtraGrid.Columns.GridColumn valueColumn;
        private DevExpress.XtraGrid.Columns.GridColumn metadataIdColumn;
        private DevExpress.XtraGrid.Columns.GridColumn propNameColumn;
        private DevExpress.XtraTreeList.Columns.TreeListColumn columnId;
        private DevExpress.XtraTreeList.Columns.TreeListColumn parentColumn;
        private DevExpress.XtraGrid.Columns.GridColumn deleteColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryDeleteButton;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}