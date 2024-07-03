namespace CloudyHoa_Client_.ExpenseWindows.CategoryMW
{
    partial class CategoryMW
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
            this.labelControlName = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit = new DevExpress.XtraEditors.TextEdit();
            this.universalButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControlName
            // 
            this.labelControlName.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControlName.Appearance.Options.UseFont = true;
            this.labelControlName.Location = new System.Drawing.Point(67, 12);
            this.labelControlName.Name = "labelControlName";
            this.labelControlName.Size = new System.Drawing.Size(187, 28);
            this.labelControlName.TabIndex = 0;
            this.labelControlName.Text = "Создание категории";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(11, 79);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(80, 23);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Название:";
            // 
            // textEdit
            // 
            this.textEdit.Location = new System.Drawing.Point(97, 75);
            this.textEdit.Name = "textEdit";
            this.textEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textEdit.Properties.Appearance.Options.UseFont = true;
            this.textEdit.Size = new System.Drawing.Size(209, 30);
            this.textEdit.TabIndex = 2;
            this.textEdit.EditValueChanged += new System.EventHandler(this.textEdit_EditValueChanged);
            // 
            // universalButton
            // 
            this.universalButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.universalButton.Appearance.Options.UseFont = true;
            this.universalButton.Location = new System.Drawing.Point(212, 130);
            this.universalButton.Name = "universalButton";
            this.universalButton.Size = new System.Drawing.Size(94, 31);
            this.universalButton.TabIndex = 3;
            this.universalButton.Text = "Сохранить";
            // 
            // CategoryMW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 173);
            this.Controls.Add(this.universalButton);
            this.Controls.Add(this.textEdit);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControlName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "CategoryMW";
            this.Text = "Категория";
            this.Load += new System.EventHandler(this.CategoryMW_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControlName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEdit;
        private DevExpress.XtraEditors.SimpleButton universalButton;
    }
}