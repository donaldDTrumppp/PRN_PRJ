using PRN_PRJ.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PRN_PRJ
{
    public partial class UpdateAccount : Form
    {
        private User LoginUser;
        public UpdateAccount()
        {
            InitializeComponent();
        }
        PRN_PRJContext context = new PRN_PRJContext();


        public UpdateAccount(User user)
        {
            this.LoginUser = user;
            InitializeComponent();
        }

        private void UpdateAccount_Load(object sender, EventArgs e)
        {
            if (LoginUser != null)
            {
                var user = context.Users.FirstOrDefault(u => u.UserId == LoginUser.UserId);
                if (user != null)
                {
                    txtID.Text = user.UserId.ToString();
                    txtUsername.Text = user.Username.ToString();
                    txtFullname.Text = user.FullName.ToString();
                    txtPhone.Text = user.PhoneNumber.ToString();
                    txtAddress.Text = user.Address.ToString();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string fullname = txtFullname.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(fullname) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                User user = context.Users.FirstOrDefault(item => item.UserId == Int32.Parse(txtID.Text));

                if (user != null)
                {
                    user.Username = txtUsername.Text;
                    user.FullName = txtFullname.Text;
                    if (PhoneValidate(txtPhone.Text))
                    {
                        user.PhoneNumber = txtPhone.Text;
                    }
                    else
                    {
                        return;
                    }
                    user.Address = txtAddress.Text;
                    if (context.SaveChanges() > 0)
                    {
                        MessageBox.Show("Save success!");
                        Account a = new Account(user);
                        this.Hide();
                        a.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save Error: " + ex);
            }
        }
        private bool PhoneValidate(string phone)
        {
            string phonePattern = "^[0-9]{10}$";

            if (!Regex.IsMatch(phone, phonePattern))
            {
                MessageBox.Show("Phone Number should be 10 numeric digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtPhone.Text.Length > 10)
            {
                MessageBox.Show("Phone Number should be no more than 10 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Text = txtPhone.Text.Substring(0, 10);
                txtPhone.SelectionStart = txtPhone.Text.Length;
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
