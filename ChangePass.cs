using PRN_PRJ.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN_PRJ
{
    public partial class ChangePass : Form
    {
        private User LoginUser;
        public ChangePass()
        {
            InitializeComponent();
        }
        public ChangePass(User user)
        {
            this.LoginUser = user;
            InitializeComponent();
        }
        PRN_PRJContext context = new PRN_PRJContext();

        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                User user = context.Users.FirstOrDefault(item => item.Username == txtusername.Text);
                if (user != null && user.Password == txtPass.Text)
                {
                    if (txtNewPass.Text == txtComNewPass.Text)
                    {
                        user.Password = txtNewPass.Text;

                        if (context.SaveChanges() > 0)
                        {
                            MessageBox.Show("Password changed successfully!");
                            Login f = new Login();
                            this.Hide();
                            f.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Confirm New Password Wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Old Password Wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Change password error: " + ex.Message);
            }
        }
        private void ChangePass_Load(object sender, EventArgs e)
        {
            if (LoginUser != null)
            {
                var user = context.Users.FirstOrDefault(u => u.UserId == LoginUser.UserId);

                if (user != null)
                {
                    txtusername.Text = user.Username.ToString();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Account a = new Account(LoginUser);
            this.Hide();
            a.Show();
        }
    }
}
