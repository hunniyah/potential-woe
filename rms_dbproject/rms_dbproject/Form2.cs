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

        

        private void tab_Performance_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            // Close all open forms except the current one
            foreach (Form form in Application.OpenForms)
            {
                if (form != this) // Skip the current form
                {
                    form.Close();
                }
            }

            // Close the current form
            this.Close();
        }
    }
}
