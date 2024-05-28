namespace rms_dbproject
{
    partial class Form3
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            top_bar = new Panel();
            btn_back = new button();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            hr_tabs = new ReaLTaiizor.Controls.AirTabPage();
            HRhome = new TabPage();
            panel5 = new Panel();
            hrPrtl = new Label();
            hr_details = new TableLayoutPanel();
            mngEmp = new TabPage();
            panel8 = new Panel();
            viewEmp_container = new Panel();
            viewEmp_datagrid = new ReaLTaiizor.Controls.PoisonDataGridView();
            btn_viewEmp = new Button();
            btn_addEmp = new Button();
            panel4 = new Panel();
            lbl_mngEmp = new Label();
            attdncRecord = new TabPage();
            panel2 = new Panel();
            attendanceDatagrid = new ReaLTaiizor.Controls.PoisonDataGridView();
            panel1 = new Panel();
            lbl_empAtdcRecord = new Label();
            mngSupp = new TabPage();
            panel6 = new Panel();
            pnl_btnsViewAddemp = new Panel();
            panel9 = new Panel();
            viewSupp_container = new Panel();
            viewSupp_datagrid = new ReaLTaiizor.Controls.PoisonDataGridView();
            btn_viewSupp = new Button();
            btn_addSupp = new Button();
            poisonDataGridView2 = new ReaLTaiizor.Controls.PoisonDataGridView();
            panel3 = new Panel();
            lbl_suppList = new Label();
            tabPage1 = new TabPage();
            panel11 = new Panel();
            addProd_header = new Label();
            btn_addProduct = new Button();
            viewEmp_transition = new System.Windows.Forms.Timer(components);
            top_bar.SuspendLayout();
            hr_tabs.SuspendLayout();
            HRhome.SuspendLayout();
            panel5.SuspendLayout();
            mngEmp.SuspendLayout();
            panel8.SuspendLayout();
            viewEmp_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewEmp_datagrid).BeginInit();
            panel4.SuspendLayout();
            attdncRecord.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)attendanceDatagrid).BeginInit();
            panel1.SuspendLayout();
            mngSupp.SuspendLayout();
            panel6.SuspendLayout();
            pnl_btnsViewAddemp.SuspendLayout();
            panel9.SuspendLayout();
            viewSupp_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewSupp_datagrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)poisonDataGridView2).BeginInit();
            panel3.SuspendLayout();
            tabPage1.SuspendLayout();
            panel11.SuspendLayout();
            SuspendLayout();
            // 
            // top_bar
            // 
            top_bar.BackColor = Color.FromArgb(31, 73, 89);
            top_bar.Controls.Add(btn_back);
            top_bar.Controls.Add(nightControlBox1);
            top_bar.Dock = DockStyle.Top;
            top_bar.Location = new Point(0, 0);
            top_bar.Name = "top_bar";
            top_bar.Size = new Size(1319, 55);
            top_bar.TabIndex = 0;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.FromArgb(53, 91, 105);
            btn_back.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_back.ForeColor = Color.White;
            btn_back.Hoverforecolor1 = Color.FromArgb(219, 151, 38);
            btn_back.HoverImage1 = null;
            btn_back.Location = new Point(12, 3);
            btn_back.Name = "btn_back";
            btn_back.Normalforecolor1 = Color.White;
            btn_back.NormalImage1 = null;
            btn_back.Size = new Size(71, 41);
            btn_back.TabIndex = 8;
            btn_back.Text = "<";
            btn_back.Tooltip1 = null;
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            nightControlBox1.Location = new Point(1180, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 0;
            // 
            // hr_tabs
            // 
            hr_tabs.Alignment = TabAlignment.Left;
            hr_tabs.BaseColor = Color.FromArgb(53, 91, 105);
            hr_tabs.Controls.Add(HRhome);
            hr_tabs.Controls.Add(mngEmp);
            hr_tabs.Controls.Add(attdncRecord);
            hr_tabs.Controls.Add(mngSupp);
            hr_tabs.Controls.Add(tabPage1);
            hr_tabs.Dock = DockStyle.Fill;
            hr_tabs.Font = new Font("Georgia", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hr_tabs.ItemSize = new Size(70, 170);
            hr_tabs.Location = new Point(0, 55);
            hr_tabs.Multiline = true;
            hr_tabs.Name = "hr_tabs";
            hr_tabs.NormalTextColor = Color.White;
            hr_tabs.Padding = new Point(10, 10);
            hr_tabs.SelectedIndex = 0;
            hr_tabs.SelectedTabBackColor = SystemColors.InactiveBorder;
            hr_tabs.SelectedTextColor = Color.FromArgb(220, 161, 44);
            hr_tabs.ShowOuterBorders = false;
            hr_tabs.Size = new Size(1319, 771);
            hr_tabs.SizeMode = TabSizeMode.Fixed;
            hr_tabs.SquareColor = Color.FromArgb(1, 20, 37);
            hr_tabs.TabCursor = Cursors.Hand;
            hr_tabs.TabIndex = 1;
            // 
            // HRhome
            // 
            HRhome.BackColor = SystemColors.InactiveBorder;
            HRhome.Controls.Add(panel5);
            HRhome.Controls.Add(hr_details);
            HRhome.Font = new Font("Georgia", 14F);
            HRhome.Location = new Point(174, 4);
            HRhome.Name = "HRhome";
            HRhome.Padding = new Padding(10);
            HRhome.Size = new Size(1141, 763);
            HRhome.TabIndex = 3;
            HRhome.Text = "Home";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(92, 124, 137);
            panel5.Controls.Add(hrPrtl);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(10, 10);
            panel5.Name = "panel5";
            panel5.Size = new Size(1121, 78);
            panel5.TabIndex = 6;
            // 
            // hrPrtl
            // 
            hrPrtl.Anchor = AnchorStyles.None;
            hrPrtl.AutoSize = true;
            hrPrtl.Font = new Font("Georgia", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hrPrtl.ForeColor = Color.FromArgb(1, 20, 37);
            hrPrtl.Location = new Point(440, 21);
            hrPrtl.Name = "hrPrtl";
            hrPrtl.Size = new Size(159, 38);
            hrPrtl.TabIndex = 1;
            hrPrtl.Text = "HR Portal";
            hrPrtl.TextAlign = ContentAlignment.TopCenter;
            // 
            // hr_details
            // 
            hr_details.ColumnCount = 2;
            hr_details.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            hr_details.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            hr_details.Location = new Point(250, 116);
            hr_details.Name = "hr_details";
            hr_details.RowCount = 5;
            hr_details.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            hr_details.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            hr_details.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            hr_details.RowStyles.Add(new RowStyle(SizeType.Absolute, 74F));
            hr_details.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            hr_details.Size = new Size(552, 380);
            hr_details.TabIndex = 0;
            hr_details.Paint += hr_details_Paint;
            // 
            // mngEmp
            // 
            mngEmp.BackColor = SystemColors.InactiveBorder;
            mngEmp.Controls.Add(panel8);
            mngEmp.Controls.Add(panel4);
            mngEmp.Font = new Font("Georgia", 14F);
            mngEmp.Location = new Point(174, 4);
            mngEmp.Name = "mngEmp";
            mngEmp.Padding = new Padding(10);
            mngEmp.Size = new Size(1141, 763);
            mngEmp.TabIndex = 0;
            mngEmp.Text = "Manage Employees";
            mngEmp.Click += mngEmp_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(viewEmp_container);
            panel8.Controls.Add(btn_addEmp);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(10, 88);
            panel8.Name = "panel8";
            panel8.Size = new Size(1121, 665);
            panel8.TabIndex = 14;
            // 
            // viewEmp_container
            // 
            viewEmp_container.Controls.Add(viewEmp_datagrid);
            viewEmp_container.Controls.Add(btn_viewEmp);
            viewEmp_container.Dock = DockStyle.Fill;
            viewEmp_container.Location = new Point(0, 0);
            viewEmp_container.Name = "viewEmp_container";
            viewEmp_container.Size = new Size(1121, 565);
            viewEmp_container.TabIndex = 13;
            viewEmp_container.Paint += viewEmp_container_Paint;
            // 
            // viewEmp_datagrid
            // 
            viewEmp_datagrid.AllowUserToAddRows = false;
            viewEmp_datagrid.AllowUserToDeleteRows = false;
            viewEmp_datagrid.AllowUserToResizeRows = false;
            viewEmp_datagrid.BackgroundColor = Color.FromArgb(255, 255, 255);
            viewEmp_datagrid.BorderStyle = BorderStyle.None;
            viewEmp_datagrid.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            viewEmp_datagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(31, 73, 89);
            dataGridViewCellStyle1.Font = new Font("Georgia", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(36, 36, 36);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            viewEmp_datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            viewEmp_datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Georgia", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(36, 36, 36);
            dataGridViewCellStyle2.Padding = new Padding(10);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(1, 20, 37);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            viewEmp_datagrid.DefaultCellStyle = dataGridViewCellStyle2;
            viewEmp_datagrid.Dock = DockStyle.Fill;
            viewEmp_datagrid.EnableHeadersVisualStyles = false;
            viewEmp_datagrid.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            viewEmp_datagrid.GridColor = Color.FromArgb(255, 255, 255);
            viewEmp_datagrid.Location = new Point(0, 99);
            viewEmp_datagrid.Name = "viewEmp_datagrid";
            viewEmp_datagrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(31, 73, 89);
            dataGridViewCellStyle3.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.Padding = new Padding(1);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(36, 36, 36);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            viewEmp_datagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            viewEmp_datagrid.RowHeadersWidth = 70;
            viewEmp_datagrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            viewEmp_datagrid.RowTemplate.Height = 50;
            viewEmp_datagrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            viewEmp_datagrid.Size = new Size(1121, 466);
            viewEmp_datagrid.TabIndex = 15;
            // 
            // btn_viewEmp
            // 
            btn_viewEmp.BackColor = Color.FromArgb(219, 145, 53);
            btn_viewEmp.Dock = DockStyle.Top;
            btn_viewEmp.Location = new Point(0, 0);
            btn_viewEmp.Name = "btn_viewEmp";
            btn_viewEmp.Size = new Size(1121, 99);
            btn_viewEmp.TabIndex = 14;
            btn_viewEmp.Text = "View Employees";
            btn_viewEmp.UseVisualStyleBackColor = false;
            // 
            // btn_addEmp
            // 
            btn_addEmp.BackColor = Color.FromArgb(219, 145, 53);
            btn_addEmp.Dock = DockStyle.Bottom;
            btn_addEmp.Location = new Point(0, 565);
            btn_addEmp.Name = "btn_addEmp";
            btn_addEmp.Size = new Size(1121, 100);
            btn_addEmp.TabIndex = 10;
            btn_addEmp.Text = "Add Employee";
            btn_addEmp.UseVisualStyleBackColor = false;
            btn_addEmp.Click += btn_addEmp_Click_1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(92, 124, 137);
            panel4.Controls.Add(lbl_mngEmp);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(10, 10);
            panel4.Name = "panel4";
            panel4.Size = new Size(1121, 78);
            panel4.TabIndex = 5;
            // 
            // lbl_mngEmp
            // 
            lbl_mngEmp.Anchor = AnchorStyles.None;
            lbl_mngEmp.AutoSize = true;
            lbl_mngEmp.Font = new Font("Georgia", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_mngEmp.ForeColor = Color.FromArgb(1, 20, 37);
            lbl_mngEmp.ImageAlign = ContentAlignment.TopCenter;
            lbl_mngEmp.Location = new Point(440, 21);
            lbl_mngEmp.Name = "lbl_mngEmp";
            lbl_mngEmp.Size = new Size(290, 38);
            lbl_mngEmp.TabIndex = 1;
            lbl_mngEmp.Text = "Manage Employees";
            lbl_mngEmp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // attdncRecord
            // 
            attdncRecord.BackColor = SystemColors.InactiveBorder;
            attdncRecord.Controls.Add(panel2);
            attdncRecord.Controls.Add(panel1);
            attdncRecord.Font = new Font("Georgia", 14F);
            attdncRecord.Location = new Point(174, 4);
            attdncRecord.Name = "attdncRecord";
            attdncRecord.Padding = new Padding(10);
            attdncRecord.Size = new Size(1141, 763);
            attdncRecord.TabIndex = 2;
            attdncRecord.Text = "Attendance Record";
            // 
            // panel2
            // 
            panel2.Controls.Add(attendanceDatagrid);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(10, 88);
            panel2.Name = "panel2";
            panel2.Size = new Size(1121, 665);
            panel2.TabIndex = 4;
            // 
            // attendanceDatagrid
            // 
            attendanceDatagrid.AllowUserToAddRows = false;
            attendanceDatagrid.AllowUserToDeleteRows = false;
            attendanceDatagrid.AllowUserToResizeRows = false;
            attendanceDatagrid.BackgroundColor = Color.FromArgb(255, 255, 255);
            attendanceDatagrid.BorderStyle = BorderStyle.None;
            attendanceDatagrid.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            attendanceDatagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(31, 73, 89);
            dataGridViewCellStyle4.Font = new Font("Georgia", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(36, 36, 36);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            attendanceDatagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            attendanceDatagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle5.Font = new Font("Georgia", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(36, 36, 36);
            dataGridViewCellStyle5.Padding = new Padding(10);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(1, 20, 37);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            attendanceDatagrid.DefaultCellStyle = dataGridViewCellStyle5;
            attendanceDatagrid.Dock = DockStyle.Fill;
            attendanceDatagrid.EnableHeadersVisualStyles = false;
            attendanceDatagrid.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            attendanceDatagrid.GridColor = Color.FromArgb(255, 255, 255);
            attendanceDatagrid.Location = new Point(0, 0);
            attendanceDatagrid.Name = "attendanceDatagrid";
            attendanceDatagrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(31, 73, 89);
            dataGridViewCellStyle6.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.Padding = new Padding(1);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(36, 36, 36);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            attendanceDatagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            attendanceDatagrid.RowHeadersWidth = 70;
            attendanceDatagrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            attendanceDatagrid.RowTemplate.Height = 50;
            attendanceDatagrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            attendanceDatagrid.Size = new Size(1121, 665);
            attendanceDatagrid.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(92, 124, 137);
            panel1.Controls.Add(lbl_empAtdcRecord);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(1121, 78);
            panel1.TabIndex = 3;
            // 
            // lbl_empAtdcRecord
            // 
            lbl_empAtdcRecord.Anchor = AnchorStyles.None;
            lbl_empAtdcRecord.AutoSize = true;
            lbl_empAtdcRecord.Font = new Font("Georgia", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_empAtdcRecord.ForeColor = Color.FromArgb(1, 20, 37);
            lbl_empAtdcRecord.Location = new Point(328, 17);
            lbl_empAtdcRecord.Name = "lbl_empAtdcRecord";
            lbl_empAtdcRecord.Size = new Size(575, 38);
            lbl_empAtdcRecord.TabIndex = 1;
            lbl_empAtdcRecord.Text = "EMPLOYEES ATTENDANCE REPORT";
            lbl_empAtdcRecord.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mngSupp
            // 
            mngSupp.BackColor = SystemColors.InactiveBorder;
            mngSupp.Controls.Add(panel6);
            mngSupp.Controls.Add(panel3);
            mngSupp.Font = new Font("Georgia", 14F);
            mngSupp.Location = new Point(174, 4);
            mngSupp.Name = "mngSupp";
            mngSupp.Padding = new Padding(10);
            mngSupp.Size = new Size(1141, 763);
            mngSupp.TabIndex = 1;
            mngSupp.Text = "Manage Suppliers";
            // 
            // panel6
            // 
            panel6.Controls.Add(pnl_btnsViewAddemp);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(10, 104);
            panel6.Name = "panel6";
            panel6.Size = new Size(1121, 649);
            panel6.TabIndex = 7;
            // 
            // pnl_btnsViewAddemp
            // 
            pnl_btnsViewAddemp.Controls.Add(panel9);
            pnl_btnsViewAddemp.Controls.Add(poisonDataGridView2);
            pnl_btnsViewAddemp.Dock = DockStyle.Fill;
            pnl_btnsViewAddemp.Location = new Point(0, 0);
            pnl_btnsViewAddemp.Name = "pnl_btnsViewAddemp";
            pnl_btnsViewAddemp.Size = new Size(1121, 649);
            pnl_btnsViewAddemp.TabIndex = 8;
            // 
            // panel9
            // 
            panel9.Controls.Add(viewSupp_container);
            panel9.Controls.Add(btn_addSupp);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(1121, 649);
            panel9.TabIndex = 14;
            // 
            // viewSupp_container
            // 
            viewSupp_container.Controls.Add(viewSupp_datagrid);
            viewSupp_container.Controls.Add(btn_viewSupp);
            viewSupp_container.Dock = DockStyle.Fill;
            viewSupp_container.Location = new Point(0, 0);
            viewSupp_container.Name = "viewSupp_container";
            viewSupp_container.Size = new Size(1121, 550);
            viewSupp_container.TabIndex = 7;
            // 
            // viewSupp_datagrid
            // 
            viewSupp_datagrid.AllowUserToAddRows = false;
            viewSupp_datagrid.AllowUserToDeleteRows = false;
            viewSupp_datagrid.AllowUserToResizeRows = false;
            viewSupp_datagrid.BackgroundColor = Color.FromArgb(255, 255, 255);
            viewSupp_datagrid.BorderStyle = BorderStyle.None;
            viewSupp_datagrid.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            viewSupp_datagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(31, 73, 89);
            dataGridViewCellStyle7.Font = new Font("Georgia", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(36, 36, 36);
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            viewSupp_datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            viewSupp_datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle8.Font = new Font("Georgia", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(36, 36, 36);
            dataGridViewCellStyle8.Padding = new Padding(10);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(1, 20, 37);
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            viewSupp_datagrid.DefaultCellStyle = dataGridViewCellStyle8;
            viewSupp_datagrid.Dock = DockStyle.Fill;
            viewSupp_datagrid.EnableHeadersVisualStyles = false;
            viewSupp_datagrid.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            viewSupp_datagrid.GridColor = Color.FromArgb(255, 255, 255);
            viewSupp_datagrid.Location = new Point(0, 99);
            viewSupp_datagrid.Name = "viewSupp_datagrid";
            viewSupp_datagrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(31, 73, 89);
            dataGridViewCellStyle9.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle9.Padding = new Padding(1);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(36, 36, 36);
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            viewSupp_datagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            viewSupp_datagrid.RowHeadersWidth = 70;
            viewSupp_datagrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            viewSupp_datagrid.RowTemplate.Height = 50;
            viewSupp_datagrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            viewSupp_datagrid.Size = new Size(1121, 451);
            viewSupp_datagrid.TabIndex = 14;
            // 
            // btn_viewSupp
            // 
            btn_viewSupp.BackColor = Color.FromArgb(219, 145, 53);
            btn_viewSupp.Dock = DockStyle.Top;
            btn_viewSupp.Location = new Point(0, 0);
            btn_viewSupp.Name = "btn_viewSupp";
            btn_viewSupp.Size = new Size(1121, 99);
            btn_viewSupp.TabIndex = 13;
            btn_viewSupp.Text = "View Suppliers";
            btn_viewSupp.UseVisualStyleBackColor = false;
            // 
            // btn_addSupp
            // 
            btn_addSupp.BackColor = Color.FromArgb(219, 145, 53);
            btn_addSupp.Dock = DockStyle.Bottom;
            btn_addSupp.Location = new Point(0, 550);
            btn_addSupp.Name = "btn_addSupp";
            btn_addSupp.Size = new Size(1121, 99);
            btn_addSupp.TabIndex = 10;
            btn_addSupp.Text = "Add Supplier";
            btn_addSupp.UseVisualStyleBackColor = false;
            btn_addSupp.Click += btn_addSupp_Click_1;
            // 
            // poisonDataGridView2
            // 
            poisonDataGridView2.AllowUserToAddRows = false;
            poisonDataGridView2.AllowUserToDeleteRows = false;
            poisonDataGridView2.AllowUserToResizeRows = false;
            poisonDataGridView2.BackgroundColor = Color.FromArgb(255, 255, 255);
            poisonDataGridView2.BorderStyle = BorderStyle.None;
            poisonDataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            poisonDataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(31, 73, 89);
            dataGridViewCellStyle10.Font = new Font("Georgia", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(36, 36, 36);
            dataGridViewCellStyle10.SelectionForeColor = Color.White;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            poisonDataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            poisonDataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle11.Font = new Font("Georgia", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle11.ForeColor = Color.FromArgb(36, 36, 36);
            dataGridViewCellStyle11.Padding = new Padding(10);
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(1, 20, 37);
            dataGridViewCellStyle11.SelectionForeColor = Color.White;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            poisonDataGridView2.DefaultCellStyle = dataGridViewCellStyle11;
            poisonDataGridView2.Dock = DockStyle.Fill;
            poisonDataGridView2.EnableHeadersVisualStyles = false;
            poisonDataGridView2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            poisonDataGridView2.GridColor = Color.FromArgb(255, 255, 255);
            poisonDataGridView2.Location = new Point(0, 0);
            poisonDataGridView2.Name = "poisonDataGridView2";
            poisonDataGridView2.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(31, 73, 89);
            dataGridViewCellStyle12.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle12.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle12.Padding = new Padding(1);
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(36, 36, 36);
            dataGridViewCellStyle12.SelectionForeColor = Color.White;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            poisonDataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            poisonDataGridView2.RowHeadersWidth = 70;
            poisonDataGridView2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            poisonDataGridView2.RowTemplate.Height = 50;
            poisonDataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            poisonDataGridView2.Size = new Size(1121, 649);
            poisonDataGridView2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(92, 124, 137);
            panel3.Controls.Add(lbl_suppList);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(10, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(1121, 94);
            panel3.TabIndex = 4;
            // 
            // lbl_suppList
            // 
            lbl_suppList.Anchor = AnchorStyles.None;
            lbl_suppList.AutoSize = true;
            lbl_suppList.Font = new Font("Georgia", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_suppList.ForeColor = Color.FromArgb(1, 20, 37);
            lbl_suppList.Location = new Point(440, 21);
            lbl_suppList.Name = "lbl_suppList";
            lbl_suppList.Size = new Size(270, 38);
            lbl_suppList.TabIndex = 1;
            lbl_suppList.Text = "Manage Suppliers";
            lbl_suppList.TextAlign = ContentAlignment.TopCenter;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.InactiveBorder;
            tabPage1.Controls.Add(panel11);
            tabPage1.Controls.Add(btn_addProduct);
            tabPage1.Location = new Point(174, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1141, 763);
            tabPage1.TabIndex = 4;
            tabPage1.Text = "Add Product";
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(92, 124, 137);
            panel11.Controls.Add(addProd_header);
            panel11.Dock = DockStyle.Top;
            panel11.Location = new Point(3, 3);
            panel11.Name = "panel11";
            panel11.Size = new Size(1135, 78);
            panel11.TabIndex = 15;
            // 
            // addProd_header
            // 
            addProd_header.Anchor = AnchorStyles.None;
            addProd_header.AutoSize = true;
            addProd_header.Font = new Font("Georgia", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addProd_header.ForeColor = Color.FromArgb(1, 20, 37);
            addProd_header.Location = new Point(440, 21);
            addProd_header.Name = "addProd_header";
            addProd_header.Size = new Size(291, 38);
            addProd_header.TabIndex = 1;
            addProd_header.Text = "Add a New Product";
            addProd_header.TextAlign = ContentAlignment.TopCenter;
            // 
            // btn_addProduct
            // 
            btn_addProduct.Anchor = AnchorStyles.None;
            btn_addProduct.BackColor = Color.FromArgb(219, 145, 53);
            btn_addProduct.FlatStyle = FlatStyle.Flat;
            btn_addProduct.Location = new Point(411, 233);
            btn_addProduct.Name = "btn_addProduct";
            btn_addProduct.Size = new Size(354, 82);
            btn_addProduct.TabIndex = 14;
            btn_addProduct.Text = "Add ";
            btn_addProduct.UseVisualStyleBackColor = false;
            btn_addProduct.Click += btn_addProduct_Click;
            // 
            // viewEmp_transition
            // 
            viewEmp_transition.Interval = 10;
            viewEmp_transition.Tick += viewEmp_transition_Tick;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1319, 826);
            Controls.Add(hr_tabs);
            Controls.Add(top_bar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            Text = "Form3";
            top_bar.ResumeLayout(false);
            hr_tabs.ResumeLayout(false);
            HRhome.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            mngEmp.ResumeLayout(false);
            panel8.ResumeLayout(false);
            viewEmp_container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)viewEmp_datagrid).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            attdncRecord.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)attendanceDatagrid).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            mngSupp.ResumeLayout(false);
            panel6.ResumeLayout(false);
            pnl_btnsViewAddemp.ResumeLayout(false);
            panel9.ResumeLayout(false);
            viewSupp_container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)viewSupp_datagrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)poisonDataGridView2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tabPage1.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel salaryPanel;
        private FlowLayoutPanel SalaryDatagrid;
        private Label lbl_salary;
        private Panel salaryData;
        private ReaLTaiizor.Controls.ParrotLineGraph salaryGraph;
        private Label lbl_salAmount;
        private Label lbl_salDate;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel2;
        private ReaLTaiizor.Controls.ParrotLineGraph parrotLineGraph1;
        private Label label2;
        private Label label3;
        private Panel top_bar;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private ReaLTaiizor.Controls.AirTabPage hr_tabs;
        private TabPage HRhome;
        private TabPage mngEmp;
        private TabPage mngSupp;
        private TabPage attdncRecord;
        private TableLayoutPanel hr_details;
        private Panel panel1;
        private Label lbl_empAtdcRecord;
        private ReaLTaiizor.Controls.PoisonDataGridView attendanceDatagrid;
        private Panel panel3;
        private Label lbl_suppList;
        private TabPage tabPage1;
        private Panel panel5;
        private Label hrPrtl;
        private Panel panel4;
        private Label lbl_mngEmp;
        private System.Windows.Forms.Timer viewEmp_transition;
        private Panel panel11;
        private Label addProd_header;
        private Button btn_addProduct;
        private Panel panel8;
        private Button btn_addEmp;
        private Panel panel6;
        private Panel pnl_btnsViewAddemp;
        private Panel panel9;
        private Panel viewSupp_container;
        private ReaLTaiizor.Controls.PoisonDataGridView viewSupp_datagrid;
        private Button btn_viewSupp;
        private Button btn_addSupp;
        private ReaLTaiizor.Controls.PoisonDataGridView poisonDataGridView2;
        private Panel viewEmp_container;
        private ReaLTaiizor.Controls.PoisonDataGridView viewEmp_datagrid;
        private Button btn_viewEmp;
        private button btn_back;
    }
}