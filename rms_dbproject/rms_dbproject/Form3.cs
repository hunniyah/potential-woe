using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace rms_dbproject
{
    public partial class Form3 : Form
    {
        private bool isViewEmployeesExpanded = false; // Flag to track the panel state
        private System.Windows.Forms.Timer slideTimer; // Timer for the slide animation
        private const int expandedHeight = 200; // Adjust the final height as needed
        private const int slideSpeed = 10; // Adjust the value for smoother or faster animation

        public Form3()
        {
            InitializeComponent();
            showData();
            InitializeViewEmployeesPanel();
            InitializeSlideTimer();
            viewEmp_container.Show();
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
            attendanceDatagrid.DataSource = dataTable2;

            string query3 = "SELECT customer.last_name,customer.first_name, sum(payment.amount) AS totalPaid\r\nFROM payment\r\ninner join customer ON payment.customer_id=customer.customer_id\r\ngroup by customer.last_name, customer.first_name\r\norder by customer.last_name, customer.first_name;";
            DataTable dataTable3 = loaddata(query3);
            viewEmp_datagrid.DataSource = dataTable3;

            string query4 = "select*from staff;\r\nselect* from inventory;\r\nselect* from film;\r\nselect*from film_list;\r\nselect*from rental;";
            DataTable dataTable4 = loaddata(query4);
            viewSupp_datagrid.DataSource = dataTable4;
        }

        private void InitializeViewEmployeesPanel()
        {
            // Set the initial state of the viewEmp_container
            viewEmp_container.Height = 0;
            viewEmp_container.Visible = false;
        }

        private void InitializeSlideTimer()
        {
            viewEmp_transition = new System.Windows.Forms.Timer();
            viewEmp_transition.Interval = 15; // Adjust the interval for smoother or faster animation
            viewEmp_transition.Tick += viewEmp_transition_Tick;
        }

        private void btn_viewEmployees_Click(object sender, EventArgs e)
        {
            isViewEmployeesExpanded = !isViewEmployeesExpanded;
            viewEmp_container.Visible = true;
            viewEmp_transition.Start();
        }

        private void SlideTimer_Tick(object sender, EventArgs e)
        {
            if (isViewEmployeesExpanded)
            {
                if (viewEmp_container.Height < expandedHeight) // Set the final expanded height
                {
                    viewEmp_container.Height += slideSpeed;
                    if (viewEmp_container.Height >= expandedHeight)
                    {
                        viewEmp_transition.Stop();
                        viewEmp_container.Height = expandedHeight;
                    }
                }
            }
            else
            {
                if (viewEmp_container.Height > 0)
                {
                    viewEmp_container.Height -= slideSpeed;
                    if (viewEmp_container.Height <= 0)
                    {
                        viewEmp_transition.Stop();
                        viewEmp_container.Height = 0;
                        viewEmp_container.Visible = false;
                    }
                }
            }
        }




        private void hr_details_Paint(object sender, PaintEventArgs e)
        {
            // Event handler code
        }

        private void viewEmp_datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void attendanceDatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbl_empAtdcRecord_Click(object sender, EventArgs e)
        {

        }

        private void mngEmp_Click(object sender, EventArgs e)
        {

        }

        private void btn_viewEmp_Click(object sender, EventArgs e)
        {

        }

        private void viewEmp_transition_Tick(object sender, EventArgs e)
        {
            viewEmp_transition.Start();
        }

        private void btn__Click(object sender, EventArgs e)
        {

        }

        private void viewEmp_datagrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void viewSupp_datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            addProductForm productForm = new addProductForm();

            // Show the addProductForm
            productForm.Show();
        }

        private void btn_addEmp_Click(object sender, EventArgs e)
        {
            addEmployeeForm employeeForm = new addEmployeeForm();

            // Show the addEmployeeForm
            employeeForm.Show();
        }

        private void btn_addSupp_Click(object sender, EventArgs e)
        {
            addSupplierForm supplierForm = new addSupplierForm();

            // Show the addSupplierForm
            supplierForm.Show();
        }

        private void viewEmp_datagrid_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_addEmp_Click_1(object sender, EventArgs e)
        {
            addEmployeeForm employeeForm = new addEmployeeForm();

            // Show the addEmployeeForm
            employeeForm.Show();
        }

        private void viewEmp_container_Paint(object sender, PaintEventArgs e)
        {
            this.Show();
        }

        private void btn_addSupp_Click_1(object sender, EventArgs e)
        {
            addSupplierForm supplierForm = new addSupplierForm();

            // Show the addSupplierForm
            supplierForm.Show();
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
