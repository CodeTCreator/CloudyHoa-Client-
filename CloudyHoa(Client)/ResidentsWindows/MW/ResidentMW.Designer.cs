namespace CloudyHoa_Client_.ResidentsWindows.MW
{
    partial class ResidentMW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResidentMW));
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.residentForm1 = new CloudyHoa_Client_.General.ResidentForm();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Appearance.Options.UseFont = true;
            this.saveButton.Appearance.Options.UseTextOptions = true;
            this.saveButton.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.saveButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.ImageOptions.Image")));
            this.saveButton.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.saveButton.Location = new System.Drawing.Point(293, 429);
            this.saveButton.Margin = new System.Windows.Forms.Padding(10);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(143, 40);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Сохранить";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(145, 429);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(135, 40);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Очистить";
            // 
            // residentForm1
            // 
            this.residentForm1.Location = new System.Drawing.Point(3, 0);
            this.residentForm1.Name = "residentForm1";
            this.residentForm1.Size = new System.Drawing.Size(444, 423);
            this.residentForm1.TabIndex = 3;
            // 
            // ResidentMW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 478);
            this.Controls.Add(this.residentForm1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.saveButton);
            this.Name = "ResidentMW";
            this.Text = "Данные о жильце";
            this.Load += new System.EventHandler(this.ResidentMW_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private General.ResidentForm residentForm1;
    }
}