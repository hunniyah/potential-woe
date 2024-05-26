namespace rms_dbproject
{
    partial class folo
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
            splitter1 = new Splitter();
            pictureBox1 = new PictureBox();
            flower = new PictureBox();
            lblnm = new Label();
            label1 = new Label();
            txtnm = new TextBox();
            txtps = new TextBox();
            lblrm = new CheckBox();
            flow = new PictureBox();
            btnlog = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flower).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flow).BeginInit();
            SuspendLayout();
            // 
            // splitter1
            // 
            splitter1.BackColor = Color.FromArgb(31, 73, 89);
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(286, 530);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            splitter1.SplitterMoved += this.splitter1_SplitterMoved;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(31, 73, 89);
            pictureBox1.Image = Properties.Resources._23;
            pictureBox1.Location = new Point(-17, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(303, 278);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // flower
            // 
            flower.Image = Properties.Resources._12;
            flower.Location = new Point(605, -16);
            flower.Name = "flower";
            flower.Size = new Size(353, 361);
            flower.SizeMode = PictureBoxSizeMode.StretchImage;
            flower.TabIndex = 2;
            flower.TabStop = false;
            // 
            // lblnm
            // 
            lblnm.AutoSize = true;
            lblnm.FlatStyle = FlatStyle.Flat;
            lblnm.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblnm.ForeColor = SystemColors.ButtonHighlight;
            lblnm.Location = new Point(483, 121);
            lblnm.Name = "lblnm";
            lblnm.Size = new Size(76, 29);
            lblnm.TabIndex = 4;
            lblnm.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(483, 244);
            label1.Name = "label1";
            label1.Size = new Size(115, 29);
            label1.TabIndex = 5;
            label1.Text = "Password";
            label1.Click += this.label1_Click;
            // 
            // txtnm
            // 
            txtnm.BackColor = Color.FromArgb(1, 20, 37);
            txtnm.BorderStyle = BorderStyle.None;
            txtnm.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtnm.ForeColor = SystemColors.ButtonHighlight;
            txtnm.Location = new Point(483, 165);
            txtnm.Multiline = true;
            txtnm.Name = "txtnm";
            txtnm.Size = new Size(310, 44);
            txtnm.TabIndex = 6;
            txtnm.UseWaitCursor = true;
            txtnm.TextChanged += this.txtnm_TextChanged;
            // 
            // txtps
            // 
            txtps.BackColor = Color.FromArgb(1, 20, 37);
            txtps.BorderStyle = BorderStyle.None;
            txtps.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtps.ForeColor = SystemColors.ButtonHighlight;
            txtps.Location = new Point(483, 281);
            txtps.Multiline = true;
            txtps.Name = "txtps";
            txtps.Size = new Size(310, 46);
            txtps.TabIndex = 7;
            // 
            // lblrm
            // 
            lblrm.AutoSize = true;
            lblrm.FlatStyle = FlatStyle.Popup;
            lblrm.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblrm.ForeColor = SystemColors.ButtonHighlight;
            lblrm.Location = new Point(483, 351);
            lblrm.Name = "lblrm";
            lblrm.Size = new Size(192, 33);
            lblrm.TabIndex = 8;
            lblrm.Text = "Remember me";
            lblrm.UseVisualStyleBackColor = true;
            // 
            // flow
            // 
            flow.Image = Properties.Resources._21;
            flow.Location = new Point(275, 153);
            flow.Name = "flow";
            flow.Size = new Size(400, 405);
            flow.SizeMode = PictureBoxSizeMode.StretchImage;
            flow.TabIndex = 9;
            flow.TabStop = false;
            // 
            // btnlog
            // 
            btnlog.AutoSize = true;
            btnlog.BackColor = Color.FromArgb(1, 20, 37);
            btnlog.FlatStyle = FlatStyle.Popup;
            btnlog.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnlog.ForeColor = SystemColors.ButtonHighlight;
            btnlog.Location = new Point(664, 407);
            btnlog.Name = "btnlog";
            btnlog.Size = new Size(129, 39);
            btnlog.TabIndex = 10;
            btnlog.Text = "Login";
            btnlog.UseVisualStyleBackColor = false;
            btnlog.Click += this.btnlog_Click;
            // 
            // folo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(92, 124, 137);
            ClientSize = new Size(952, 530);
            Controls.Add(btnlog);
            Controls.Add(lblrm);
            Controls.Add(txtps);
            Controls.Add(txtnm);
            Controls.Add(label1);
            Controls.Add(lblnm);
            Controls.Add(flower);
            Controls.Add(pictureBox1);
            Controls.Add(splitter1);
            Controls.Add(flow);
            FormBorderStyle = FormBorderStyle.None;
            Name = "folo";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)flower).EndInit();
            ((System.ComponentModel.ISupportInitialize)flow).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Splitter splitter1;
        public PictureBox pictureBox1;
        public PictureBox flower;
        private Label lblnm;
        private Label label1;
        private TextBox txtnm;
        private TextBox txtps;
        private CheckBox lblrm;
        private PictureBox flow;
        private Button btnlog;
    }
}