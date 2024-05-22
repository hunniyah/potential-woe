namespace rms_dbproject
{
    partial class employee_dashboard
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            lnk_editProfile = new LinkLabel();
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(components);
            emp_details = new Panel();
            emp_menu = new Guna.UI2.WinForms.Guna2TabControl();
            tab_attendance = new TabPage();
            tab_Performance = new TabPage();
            tab_salary = new TabPage();
            tab_home = new TabPage();
            lbl_welcome = new Guna.UI2.WinForms.Guna2HtmlLabel();
            label1 = new Label();
            lbl_theEmpofmonth = new Label();
            lbl_rating = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lbl_rankings = new Guna.UI2.WinForms.Guna2HtmlLabel();
            listView_empRankings = new ListView();
            lbl_remarks = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lbl_performance = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2ProgressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            lbl_employee_of_month = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2RatingStar1 = new Guna.UI2.WinForms.Guna2RatingStar();
            btn_close = new Guna.UI2.WinForms.Guna2TileButton();
            panel1.SuspendLayout();
            emp_menu.SuspendLayout();
            tab_Performance.SuspendLayout();
            tab_home.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Lavender;
            panel1.Controls.Add(btn_close);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1192, 51);
            panel1.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 500;
            // 
            // lnk_editProfile
            // 
            lnk_editProfile.AutoSize = true;
            lnk_editProfile.LinkColor = Color.FromArgb(64, 64, 64);
            lnk_editProfile.Location = new Point(385, 160);
            lnk_editProfile.Name = "lnk_editProfile";
            lnk_editProfile.Size = new Size(153, 29);
            lnk_editProfile.TabIndex = 4;
            lnk_editProfile.TabStop = true;
            lnk_editProfile.Text = "Edit Profile";
            // 
            // guna2Elipse3
            // 
            guna2Elipse3.TargetControl = this;
            // 
            // emp_details
            // 
            emp_details.Location = new Point(104, 207);
            emp_details.Name = "emp_details";
            emp_details.Size = new Size(742, 326);
            emp_details.TabIndex = 5;
            // 
            // emp_menu
            // 
            emp_menu.Alignment = TabAlignment.Left;
            emp_menu.Controls.Add(tab_home);
            emp_menu.Controls.Add(tab_attendance);
            emp_menu.Controls.Add(tab_Performance);
            emp_menu.Controls.Add(tab_salary);
            emp_menu.Dock = DockStyle.Left;
            emp_menu.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emp_menu.ItemSize = new Size(250, 70);
            emp_menu.Location = new Point(0, 51);
            emp_menu.Name = "emp_menu";
            emp_menu.SelectedIndex = 0;
            emp_menu.Size = new Size(1192, 622);
            emp_menu.TabButtonHoverState.BorderColor = Color.Empty;
            emp_menu.TabButtonHoverState.FillColor = Color.FromArgb(40, 52, 70);
            emp_menu.TabButtonHoverState.Font = new Font("Segoe UI Semibold", 10F);
            emp_menu.TabButtonHoverState.ForeColor = Color.White;
            emp_menu.TabButtonHoverState.InnerColor = Color.FromArgb(40, 52, 70);
            emp_menu.TabButtonIdleState.BorderColor = Color.Empty;
            emp_menu.TabButtonIdleState.FillColor = Color.FromArgb(33, 42, 57);
            emp_menu.TabButtonIdleState.Font = new Font("Segoe UI Semibold", 10F);
            emp_menu.TabButtonIdleState.ForeColor = Color.FromArgb(156, 160, 167);
            emp_menu.TabButtonIdleState.InnerColor = Color.FromArgb(33, 42, 57);
            emp_menu.TabButtonSelectedState.BorderColor = Color.Empty;
            emp_menu.TabButtonSelectedState.FillColor = Color.FromArgb(29, 37, 49);
            emp_menu.TabButtonSelectedState.Font = new Font("Segoe UI Semibold", 10F);
            emp_menu.TabButtonSelectedState.ForeColor = Color.White;
            emp_menu.TabButtonSelectedState.InnerColor = Color.FromArgb(76, 132, 255);
            emp_menu.TabButtonSize = new Size(250, 70);
            emp_menu.TabIndex = 3;
            emp_menu.TabMenuBackColor = Color.FromArgb(33, 42, 57);
            // 
            // tab_attendance
            // 
            tab_attendance.Font = new Font("Georgia", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tab_attendance.Location = new Point(254, 4);
            tab_attendance.Name = "tab_attendance";
            tab_attendance.Padding = new Padding(3);
            tab_attendance.Size = new Size(934, 614);
            tab_attendance.TabIndex = 1;
            tab_attendance.Text = "Attendance";
            tab_attendance.UseVisualStyleBackColor = true;
            // 
            // tab_Performance
            // 
            tab_Performance.Controls.Add(lbl_theEmpofmonth);
            tab_Performance.Controls.Add(lbl_rating);
            tab_Performance.Controls.Add(lbl_rankings);
            tab_Performance.Controls.Add(listView_empRankings);
            tab_Performance.Controls.Add(lbl_remarks);
            tab_Performance.Controls.Add(lbl_performance);
            tab_Performance.Controls.Add(guna2ProgressBar1);
            tab_Performance.Controls.Add(lbl_employee_of_month);
            tab_Performance.Controls.Add(guna2RatingStar1);
            tab_Performance.Location = new Point(254, 4);
            tab_Performance.Name = "tab_Performance";
            tab_Performance.Size = new Size(934, 614);
            tab_Performance.TabIndex = 2;
            tab_Performance.Text = "Performance";
            tab_Performance.UseVisualStyleBackColor = true;
            tab_Performance.Click += tab_Performance_Click;
            // 
            // tab_salary
            // 
            tab_salary.Font = new Font("Georgia", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tab_salary.Location = new Point(254, 4);
            tab_salary.Name = "tab_salary";
            tab_salary.Size = new Size(934, 614);
            tab_salary.TabIndex = 3;
            tab_salary.Text = "Salary Report";
            tab_salary.UseVisualStyleBackColor = true;
            // 
            // tab_home
            // 
            tab_home.Controls.Add(lbl_welcome);
            tab_home.Controls.Add(emp_details);
            tab_home.Controls.Add(label1);
            tab_home.Controls.Add(lnk_editProfile);
            tab_home.Location = new Point(254, 4);
            tab_home.Name = "tab_home";
            tab_home.Size = new Size(934, 614);
            tab_home.TabIndex = 4;
            tab_home.Text = "Home";
            tab_home.UseVisualStyleBackColor = true;
            // 
            // lbl_welcome
            // 
            lbl_welcome.BackColor = Color.Transparent;
            lbl_welcome.Font = new Font("Georgia", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_welcome.Location = new Point(361, 44);
            lbl_welcome.Name = "lbl_welcome";
            lbl_welcome.Size = new Size(164, 34);
            lbl_welcome.TabIndex = 3;
            lbl_welcome.Text = "WELCOME\r\n!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(297, 94);
            label1.Name = "label1";
            label1.Size = new Size(281, 32);
            label1.TabIndex = 3;
            label1.Text = "\"EMPLOYEE NAME\"";
            // 
            // lbl_theEmpofmonth
            // 
            lbl_theEmpofmonth.AutoSize = true;
            lbl_theEmpofmonth.Location = new Point(341, 330);
            lbl_theEmpofmonth.Name = "lbl_theEmpofmonth";
            lbl_theEmpofmonth.Size = new Size(258, 29);
            lbl_theEmpofmonth.TabIndex = 21;
            lbl_theEmpofmonth.Text = "'EMPLOYEE NAME'";
            // 
            // lbl_rating
            // 
            lbl_rating.BackColor = Color.Transparent;
            lbl_rating.Font = new Font("Georgia", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_rating.Location = new Point(176, 132);
            lbl_rating.Name = "lbl_rating";
            lbl_rating.Size = new Size(74, 29);
            lbl_rating.TabIndex = 20;
            lbl_rating.Text = "Rating:";
            // 
            // lbl_rankings
            // 
            lbl_rankings.BackColor = Color.Transparent;
            lbl_rankings.Font = new Font("Georgia", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_rankings.Location = new Point(185, 409);
            lbl_rankings.Name = "lbl_rankings";
            lbl_rankings.Size = new Size(101, 29);
            lbl_rankings.TabIndex = 19;
            lbl_rankings.Text = "Rankings:";
            // 
            // listView_empRankings
            // 
            listView_empRankings.Location = new Point(207, 453);
            listView_empRankings.Name = "listView_empRankings";
            listView_empRankings.Size = new Size(552, 146);
            listView_empRankings.TabIndex = 18;
            listView_empRankings.UseCompatibleStateImageBehavior = false;
            // 
            // lbl_remarks
            // 
            lbl_remarks.BackColor = Color.Transparent;
            lbl_remarks.Font = new Font("Georgia", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_remarks.Location = new Point(176, 224);
            lbl_remarks.Name = "lbl_remarks";
            lbl_remarks.Size = new Size(97, 29);
            lbl_remarks.TabIndex = 17;
            lbl_remarks.Text = "Remarks:";
            // 
            // lbl_performance
            // 
            lbl_performance.BackColor = Color.Transparent;
            lbl_performance.Font = new Font("Georgia", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_performance.Location = new Point(341, 14);
            lbl_performance.Name = "lbl_performance";
            lbl_performance.Size = new Size(188, 29);
            lbl_performance.TabIndex = 16;
            lbl_performance.Text = "Your Performance:";
            // 
            // guna2ProgressBar1
            // 
            guna2ProgressBar1.CustomizableEdges = customizableEdges3;
            guna2ProgressBar1.Location = new Point(176, 58);
            guna2ProgressBar1.Name = "guna2ProgressBar1";
            guna2ProgressBar1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2ProgressBar1.Size = new Size(591, 45);
            guna2ProgressBar1.TabIndex = 15;
            guna2ProgressBar1.Text = "guna2ProgressBar1";
            guna2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // lbl_employee_of_month
            // 
            lbl_employee_of_month.BackColor = Color.Transparent;
            lbl_employee_of_month.Font = new Font("Georgia", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_employee_of_month.Location = new Point(262, 293);
            lbl_employee_of_month.Name = "lbl_employee_of_month";
            lbl_employee_of_month.Size = new Size(380, 34);
            lbl_employee_of_month.TabIndex = 14;
            lbl_employee_of_month.Text = "EMPLOYEE OF THE MONTH";
            // 
            // guna2RatingStar1
            // 
            guna2RatingStar1.Location = new Point(384, 132);
            guna2RatingStar1.Name = "guna2RatingStar1";
            guna2RatingStar1.RatingColor = Color.FromArgb(128, 128, 255);
            guna2RatingStar1.Size = new Size(145, 40);
            guna2RatingStar1.TabIndex = 13;
            // 
            // btn_close
            // 
            btn_close.CustomizableEdges = customizableEdges1;
            btn_close.DisabledState.BorderColor = Color.DarkGray;
            btn_close.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_close.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_close.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_close.FillColor = Color.LightSlateGray;
            btn_close.FocusedColor = Color.LightSlateGray;
            btn_close.Font = new Font("Candara", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_close.ForeColor = Color.White;
            btn_close.Location = new Point(1087, 12);
            btn_close.Name = "btn_close";
            btn_close.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_close.Size = new Size(84, 33);
            btn_close.TabIndex = 0;
            btn_close.Text = "Close";
            btn_close.Click += btn_close_Click;
            // 
            // employee_dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1192, 673);
            Controls.Add(emp_menu);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "employee_dashboard";
            Text = "dashboard";
            Load += employee_dashboard_Load;
            panel1.ResumeLayout(false);
            emp_menu.ResumeLayout(false);
            tab_Performance.ResumeLayout(false);
            tab_Performance.PerformLayout();
            tab_home.ResumeLayout(false);
            tab_home.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private LinkLabel lnk_editProfile;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Panel emp_details;
        private Guna.UI2.WinForms.Guna2TabControl emp_menu;
        private TabPage tab_attendance;
        private TabPage tab_Performance;
        private TabPage tab_salary;
        private TabPage tab_home;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_welcome;
        private Label label1;
        private Label lbl_theEmpofmonth;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_rating;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_rankings;
        private ListView listView_empRankings;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_remarks;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_performance;
        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_employee_of_month;
        private Guna.UI2.WinForms.Guna2RatingStar guna2RatingStar1;
        private Guna.UI2.WinForms.Guna2TileButton btn_close;
    }
}