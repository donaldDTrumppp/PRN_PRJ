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
using User = PRN_PRJ.Models.User;

namespace PRN_PRJ
{
    public partial class Account : Form
    {
        private User LoginUser;
        public Account()
        {
            InitializeComponent();

        }

        public Account(User user)
        {
            this.LoginUser = user;
            InitializeComponent();
        }

        PRN_PRJContext context = new PRN_PRJContext();
        private void Account_Load(object sender, EventArgs e)
        {
            if (LoginUser != null)
            {
                var user = context.Users.FirstOrDefault(u => u.UserId == LoginUser.UserId);

                if (user != null)
                {
                    lblID.Text = user.UserId.ToString();
                    lblUsername.Text = user.Username;
                    lblFullname.Text = user.FullName;
                    lblPhone.Text = user.PhoneNumber;
                    lblAddress.Text = user.Address;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateAccount ua = new UpdateAccount(LoginUser);
            ua.Show();
            this.Hide();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            ChangePass cp = new ChangePass(LoginUser);
            cp.Show();
            this.Hide();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Home h = new Home(LoginUser);
            this.Hide();
            h.Show();
        }
    }
}
