using Intersoft.Crosslight.UI.DataVisualization;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace rms_dbproject
{
    public partial class financePortalForm : Form
    {
        

        public financePortalForm()
        {
            InitializeComponent();
          


            showData();
        }


      


        private DataTable loaddata(string query)
        {
            string connectionstring = "server=localhost;uid=root;pwd=Sehar32022;database=sakila";
            MySqlConnection con = new MySqlConnection(connectionstring);
            con.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            con.Close();
            return dataTable;
        }

        private void showData()
        {
            string query2 = "select * from customer; select * from payment; select * from film_actor; select * from country; select * from store; select * from address; select * from city;";
            DataTable dataTable2 = loaddata(query2);
            salaryRprt_datagrid.DataSource = dataTable2;

            string query3 = "SELECT customer.last_name, customer.first_name, sum(payment.amount) AS totalPaid FROM payment INNER JOIN customer ON payment.customer_id=customer.customer_id GROUP BY customer.last_name, customer.first_name ORDER BY customer.last_name, customer.first_name;";
            DataTable dataTable3 = loaddata(query3);
            salesRprt_datagrid.DataSource = dataTable3;

            // Add data to the chart (Example)
            

            string query4 = "select * from staff; select * from inventory; select * from film; select * from film_list; select * from rental;";
            DataTable dataTable4 = loaddata(query4);
            billsRprt_datagrid.DataSource = dataTable4;
        }

        private void top_bar_Paint(object sender, PaintEventArgs e)
        {
            // Paint event handler for top bar
        }

        private void nightControlBox1_Click(object sender, EventArgs e)
        {
            // Event handler for nightControlBox1 click
        }

        private void Fin_home_Click(object sender, EventArgs e)
        {
            // Event handler for Fin_home click
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
