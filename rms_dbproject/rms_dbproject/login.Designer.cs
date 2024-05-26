namespace login_2._0
{
    partial class log
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(log));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lblnm = new System.Windows.Forms.Label();
            this.lblps = new System.Windows.Forms.Label();
            this.txtnm = new System.Windows.Forms.TextBox();
            this.txtps = new System.Windows.Forms.TextBox();
            this.chrm = new System.Windows.Forms.CheckBox();
            this.btnlo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            resources.ApplyResources(this.splitter1, "splitter1");
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.splitter1.Name = "splitter1";
            this.splitter1.TabStop = false;
            this.splitter1.UseWaitCursor = true;
            // 
            // lblnm
            // 
            resources.ApplyResources(this.lblnm, "lblnm");
            this.lblnm.Name = "lblnm";
            this.lblnm.UseWaitCursor = true;
            this.lblnm.Click += new System.EventHandler(this.lblnm_Click);
            // 
            // lblps
            // 
            resources.ApplyResources(this.lblps, "lblps");
            this.lblps.Name = "lblps";
            this.lblps.UseWaitCursor = true;
            this.lblps.Click += new System.EventHandler(this.lblps_Click);
            // 
            // txtnm
            // 
            this.txtnm.AcceptsTab = true;
            resources.ApplyResources(this.txtnm, "txtnm");
            this.txtnm.AllowDrop = true;
            this.txtnm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(20)))), ((int)(((byte)(37)))));
            this.txtnm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnm.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtnm.Name = "txtnm";
            this.txtnm.UseWaitCursor = true;
            // 
            // txtps
            // 
            this.txtps.AcceptsReturn = true;
            this.txtps.AcceptsTab = true;
            resources.ApplyResources(this.txtps, "txtps");
            this.txtps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(20)))), ((int)(((byte)(37)))));
            this.txtps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtps.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtps.Name = "txtps";
            this.txtps.UseSystemPasswordChar = true;
            this.txtps.UseWaitCursor = true;
            this.txtps.TextChanged += new System.EventHandler(this.txtps_TextChanged_1);
            // 
            // chrm
            // 
            resources.ApplyResources(this.chrm, "chrm");
            this.chrm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chrm.Name = "chrm";
            this.chrm.UseVisualStyleBackColor = true;
            this.chrm.UseWaitCursor = true;
            this.chrm.CheckedChanged += new System.EventHandler(this.chrm_CheckedChanged);
            // 
            // btnlo
            // 
            resources.ApplyResources(this.btnlo, "btnlo");
            this.btnlo.AutoEllipsis = true;
            this.btnlo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(20)))), ((int)(((byte)(37)))));
            this.btnlo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnlo.Name = "btnlo";
            this.btnlo.UseVisualStyleBackColor = false;
            this.btnlo.UseWaitCursor = true;
            this.btnlo.Click += new System.EventHandler(this.btnlo_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::login_2._0.Properties.Resources._21;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.BackgroundImage = global::login_2._0.Properties.Resources._1;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            this.pictureBox2.UseWaitCursor = true;
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.BackgroundImage = global::login_2._0.Properties.Resources._23;
            this.pictureBox3.Image = global::login_2._0.Properties.Resources._22;
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            this.pictureBox3.UseWaitCursor = true;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // log
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(124)))), ((int)(((byte)(137)))));
            this.Controls.Add(this.txtps);
            this.Controls.Add(this.txtnm);
            this.Controls.Add(this.btnlo);
            this.Controls.Add(this.chrm);
            this.Controls.Add(this.lblps);
            this.Controls.Add(this.lblnm);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "log";
            this.ShowInTaskbar = false;
            this.UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblnm;
        private System.Windows.Forms.Label lblps;
        private System.Windows.Forms.TextBox txtnm;
        private System.Windows.Forms.TextBox txtps;
        private System.Windows.Forms.CheckBox chrm;
        private System.Windows.Forms.Button btnlo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

