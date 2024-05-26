using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rms_dbproject
{
    public partial class employee_dashboard : Form
    {

        public employee_dashboard()
        {
            InitializeComponent();
        }
        

        private void employee_dashboard_Load(object sender, EventArgs e)
        {

        }

        bool optionsExpand = false;

        private void optionsTransition_Tick(object sender, EventArgs e)
        {
            const int maxHeight = 277; // Maximum height of the options container
            const int minHeight = 91;  // Minimum height of the options container
            const int increment = 10;  // Increment to adjust the height of the options container

            if (!optionsExpand)
            {
                // Expand the options container
                optionsContainer.Height += increment;
                if (optionsContainer.Height >= maxHeight)
                {
                    optionsContainer.Height = maxHeight; // Ensure the height is exactly maxHeight
                    optionsTransition.Stop();
                    optionsExpand = true;
                }
            }
            else
            {
                // Contract the options container
                optionsContainer.Height -= increment;
                if (optionsContainer.Height <= minHeight)
                {
                    optionsContainer.Height = minHeight; // Ensure the height is exactly minHeight
                    optionsTransition.Stop();
                    optionsExpand = false;
                }
            }
        }

        private void tab_options_Click(object sender, EventArgs e)
        {

        }

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 83)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                    panel1.Width = sidebar.Width;
                    panel2.Width = sidebar.Width;
                    panel3.Width = sidebar.Width;
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 295)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                    panel1.Width = sidebar.Width;
                    panel2.Width = sidebar.Width;
                    panel3.Width = sidebar.Width;
                }
            }
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void tb_options_Click(object sender, EventArgs e)
        {
            optionsTransition.Start();
            ShowPanel(optionsPanel);
        }

        private void tb_home_Click(object sender, EventArgs e)
        {
            ShowPanel(homePanel);
        }

        private void tb_attendance_Click(object sender, EventArgs e)
        {
            ShowPanel(attendancePanel);
        }

        private void tb_salary_Click(object sender, EventArgs e)
        {
            ShowPanel(salaryPanel);
        }

        private void ShowPanel(Control panel)
        {
            homePanel.Visible = false;
            attendancePanel.Visible = false;
            salaryPanel.Visible = false;
            optionsPanel.Visible = false;

            panel.Visible = true;
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_attendance_Click(object sender, EventArgs e)
        {

        }

        private void homePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void attendancePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void attendancePanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void empDetails_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
