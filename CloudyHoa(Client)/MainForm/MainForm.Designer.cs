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
            this.propButton = new DevExpress.XtraEditors.SimpleButton();
            this.enteringReadingButton = new DevExpress.XtraEditors.SimpleButton();
            this.MDButton = new DevExpress.XtraEditors.SimpleButton();
            this.residentsButton = new DevExpress.XtraEditors.SimpleButton();
            this.paButton = new DevExpress.XtraEditors.SimpleButton();
            this.tariffButton = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.calculationButton = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.historyCalculatingButton = new DevExpress.XtraEditors.SimpleButton();
            this.historyEnteringButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Appearance.Options.UseFont = true;
            this.exitButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("exitButton.ImageOptions.SvgImage")));
            this.exitButton.Location = new System.Drawing.Point(12, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(116, 46);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Выйти";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // objectButton
            // 
            this.objectButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.objectButton.Appearance.Options.UseFont = true;
            this.objectButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("objectButton.ImageOptions.SvgImage")));
            this.objectButton.Location = new System.Drawing.Point(15, 50);
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
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupControl1.AppearanceCaption.Options.UseBackColor = true;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.CaptionImageOptions.SvgImage = global::CloudyHoa_Client_.Properties.Resources.travel_hotel;
            this.groupControl1.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControl1.Controls.Add(this.propButton);
            this.groupControl1.Controls.Add(this.objectButton);
            this.groupControl1.Location = new System.Drawing.Point(25, 10);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(240, 220);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Учет объектов";
            // 
            // propButton
            // 
            this.propButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.propButton.Appearance.Options.UseFont = true;
            this.propButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("propButton.ImageOptions.SvgImage")));
            this.propButton.Location = new System.Drawing.Point(15, 130);
            this.propButton.Name = "propButton";
            this.propButton.Size = new System.Drawing.Size(206, 74);
            this.propButton.TabIndex = 3;
            this.propButton.Text = "Характеристики";
            this.propButton.Click += new System.EventHandler(this.propButton_Click);
            // 
            // enteringReadingButton
            // 
            this.enteringReadingButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enteringReadingButton.Appearance.Options.UseFont = true;
            this.enteringReadingButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("enteringReadingButton.ImageOptions.SvgImage")));
            this.enteringReadingButton.Location = new System.Drawing.Point(15, 50);
            this.enteringReadingButton.Name = "enteringReadingButton";
            this.enteringReadingButton.Size = new System.Drawing.Size(206, 74);
            this.enteringReadingButton.TabIndex = 8;
            this.enteringReadingButton.Text = "Ввод \r\nпоказаний";
            this.enteringReadingButton.Click += new System.EventHandler(this.enteringReadingButton_Click);
            // 
            // MDButton
            // 
            this.MDButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MDButton.Appearance.Options.UseFont = true;
            this.MDButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("MDButton.ImageOptions.SvgImage")));
            this.MDButton.Location = new System.Drawing.Point(15, 130);
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
            this.residentsButton.Location = new System.Drawing.Point(15, 130);
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
            this.paButton.Location = new System.Drawing.Point(15, 50);
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
            this.tariffButton.Location = new System.Drawing.Point(15, 50);
            this.tariffButton.Name = "tariffButton";
            this.tariffButton.Size = new System.Drawing.Size(206, 75);
            this.tariffButton.TabIndex = 4;
            this.tariffButton.Text = "Тарифы";
            this.tariffButton.Click += new System.EventHandler(this.tariffButton_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(210, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(179, 37);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Главное меню";
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.CaptionImageOptions.SvgImage = global::CloudyHoa_Client_.Properties.Resources.calculatenow;
            this.groupControl2.Controls.Add(this.calculationButton);
            this.groupControl2.Controls.Add(this.enteringReadingButton);
            this.groupControl2.Location = new System.Drawing.Point(320, 245);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(240, 220);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "Расчеты";
            // 
            // calculationButton
            // 
            this.calculationButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculationButton.Appearance.Options.UseFont = true;
            this.calculationButton.ImageOptions.Image = global::CloudyHoa_Client_.Properties.Resources.calculatenow_32x32;
            this.calculationButton.Location = new System.Drawing.Point(15, 130);
            this.calculationButton.Name = "calculationButton";
            this.calculationButton.Size = new System.Drawing.Size(205, 73);
            this.calculationButton.TabIndex = 9;
            this.calculationButton.Text = "Расчитать \r\nпоказания";
            this.calculationButton.Click += new System.EventHandler(this.calculationButton_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.CaptionImageOptions.SvgImage = global::CloudyHoa_Client_.Properties.Resources.bo_resume;
            this.groupControl3.Controls.Add(this.residentsButton);
            this.groupControl3.Controls.Add(this.paButton);
            this.groupControl3.Location = new System.Drawing.Point(320, 10);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(240, 220);
            this.groupControl3.TabIndex = 6;
            this.groupControl3.Text = "Абоненты";
            // 
            // groupControl4
            // 
            this.groupControl4.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupControl4.AppearanceCaption.Options.UseFont = true;
            this.groupControl4.CaptionImageOptions.SvgImage = global::CloudyHoa_Client_.Properties.Resources.financial;
            this.groupControl4.Controls.Add(this.MDButton);
            this.groupControl4.Controls.Add(this.tariffButton);
            this.groupControl4.Location = new System.Drawing.Point(25, 245);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(240, 220);
            this.groupControl4.TabIndex = 8;
            this.groupControl4.Text = "Объекты учета";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 84);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(585, 498);
            this.xtraTabControl1.TabIndex = 10;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.groupControl1);
            this.xtraTabPage1.Controls.Add(this.groupControl2);
            this.xtraTabPage1.Controls.Add(this.groupControl4);
            this.xtraTabPage1.Controls.Add(this.groupControl3);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(583, 468);
            this.xtraTabPage1.Text = "Страница 1";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.groupControl5);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(583, 468);
            this.xtraTabPage2.Text = "Страница 2";
            // 
            // groupControl5
            // 
            this.groupControl5.Appearance.BackColor = System.Drawing.Color.Maroon;
            this.groupControl5.Appearance.Options.UseBackColor = true;
            this.groupControl5.AppearanceCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupControl5.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupControl5.AppearanceCaption.Options.UseBackColor = true;
            this.groupControl5.AppearanceCaption.Options.UseFont = true;
            this.groupControl5.CaptionImageOptions.SvgImage = global::CloudyHoa_Client_.Properties.Resources.portrait;
            this.groupControl5.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControl5.Controls.Add(this.historyCalculatingButton);
            this.groupControl5.Controls.Add(this.historyEnteringButton);
            this.groupControl5.Location = new System.Drawing.Point(25, 10);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(240, 220);
            this.groupControl5.TabIndex = 4;
            this.groupControl5.Text = "История";
            // 
            // historyCalculatingButton
            // 
            this.historyCalculatingButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.historyCalculatingButton.Appearance.Options.UseFont = true;
            this.historyCalculatingButton.ImageOptions.SvgImage = global::CloudyHoa_Client_.Properties.Resources.accounting;
            this.historyCalculatingButton.Location = new System.Drawing.Point(15, 130);
            this.historyCalculatingButton.Name = "historyCalculatingButton";
            this.historyCalculatingButton.Size = new System.Drawing.Size(206, 74);
            this.historyCalculatingButton.TabIndex = 3;
            this.historyCalculatingButton.Text = "История \r\nрасчетов";
            this.historyCalculatingButton.Click += new System.EventHandler(this.historyCalculatingButton_Click);
            // 
            // historyEnteringButton
            // 
            this.historyEnteringButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.historyEnteringButton.Appearance.Options.UseFont = true;
            this.historyEnteringButton.ImageOptions.SvgImage = global::CloudyHoa_Client_.Properties.Resources.gaugestylelinearvertical;
            this.historyEnteringButton.Location = new System.Drawing.Point(15, 50);
            this.historyEnteringButton.Name = "historyEnteringButton";
            this.historyEnteringButton.Size = new System.Drawing.Size(206, 74);
            this.historyEnteringButton.TabIndex = 2;
            this.historyEnteringButton.Text = "История \r\nпоказаний";
            this.historyEnteringButton.Click += new System.EventHandler(this.historyEnteringButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 582);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.exitButton);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "MainForm";
            this.Text = "Главное меню";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
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
        private DevExpress.XtraEditors.SimpleButton calculationButton;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.SimpleButton historyCalculatingButton;
        private DevExpress.XtraEditors.SimpleButton historyEnteringButton;
    }
}