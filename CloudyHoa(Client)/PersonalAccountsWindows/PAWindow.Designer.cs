namespace CloudyHoa_Client_.PersonalAccountsWindows
{
    partial class PAWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PAWindow));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControlPA = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnRegistered = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnLives = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnOwnerId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnAccount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnObjectId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.treeListControl1 = new CloudyHoa_Client_.General.TreeListControl();
            this.panelControl = new DevExpress.XtraEditors.PanelControl();
            this.deleteAccountButton = new DevExpress.XtraEditors.SimpleButton();
            this.editAccountButton = new DevExpress.XtraEditors.SimpleButton();
            this.addAccountButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).BeginInit();
            this.panelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(426, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(251, 31);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Лицевые счета системы";
            // 
            // gridControlPA
            // 
            this.gridControlPA.Location = new System.Drawing.Point(468, 84);
            this.gridControlPA.MainView = this.gridView1;
            this.gridControlPA.Name = "gridControlPA";
            this.gridControlPA.Size = new System.Drawing.Size(560, 454);
            this.gridControlPA.TabIndex = 1;
            this.gridControlPA.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControlPA.Click += new System.EventHandler(this.gridControlPA_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnId,
            this.gridColumnRegistered,
            this.gridColumnLives,
            this.gridColumnOwnerId,
            this.gridColumnAccount,
            this.gridColumnObjectId,
            this.gridColumnFullName});
            this.gridView1.GridControl = this.gridControlPA;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumnId
            // 
            this.gridColumnId.Caption = "Id";
            this.gridColumnId.FieldName = "id";
            this.gridColumnId.MinWidth = 25;
            this.gridColumnId.Name = "gridColumnId";
            this.gridColumnId.Width = 94;
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
            // treeListControl1
            // 
            this.treeListControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeListControl1.Location = new System.Drawing.Point(6, 6);
            this.treeListControl1.Margin = new System.Windows.Forms.Padding(4);
            this.treeListControl1.Name = "treeListControl1";
            this.treeListControl1.Size = new System.Drawing.Size(455, 532);
            this.treeListControl1.TabIndex = 2;
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.deleteAccountButton);
            this.panelControl.Controls.Add(this.editAccountButton);
            this.panelControl.Controls.Add(this.addAccountButton);
            this.panelControl.Controls.Add(this.treeListControl1);
            this.panelControl.Controls.Add(this.gridControlPA);
            this.panelControl.Location = new System.Drawing.Point(12, 84);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1033, 544);
            this.panelControl.TabIndex = 3;
            // 
            // deleteAccountButton
            // 
            this.deleteAccountButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteAccountButton.Appearance.Options.UseFont = true;
            this.deleteAccountButton.Enabled = false;
            this.deleteAccountButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("deleteAccountButton.ImageOptions.Image")));
            this.deleteAccountButton.Location = new System.Drawing.Point(762, 34);
            this.deleteAccountButton.Name = "deleteAccountButton";
            this.deleteAccountButton.Size = new System.Drawing.Size(135, 44);
            this.deleteAccountButton.TabIndex = 6;
            this.deleteAccountButton.Text = "Удалить";
            this.deleteAccountButton.Click += new System.EventHandler(this.deleteAccountButton_Click);
            // 
            // editAccountButton
            // 
            this.editAccountButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editAccountButton.Appearance.Options.UseFont = true;
            this.editAccountButton.Enabled = false;
            this.editAccountButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("editAccountButton.ImageOptions.Image")));
            this.editAccountButton.Location = new System.Drawing.Point(616, 34);
            this.editAccountButton.Name = "editAccountButton";
            this.editAccountButton.Size = new System.Drawing.Size(135, 44);
            this.editAccountButton.TabIndex = 5;
            this.editAccountButton.Text = "Изменить";
            this.editAccountButton.Click += new System.EventHandler(this.editAccountButton_Click);
            // 
            // addAccountButton
            // 
            this.addAccountButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addAccountButton.Appearance.Options.UseFont = true;
            this.addAccountButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("addAccountButton.ImageOptions.Image")));
            this.addAccountButton.Location = new System.Drawing.Point(470, 34);
            this.addAccountButton.Name = "addAccountButton";
            this.addAccountButton.Size = new System.Drawing.Size(135, 44);
            this.addAccountButton.TabIndex = 4;
            this.addAccountButton.Text = "Добавить";
            this.addAccountButton.Click += new System.EventHandler(this.addAccountButton_Click);
            // 
            // PAWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 640);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.labelControl1);
            this.Name = "PAWindow";
            this.Text = "Лицевые счета";
            this.Load += new System.EventHandler(this.PAWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControlPA;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private General.TreeListControl treeListControl1;
        private DevExpress.XtraEditors.PanelControl panelControl;
        private DevExpress.XtraEditors.SimpleButton deleteAccountButton;
        private DevExpress.XtraEditors.SimpleButton editAccountButton;
        private DevExpress.XtraEditors.SimpleButton addAccountButton;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnRegistered;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnLives;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnOwnerId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnAccount;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnObjectId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnFullName;
    }
}