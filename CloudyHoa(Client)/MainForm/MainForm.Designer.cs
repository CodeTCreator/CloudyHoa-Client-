namespace CloudyHoa_Client_.MainForm
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.exitButton = new DevExpress.XtraEditors.SimpleButton();
            this.objectButton = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.enteringReadingButton = new DevExpress.XtraEditors.SimpleButton();
            this.MDButton = new DevExpress.XtraEditors.SimpleButton();
            this.residentsButton = new DevExpress.XtraEditors.SimpleButton();
            this.paButton = new DevExpress.XtraEditors.SimpleButton();
            this.tariffButton = new DevExpress.XtraEditors.SimpleButton();
            this.propButton = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(730, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(58, 24);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Выйти";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // objectButton
            // 
            this.objectButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.objectButton.Appearance.Options.UseFont = true;
            this.objectButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("objectButton.ImageOptions.SvgImage")));
            this.objectButton.Location = new System.Drawing.Point(5, 44);
            this.objectButton.Name = "objectButton";
            this.objectButton.Size = new System.Drawing.Size(206, 74);
            this.objectButton.TabIndex = 2;
            this.objectButton.Text = "Объекты";
            this.objectButton.Click += new System.EventHandler(this.objectButton_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.Maroon;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.AppearanceCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupControl1.AppearanceCaption.Options.UseBackColor = true;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl1.CaptionImageOptions.SvgImage")));
            this.groupControl1.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.enteringReadingButton);
            this.groupControl1.Controls.Add(this.MDButton);
            this.groupControl1.Controls.Add(this.residentsButton);
            this.groupControl1.Controls.Add(this.paButton);
            this.groupControl1.Controls.Add(this.tariffButton);
            this.groupControl1.Controls.Add(this.propButton);
            this.groupControl1.Controls.Add(this.objectButton);
            this.groupControl1.Location = new System.Drawing.Point(22, 73);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(694, 284);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Какая-то группа";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = global::CloudyHoa_Client_.Properties.Resources.calculatenow_32x32;
            this.simpleButton2.Location = new System.Drawing.Point(439, 125);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(205, 73);
            this.simpleButton2.TabIndex = 9;
            this.simpleButton2.Text = "Расчитать";
            // 
            // enteringReadingButton
            // 
            this.enteringReadingButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enteringReadingButton.Appearance.Options.UseFont = true;
            this.enteringReadingButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("enteringReadingButton.ImageOptions.SvgImage")));
            this.enteringReadingButton.Location = new System.Drawing.Point(438, 44);
            this.enteringReadingButton.Name = "enteringReadingButton";
            this.enteringReadingButton.Size = new System.Drawing.Size(206, 74);
            this.enteringReadingButton.TabIndex = 8;
            this.enteringReadingButton.Text = "Ввод \r\nпоказаний";
            // 
            // MDButton
            // 
            this.MDButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MDButton.Appearance.Options.UseFont = true;
            this.MDButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("MDButton.ImageOptions.SvgImage")));
            this.MDButton.Location = new System.Drawing.Point(226, 206);
            this.MDButton.Name = "MDButton";
            this.MDButton.Size = new System.Drawing.Size(206, 73);
            this.MDButton.TabIndex = 7;
            this.MDButton.Text = "Счетчики";
            this.MDButton.Click += new System.EventHandler(this.MDButton_Click);
            // 
            // residentsButton
            // 
            this.residentsButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.residentsButton.Appearance.Options.UseFont = true;
            this.residentsButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("residentsButton.ImageOptions.SvgImage")));
            this.residentsButton.Location = new System.Drawing.Point(226, 125);
            this.residentsButton.Name = "residentsButton";
            this.residentsButton.Size = new System.Drawing.Size(206, 73);
            this.residentsButton.TabIndex = 6;
            this.residentsButton.Text = "Учет жильцов";
            this.residentsButton.Click += new System.EventHandler(this.residentsButton_Click);
            // 
            // paButton
            // 
            this.paButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.paButton.Appearance.Options.UseFont = true;
            this.paButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("paButton.ImageOptions.SvgImage")));
            this.paButton.Location = new System.Drawing.Point(226, 44);
            this.paButton.Name = "paButton";
            this.paButton.Size = new System.Drawing.Size(206, 74);
            this.paButton.TabIndex = 5;
            this.paButton.Text = "Лицевые счета";
            this.paButton.Click += new System.EventHandler(this.paButton_Click);
            // 
            // tariffButton
            // 
            this.tariffButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tariffButton.Appearance.Options.UseFont = true;
            this.tariffButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("tariffButton.ImageOptions.SvgImage")));
            this.tariffButton.Location = new System.Drawing.Point(5, 204);
            this.tariffButton.Name = "tariffButton";
            this.tariffButton.Size = new System.Drawing.Size(206, 75);
            this.tariffButton.TabIndex = 4;
            this.tariffButton.Text = "Тарифы";
            this.tariffButton.Click += new System.EventHandler(this.tariffButton_Click);
            // 
            // propButton
            // 
            this.propButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.propButton.Appearance.Options.UseFont = true;
            this.propButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("propButton.ImageOptions.SvgImage")));
            this.propButton.Location = new System.Drawing.Point(5, 124);
            this.propButton.Name = "propButton";
            this.propButton.Size = new System.Drawing.Size(206, 74);
            this.propButton.TabIndex = 3;
            this.propButton.Text = "Характеристики";
            this.propButton.Click += new System.EventHandler(this.propButton_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(312, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(179, 37);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Главное меню";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.exitButton);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "MainForm";
            this.Text = "Главное меню";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton exitButton;
        private DevExpress.XtraEditors.SimpleButton objectButton;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton propButton;
        private DevExpress.XtraEditors.SimpleButton tariffButton;
        private DevExpress.XtraEditors.SimpleButton paButton;
        private DevExpress.XtraEditors.SimpleButton residentsButton;
        private DevExpress.XtraEditors.SimpleButton MDButton;
        private DevExpress.XtraEditors.SimpleButton enteringReadingButton;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}