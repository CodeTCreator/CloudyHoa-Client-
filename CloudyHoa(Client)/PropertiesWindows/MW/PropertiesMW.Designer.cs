namespace CloudyHoa_Client_.PropertiesWindows.MW
{
    partial class PropertiesMW
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
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.stackPanelProperties = new DevExpress.Utils.Layout.StackPanel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanelProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Appearance.BorderColor = System.Drawing.Color.Black;
            this.saveButton.Appearance.Options.UseBorderColor = true;
            this.saveButton.AppearanceDisabled.Options.UseBorderColor = true;
            this.saveButton.Location = new System.Drawing.Point(546, 392);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(94, 29);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Сохранить";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // stackPanelProperties
            // 
            this.stackPanelProperties.AutoScroll = true;
            this.stackPanelProperties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.stackPanelProperties.LabelVertAlignment = DevExpress.Utils.Layout.LabelVertAlignment.Center;
            this.stackPanelProperties.LayoutDirection = DevExpress.Utils.Layout.StackPanelLayoutDirection.TopDown;
            this.stackPanelProperties.Location = new System.Drawing.Point(22, 67);
            this.stackPanelProperties.Name = "stackPanelProperties";
            this.stackPanelProperties.Size = new System.Drawing.Size(618, 309);
            this.stackPanelProperties.TabIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl1.Controls.Add(this.labelName);
            this.panelControl1.Controls.Add(this.stackPanelProperties);
            this.panelControl1.Controls.Add(this.saveButton);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(656, 426);
            this.panelControl1.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(22, 14);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(97, 33);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Объект:";
            // 
            // PropertiesMW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 450);
            this.Controls.Add(this.panelControl1);
            this.Name = "PropertiesMW";
            this.Text = "Изменение характеристик";
            this.Load += new System.EventHandler(this.PropertiesMW_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stackPanelProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.Utils.Layout.StackPanel stackPanelProperties;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label labelName;
    }
}