namespace CloudyHoa_Client_.General
{
    partial class ResidentsGridControl
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
            this.gridControlResidents = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.columnId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnFIO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnRegistered = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.columnRD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnResidence = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnCID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnOwner = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnObjectId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnOS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnNumerator = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnDenominator = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlResidents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlResidents
            // 
            this.gridControlResidents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlResidents.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridControlResidents.Location = new System.Drawing.Point(0, 0);
            this.gridControlResidents.MainView = this.gridView1;
            this.gridControlResidents.Name = "gridControlResidents";
            this.gridControlResidents.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControlResidents.Size = new System.Drawing.Size(933, 412);
            this.gridControlResidents.TabIndex = 2;
            this.gridControlResidents.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControlResidents.Click += new System.EventHandler(this.gridControlResidents_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.columnId,
            this.columnFIO,
            this.columnRegistered,
            this.columnRD,
            this.columnResidence,
            this.columnCID,
            this.columnOwner,
            this.columnObjectId,
            this.columnOS,
            this.columnNumerator,
            this.columnDenominator});
            this.gridView1.GridControl = this.gridControlResidents;
            this.gridView1.GroupRowHeight = 20;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowHeight = 20;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // columnId
            // 
            this.columnId.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.columnId.AppearanceHeader.Options.UseFont = true;
            this.columnId.Caption = "ID жильца";
            this.columnId.FieldName = "id";
            this.columnId.MinWidth = 25;
            this.columnId.Name = "columnId";
            this.columnId.OptionsColumn.ReadOnly = true;
            this.columnId.Width = 94;
            // 
            // columnFIO
            // 
            this.columnFIO.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.columnFIO.AppearanceCell.Options.UseFont = true;
            this.columnFIO.AppearanceCell.Options.UseTextOptions = true;
            this.columnFIO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.columnFIO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.columnFIO.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.columnFIO.AppearanceHeader.Options.UseFont = true;
            this.columnFIO.AppearanceHeader.Options.UseTextOptions = true;
            this.columnFIO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.columnFIO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.columnFIO.Caption = "ФИО";
            this.columnFIO.FieldName = "full_name";
            this.columnFIO.MinWidth = 25;
            this.columnFIO.Name = "columnFIO";
            this.columnFIO.Visible = true;
            this.columnFIO.VisibleIndex = 0;
            this.columnFIO.Width = 142;
            // 
            // columnRegistered
            // 
            this.columnRegistered.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.columnRegistered.AppearanceCell.Options.UseFont = true;
            this.columnRegistered.AppearanceCell.Options.UseTextOptions = true;
            this.columnRegistered.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.columnRegistered.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.columnRegistered.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.columnRegistered.AppearanceHeader.Options.UseFont = true;
            this.columnRegistered.AppearanceHeader.Options.UseTextOptions = true;
            this.columnRegistered.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.columnRegistered.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.columnRegistered.Caption = "Зарегистрирован";
            this.columnRegistered.ColumnEdit = this.repositoryItemCheckEdit1;
            this.columnRegistered.FieldName = "registered";
            this.columnRegistered.MinWidth = 25;
            this.columnRegistered.Name = "columnRegistered";
            this.columnRegistered.Visible = true;
            this.columnRegistered.VisibleIndex = 1;
            this.columnRegistered.Width = 124;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.CheckBox;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // columnRD
            // 
            this.columnRD.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.columnRD.AppearanceCell.Options.UseFont = true;
            this.columnRD.AppearanceCell.Options.UseTextOptions = true;
            this.columnRD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.columnRD.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.columnRD.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.columnRD.AppearanceHeader.Options.UseFont = true;
            this.columnRD.AppearanceHeader.Options.UseTextOptions = true;
            this.columnRD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.columnRD.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.columnRD.Caption = "Дата регистрации";
            this.columnRD.FieldName = "registration_date";
            this.columnRD.MinWidth = 25;
            this.columnRD.Name = "columnRD";
            this.columnRD.Visible = true;
            this.columnRD.VisibleIndex = 2;
            this.columnRD.Width = 121;
            // 
            // columnResidence
            // 
            this.columnResidence.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.columnResidence.AppearanceCell.Options.UseFont = true;
            this.columnResidence.AppearanceCell.Options.UseTextOptions = true;
            this.columnResidence.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.columnResidence.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.columnResidence.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.columnResidence.AppearanceHeader.Options.UseFont = true;
            this.columnResidence.AppearanceHeader.Options.UseTextOptions = true;
            this.columnResidence.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.columnResidence.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.columnResidence.Caption = "Проживающий";
            this.columnResidence.FieldName = "residence";
            this.columnResidence.MinWidth = 25;
            this.columnResidence.Name = "columnResidence";
            this.columnResidence.Visible = true;
            this.columnResidence.VisibleIndex = 3;
            this.columnResidence.Width = 148;
            // 
            // columnCID
            // 
            this.columnCID.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.columnCID.AppearanceCell.Options.UseFont = true;
            this.columnCID.AppearanceCell.Options.UseTextOptions = true;
            this.columnCID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.columnCID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.columnCID.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.columnCID.AppearanceHeader.Options.UseFont = true;
            this.columnCID.AppearanceHeader.Options.UseTextOptions = true;
            this.columnCID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.columnCID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.columnCID.Caption = "Дата заселения";
            this.columnCID.FieldName = "check_in_date";
            this.columnCID.MinWidth = 25;
            this.columnCID.Name = "columnCID";
            this.columnCID.Visible = true;
            this.columnCID.VisibleIndex = 4;
            this.columnCID.Width = 112;
            // 
            // columnOwner
            // 
            this.columnOwner.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.columnOwner.AppearanceCell.Options.UseFont = true;
            this.columnOwner.AppearanceCell.Options.UseTextOptions = true;
            this.columnOwner.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.columnOwner.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.columnOwner.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.columnOwner.AppearanceHeader.Options.UseFont = true;
            this.columnOwner.AppearanceHeader.Options.UseTextOptions = true;
            this.columnOwner.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.columnOwner.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.columnOwner.Caption = "Собственник";
            this.columnOwner.ColumnEdit = this.repositoryItemCheckEdit1;
            this.columnOwner.FieldName = "owner";
            this.columnOwner.MinWidth = 25;
            this.columnOwner.Name = "columnOwner";
            this.columnOwner.Visible = true;
            this.columnOwner.VisibleIndex = 5;
            this.columnOwner.Width = 112;
            // 
            // columnObjectId
            // 
            this.columnObjectId.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.columnObjectId.AppearanceCell.Options.UseFont = true;
            this.columnObjectId.AppearanceCell.Options.UseTextOptions = true;
            this.columnObjectId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.columnObjectId.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.columnObjectId.Caption = "ID объекта";
            this.columnObjectId.FieldName = "object_id";
            this.columnObjectId.MinWidth = 25;
            this.columnObjectId.Name = "columnObjectId";
            this.columnObjectId.Width = 94;
            // 
            // columnOS
            // 
            this.columnOS.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.columnOS.AppearanceCell.Options.UseFont = true;
            this.columnOS.AppearanceCell.Options.UseTextOptions = true;
            this.columnOS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.columnOS.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.columnOS.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.columnOS.AppearanceHeader.Options.UseFont = true;
            this.columnOS.AppearanceHeader.Options.UseTextOptions = true;
            this.columnOS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.columnOS.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.columnOS.Caption = "Доля владения";
            this.columnOS.FieldName = "columnOS";
            this.columnOS.MinWidth = 25;
            this.columnOS.Name = "columnOS";
            this.columnOS.UnboundDataType = typeof(string);
            this.columnOS.UnboundExpression = "Iif([owners_share_numerator] <> null And [owners_share_denominator] <> null, Conc" +
    "at([owners_share_numerator], \'/\', [owners_share_denominator]), \'\')";
            this.columnOS.Visible = true;
            this.columnOS.VisibleIndex = 6;
            this.columnOS.Width = 144;
            // 
            // columnNumerator
            // 
            this.columnNumerator.AppearanceCell.Options.UseTextOptions = true;
            this.columnNumerator.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.columnNumerator.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.columnNumerator.Caption = "Числитель";
            this.columnNumerator.FieldName = "owners_share_numerator";
            this.columnNumerator.MinWidth = 25;
            this.columnNumerator.Name = "columnNumerator";
            this.columnNumerator.Width = 94;
            // 
            // columnDenominator
            // 
            this.columnDenominator.AppearanceCell.Options.UseTextOptions = true;
            this.columnDenominator.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.columnDenominator.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.columnDenominator.Caption = "Знаменатель";
            this.columnDenominator.FieldName = "owners_share_denominator";
            this.columnDenominator.MinWidth = 25;
            this.columnDenominator.Name = "columnDenominator";
            this.columnDenominator.Width = 94;
            // 
            // ResidentsGridControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlResidents);
            this.Name = "ResidentsGridControl";
            this.Size = new System.Drawing.Size(933, 412);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlResidents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlResidents;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn columnId;
        private DevExpress.XtraGrid.Columns.GridColumn columnFIO;
        private DevExpress.XtraGrid.Columns.GridColumn columnRegistered;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn columnRD;
        private DevExpress.XtraGrid.Columns.GridColumn columnResidence;
        private DevExpress.XtraGrid.Columns.GridColumn columnCID;
        private DevExpress.XtraGrid.Columns.GridColumn columnOwner;
        private DevExpress.XtraGrid.Columns.GridColumn columnObjectId;
        private DevExpress.XtraGrid.Columns.GridColumn columnOS;
        private DevExpress.XtraGrid.Columns.GridColumn columnNumerator;
        private DevExpress.XtraGrid.Columns.GridColumn columnDenominator;
    }
}
