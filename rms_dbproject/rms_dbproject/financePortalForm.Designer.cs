
namespace rms_dbproject
{
    partial class financePortalForm
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
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle25 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle26 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle27 = new DataGridViewCellStyle();
            top_bar = new Panel();
            btn_back = new button();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            finance_tabs = new ReaLTaiizor.Controls.AirTabPage();
            Fin_home = new TabPage();
            panel5 = new Panel();
            finPrtl = new Label();
            hr_details = new TableLayoutPanel();
            salaryRprt = new TabPage();
            panel6 = new Panel();
            salaryRprt_datagrid = new ReaLTaiizor.Controls.PoisonDataGridView();
            panel3 = new Panel();
            lbl_salRprt = new Label();
            salesRpt = new TabPage();
            panel2 = new Panel();
            salesRprt_datagrid = new ReaLTaiizor.Controls.PoisonDataGridView();
            panel1 = new Panel();
            lbl_prodsalesRprt = new Label();
            billsReport = new TabPage();
            panel8 = new Panel();
            viewEmp_container = new Panel();
            billsRprt_datagrid = new ReaLTaiizor.Controls.PoisonDataGridView();
            panel4 = new Panel();
            lbl_billsRprt = new Label();
            top_bar.SuspendLayout();
            finance_tabs.SuspendLayout();
            Fin_home.SuspendLayout();
            panel5.SuspendLayout();
            salaryRprt.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)salaryRprt_datagrid).BeginInit();
            panel3.SuspendLayout();
            salesRpt.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)salesRprt_datagrid).BeginInit();
            panel1.SuspendLayout();
            billsReport.SuspendLayout();
            panel8.SuspendLayout();
            viewEmp_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)billsRprt_datagrid).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // top_bar
            // 
            top_bar.BackColor = Color.FromArgb(53, 91, 105);
            top_bar.Controls.Add(btn_back);
            top_bar.Controls.Add(nightControlBox1);
            top_bar.Dock = DockStyle.Top;
            top_bar.Location = new Point(0, 0);
            top_bar.Name = "top_bar";
            top_bar.Size = new Size(1266, 50);
            top_bar.TabIndex = 1;
            top_bar.Paint += top_bar_Paint;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.FromArgb(53, 91, 105);
            btn_back.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_back.ForeColor = Color.White;
            btn_back.Hoverforecolor1 = Color.FromArgb(220, 161, 44);
            btn_back.HoverImage1 = null;
            btn_back.Location = new Point(26, 3);
            btn_back.Name = "btn_back";
            btn_back.Normalforecolor1 = Color.White;
            btn_back.NormalImage1 = null;
            btn_back.Size = new Size(71, 41);
            btn_back.TabIndex = 7;
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
            nightControlBox1.Location = new Point(1127, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 0;
            nightControlBox1.Click += nightControlBox1_Click;
            // 
            // finance_tabs
            // 
            finance_tabs.Alignment = TabAlignment.Left;
            finance_tabs.BaseColor = Color.FromArgb(53, 91, 105);
            finance_tabs.Controls.Add(Fin_home);
            finance_tabs.Controls.Add(salaryRprt);
            finance_tabs.Controls.Add(salesRpt);
            finance_tabs.Controls.Add(billsReport);
            finance_tabs.Dock = DockStyle.Fill;
            finance_tabs.Font = new Font("Georgia", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            finance_tabs.ItemSize = new Size(70, 170);
            finance_tabs.Location = new Point(0, 50);
            finance_tabs.Multiline = true;
            finance_tabs.Name = "finance_tabs";
            finance_tabs.NormalTextColor = Color.White;
            finance_tabs.Padding = new Point(10, 10);
            finance_tabs.SelectedIndex = 0;
            finance_tabs.SelectedTabBackColor = SystemColors.InactiveBorder;
            finance_tabs.SelectedTextColor = Color.FromArgb(220, 161, 44);
            finance_tabs.ShowOuterBorders = false;
            finance_tabs.Size = new Size(1266, 624);
            finance_tabs.SizeMode = TabSizeMode.Fixed;
            finance_tabs.SquareColor = Color.FromArgb(1, 20, 37);
            finance_tabs.TabCursor = Cursors.Hand;
            finance_tabs.TabIndex = 2;
            // 
            // Fin_home
            // 
            Fin_home.BackColor = SystemColors.InactiveBorder;
            Fin_home.Controls.Add(panel5);
            Fin_home.Controls.Add(hr_details);
            Fin_home.Font = new Font("Georgia", 14F);
            Fin_home.Location = new Point(174, 4);
            Fin_home.Name = "Fin_home";
            Fin_home.Padding = new Padding(10);
            Fin_home.Size = new Size(1088, 616);
            Fin_home.TabIndex = 3;
            Fin_home.Text = "Home";
            Fin_home.Click += Fin_home_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(92, 124, 137);
            panel5.Controls.Add(finPrtl);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(10, 10);
            panel5.Name = "panel5";
            panel5.Size = new Size(1068, 78);
            panel5.TabIndex = 6;
            // 
            // finPrtl
            // 
            finPrtl.Anchor = AnchorStyles.None;
            finPrtl.AutoSize = true;
            finPrtl.Font = new Font("Georgia", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            finPrtl.ForeColor = Color.FromArgb(1, 20, 37);
            finPrtl.Location = new Point(422, 21);
            finPrtl.Name = "finPrtl";
            finPrtl.Size = new Size(295, 38);
            finPrtl.TabIndex = 1;
            finPrtl.Text = "FINANCE PORTAL";
            finPrtl.TextAlign = ContentAlignment.TopCenter;
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
            // 
            // salaryRprt
            // 
            salaryRprt.BackColor = SystemColors.InactiveBorder;
            salaryRprt.Controls.Add(panel6);
            salaryRprt.Controls.Add(panel3);
            salaryRprt.Font = new Font("Georgia", 14F);
            salaryRprt.Location = new Point(174, 4);
            salaryRprt.Name = "salaryRprt";
            salaryRprt.Padding = new Padding(10);
            salaryRprt.Size = new Size(1088, 616);
            salaryRprt.TabIndex = 1;
            salaryRprt.Text = "Salary Report";
            // 
            // panel6
            // 
            panel6.Controls.Add(salaryRprt_datagrid);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(10, 98);
            panel6.Name = "panel6";
            panel6.Size = new Size(1068, 508);
            panel6.TabIndex = 5;
            // 
            // salaryRprt_datagrid
            // 
            salaryRprt_datagrid.AllowUserToAddRows = false;
            salaryRprt_datagrid.AllowUserToDeleteRows = false;
            salaryRprt_datagrid.AllowUserToResizeRows = false;
            salaryRprt_datagrid.BackgroundColor = Color.FromArgb(255, 255, 255);
            salaryRprt_datagrid.BorderStyle = BorderStyle.None;
            salaryRprt_datagrid.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            salaryRprt_datagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = Color.FromArgb(31, 73, 89);
            dataGridViewCellStyle19.Font = new Font("Georgia", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle19.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle19.SelectionBackColor = Color.FromArgb(36, 36, 36);
            dataGridViewCellStyle19.SelectionForeColor = Color.White;
            dataGridViewCellStyle19.WrapMode = DataGridViewTriState.True;
            salaryRprt_datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            salaryRprt_datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle20.Font = new Font("Georgia", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle20.ForeColor = Color.FromArgb(36, 36, 36);
            dataGridViewCellStyle20.Padding = new Padding(10);
            dataGridViewCellStyle20.SelectionBackColor = Color.FromArgb(1, 20, 37);
            dataGridViewCellStyle20.SelectionForeColor = Color.White;
            dataGridViewCellStyle20.WrapMode = DataGridViewTriState.False;
            salaryRprt_datagrid.DefaultCellStyle = dataGridViewCellStyle20;
            salaryRprt_datagrid.Dock = DockStyle.Bottom;
            salaryRprt_datagrid.EnableHeadersVisualStyles = false;
            salaryRprt_datagrid.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            salaryRprt_datagrid.GridColor = Color.FromArgb(255, 255, 255);
            salaryRprt_datagrid.Location = new Point(0, 142);
            salaryRprt_datagrid.Name = "salaryRprt_datagrid";
            salaryRprt_datagrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = Color.FromArgb(31, 73, 89);
            dataGridViewCellStyle21.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle21.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle21.Padding = new Padding(1);
            dataGridViewCellStyle21.SelectionBackColor = Color.FromArgb(36, 36, 36);
            dataGridViewCellStyle21.SelectionForeColor = Color.White;
            dataGridViewCellStyle21.WrapMode = DataGridViewTriState.True;
            salaryRprt_datagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            salaryRprt_datagrid.RowHeadersWidth = 70;
            salaryRprt_datagrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            salaryRprt_datagrid.RowTemplate.Height = 50;
            salaryRprt_datagrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            salaryRprt_datagrid.Size = new Size(1068, 366);
            salaryRprt_datagrid.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(92, 124, 137);
            panel3.Controls.Add(lbl_salRprt);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(10, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(1068, 88);
            panel3.TabIndex = 4;
            // 
            // lbl_salRprt
            // 
            lbl_salRprt.Anchor = AnchorStyles.None;
            lbl_salRprt.AutoSize = true;
            lbl_salRprt.Font = new Font("Georgia", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_salRprt.ForeColor = Color.FromArgb(1, 20, 37);
            lbl_salRprt.Location = new Point(314, 24);
            lbl_salRprt.Name = "lbl_salRprt";
            lbl_salRprt.Size = new Size(459, 38);
            lbl_salRprt.TabIndex = 1;
            lbl_salRprt.Text = "EMPLOYEE SALARY REPORT";
            lbl_salRprt.TextAlign = ContentAlignment.TopCenter;
            // 
            // salesRpt
            // 
            salesRpt.BackColor = SystemColors.InactiveBorder;
            salesRpt.Controls.Add(panel2);
            salesRpt.Controls.Add(panel1);
            salesRpt.Font = new Font("Georgia", 14F);
            salesRpt.Location = new Point(174, 4);
            salesRpt.Name = "salesRpt";
            salesRpt.Padding = new Padding(10);
            salesRpt.Size = new Size(1088, 616);
            salesRpt.TabIndex = 2;
            salesRpt.Text = "Sales Report";
            // 
            // panel2
            // 
            panel2.Controls.Add(salesRprt_datagrid);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(10, 91);
            panel2.Name = "panel2";
            panel2.Size = new Size(1068, 515);
            panel2.TabIndex = 4;
            // 
            // salesRprt_datagrid
            // 
            salesRprt_datagrid.AllowUserToAddRows = false;
            salesRprt_datagrid.AllowUserToDeleteRows = false;
            salesRprt_datagrid.AllowUserToResizeRows = false;
            salesRprt_datagrid.BackgroundColor = Color.FromArgb(255, 255, 255);
            salesRprt_datagrid.BorderStyle = BorderStyle.None;
            salesRprt_datagrid.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            salesRprt_datagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = Color.FromArgb(31, 73, 89);
            dataGridViewCellStyle22.Font = new Font("Georgia", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle22.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle22.SelectionBackColor = Color.FromArgb(36, 36, 36);
            dataGridViewCellStyle22.SelectionForeColor = Color.White;
            dataGridViewCellStyle22.WrapMode = DataGridViewTriState.True;
            salesRprt_datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            salesRprt_datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle23.Font = new Font("Georgia", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle23.ForeColor = Color.FromArgb(36, 36, 36);
            dataGridViewCellStyle23.Padding = new Padding(10);
            dataGridViewCellStyle23.SelectionBackColor = Color.FromArgb(1, 20, 37);
            dataGridViewCellStyle23.SelectionForeColor = Color.White;
            dataGridViewCellStyle23.WrapMode = DataGridViewTriState.False;
            salesRprt_datagrid.DefaultCellStyle = dataGridViewCellStyle23;
            salesRprt_datagrid.Dock = DockStyle.Bottom;
            salesRprt_datagrid.EnableHeadersVisualStyles = false;
            salesRprt_datagrid.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            salesRprt_datagrid.GridColor = Color.FromArgb(255, 255, 255);
            salesRprt_datagrid.Location = new Point(0, 89);
            salesRprt_datagrid.Name = "salesRprt_datagrid";
            salesRprt_datagrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = Color.FromArgb(31, 73, 89);
            dataGridViewCellStyle24.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle24.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle24.Padding = new Padding(1);
            dataGridViewCellStyle24.SelectionBackColor = Color.FromArgb(36, 36, 36);
            dataGridViewCellStyle24.SelectionForeColor = Color.White;
            dataGridViewCellStyle24.WrapMode = DataGridViewTriState.True;
            salesRprt_datagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            salesRprt_datagrid.RowHeadersWidth = 70;
            salesRprt_datagrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            salesRprt_datagrid.RowTemplate.Height = 50;
            salesRprt_datagrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            salesRprt_datagrid.Size = new Size(1068, 426);
            salesRprt_datagrid.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(92, 124, 137);
            panel1.Controls.Add(lbl_prodsalesRprt);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(1068, 81);
            panel1.TabIndex = 3;
            // 
            // lbl_prodsalesRprt
            // 
            lbl_prodsalesRprt.AutoSize = true;
            lbl_prodsalesRprt.Font = new Font("Georgia", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_prodsalesRprt.ForeColor = Color.FromArgb(1, 20, 37);
            lbl_prodsalesRprt.Location = new Point(328, 17);
            lbl_prodsalesRprt.Name = "lbl_prodsalesRprt";
            lbl_prodsalesRprt.Size = new Size(414, 38);
            lbl_prodsalesRprt.TabIndex = 1;
            lbl_prodsalesRprt.Text = "PRODUCT SALES REPORT";
            lbl_prodsalesRprt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // billsReport
            // 
            billsReport.BackColor = SystemColors.InactiveBorder;
            billsReport.Controls.Add(panel8);
            billsReport.Controls.Add(panel4);
            billsReport.Font = new Font("Georgia", 14F);
            billsReport.Location = new Point(174, 4);
            billsReport.Name = "billsReport";
            billsReport.Padding = new Padding(10);
            billsReport.Size = new Size(1088, 616);
            billsReport.TabIndex = 0;
            billsReport.Text = "Bills Report";
            // 
            // panel8
            // 
            panel8.Controls.Add(viewEmp_container);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(10, 88);
            panel8.Name = "panel8";
            panel8.Size = new Size(1068, 518);
            panel8.TabIndex = 14;
            // 
            // viewEmp_container
            // 
            viewEmp_container.Controls.Add(billsRprt_datagrid);
            viewEmp_container.Dock = DockStyle.Fill;
            viewEmp_container.Location = new Point(0, 0);
            viewEmp_container.Name = "viewEmp_container";
            viewEmp_container.Size = new Size(1068, 518);
            viewEmp_container.TabIndex = 13;
            // 
            // billsRprt_datagrid
            // 
            billsRprt_datagrid.AllowUserToAddRows = false;
            billsRprt_datagrid.AllowUserToDeleteRows = false;
            billsRprt_datagrid.AllowUserToResizeRows = false;
            billsRprt_datagrid.BackgroundColor = Color.FromArgb(255, 255, 255);
            billsRprt_datagrid.BorderStyle = BorderStyle.None;
            billsRprt_datagrid.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            billsRprt_datagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle25.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = Color.FromArgb(31, 73, 89);
            dataGridViewCellStyle25.Font = new Font("Georgia", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle25.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle25.SelectionBackColor = Color.FromArgb(36, 36, 36);
            dataGridViewCellStyle25.SelectionForeColor = Color.White;
            dataGridViewCellStyle25.WrapMode = DataGridViewTriState.True;
            billsRprt_datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            billsRprt_datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle26.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle26.Font = new Font("Georgia", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle26.ForeColor = Color.FromArgb(36, 36, 36);
            dataGridViewCellStyle26.Padding = new Padding(10);
            dataGridViewCellStyle26.SelectionBackColor = Color.FromArgb(1, 20, 37);
            dataGridViewCellStyle26.SelectionForeColor = Color.White;
            dataGridViewCellStyle26.WrapMode = DataGridViewTriState.False;
            billsRprt_datagrid.DefaultCellStyle = dataGridViewCellStyle26;
            billsRprt_datagrid.Dock = DockStyle.Bottom;
            billsRprt_datagrid.EnableHeadersVisualStyles = false;
            billsRprt_datagrid.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            billsRprt_datagrid.GridColor = Color.FromArgb(255, 255, 255);
            billsRprt_datagrid.Location = new Point(0, 112);
            billsRprt_datagrid.Name = "billsRprt_datagrid";
            billsRprt_datagrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle27.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = Color.FromArgb(31, 73, 89);
            dataGridViewCellStyle27.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle27.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle27.Padding = new Padding(1);
            dataGridViewCellStyle27.SelectionBackColor = Color.FromArgb(36, 36, 36);
            dataGridViewCellStyle27.SelectionForeColor = Color.White;
            dataGridViewCellStyle27.WrapMode = DataGridViewTriState.True;
            billsRprt_datagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            billsRprt_datagrid.RowHeadersWidth = 70;
            billsRprt_datagrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            billsRprt_datagrid.RowTemplate.Height = 50;
            billsRprt_datagrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            billsRprt_datagrid.Size = new Size(1068, 406);
            billsRprt_datagrid.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(92, 124, 137);
            panel4.Controls.Add(lbl_billsRprt);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(10, 10);
            panel4.Name = "panel4";
            panel4.Size = new Size(1068, 78);
            panel4.TabIndex = 5;
            // 
            // lbl_billsRprt
            // 
            lbl_billsRprt.Anchor = AnchorStyles.None;
            lbl_billsRprt.AutoSize = true;
            lbl_billsRprt.Font = new Font("Georgia", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_billsRprt.ForeColor = Color.FromArgb(1, 20, 37);
            lbl_billsRprt.ImageAlign = ContentAlignment.TopCenter;
            lbl_billsRprt.Location = new Point(419, 19);
            lbl_billsRprt.Name = "lbl_billsRprt";
            lbl_billsRprt.Size = new Size(243, 38);
            lbl_billsRprt.TabIndex = 1;
            lbl_billsRprt.Text = "BILLS REPORT";
            lbl_billsRprt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // financePortalForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1266, 674);
            Controls.Add(finance_tabs);
            Controls.Add(top_bar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "financePortalForm";
            Text = "financePortalForm";
            top_bar.ResumeLayout(false);
            finance_tabs.ResumeLayout(false);
            Fin_home.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            salaryRprt.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)salaryRprt_datagrid).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            salesRpt.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)salesRprt_datagrid).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            billsReport.ResumeLayout(false);
            panel8.ResumeLayout(false);
            viewEmp_container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)billsRprt_datagrid).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel top_bar;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private ReaLTaiizor.Controls.AirTabPage finance_tabs;
        private TabPage Fin_home;
        private Panel panel5;
        private Label finPrtl;
        private TableLayoutPanel hr_details;
        private TabPage salaryRprt;
        private ReaLTaiizor.Controls.PoisonDataGridView viewSupp_datagrid;
        private Button btn_viewSupp;
        private Button btn_addSupp;
        private Panel panel3;
        private Label lbl_salRprt;
        private TabPage salesRpt;
        private Panel panel2;
        private ReaLTaiizor.Controls.PoisonDataGridView salesRprt_datagrid;
        private Panel panel1;
        private Label lbl_prodsalesRprt;
        private TabPage billsReport;
        private Panel panel8;
        private Panel viewEmp_container;
        private ReaLTaiizor.Controls.PoisonDataGridView viewEmp_datagrid;
        private Button btn_viewEmp;
        private Button btn_addEmp;
        private Panel panel4;
        private Label lbl_billsRprt;
        private ReaLTaiizor.Controls.PoisonDataGridView billsRprt_datagrid;
        private button btn_back;
        private Panel panel6;
        private ReaLTaiizor.Controls.PoisonDataGridView salaryRprt_datagrid;
    }
}