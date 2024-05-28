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
    public partial class addEmployeeForm : Form
    {
        public addEmployeeForm()
        {
            InitializeComponent();
        }

        private void nightControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
