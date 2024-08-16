namespace CloudyHoa_Client_.ReadingExcel
{
    partial class ReadingExcelForm
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
            this.reviewButton = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControlFileName = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxSheets = new System.Windows.Forms.ComboBox();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.saveNameColunmButton = new DevExpress.XtraEditors.SimpleButton();
            this.stackPanel1 = new DevExpress.Utils.Layout.StackPanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // reviewButton
            // 
            this.reviewButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reviewButton.Appearance.Options.UseFont = true;
            this.reviewButton.Location = new System.Drawing.Point(5, 7);
            this.reviewButton.Name = "reviewButton";
            this.reviewButton.Size = new System.Drawing.Size(100, 29);
            this.reviewButton.TabIndex = 1;
            this.reviewButton.Text = "Обзор";
            this.reviewButton.Click += new System.EventHandler(this.reviewButton_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControlFileName);
            this.panelControl1.Controls.Add(this.comboBoxSheets);
            this.panelControl1.Controls.Add(this.saveButton);
            this.panelControl1.Controls.Add(this.reviewButton);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 463);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(800, 41);
            this.panelControl1.TabIndex = 3;
            // 
            // labelControlFileName
            // 
            this.labelControlFileName.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControlFileName.Appearance.Options.UseFont = true;
            this.labelControlFileName.Location = new System.Drawing.Point(115, 11);
            this.labelControlFileName.Name = "labelControlFileName";
            this.labelControlFileName.Size = new System.Drawing.Size(44, 23);
            this.labelControlFileName.TabIndex = 4;
            this.labelControlFileName.Text = "Файл:";
            // 
            // comboBoxSheets
            // 
            this.comboBoxSheets.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSheets.FormattingEnabled = true;
            this.comboBoxSheets.Location = new System.Drawing.Point(291, 5);
            this.comboBoxSheets.Name = "comboBoxSheets";
            this.comboBoxSheets.Size = new System.Drawing.Size(165, 31);
            this.comboBoxSheets.TabIndex = 3;
            this.comboBoxSheets.SelectionChangeCommitted += new System.EventHandler(this.comboBoxSheets_SelectionChangeCommitted);
            // 
            // saveButton
            // 
            this.saveButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Appearance.Options.UseFont = true;
            this.saveButton.Location = new System.Drawing.Point(692, 7);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(103, 29);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Сохранить";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 57);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(800, 406);
            this.panelControl2.TabIndex = 4;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.saveNameColunmButton);
            this.panelControl3.Controls.Add(this.stackPanel1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(2, 1);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(796, 66);
            this.panelControl3.TabIndex = 1;
            // 
            // saveNameColunmButton
            // 
            this.saveNameColunmButton.ImageOptions.Image = global::CloudyHoa_Client_.Properties.Resources.saveall_32x32;
            this.saveNameColunmButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.saveNameColunmButton.Location = new System.Drawing.Point(736, 10);
            this.saveNameColunmButton.Name = "saveNameColunmButton";
            this.saveNameColunmButton.Size = new System.Drawing.Size(50, 50);
            this.saveNameColunmButton.TabIndex = 1;
            this.saveNameColunmButton.Click += new System.EventHandler(this.saveNameColunmButton_Click);
            // 
            // stackPanel1
            // 
            this.stackPanel1.AutoScroll = true;
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.stackPanel1.Location = new System.Drawing.Point(2, 2);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(720, 62);
            this.stackPanel1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(2, 67);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(796, 337);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(254, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(282, 28);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Загрузка данных из файла";
            // 
            // ReadingExcelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "ReadingExcelForm";
            this.Text = "Загрузка данных";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton reviewButton;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControlFileName;
        private System.Windows.Forms.ComboBox comboBoxSheets;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton saveNameColunmButton;
        private DevExpress.Utils.Layout.StackPanel stackPanel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}