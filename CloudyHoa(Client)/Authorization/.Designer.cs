namespace CloudyHoa_Client_
{
    partial class LoginForm
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.rememberCheckBox = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.loginButton = new DevExpress.XtraEditors.SimpleButton();
            this.passwordEdit = new DevExpress.XtraEditors.TextEdit();
            this.loginEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rememberCheckBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(321, 34);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(285, 54);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Облачное ТСЖ";
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl2.Controls.Add(this.rememberCheckBox);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.loginButton);
            this.panelControl2.Controls.Add(this.passwordEdit);
            this.panelControl2.Controls.Add(this.loginEdit);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Location = new System.Drawing.Point(541, 128);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(5);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(400, 482);
            this.panelControl2.TabIndex = 3;
            // 
            // rememberCheckBox
            // 
            this.rememberCheckBox.Location = new System.Drawing.Point(88, 323);
            this.rememberCheckBox.Margin = new System.Windows.Forms.Padding(5);
            this.rememberCheckBox.Name = "rememberCheckBox";
            this.rememberCheckBox.Properties.Caption = "Запомнить";
            this.rememberCheckBox.Size = new System.Drawing.Size(148, 24);
            this.rememberCheckBox.TabIndex = 18;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(178, 218);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(63, 23);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "Пароль:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(178, 113);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 23);
            this.labelControl2.TabIndex = 15;
            this.labelControl2.Text = "Логин:";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(163, 412);
            this.loginButton.Margin = new System.Windows.Forms.Padding(5);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(100, 40);
            this.loginButton.TabIndex = 14;
            this.loginButton.Text = "Войти";
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordEdit
            // 
            this.passwordEdit.Location = new System.Drawing.Point(88, 263);
            this.passwordEdit.Margin = new System.Windows.Forms.Padding(5);
            this.passwordEdit.Name = "passwordEdit";
            this.passwordEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordEdit.Properties.Appearance.Options.UseFont = true;
            this.passwordEdit.Properties.PasswordChar = '*';
            this.passwordEdit.Properties.UseSystemPasswordChar = true;
            this.passwordEdit.Size = new System.Drawing.Size(224, 26);
            this.passwordEdit.TabIndex = 13;
            // 
            // loginEdit
            // 
            this.loginEdit.Location = new System.Drawing.Point(88, 158);
            this.loginEdit.Margin = new System.Windows.Forms.Padding(5);
            this.loginEdit.Name = "loginEdit";
            this.loginEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginEdit.Properties.Appearance.Options.UseFont = true;
            this.loginEdit.Size = new System.Drawing.Size(224, 26);
            this.loginEdit.TabIndex = 12;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(115, 24);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(166, 37);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Авторизация";
            // 
            // panelControl1
            // 
            this.panelControl1.ContentImage = global::CloudyHoa_Client_.Properties.Resources.orig1;
            this.panelControl1.Location = new System.Drawing.Point(15, 128);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(6);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(515, 482);
            this.panelControl1.TabIndex = 2;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 631);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "LoginForm";
            this.Text = "Авторизация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rememberCheckBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton loginButton;
        private DevExpress.XtraEditors.TextEdit passwordEdit;
        private DevExpress.XtraEditors.TextEdit loginEdit;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.CheckEdit rememberCheckBox;
    }
}

