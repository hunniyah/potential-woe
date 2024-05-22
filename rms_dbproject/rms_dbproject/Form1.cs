namespace rms_dbproject
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void tb_accountant_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            employee_dashboard empdash = new employee_dashboard();

            // Show the dashboard form
            empdash.Show();

            // Hide the login form
            this.Hide();
        }
    }
}
