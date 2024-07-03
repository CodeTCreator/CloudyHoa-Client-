namespace CloudyHoa_Client_.ExpenseWindows.ExternalExpenseMW
{
    partial class ExternalExpenseMW
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.viewButton = new DevExpress.XtraEditors.SimpleButton();
            this.labelControlObjects = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxCat = new System.Windows.Forms.ComboBox();
            this.labelControlRC = new DevExpress.XtraEditors.LabelControl();
            this.labelControlCost = new DevExpress.XtraEditors.LabelControl();
            this.labelControlQuantity = new DevExpress.XtraEditors.LabelControl();
            this.labelControlName = new DevExpress.XtraEditors.LabelControl();
            this.labelControlCategory = new DevExpress.XtraEditors.LabelControl();
            this.labelControlPeriod = new DevExpress.XtraEditors.LabelControl();
            this.labelControlWN = new DevExpress.XtraEditors.LabelControl();
            this.textEditObjects = new DevExpress.XtraEditors.TextEdit();
            this.spinEditCost = new DevExpress.XtraEditors.SpinEdit();
            this.spinEditQuantity = new DevExpress.XtraEditors.SpinEdit();
            this.universalButton = new DevExpress.XtraEditors.SimpleButton();
            this.textEditResultCost = new DevExpress.XtraEditors.TextEdit();
            this.textEditName = new DevExpress.XtraEditors.TextEdit();
            this.periodTimeOffset = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditObjects.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditResultCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodTimeOffset.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.viewButton);
            this.panelControl1.Controls.Add(this.textEditObjects);
            this.panelControl1.Controls.Add(this.labelControlObjects);
            this.panelControl1.Controls.Add(this.spinEditCost);
            this.panelControl1.Controls.Add(this.spinEditQuantity);
            this.panelControl1.Controls.Add(this.universalButton);
            this.panelControl1.Controls.Add(this.comboBoxCat);
            this.panelControl1.Controls.Add(this.textEditResultCost);
            this.panelControl1.Controls.Add(this.textEditName);
            this.panelControl1.Controls.Add(this.labelControlRC);
            this.panelControl1.Controls.Add(this.labelControlCost);
            this.panelControl1.Controls.Add(this.labelControlQuantity);
            this.panelControl1.Controls.Add(this.labelControlName);
            this.panelControl1.Controls.Add(this.labelControlCategory);
            this.panelControl1.Controls.Add(this.labelControlPeriod);
            this.panelControl1.Controls.Add(this.periodTimeOffset);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 49);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(442, 401);
            this.panelControl1.TabIndex = 3;
            // 
            // viewButton
            // 
            this.viewButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.viewButton.Appearance.Options.UseFont = true;
            this.viewButton.Location = new System.Drawing.Point(148, 163);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(94, 29);
            this.viewButton.TabIndex = 31;
            this.viewButton.Text = "Обзор";
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // labelControlObjects
            // 
            this.labelControlObjects.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControlObjects.Appearance.Options.UseFont = true;
            this.labelControlObjects.Location = new System.Drawing.Point(23, 170);
            this.labelControlObjects.Name = "labelControlObjects";
            this.labelControlObjects.Size = new System.Drawing.Size(61, 23);
            this.labelControlObjects.TabIndex = 29;
            this.labelControlObjects.Text = "Объект:";
            // 
            // comboBoxCat
            // 
            this.comboBoxCat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCat.FormattingEnabled = true;
            this.comboBoxCat.Location = new System.Drawing.Point(207, 25);
            this.comboBoxCat.Name = "comboBoxCat";
            this.comboBoxCat.Size = new System.Drawing.Size(223, 31);
            this.comboBoxCat.TabIndex = 24;
            this.comboBoxCat.SelectionChangeCommitted += new System.EventHandler(this.comboBoxCat_SelectionChangeCommitted);
            // 
            // labelControlRC
            // 
            this.labelControlRC.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControlRC.Appearance.Options.UseFont = true;
            this.labelControlRC.Location = new System.Drawing.Point(23, 305);
            this.labelControlRC.Name = "labelControlRC";
            this.labelControlRC.Size = new System.Drawing.Size(51, 23);
            this.labelControlRC.TabIndex = 20;
            this.labelControlRC.Text = "Итого:";
            // 
            // labelControlCost
            // 
            this.labelControlCost.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControlCost.Appearance.Options.UseFont = true;
            this.labelControlCost.Location = new System.Drawing.Point(23, 264);
            this.labelControlCost.Name = "labelControlCost";
            this.labelControlCost.Size = new System.Drawing.Size(163, 23);
            this.labelControlCost.TabIndex = 19;
            this.labelControlCost.Text = "Стоимость единицы:";
            // 
            // labelControlQuantity
            // 
            this.labelControlQuantity.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControlQuantity.Appearance.Options.UseFont = true;
            this.labelControlQuantity.Location = new System.Drawing.Point(23, 213);
            this.labelControlQuantity.Name = "labelControlQuantity";
            this.labelControlQuantity.Size = new System.Drawing.Size(96, 23);
            this.labelControlQuantity.TabIndex = 18;
            this.labelControlQuantity.Text = "Количество:";
            // 
            // labelControlName
            // 
            this.labelControlName.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControlName.Appearance.Options.UseFont = true;
            this.labelControlName.Location = new System.Drawing.Point(23, 128);
            this.labelControlName.Name = "labelControlName";
            this.labelControlName.Size = new System.Drawing.Size(80, 23);
            this.labelControlName.TabIndex = 17;
            this.labelControlName.Text = "Название:";
            // 
            // labelControlCategory
            // 
            this.labelControlCategory.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControlCategory.Appearance.Options.UseFont = true;
            this.labelControlCategory.Location = new System.Drawing.Point(23, 33);
            this.labelControlCategory.Name = "labelControlCategory";
            this.labelControlCategory.Size = new System.Drawing.Size(85, 23);
            this.labelControlCategory.TabIndex = 16;
            this.labelControlCategory.Text = "Категория:";
            // 
            // labelControlPeriod
            // 
            this.labelControlPeriod.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControlPeriod.Appearance.Options.UseFont = true;
            this.labelControlPeriod.Location = new System.Drawing.Point(23, 80);
            this.labelControlPeriod.Name = "labelControlPeriod";
            this.labelControlPeriod.Size = new System.Drawing.Size(64, 23);
            this.labelControlPeriod.TabIndex = 15;
            this.labelControlPeriod.Text = "Период:";
            // 
            // labelControlWN
            // 
            this.labelControlWN.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControlWN.Appearance.Options.UseFont = true;
            this.labelControlWN.Location = new System.Drawing.Point(134, 12);
            this.labelControlWN.Name = "labelControlWN";
            this.labelControlWN.Size = new System.Drawing.Size(192, 31);
            this.labelControlWN.TabIndex = 2;
            this.labelControlWN.Text = "Создание расхода";
            // 
            // textEditObjects
            // 
            this.textEditObjects.Enabled = false;
            this.textEditObjects.Location = new System.Drawing.Point(248, 163);
            this.textEditObjects.Name = "textEditObjects";
            this.textEditObjects.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textEditObjects.Properties.Appearance.Options.UseFont = true;
            this.textEditObjects.Size = new System.Drawing.Size(181, 30);
            this.textEditObjects.TabIndex = 30;
            // 
            // spinEditCost
            // 
            this.spinEditCost.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditCost.Location = new System.Drawing.Point(206, 257);
            this.spinEditCost.Name = "spinEditCost";
            this.spinEditCost.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spinEditCost.Properties.Appearance.Options.UseFont = true;
            this.spinEditCost.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditCost.Properties.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.spinEditCost.Properties.MaskSettings.Set("mask", "n");
            this.spinEditCost.Properties.MaxValue = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.spinEditCost.Size = new System.Drawing.Size(223, 30);
            this.spinEditCost.TabIndex = 28;
            this.spinEditCost.EditValueChanged += new System.EventHandler(this.spinEditCost_EditValueChanged);
            // 
            // spinEditQuantity
            // 
            this.spinEditQuantity.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditQuantity.Location = new System.Drawing.Point(206, 206);
            this.spinEditQuantity.Name = "spinEditQuantity";
            this.spinEditQuantity.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spinEditQuantity.Properties.Appearance.Options.UseFont = true;
            this.spinEditQuantity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditQuantity.Properties.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.spinEditQuantity.Properties.MaskSettings.Set("mask", "n");
            this.spinEditQuantity.Properties.MaxValue = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.spinEditQuantity.Size = new System.Drawing.Size(223, 30);
            this.spinEditQuantity.TabIndex = 27;
            this.spinEditQuantity.EditValueChanged += new System.EventHandler(this.spinEditQuantity_EditValueChanged);
            // 
            // universalButton
            // 
            this.universalButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.universalButton.Appearance.Options.UseFont = true;
            this.universalButton.ImageOptions.Image = global::CloudyHoa_Client_.Properties.Resources.save_32x32;
            this.universalButton.Location = new System.Drawing.Point(284, 349);
            this.universalButton.Name = "universalButton";
            this.universalButton.Size = new System.Drawing.Size(145, 40);
            this.universalButton.TabIndex = 26;
            this.universalButton.Text = "Сохранить";
            // 
            // textEditResultCost
            // 
            this.textEditResultCost.EditValue = "0";
            this.textEditResultCost.Enabled = false;
            this.textEditResultCost.Location = new System.Drawing.Point(206, 298);
            this.textEditResultCost.Name = "textEditResultCost";
            this.textEditResultCost.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textEditResultCost.Properties.Appearance.Options.UseFont = true;
            this.textEditResultCost.Properties.Appearance.Options.UseTextOptions = true;
            this.textEditResultCost.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.textEditResultCost.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.textEditResultCost.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.textEditResultCost.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.textEditResultCost.Size = new System.Drawing.Size(223, 30);
            this.textEditResultCost.TabIndex = 23;
            // 
            // textEditName
            // 
            this.textEditName.Location = new System.Drawing.Point(207, 121);
            this.textEditName.Name = "textEditName";
            this.textEditName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textEditName.Properties.Appearance.Options.UseFont = true;
            this.textEditName.Size = new System.Drawing.Size(222, 30);
            this.textEditName.TabIndex = 22;
            this.textEditName.EditValueChanged += new System.EventHandler(this.textEditName_EditValueChanged);
            // 
            // periodTimeOffset
            // 
            this.periodTimeOffset.EditValue = null;
            this.periodTimeOffset.Location = new System.Drawing.Point(207, 73);
            this.periodTimeOffset.Name = "periodTimeOffset";
            this.periodTimeOffset.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.periodTimeOffset.Properties.Appearance.Options.UseFont = true;
            this.periodTimeOffset.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.periodTimeOffset.Properties.MaskSettings.Set("mask", "Y");
            this.periodTimeOffset.Size = new System.Drawing.Size(222, 30);
            this.periodTimeOffset.TabIndex = 14;
            this.periodTimeOffset.EditValueChanged += new System.EventHandler(this.periodTimeOffset_EditValueChanged);
            // 
            // ExternalExpenseMW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 450);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.labelControlWN);
            this.Name = "ExternalExpenseMW";
            this.Text = "Расход на объект учета";
            this.Load += new System.EventHandler(this.ExternalExpenseMW_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditObjects.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditResultCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodTimeOffset.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton viewButton;
        private DevExpress.XtraEditors.TextEdit textEditObjects;
        private DevExpress.XtraEditors.LabelControl labelControlObjects;
        private DevExpress.XtraEditors.SpinEdit spinEditCost;
        private DevExpress.XtraEditors.SpinEdit spinEditQuantity;
        private DevExpress.XtraEditors.SimpleButton universalButton;
        private System.Windows.Forms.ComboBox comboBoxCat;
        private DevExpress.XtraEditors.TextEdit textEditResultCost;
        private DevExpress.XtraEditors.TextEdit textEditName;
        private DevExpress.XtraEditors.LabelControl labelControlRC;
        private DevExpress.XtraEditors.LabelControl labelControlCost;
        private DevExpress.XtraEditors.LabelControl labelControlQuantity;
        private DevExpress.XtraEditors.LabelControl labelControlName;
        private DevExpress.XtraEditors.LabelControl labelControlCategory;
        private DevExpress.XtraEditors.LabelControl labelControlPeriod;
        private DevExpress.XtraEditors.DateTimeOffsetEdit periodTimeOffset;
        private DevExpress.XtraEditors.LabelControl labelControlWN;
    }
}