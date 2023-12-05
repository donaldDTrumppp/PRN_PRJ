using PRN_PRJ.Models;

namespace PRN_PRJ
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        PRN_PRJContext context = new PRN_PRJContext();
        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Username or Email")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Black;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Username or Email";
                txtUser.ForeColor = Color.Silver;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Password")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.Black;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Password";
                txtPass.ForeColor = Color.Silver;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            check(txtUser.Text, txtPass.Text, txtVerify.Text);
        }

        void check(string username, string password, string verifyCode)
        {
            var user = context.Users
                .Where(item => item.Username.Equals(username) &&
                item.Password.Equals(password) && item.VerificationCode.Equals(verifyCode)).FirstOrDefault();
            if (user != null)
            {
                Home h = new Home(user);
                this.Hide();
                h.Show();
            }
            else
            {
                MessageBox.Show("Login failed. Please check your Username, Password, Verification Code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register res = new Register();
            res.Show();
            this.Hide();
        }

        private void txtVerify_Enter(object sender, EventArgs e)
        {
            if (txtVerify.Text == "eg. 123456")
            {
                txtVerify.Text = "";
                txtVerify.ForeColor = Color.Black;
            }
        }

        private void txtVerify_Leave(object sender, EventArgs e)
        {
            if (txtVerify.Text == "")
            {
                txtVerify.Text = "eg. 123456";
                txtVerify.ForeColor = Color.Silver;
            }
        }
    }
}