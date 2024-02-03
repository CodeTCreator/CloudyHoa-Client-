namespace CloudyHoa_Client_.Authorization
{
    partial class AuthorizationControl
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
            this.passwordEdit = new DevExpress.XtraEditors.TextEdit();
            this.loginEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.passwordEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordEdit
            // 
            this.passwordEdit.Location = new System.Drawing.Point(85, 314);
            this.passwordEdit.Name = "passwordEdit";
            this.passwordEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordEdit.Properties.Appearance.Options.UseFont = true;
            this.passwordEdit.Properties.PasswordChar = '*';
            this.passwordEdit.Properties.UseSystemPasswordChar = true;
            this.passwordEdit.Size = new System.Drawing.Size(200, 26);
            this.passwordEdit.TabIndex = 6;
            // 
            // loginEdit
            // 
            this.loginEdit.Location = new System.Drawing.Point(85, 215);
            this.loginEdit.Name = "loginEdit";
            this.loginEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginEdit.Properties.Appearance.Options.UseFont = true;
            this.loginEdit.Size = new System.Drawing.Size(200, 26);
            this.loginEdit.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(102, 30);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(166, 37);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Авторизация";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(135, 440);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(100, 30);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "Войти";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(159, 186);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 23);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Логин:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(159, 285);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(63, 23);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Пароль:";
            // 
            // AuthorizationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.passwordEdit);
            this.Controls.Add(this.loginEdit);
            this.Controls.Add(this.labelControl2);
            this.Name = "AuthorizationControl";
            this.Size = new System.Drawing.Size(370, 500);
            ((System.ComponentModel.ISupportInitialize)(this.passwordEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit passwordEdit;
        private DevExpress.XtraEditors.TextEdit loginEdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}
