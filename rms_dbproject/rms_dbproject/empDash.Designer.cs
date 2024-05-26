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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employee_dashboard));
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
            homePanel = new FlowLayoutPanel();
            panel7 = new Panel();
            lbl_welcome = new Label();
            empDetails_panel = new Panel();
            lbl_phoneNo = new Label();
            lbl_startDate = new Label();
            lbl_empEmail = new Label();
            lbl_empPosition = new Label();
            lbl_empName = new Label();
            attendancePanel = new Panel();
            attendanceData = new Panel();
            atdncGraph = new ReaLTaiizor.Controls.ParrotBarGraph();
            attendanceTable = new TableLayoutPanel();
            lbl_attendance = new Label();
            panel8 = new Panel();
            salaryPanel = new FlowLayoutPanel();
            SalaryDatagrid = new FlowLayoutPanel();
            panel9 = new Panel();
            lbl_salary = new Label();
            salaryData = new Panel();
            salaryGraph = new ReaLTaiizor.Controls.ParrotLineGraph();
            lbl_salAmount = new Label();
            lbl_salDate = new Label();
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
            empDetails_panel.SuspendLayout();
            attendancePanel.SuspendLayout();
            attendanceData.SuspendLayout();
            salaryPanel.SuspendLayout();
            panel9.SuspendLayout();
            salaryData.SuspendLayout();
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
            sidebar.Size = new Size(295, 686);
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
            // homePanel
            // 
            homePanel.Controls.Add(panel7);
            homePanel.Controls.Add(empDetails_panel);
            homePanel.Dock = DockStyle.Fill;
            homePanel.Location = new Point(295, 56);
            homePanel.Name = "homePanel";
            homePanel.Size = new Size(1027, 686);
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
            lbl_welcome.Click += lbl_welcome_Click;
            // 
            // empDetails_panel
            // 
            empDetails_panel.Controls.Add(lbl_phoneNo);
            empDetails_panel.Controls.Add(lbl_startDate);
            empDetails_panel.Controls.Add(lbl_empEmail);
            empDetails_panel.Controls.Add(lbl_empPosition);
            empDetails_panel.Controls.Add(lbl_empName);
            empDetails_panel.Location = new Point(3, 160);
            empDetails_panel.Name = "empDetails_panel";
            empDetails_panel.Size = new Size(1272, 525);
            empDetails_panel.TabIndex = 1;
            empDetails_panel.Paint += empDetails_panel_Paint_1;
            // 
            // lbl_phoneNo
            // 
            lbl_phoneNo.AutoSize = true;
            lbl_phoneNo.BackColor = Color.Transparent;
            lbl_phoneNo.Font = new Font("Georgia", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_phoneNo.ForeColor = Color.Black;
            lbl_phoneNo.Location = new Point(126, 405);
            lbl_phoneNo.Name = "lbl_phoneNo";
            lbl_phoneNo.Size = new Size(172, 32);
            lbl_phoneNo.TabIndex = 6;
            lbl_phoneNo.Text = "PHONE NO:";
            lbl_phoneNo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_startDate
            // 
            lbl_startDate.AutoSize = true;
            lbl_startDate.BackColor = Color.Transparent;
            lbl_startDate.Font = new Font("Georgia", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_startDate.ForeColor = Color.Black;
            lbl_startDate.Location = new Point(126, 231);
            lbl_startDate.Name = "lbl_startDate";
            lbl_startDate.Size = new Size(130, 32);
            lbl_startDate.TabIndex = 5;
            lbl_startDate.Text = "JOINED:";
            lbl_startDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_empEmail
            // 
            lbl_empEmail.AutoSize = true;
            lbl_empEmail.BackColor = Color.Transparent;
            lbl_empEmail.Font = new Font("Georgia", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_empEmail.ForeColor = Color.Black;
            lbl_empEmail.Location = new Point(126, 322);
            lbl_empEmail.Name = "lbl_empEmail";
            lbl_empEmail.Size = new Size(114, 32);
            lbl_empEmail.TabIndex = 4;
            lbl_empEmail.Text = "EMAIL:";
            lbl_empEmail.TextAlign = ContentAlignment.MiddleCenter;
            lbl_empEmail.Click += lbl_empEmail_Click;
            // 
            // lbl_empPosition
            // 
            lbl_empPosition.AutoSize = true;
            lbl_empPosition.BackColor = Color.Transparent;
            lbl_empPosition.Font = new Font("Georgia", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_empPosition.ForeColor = Color.Black;
            lbl_empPosition.Location = new Point(126, 146);
            lbl_empPosition.Name = "lbl_empPosition";
            lbl_empPosition.Size = new Size(158, 32);
            lbl_empPosition.TabIndex = 2;
            lbl_empPosition.Text = "POSITION:";
            lbl_empPosition.TextAlign = ContentAlignment.MiddleCenter;
            lbl_empPosition.Click += lbl_empPosition_Click;
            // 
            // lbl_empName
            // 
            lbl_empName.AutoSize = true;
            lbl_empName.BackColor = Color.Transparent;
            lbl_empName.Font = new Font("Georgia", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_empName.ForeColor = Color.Black;
            lbl_empName.Location = new Point(126, 57);
            lbl_empName.Name = "lbl_empName";
            lbl_empName.Size = new Size(107, 32);
            lbl_empName.TabIndex = 1;
            lbl_empName.Text = "NAME:";
            lbl_empName.TextAlign = ContentAlignment.MiddleCenter;
            lbl_empName.Click += lbl_empName_Click;
            // 
            // attendancePanel
            // 
            attendancePanel.Controls.Add(attendanceData);
            attendancePanel.Controls.Add(lbl_attendance);
            attendancePanel.Controls.Add(panel8);
            attendancePanel.Dock = DockStyle.Fill;
            attendancePanel.Location = new Point(295, 56);
            attendancePanel.Name = "attendancePanel";
            attendancePanel.Size = new Size(1027, 686);
            attendancePanel.TabIndex = 17;
            // 
            // attendanceData
            // 
            attendanceData.Controls.Add(atdncGraph);
            attendanceData.Controls.Add(attendanceTable);
            attendanceData.Dock = DockStyle.Bottom;
            attendanceData.Location = new Point(0, 172);
            attendanceData.Name = "attendanceData";
            attendanceData.Size = new Size(1027, 514);
            attendanceData.TabIndex = 4;
            // 
            // atdncGraph
            // 
            atdncGraph.FilledColor = Color.White;
            atdncGraph.GraphOrientation = ReaLTaiizor.Controls.ParrotBarGraph.Orientation.Vertical;
            atdncGraph.GraphStyle = ReaLTaiizor.Controls.ParrotBarGraph.Style.Material;
            atdncGraph.Items = (List<int>)resources.GetObject("atdncGraph.Items");
            atdncGraph.Location = new Point(480, 127);
            atdncGraph.Name = "atdncGraph";
            atdncGraph.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            atdncGraph.ShowGrid = false;
            atdncGraph.Size = new Size(510, 300);
            atdncGraph.Sorting = ReaLTaiizor.Controls.ParrotBarGraph.SortStyle.Normal;
            atdncGraph.SplitterColor = Color.FromArgb(59, 62, 71);
            atdncGraph.TabIndex = 1;
            atdncGraph.Text = "attendance Graph";
            atdncGraph.TextAlignment = ReaLTaiizor.Controls.ParrotBarGraph.Aligning.Far;
            atdncGraph.TextColor = Color.FromArgb(120, 120, 120);
            atdncGraph.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            atdncGraph.UnfilledColor = Color.White;
            // 
            // attendanceTable
            // 
            attendanceTable.ColumnCount = 2;
            attendanceTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 214F));
            attendanceTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            attendanceTable.Dock = DockStyle.Left;
            attendanceTable.Location = new Point(0, 0);
            attendanceTable.Name = "attendanceTable";
            attendanceTable.RowCount = 7;
            attendanceTable.RowStyles.Add(new RowStyle(SizeType.Percent, 48.45361F));
            attendanceTable.RowStyles.Add(new RowStyle(SizeType.Percent, 51.54639F));
            attendanceTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));
            attendanceTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            attendanceTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            attendanceTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 76F));
            attendanceTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 103F));
            attendanceTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            attendanceTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 86F));
            attendanceTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            attendanceTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            attendanceTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            attendanceTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            attendanceTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            attendanceTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            attendanceTable.Size = new Size(438, 514);
            attendanceTable.TabIndex = 0;
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
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel8.BackColor = Color.FromArgb(1, 20, 37);
            panel8.Location = new Point(0, 40);
            panel8.Name = "panel8";
            panel8.Size = new Size(5939, 51);
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
            salaryPanel.Size = new Size(1027, 686);
            salaryPanel.TabIndex = 18;
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
            lbl_salary.TextAlign = ContentAlignment.TopCenter;
            // 
            // salaryData
            // 
            salaryData.Controls.Add(salaryGraph);
            salaryData.Controls.Add(lbl_salAmount);
            salaryData.Controls.Add(lbl_salDate);
            salaryData.Location = new Point(3, 111);
            salaryData.Name = "salaryData";
            salaryData.Size = new Size(1119, 486);
            salaryData.TabIndex = 7;
            // 
            // salaryGraph
            // 
            salaryGraph.BackGroundColor = Color.FromArgb(102, 217, 174);
            salaryGraph.BelowLineColor = Color.FromArgb(24, 202, 142);
            salaryGraph.BorderColor = Color.White;
            salaryGraph.GraphStyle = ReaLTaiizor.Controls.ParrotLineGraph.Style.Material;
            salaryGraph.GraphTitle = "Salary Graph";
            salaryGraph.GraphTitleColor = Color.Gray;
            salaryGraph.Items = (List<int>)resources.GetObject("salaryGraph.Items");
            salaryGraph.LineColor = Color.White;
            salaryGraph.Location = new Point(274, 280);
            salaryGraph.Name = "salaryGraph";
            salaryGraph.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            salaryGraph.PointSize = 7;
            salaryGraph.ShowBorder = false;
            salaryGraph.ShowPoints = true;
            salaryGraph.ShowTitle = false;
            salaryGraph.ShowVerticalLines = false;
            salaryGraph.Size = new Size(521, 187);
            salaryGraph.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            salaryGraph.TabIndex = 2;
            salaryGraph.Text = "Salary Graph";
            salaryGraph.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            salaryGraph.TitleAlignment = StringAlignment.Near;
            salaryGraph.VerticalLineColor = Color.DimGray;
            // 
            // lbl_salAmount
            // 
            lbl_salAmount.AutoSize = true;
            lbl_salAmount.Font = new Font("Georgia", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_salAmount.ForeColor = Color.White;
            lbl_salAmount.Location = new Point(669, 42);
            lbl_salAmount.Name = "lbl_salAmount";
            lbl_salAmount.Size = new Size(126, 32);
            lbl_salAmount.TabIndex = 1;
            lbl_salAmount.Text = "Amount:";
            lbl_salAmount.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl_salDate
            // 
            lbl_salDate.AutoSize = true;
            lbl_salDate.Font = new Font("Georgia", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_salDate.ForeColor = Color.White;
            lbl_salDate.Location = new Point(274, 42);
            lbl_salDate.Name = "lbl_salDate";
            lbl_salDate.Size = new Size(82, 32);
            lbl_salDate.TabIndex = 0;
            lbl_salDate.Text = "Date:";
            lbl_salDate.TextAlign = ContentAlignment.TopCenter;
            // 
            // employee_dashboard
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1322, 742);
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
            empDetails_panel.ResumeLayout(false);
            empDetails_panel.PerformLayout();
            attendancePanel.ResumeLayout(false);
            attendancePanel.PerformLayout();
            attendanceData.ResumeLayout(false);
            salaryPanel.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            salaryData.ResumeLayout(false);
            salaryData.PerformLayout();
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
        private FlowLayoutPanel homePanel;
        private Panel panel7;
        private Label lbl_welcome;
        private Panel empDetails_panel;
        private Label label4;
        private Label label2;
        private Label lbl_empPosition;
        private Label lbl_empName;
        private Panel attendancePanel;
        private Panel attendanceData;
        private ReaLTaiizor.Controls.ParrotBarGraph atdncGraph;
        private TableLayoutPanel attendanceTable;
        private Label lbl_attendance;
        private Panel panel8;
        private FlowLayoutPanel salaryPanel;
        private FlowLayoutPanel SalaryDatagrid;
        private Panel panel9;
        private Label lbl_salary;
        private Panel salaryData;
        private ReaLTaiizor.Controls.ParrotLineGraph salaryGraph;
        private Label lbl_salAmount;
        private Label lbl_salDate;
        private Label label3;
        private Label lbl_startDate;
        private Label lbl_empEmail;
        private Label label1;
        private Label lbl_phoneNo;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel10;
        private ReaLTaiizor.Controls.ParrotLineGraph parrotLineGraph1;
    }
}
