namespace CloudyHoa_Client_.General
{
    partial class ResidentForm
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
            this.panelControl = new DevExpress.XtraEditors.PanelControl();
            this.checkOwner = new DevExpress.XtraEditors.CheckEdit();
            this.dateEditRegistration = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEditFIO = new DevExpress.XtraEditors.TextEdit();
            this.checkLives = new DevExpress.XtraEditors.CheckEdit();
            this.checkReg = new DevExpress.XtraEditors.CheckEdit();
            this.dateEditCheckIn = new DevExpress.XtraEditors.DateEdit();
            this.labelName = new DevExpress.XtraEditors.LabelControl();
            this.labelOwner = new DevExpress.XtraEditors.LabelControl();
            this.labelCID = new DevExpress.XtraEditors.LabelControl();
            this.labelDR = new DevExpress.XtraEditors.LabelControl();
            this.labelFIO = new DevExpress.XtraEditors.LabelControl();
            this.labelObjectName = new DevExpress.XtraEditors.LabelControl();
            this.textEditNumerator = new DevExpress.XtraEditors.SpinEdit();
            this.textEditDenominator = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).BeginInit();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkOwner.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditRegistration.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditRegistration.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFIO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkLives.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkReg.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditCheckIn.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditCheckIn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNumerator.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDenominator.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.checkOwner);
            this.panelControl.Controls.Add(this.dateEditRegistration);
            this.panelControl.Controls.Add(this.labelControl1);
            this.panelControl.Controls.Add(this.textEditFIO);
            this.panelControl.Controls.Add(this.checkLives);
            this.panelControl.Controls.Add(this.checkReg);
            this.panelControl.Controls.Add(this.dateEditCheckIn);
            this.panelControl.Controls.Add(this.labelName);
            this.panelControl.Controls.Add(this.labelOwner);
            this.panelControl.Controls.Add(this.labelCID);
            this.panelControl.Controls.Add(this.labelDR);
            this.panelControl.Controls.Add(this.labelFIO);
            this.panelControl.Controls.Add(this.labelObjectName);
            this.panelControl.Controls.Add(this.textEditNumerator);
            this.panelControl.Controls.Add(this.textEditDenominator);
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(444, 423);
            this.panelControl.TabIndex = 0;
            // 
            // checkOwner
            // 
            this.checkOwner.Location = new System.Drawing.Point(21, 333);
            this.checkOwner.Name = "checkOwner";
            this.checkOwner.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkOwner.Properties.Appearance.Options.UseFont = true;
            this.checkOwner.Properties.Caption = "Владелец";
            this.checkOwner.Size = new System.Drawing.Size(209, 32);
            this.checkOwner.TabIndex = 29;
            this.checkOwner.CheckedChanged += new System.EventHandler(this.checkEditOwner_CheckedChanged);
            // 
            // dateEditRegistration
            // 
            this.dateEditRegistration.EditValue = null;
            this.dateEditRegistration.Enabled = false;
            this.dateEditRegistration.Location = new System.Drawing.Point(215, 237);
            this.dateEditRegistration.Name = "dateEditRegistration";
            this.dateEditRegistration.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateEditRegistration.Properties.Appearance.Options.UseFont = true;
            this.dateEditRegistration.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditRegistration.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditRegistration.Size = new System.Drawing.Size(208, 30);
            this.dateEditRegistration.TabIndex = 28;
            this.dateEditRegistration.EditValueChanged += new System.EventHandler(this.dateEditRegistration_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(266, 375);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(11, 37);
            this.labelControl1.TabIndex = 27;
            this.labelControl1.Text = "/";
            // 
            // textEditFIO
            // 
            this.textEditFIO.Location = new System.Drawing.Point(104, 146);
            this.textEditFIO.Name = "textEditFIO";
            this.textEditFIO.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditFIO.Properties.Appearance.Options.UseFont = true;
            this.textEditFIO.Size = new System.Drawing.Size(319, 30);
            this.textEditFIO.TabIndex = 24;
            this.textEditFIO.EditValueChanged += new System.EventHandler(this.textEditFIO_EditValueChanged);
            // 
            // checkLives
            // 
            this.checkLives.Location = new System.Drawing.Point(236, 190);
            this.checkLives.Name = "checkLives";
            this.checkLives.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkLives.Properties.Appearance.Options.UseFont = true;
            this.checkLives.Properties.Caption = "Проживающий";
            this.checkLives.Size = new System.Drawing.Size(187, 32);
            this.checkLives.TabIndex = 23;
            this.checkLives.CheckedChanged += new System.EventHandler(this.checkLives_CheckedChanged);
            // 
            // checkReg
            // 
            this.checkReg.Location = new System.Drawing.Point(21, 190);
            this.checkReg.Name = "checkReg";
            this.checkReg.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkReg.Properties.Appearance.Options.UseFont = true;
            this.checkReg.Properties.Caption = "Зарегистрирован";
            this.checkReg.Size = new System.Drawing.Size(209, 32);
            this.checkReg.TabIndex = 22;
            this.checkReg.CheckedChanged += new System.EventHandler(this.checkReg_CheckedChanged);
            // 
            // dateEditCheckIn
            // 
            this.dateEditCheckIn.EditValue = null;
            this.dateEditCheckIn.Enabled = false;
            this.dateEditCheckIn.Location = new System.Drawing.Point(215, 288);
            this.dateEditCheckIn.Name = "dateEditCheckIn";
            this.dateEditCheckIn.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateEditCheckIn.Properties.Appearance.Options.UseFont = true;
            this.dateEditCheckIn.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditCheckIn.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditCheckIn.Size = new System.Drawing.Size(208, 30);
            this.dateEditCheckIn.TabIndex = 20;
            this.dateEditCheckIn.EditValueChanged += new System.EventHandler(this.dateEditCheckIn_EditValueChanged);
            // 
            // labelName
            // 
            this.labelName.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Appearance.Options.UseFont = true;
            this.labelName.Location = new System.Drawing.Point(78, 18);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(277, 28);
            this.labelName.TabIndex = 19;
            this.labelName.Text = "Ввод данных о проживающих";
            // 
            // labelOwner
            // 
            this.labelOwner.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOwner.Appearance.Options.UseFont = true;
            this.labelOwner.Location = new System.Drawing.Point(21, 380);
            this.labelOwner.Name = "labelOwner";
            this.labelOwner.Size = new System.Drawing.Size(143, 28);
            this.labelOwner.TabIndex = 18;
            this.labelOwner.Text = "Доля владения:";
            // 
            // labelCID
            // 
            this.labelCID.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCID.Appearance.Options.UseFont = true;
            this.labelCID.Location = new System.Drawing.Point(21, 290);
            this.labelCID.Name = "labelCID";
            this.labelCID.Size = new System.Drawing.Size(144, 28);
            this.labelCID.TabIndex = 17;
            this.labelCID.Text = "Дата заселения:";
            // 
            // labelDR
            // 
            this.labelDR.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDR.Appearance.Options.UseFont = true;
            this.labelDR.Location = new System.Drawing.Point(21, 239);
            this.labelDR.Name = "labelDR";
            this.labelDR.Size = new System.Drawing.Size(168, 28);
            this.labelDR.TabIndex = 16;
            this.labelDR.Text = "Дата регистрации:";
            // 
            // labelFIO
            // 
            this.labelFIO.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFIO.Appearance.Options.UseFont = true;
            this.labelFIO.Location = new System.Drawing.Point(21, 144);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(49, 28);
            this.labelFIO.TabIndex = 15;
            this.labelFIO.Text = "ФИО:";
            // 
            // labelObjectName
            // 
            this.labelObjectName.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelObjectName.Appearance.Options.UseFont = true;
            this.labelObjectName.Location = new System.Drawing.Point(21, 86);
            this.labelObjectName.Name = "labelObjectName";
            this.labelObjectName.Size = new System.Drawing.Size(71, 28);
            this.labelObjectName.TabIndex = 14;
            this.labelObjectName.Text = "Объект:";
            // 
            // textEditNumerator
            // 
            this.textEditNumerator.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.textEditNumerator.Enabled = false;
            this.textEditNumerator.Location = new System.Drawing.Point(215, 382);
            this.textEditNumerator.Name = "textEditNumerator";
            this.textEditNumerator.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textEditNumerator.Properties.Appearance.Options.UseFont = true;
            this.textEditNumerator.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEditNumerator.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEditNumerator.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.textEditNumerator.Properties.IsFloatValue = false;
            this.textEditNumerator.Properties.MaskSettings.Set("mask", "N00");
            this.textEditNumerator.Properties.MaxValue = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.textEditNumerator.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.textEditNumerator.Size = new System.Drawing.Size(45, 30);
            this.textEditNumerator.TabIndex = 25;
            this.textEditNumerator.ValueChanged += new System.EventHandler(this.textEditNumerator_ValueChanged);
            // 
            // textEditDenominator
            // 
            this.textEditDenominator.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.textEditDenominator.Enabled = false;
            this.textEditDenominator.Location = new System.Drawing.Point(283, 382);
            this.textEditDenominator.Name = "textEditDenominator";
            this.textEditDenominator.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textEditDenominator.Properties.Appearance.Options.UseFont = true;
            this.textEditDenominator.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEditDenominator.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.textEditDenominator.Properties.MaxValue = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.textEditDenominator.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.textEditDenominator.Size = new System.Drawing.Size(45, 30);
            this.textEditDenominator.TabIndex = 26;
            this.textEditDenominator.ValueChanged += new System.EventHandler(this.textEditDenominator_ValueChanged);
            // 
            // ResidentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl);
            this.Name = "ResidentForm";
            this.Size = new System.Drawing.Size(444, 423);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkOwner.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditRegistration.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditRegistration.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFIO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkLives.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkReg.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditCheckIn.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditCheckIn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNumerator.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDenominator.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEditFIO;
        private DevExpress.XtraEditors.CheckEdit checkLives;
        private DevExpress.XtraEditors.CheckEdit checkReg;
        private DevExpress.XtraEditors.DateEdit dateEditCheckIn;
        private DevExpress.XtraEditors.LabelControl labelName;
        private DevExpress.XtraEditors.LabelControl labelOwner;
        private DevExpress.XtraEditors.LabelControl labelCID;
        private DevExpress.XtraEditors.LabelControl labelDR;
        private DevExpress.XtraEditors.LabelControl labelFIO;
        private DevExpress.XtraEditors.LabelControl labelObjectName;
        private DevExpress.XtraEditors.SpinEdit textEditNumerator;
        private DevExpress.XtraEditors.SpinEdit textEditDenominator;
        private DevExpress.XtraEditors.DateEdit dateEditRegistration;
        private DevExpress.XtraEditors.CheckEdit checkOwner;
    }
}
