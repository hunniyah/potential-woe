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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            employee_dashboard empDashForm = new employee_dashboard();

            // Show the employee_dashboard form
            empDashForm.Show();

            // Close the current form
            this.Close();
        }
    }
}
