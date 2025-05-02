
namespace Login
{
    public partial class LoginForm : Form
    {
        private bool correct = false;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm f2 = new RegisterForm();
            f2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            if (username == "admin" && password == "admin")
            {
                f2.ShowDialog();
            }
            else
            {
                correct = false;
                MessageBox.Show("Invalid username or password");
            }
        }

        public bool enter()
        {
            if (correct)
                return true;
            else
                return false;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
