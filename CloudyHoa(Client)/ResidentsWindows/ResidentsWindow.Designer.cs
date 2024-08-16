namespace CloudyHoa_Client_.ResidentsWindows
{
    partial class ResidentsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResidentsWindow));
            this.panelControl = new DevExpress.XtraEditors.PanelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.svgImageAttention = new DevExpress.XtraEditors.SvgImageBox();
            this.deleteResidentButton = new DevExpress.XtraEditors.SimpleButton();
            this.editResidentButton = new DevExpress.XtraEditors.SimpleButton();
            this.addResidentButton = new DevExpress.XtraEditors.SimpleButton();
            this.residentsGridControl1 = new CloudyHoa_Client_.General.ResidentsGridControl();
            this.treeListControl1 = new CloudyHoa_Client_.General.TreeListControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).BeginInit();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageAttention)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.panelControl1);
            this.panelControl.Controls.Add(this.treeListControl1);
            this.panelControl.Location = new System.Drawing.Point(12, 63);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1171, 400);
            this.panelControl.TabIndex = 2;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.svgImageAttention);
            this.panelControl1.Controls.Add(this.deleteResidentButton);
            this.panelControl1.Controls.Add(this.editResidentButton);
            this.panelControl1.Controls.Add(this.addResidentButton);
            this.panelControl1.Controls.Add(this.residentsGridControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl1.Location = new System.Drawing.Point(345, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(824, 396);
            this.panelControl1.TabIndex = 3;
            // 
            // svgImageAttention
            // 
            this.svgImageAttention.Location = new System.Drawing.Point(771, 5);
            this.svgImageAttention.Name = "svgImageAttention";
            this.svgImageAttention.ShowToolTips = DevExpress.Utils.DefaultBoolean.True;
            this.svgImageAttention.Size = new System.Drawing.Size(48, 47);
            this.svgImageAttention.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageAttention.SvgImage")));
            this.svgImageAttention.TabIndex = 8;
            this.svgImageAttention.Text = "svgImageBox1";
            this.svgImageAttention.ToolTip = "Несоответствие долей владения. Сумма не равна 1";
            this.svgImageAttention.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Warning;
            this.svgImageAttention.Visible = false;
            // 
            // deleteResidentButton
            // 
            this.deleteResidentButton.Appearance.BackColor = System.Drawing.Color.White;
            this.deleteResidentButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteResidentButton.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteResidentButton.Appearance.Options.UseBackColor = true;
            this.deleteResidentButton.Appearance.Options.UseFont = true;
            this.deleteResidentButton.Appearance.Options.UseForeColor = true;
            this.deleteResidentButton.AutoSize = true;
            this.deleteResidentButton.Enabled = false;
            this.deleteResidentButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("deleteResidentButton.ImageOptions.Image")));
            this.deleteResidentButton.Location = new System.Drawing.Point(285, 5);
            this.deleteResidentButton.Name = "deleteResidentButton";
            this.deleteResidentButton.Size = new System.Drawing.Size(105, 36);
            this.deleteResidentButton.TabIndex = 6;
            this.deleteResidentButton.Text = "Удалить";
            this.deleteResidentButton.Click += new System.EventHandler(this.deleteResidentButton_ClickAsync);
            // 
            // editResidentButton
            // 
            this.editResidentButton.Appearance.BackColor = System.Drawing.Color.White;
            this.editResidentButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editResidentButton.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.editResidentButton.Appearance.Options.UseBackColor = true;
            this.editResidentButton.Appearance.Options.UseFont = true;
            this.editResidentButton.Appearance.Options.UseForeColor = true;
            this.editResidentButton.AutoSize = true;
            this.editResidentButton.Enabled = false;
            this.editResidentButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("editResidentButton.ImageOptions.Image")));
            this.editResidentButton.Location = new System.Drawing.Point(145, 5);
            this.editResidentButton.Name = "editResidentButton";
            this.editResidentButton.Size = new System.Drawing.Size(120, 36);
            this.editResidentButton.TabIndex = 5;
            this.editResidentButton.Text = "Изменить";
            this.editResidentButton.Click += new System.EventHandler(this.editResidentButton_Click);
            // 
            // addResidentButton
            // 
            this.addResidentButton.Appearance.BackColor = System.Drawing.Color.White;
            this.addResidentButton.Appearance.BorderColor = System.Drawing.Color.White;
            this.addResidentButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addResidentButton.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addResidentButton.Appearance.Options.UseBackColor = true;
            this.addResidentButton.Appearance.Options.UseBorderColor = true;
            this.addResidentButton.Appearance.Options.UseFont = true;
            this.addResidentButton.Appearance.Options.UseForeColor = true;
            this.addResidentButton.AutoSize = true;
            this.addResidentButton.Enabled = false;
            this.addResidentButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("addResidentButton.ImageOptions.Image")));
            this.addResidentButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.addResidentButton.Location = new System.Drawing.Point(5, 5);
            this.addResidentButton.Name = "addResidentButton";
            this.addResidentButton.Size = new System.Drawing.Size(118, 36);
            this.addResidentButton.TabIndex = 4;
            this.addResidentButton.Text = "Добавить";
            this.addResidentButton.Click += new System.EventHandler(this.addResidentButton_Click);
            // 
            // residentsGridControl1
            // 
            this.residentsGridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.residentsGridControl1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.residentsGridControl1.Location = new System.Drawing.Point(2, 60);
            this.residentsGridControl1.Margin = new System.Windows.Forms.Padding(5);
            this.residentsGridControl1.Name = "residentsGridControl1";
            this.residentsGridControl1.Size = new System.Drawing.Size(820, 334);
            this.residentsGridControl1.TabIndex = 3;
            // 
            // treeListControl1
            // 
            this.treeListControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeListControl1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeListControl1.Location = new System.Drawing.Point(2, 2);
            this.treeListControl1.Margin = new System.Windows.Forms.Padding(4);
            this.treeListControl1.Name = "treeListControl1";
            this.treeListControl1.Size = new System.Drawing.Size(337, 396);
            this.treeListControl1.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(563, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(87, 31);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Жильцы";
            // 
            // ResidentsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1195, 473);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.panelControl);
            this.Name = "ResidentsWindow";
            this.Text = "Учет жильцов";
            this.Load += new System.EventHandler(this.ResidentsWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).EndInit();
            this.panelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageAttention)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl;
        private General.TreeListControl treeListControl1;
        private General.ResidentsGridControl residentsGridControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton deleteResidentButton;
        private DevExpress.XtraEditors.SimpleButton editResidentButton;
        private DevExpress.XtraEditors.SimpleButton addResidentButton;
        private DevExpress.XtraEditors.SvgImageBox svgImageAttention;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}