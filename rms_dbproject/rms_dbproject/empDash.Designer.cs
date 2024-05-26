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
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            topbar = new Panel();
            btn_menu = new PictureBox();
            sidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            tb_home = new button();
            panel2 = new Panel();
            tb_attendance = new button();
            panel3 = new Panel();
            tb_salary = new button();
            optionsContainer = new FlowLayoutPanel();
            panel4 = new Panel();
            tb_options = new button();
            panel6 = new Panel();
            tab_advanced = new Button();
            panel5 = new Panel();
            btn_logout = new button();
            optionsTransition = new System.Windows.Forms.Timer(components);
            sidebarTransition = new System.Windows.Forms.Timer(components);
            fileSystemWatcher1 = new FileSystemWatcher();
            gunaAreaDataset1 = new Guna.Charts.WinForms.GunaAreaDataset();
            homePanel = new FlowLayoutPanel();
            panel7 = new Panel();
            lbl_welcome = new Label();
            empDetails_panel = new Panel();
            attendancePanel = new Panel();
            lbl_attendance = new Label();
            attendanceData = new DataGridView();
            panel8 = new Panel();
            salaryPanel = new FlowLayoutPanel();
            SalaryDatagrid = new FlowLayoutPanel();
            lbl_salary = new Label();
            panel9 = new Panel();
            salaryData = new Panel();
            topbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_menu).BeginInit();
            sidebar.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            optionsContainer.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            homePanel.SuspendLayout();
            panel7.SuspendLayout();
            attendancePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)attendanceData).BeginInit();
            salaryPanel.SuspendLayout();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(1183, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 0;
            // 
            // topbar
            // 
            topbar.BackColor = Color.FromArgb(36, 36, 36);
            topbar.Controls.Add(btn_menu);
            topbar.Controls.Add(nightControlBox1);
            topbar.Dock = DockStyle.Top;
            topbar.Location = new Point(0, 0);
            topbar.Name = "topbar";
            topbar.Size = new Size(1322, 56);
            topbar.TabIndex = 1;
            // 
            // btn_menu
            // 
            btn_menu.Image = Properties.Resources.Menu;
            btn_menu.Location = new Point(12, 10);
            btn_menu.Name = "btn_menu";
            btn_menu.Size = new Size(58, 40);
            btn_menu.SizeMode = PictureBoxSizeMode.CenterImage;
            btn_menu.TabIndex = 3;
            btn_menu.TabStop = false;
            btn_menu.Click += btn_menu_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(31, 73, 89);
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(optionsContainer);
            sidebar.Dock = DockStyle.Left;
            sidebar.FlowDirection = FlowDirection.TopDown;
            sidebar.Location = new Point(0, 56);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(295, 617);
            sidebar.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(tb_home);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(25, 0, 0, 0);
            panel1.Size = new Size(301, 91);
            panel1.TabIndex = 4;
            // 
            // tb_home
            // 
            tb_home.BackColor = Color.FromArgb(31, 73, 89);
            tb_home.Font = new Font("Georgia", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_home.ForeColor = Color.White;
            tb_home.Hoverforecolor1 = Color.FromArgb(1, 20, 37);
            tb_home.HoverImage1 = Properties.Resources.Home_2_;
            tb_home.Image = Properties.Resources.h3;
            tb_home.ImageAlign = ContentAlignment.MiddleLeft;
            tb_home.Location = new Point(-11, -15);
            tb_home.Name = "tb_home";
            tb_home.Normalforecolor1 = Color.White;
            tb_home.NormalImage1 = Properties.Resources.h3;
            tb_home.Padding = new Padding(25, 0, 0, 0);
            tb_home.Size = new Size(351, 143);
            tb_home.TabIndex = 4;
            tb_home.Text = "                      HOME";
            tb_home.TextAlign = ContentAlignment.MiddleLeft;
            tb_home.Tooltip1 = null;
            tb_home.UseVisualStyleBackColor = false;
            tb_home.Click += tb_home_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(tb_attendance);
            panel2.Location = new Point(3, 100);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(25, 0, 0, 0);
            panel2.Size = new Size(301, 91);
            panel2.TabIndex = 5;
            // 
            // tb_attendance
            // 
            tb_attendance.BackColor = Color.FromArgb(31, 73, 89);
            tb_attendance.Font = new Font("Georgia", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_attendance.ForeColor = Color.White;
            tb_attendance.Hoverforecolor1 = Color.FromArgb(1, 20, 37);
            tb_attendance.HoverImage1 = Properties.Resources.C1;
            tb_attendance.Image = Properties.Resources.Check_All;
            tb_attendance.ImageAlign = ContentAlignment.MiddleLeft;
            tb_attendance.Location = new Point(-9, -9);
            tb_attendance.Name = "tb_attendance";
            tb_attendance.Normalforecolor1 = Color.White;
            tb_attendance.NormalImage1 = Properties.Resources.Check_All;
            tb_attendance.Padding = new Padding(25, 0, 0, 0);
            tb_attendance.Size = new Size(351, 131);
            tb_attendance.TabIndex = 8;
            tb_attendance.Text = "                      ATTENDANCE";
            tb_attendance.TextAlign = ContentAlignment.MiddleLeft;
            tb_attendance.Tooltip1 = null;
            tb_attendance.UseVisualStyleBackColor = false;
            tb_attendance.Click += tb_attendance_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(tb_salary);
            panel3.Location = new Point(3, 197);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(25, 0, 0, 0);
            panel3.Size = new Size(301, 91);
            panel3.TabIndex = 6;
            // 
            // tb_salary
            // 
            tb_salary.BackColor = Color.FromArgb(31, 73, 89);
            tb_salary.Font = new Font("Georgia", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_salary.ForeColor = Color.White;
            tb_salary.Hoverforecolor1 = Color.FromArgb(1, 20, 37);
            tb_salary.HoverImage1 = Properties.Resources.SC2_;
            tb_salary.Image = Properties.Resources.scrol2;
            tb_salary.ImageAlign = ContentAlignment.MiddleLeft;
            tb_salary.Location = new Point(-9, -12);
            tb_salary.Name = "tb_salary";
            tb_salary.Normalforecolor1 = Color.White;
            tb_salary.NormalImage1 = Properties.Resources.scrol2;
            tb_salary.Padding = new Padding(25, 0, 0, 0);
            tb_salary.Size = new Size(351, 131);
            tb_salary.TabIndex = 6;
            tb_salary.Text = "                      SALARY";
            tb_salary.TextAlign = ContentAlignment.MiddleLeft;
            tb_salary.Tooltip1 = null;
            tb_salary.UseVisualStyleBackColor = false;
            tb_salary.Click += tb_salary_Click;
            // 
            // optionsContainer
            // 
            optionsContainer.BackColor = Color.FromArgb(31, 73, 89);
            optionsContainer.Controls.Add(panel4);
            optionsContainer.Controls.Add(panel6);
            optionsContainer.Controls.Add(panel5);
            optionsContainer.Location = new Point(3, 294);
            optionsContainer.Name = "optionsContainer";
            optionsContainer.Size = new Size(301, 303);
            optionsContainer.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.Controls.Add(tb_options);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(25, 0, 0, 0);
            panel4.Size = new Size(298, 91);
            panel4.TabIndex = 6;
            // 
            // tb_options
            // 
            tb_options.BackColor = Color.FromArgb(31, 73, 89);
            tb_options.Font = new Font("Georgia", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_options.ForeColor = Color.White;
            tb_options.Hoverforecolor1 = Color.FromArgb(1, 20, 37);
            tb_options.HoverImage1 = Properties.Resources.SV2;
            tb_options.Image = Properties.Resources.Services;
            tb_options.ImageAlign = ContentAlignment.MiddleLeft;
            tb_options.Location = new Point(-26, -20);
            tb_options.Name = "tb_options";
            tb_options.Normalforecolor1 = Color.White;
            tb_options.NormalImage1 = Properties.Resources.Services;
            tb_options.Padding = new Padding(25, 0, 0, 0);
            tb_options.Size = new Size(351, 131);
            tb_options.TabIndex = 9;
            tb_options.Text = "                      OPTIONS";
            tb_options.TextAlign = ContentAlignment.MiddleLeft;
            tb_options.Tooltip1 = null;
            tb_options.UseVisualStyleBackColor = false;
            tb_options.Click += tb_options_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(tab_advanced);
            panel6.Location = new Point(0, 97);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(25, 0, 0, 0);
            panel6.Size = new Size(301, 91);
            panel6.TabIndex = 8;
            // 
            // tab_advanced
            // 
            tab_advanced.BackColor = Color.FromArgb(92, 124, 137);
            tab_advanced.Font = new Font("Georgia", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tab_advanced.ForeColor = Color.White;
            tab_advanced.Image = Properties.Resources.Key;
            tab_advanced.ImageAlign = ContentAlignment.MiddleLeft;
            tab_advanced.Location = new Point(-11, -20);
            tab_advanced.Margin = new Padding(0);
            tab_advanced.Name = "tab_advanced";
            tab_advanced.Padding = new Padding(25, 0, 0, 0);
            tab_advanced.Size = new Size(339, 121);
            tab_advanced.TabIndex = 5;
            tab_advanced.Text = "                  ADVANCED                    ";
            tab_advanced.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(btn_logout);
            panel5.Location = new Point(0, 188);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(25, 0, 0, 0);
            panel5.Size = new Size(301, 91);
            panel5.TabIndex = 7;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.FromArgb(92, 124, 137);
            btn_logout.Font = new Font("Georgia", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_logout.ForeColor = Color.White;
            btn_logout.Hoverforecolor1 = Color.FromArgb(1, 20, 37);
            btn_logout.HoverImage1 = Properties.Resources.Lock2;
            btn_logout.Image = Properties.Resources.Lock2;
            btn_logout.ImageAlign = ContentAlignment.MiddleLeft;
            btn_logout.Location = new Point(-23, -35);
            btn_logout.Name = "btn_logout";
            btn_logout.Normalforecolor1 = Color.White;
            btn_logout.NormalImage1 = Properties.Resources.Lock2;
            btn_logout.Padding = new Padding(25, 0, 0, 0);
            btn_logout.Size = new Size(351, 131);
            btn_logout.TabIndex = 7;
            btn_logout.Text = "                      LOGOUT";
            btn_logout.TextAlign = ContentAlignment.MiddleLeft;
            btn_logout.Tooltip1 = null;
            btn_logout.UseVisualStyleBackColor = false;
            // 
            // optionsTransition
            // 
            optionsTransition.Interval = 10;
            optionsTransition.Tick += optionsTransition_Tick;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // gunaAreaDataset1
            // 
            gunaAreaDataset1.BorderColor = Color.Empty;
            gunaAreaDataset1.FillColor = Color.Empty;
            gunaAreaDataset1.Label = "Area1";
            // 
            // homePanel
            // 
            homePanel.Controls.Add(panel7);
            homePanel.Controls.Add(empDetails_panel);
            homePanel.Dock = DockStyle.Fill;
            homePanel.Location = new Point(295, 56);
            homePanel.Name = "homePanel";
            homePanel.Size = new Size(1027, 617);
            homePanel.TabIndex = 10;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(92, 124, 137);
            panel7.Controls.Add(lbl_welcome);
            panel7.Location = new Point(3, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(1272, 151);
            panel7.TabIndex = 0;
            // 
            // lbl_welcome
            // 
            lbl_welcome.AutoSize = true;
            lbl_welcome.Font = new Font("Georgia", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_welcome.ForeColor = Color.White;
            lbl_welcome.Location = new Point(363, 39);
            lbl_welcome.Name = "lbl_welcome";
            lbl_welcome.Size = new Size(267, 51);
            lbl_welcome.TabIndex = 0;
            lbl_welcome.Text = "WELCOME!";
            // 
            // empDetails_panel
            // 
            empDetails_panel.Location = new Point(3, 160);
            empDetails_panel.Name = "empDetails_panel";
            empDetails_panel.Size = new Size(1272, 525);
            empDetails_panel.TabIndex = 1;
            // 
            // attendancePanel
            // 
            attendancePanel.Controls.Add(lbl_attendance);
            attendancePanel.Controls.Add(attendanceData);
            attendancePanel.Controls.Add(panel8);
            attendancePanel.Dock = DockStyle.Fill;
            attendancePanel.Location = new Point(295, 56);
            attendancePanel.Name = "attendancePanel";
            attendancePanel.Size = new Size(1027, 617);
            attendancePanel.TabIndex = 11;
            // 
            // lbl_attendance
            // 
            lbl_attendance.AutoSize = true;
            lbl_attendance.Font = new Font("Georgia", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_attendance.ForeColor = Color.FromArgb(1, 20, 37);
            lbl_attendance.Location = new Point(190, 40);
            lbl_attendance.Name = "lbl_attendance";
            lbl_attendance.Size = new Size(493, 51);
            lbl_attendance.TabIndex = 1;
            lbl_attendance.Text = "Your Attendance Report";
            lbl_attendance.TextAlign = ContentAlignment.TopCenter;
            // 
            // attendanceData
            // 
            attendanceData.AllowUserToAddRows = false;
            attendanceData.AllowUserToDeleteRows = false;
            attendanceData.BackgroundColor = Color.FromArgb(92, 124, 137);
            attendanceData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            attendanceData.Dock = DockStyle.Bottom;
            attendanceData.GridColor = Color.White;
            attendanceData.Location = new Point(0, 170);
            attendanceData.Name = "attendanceData";
            attendanceData.ReadOnly = true;
            attendanceData.RowHeadersWidth = 62;
            attendanceData.Size = new Size(1027, 447);
            attendanceData.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel8.BackColor = Color.FromArgb(1, 20, 37);
            panel8.Location = new Point(0, 40);
            panel8.Name = "panel8";
            panel8.Size = new Size(2111, 51);
            panel8.TabIndex = 3;
            // 
            // salaryPanel
            // 
            salaryPanel.BackColor = Color.FromArgb(1, 20, 37);
            salaryPanel.Controls.Add(SalaryDatagrid);
            salaryPanel.Controls.Add(panel9);
            salaryPanel.Controls.Add(salaryData);
            salaryPanel.Dock = DockStyle.Fill;
            salaryPanel.Location = new Point(295, 56);
            salaryPanel.Name = "salaryPanel";
            salaryPanel.Size = new Size(1027, 617);
            salaryPanel.TabIndex = 12;
            salaryPanel.Visible = false;
            // 
            // SalaryDatagrid
            // 
            SalaryDatagrid.Dock = DockStyle.Fill;
            SalaryDatagrid.Location = new Point(3, 3);
            SalaryDatagrid.Name = "SalaryDatagrid";
            SalaryDatagrid.Size = new Size(1024, 0);
            SalaryDatagrid.TabIndex = 1;
            // 
            // lbl_salary
            // 
            lbl_salary.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_salary.AutoSize = true;
            lbl_salary.BackColor = Color.FromArgb(0, 5, 199, 137);
            lbl_salary.Font = new Font("Georgia", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_salary.ForeColor = Color.FromArgb(31, 73, 89);
            lbl_salary.ImageAlign = ContentAlignment.TopRight;
            lbl_salary.Location = new Point(363, 20);
            lbl_salary.Name = "lbl_salary";
            lbl_salary.Size = new Size(432, 46);
            lbl_salary.TabIndex = 5;
            lbl_salary.Text = "Your Salary Estimation";
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.Controls.Add(lbl_salary);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(3, 9);
            panel9.Name = "panel9";
            panel9.Size = new Size(1021, 96);
            panel9.TabIndex = 6;
            // 
            // salaryData
            // 
            salaryData.Location = new Point(3, 111);
            salaryData.Name = "salaryData";
            salaryData.Size = new Size(1024, 410);
            salaryData.TabIndex = 7;
            // 
            // employee_dashboard
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1322, 673);
            Controls.Add(salaryPanel);
            Controls.Add(attendancePanel);
            Controls.Add(homePanel);
            Controls.Add(sidebar);
            Controls.Add(topbar);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "employee_dashboard";
            Text = "dashboard";
            Load += employee_dashboard_Load;
            topbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btn_menu).EndInit();
            sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            optionsContainer.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            homePanel.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            attendancePanel.ResumeLayout(false);
            attendancePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)attendanceData).EndInit();
            salaryPanel.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sidebar;
        private Panel topbar;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private ReaLTaiizor.Controls.NightButton nightButton1;
        private Panel panel1;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel6;
        private FlowLayoutPanel optionsContainer;
        private PictureBox btn_menu;
        private System.Windows.Forms.Timer optionsTransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private FileSystemWatcher fileSystemWatcher1;
        private button tb_home;
        private button tb_options;
        private button tb_attendance;
        private button btn_logout;
        private button tb_salary;
        private Button tab_advanced;
        private Guna.Charts.WinForms.GunaAreaDataset gunaAreaDataset1;
        private FlowLayoutPanel salaryPanel;
        private FlowLayoutPanel SalaryDatagrid;
        private Panel panel9;
        private Label lbl_salary;
        private Panel attendancePanel;
        private Label lbl_attendance;
        private DataGridView attendanceData;
        private Panel panel8;
        private FlowLayoutPanel homePanel;
        private Panel panel7;
        private Label lbl_welcome;
        private Panel empDetails_panel;
        private Panel salaryData;
    }
}
