namespace CloudyHoa_Client_.MDWindows.MW
{
    partial class MDMW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDMW));
            this.dateEditInstallation = new DevExpress.XtraEditors.DateEdit();
            this.textEditMDNumber = new DevExpress.XtraEditors.TextEdit();
            this.dateEditVerification = new DevExpress.XtraEditors.DateEdit();
            this.labelName = new DevExpress.XtraEditors.LabelControl();
            this.labelOwner = new DevExpress.XtraEditors.LabelControl();
            this.labelCID = new DevExpress.XtraEditors.LabelControl();
            this.labelDR = new DevExpress.XtraEditors.LabelControl();
            this.labelFIO = new DevExpress.XtraEditors.LabelControl();
            this.labelObjectName = new DevExpress.XtraEditors.LabelControl();
            this.labelControlPA = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxService = new System.Windows.Forms.ComboBox();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditInstallation.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditInstallation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMDNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditVerification.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditVerification.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dateEditInstallation
            // 
            this.dateEditInstallation.EditValue = null;
            this.dateEditInstallation.Location = new System.Drawing.Point(192, 205);
            this.dateEditInstallation.Name = "dateEditInstallation";
            this.dateEditInstallation.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateEditInstallation.Properties.Appearance.Options.UseFont = true;
            this.dateEditInstallation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditInstallation.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditInstallation.Size = new System.Drawing.Size(222, 30);
            this.dateEditInstallation.TabIndex = 43;
            this.dateEditInstallation.EditValueChanged += new System.EventHandler(this.dateEditInstallation_EditValueChanged);
            // 
            // textEditMDNumber
            // 
            this.textEditMDNumber.Location = new System.Drawing.Point(192, 158);
            this.textEditMDNumber.Name = "textEditMDNumber";
            this.textEditMDNumber.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditMDNumber.Properties.Appearance.Options.UseFont = true;
            this.textEditMDNumber.Size = new System.Drawing.Size(222, 30);
            this.textEditMDNumber.TabIndex = 39;
            this.textEditMDNumber.EditValueChanged += new System.EventHandler(this.textEditMDNumber_EditValueChanged);
            // 
            // dateEditVerification
            // 
            this.dateEditVerification.EditValue = null;
            this.dateEditVerification.Location = new System.Drawing.Point(192, 256);
            this.dateEditVerification.Name = "dateEditVerification";
            this.dateEditVerification.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateEditVerification.Properties.Appearance.Options.UseFont = true;
            this.dateEditVerification.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditVerification.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditVerification.Size = new System.Drawing.Size(222, 30);
            this.dateEditVerification.TabIndex = 36;
            this.dateEditVerification.EditValueChanged += new System.EventHandler(this.dateEditVerification_EditValueChanged);
            // 
            // labelName
            // 
            this.labelName.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Appearance.Options.UseFont = true;
            this.labelName.Location = new System.Drawing.Point(111, 12);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(221, 28);
            this.labelName.TabIndex = 35;
            this.labelName.Text = "Ввод данных о счетчике";
            // 
            // labelOwner
            // 
            this.labelOwner.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOwner.Appearance.Options.UseFont = true;
            this.labelOwner.Location = new System.Drawing.Point(38, 307);
            this.labelOwner.Name = "labelOwner";
            this.labelOwner.Size = new System.Drawing.Size(63, 28);
            this.labelOwner.TabIndex = 34;
            this.labelOwner.Text = "Услуга:";
            // 
            // labelCID
            // 
            this.labelCID.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCID.Appearance.Options.UseFont = true;
            this.labelCID.Location = new System.Drawing.Point(12, 258);
            this.labelCID.Name = "labelCID";
            this.labelCID.Size = new System.Drawing.Size(130, 28);
            this.labelCID.TabIndex = 33;
            this.labelCID.Text = "Дата поверки:";
            // 
            // labelDR
            // 
            this.labelDR.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDR.Appearance.Options.UseFont = true;
            this.labelDR.Location = new System.Drawing.Point(12, 207);
            this.labelDR.Name = "labelDR";
            this.labelDR.Size = new System.Drawing.Size(145, 28);
            this.labelDR.TabIndex = 32;
            this.labelDR.Text = "Дата установки:";
            // 
            // labelFIO
            // 
            this.labelFIO.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFIO.Appearance.Options.UseFont = true;
            this.labelFIO.Location = new System.Drawing.Point(12, 156);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(152, 28);
            this.labelFIO.TabIndex = 31;
            this.labelFIO.Text = "Номер счетчика:";
            // 
            // labelObjectName
            // 
            this.labelObjectName.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelObjectName.Appearance.Options.UseFont = true;
            this.labelObjectName.Location = new System.Drawing.Point(12, 58);
            this.labelObjectName.Name = "labelObjectName";
            this.labelObjectName.Size = new System.Drawing.Size(71, 28);
            this.labelObjectName.TabIndex = 30;
            this.labelObjectName.Text = "Объект:";
            // 
            // labelControlPA
            // 
            this.labelControlPA.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControlPA.Appearance.Options.UseFont = true;
            this.labelControlPA.Location = new System.Drawing.Point(12, 101);
            this.labelControlPA.Name = "labelControlPA";
            this.labelControlPA.Size = new System.Drawing.Size(152, 28);
            this.labelControlPA.TabIndex = 45;
            this.labelControlPA.Text = "Лицевой счет №";
            // 
            // comboBoxService
            // 
            this.comboBoxService.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxService.FormattingEnabled = true;
            this.comboBoxService.Location = new System.Drawing.Point(192, 304);
            this.comboBoxService.Name = "comboBoxService";
            this.comboBoxService.Size = new System.Drawing.Size(222, 31);
            this.comboBoxService.TabIndex = 46;
            this.comboBoxService.SelectionChangeCommitted += new System.EventHandler(this.comboBoxService_SelectionChangeCommitted);
            // 
            // saveButton
            // 
            this.saveButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Appearance.Options.UseFont = true;
            this.saveButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.ImageOptions.Image")));
            this.saveButton.Location = new System.Drawing.Point(282, 369);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(132, 40);
            this.saveButton.TabIndex = 47;
            this.saveButton.Text = "Сохранить";
            // 
            // MDMW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 421);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.comboBoxService);
            this.Controls.Add(this.labelControlPA);
            this.Controls.Add(this.dateEditInstallation);
            this.Controls.Add(this.textEditMDNumber);
            this.Controls.Add(this.dateEditVerification);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelOwner);
            this.Controls.Add(this.labelCID);
            this.Controls.Add(this.labelDR);
            this.Controls.Add(this.labelFIO);
            this.Controls.Add(this.labelObjectName);
            this.Name = "MDMW";
            this.Text = "Счетчик";
            this.Load += new System.EventHandler(this.MDMW_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dateEditInstallation.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditInstallation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMDNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditVerification.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditVerification.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.DateEdit dateEditInstallation;
        private DevExpress.XtraEditors.TextEdit textEditMDNumber;
        private DevExpress.XtraEditors.DateEdit dateEditVerification;
        private DevExpress.XtraEditors.LabelControl labelName;
        private DevExpress.XtraEditors.LabelControl labelOwner;
        private DevExpress.XtraEditors.LabelControl labelCID;
        private DevExpress.XtraEditors.LabelControl labelDR;
        private DevExpress.XtraEditors.LabelControl labelFIO;
        private DevExpress.XtraEditors.LabelControl labelObjectName;
        private DevExpress.XtraEditors.LabelControl labelControlPA;
        private System.Windows.Forms.ComboBox comboBoxService;
        private DevExpress.XtraEditors.SimpleButton saveButton;
    }
}