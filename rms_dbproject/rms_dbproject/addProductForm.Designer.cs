namespace rms_dbproject
{
    partial class addProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addProductForm));
            lbl_prodName = new Label();
            txtbx_prodName = new ReaLTaiizor.Controls.CyberTextBox();
            btn_confirm = new ReaLTaiizor.Controls.CyberButton();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            SuspendLayout();
            // 
            // lbl_prodName
            // 
            resources.ApplyResources(lbl_prodName, "lbl_prodName");
            lbl_prodName.ForeColor = Color.White;
            lbl_prodName.Name = "lbl_prodName";
            // 
            // txtbx_prodName
            // 
            txtbx_prodName.Alpha = 20;
            txtbx_prodName.BackColor = Color.Transparent;
            txtbx_prodName.Background_WidthPen = 3F;
            txtbx_prodName.BackgroundPen = true;
            txtbx_prodName.ColorBackground = Color.White;
            txtbx_prodName.ColorBackground_Pen = Color.FromArgb(92, 124, 137);
            txtbx_prodName.ColorLighting = Color.FromArgb(29, 200, 238);
            txtbx_prodName.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtbx_prodName.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtbx_prodName.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            resources.ApplyResources(txtbx_prodName, "txtbx_prodName");
            txtbx_prodName.ForeColor = Color.Black;
            txtbx_prodName.Lighting = false;
            txtbx_prodName.LinearGradientPen = false;
            txtbx_prodName.Name = "txtbx_prodName";
            txtbx_prodName.PenWidth = 15;
            txtbx_prodName.RGB = false;
            txtbx_prodName.Rounding = true;
            txtbx_prodName.RoundingInt = 60;
            txtbx_prodName.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtbx_prodName.Tag = "Cyber";
            txtbx_prodName.TextButton = "";
            txtbx_prodName.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtbx_prodName.Timer_RGB = 300;
            // 
            // btn_confirm
            // 
            btn_confirm.Alpha = 20;
            btn_confirm.BackColor = Color.Transparent;
            btn_confirm.Background = true;
            btn_confirm.Background_WidthPen = 4F;
            btn_confirm.BackgroundPen = true;
            btn_confirm.ColorBackground = Color.White;
            btn_confirm.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btn_confirm.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btn_confirm.ColorBackground_Pen = Color.FromArgb(92, 124, 137);
            btn_confirm.ColorLighting = Color.FromArgb(92, 124, 137);
            btn_confirm.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btn_confirm.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btn_confirm.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btn_confirm.Effect_1 = true;
            btn_confirm.Effect_1_ColorBackground = Color.FromArgb(92, 124, 137);
            btn_confirm.Effect_1_Transparency = 25;
            btn_confirm.Effect_2 = true;
            btn_confirm.Effect_2_ColorBackground = Color.White;
            btn_confirm.Effect_2_Transparency = 20;
            resources.ApplyResources(btn_confirm, "btn_confirm");
            btn_confirm.ForeColor = Color.FromArgb(1, 20, 37);
            btn_confirm.Lighting = false;
            btn_confirm.LinearGradient_Background = false;
            btn_confirm.LinearGradientPen = false;
            btn_confirm.Name = "btn_confirm";
            btn_confirm.PenWidth = 15;
            btn_confirm.Rounding = true;
            btn_confirm.RoundingInt = 70;
            btn_confirm.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btn_confirm.Tag = "Cyber";
            btn_confirm.TextButton = "Confirm";
            btn_confirm.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btn_confirm.Timer_Effect_1 = 5;
            btn_confirm.Timer_RGB = 300;
            // 
            // nightControlBox1
            // 
            resources.ApplyResources(nightControlBox1, "nightControlBox1");
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(1, 20, 37);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Click += nightControlBox1_Click;
            // 
            // addProductForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(53, 91, 105);
            Controls.Add(nightControlBox1);
            Controls.Add(btn_confirm);
            Controls.Add(txtbx_prodName);
            Controls.Add(lbl_prodName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "addProductForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_prodName;
        private ReaLTaiizor.Controls.CyberTextBox txtbx_prodName;
        private ReaLTaiizor.Controls.CyberButton btn_confirm;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
    }
}