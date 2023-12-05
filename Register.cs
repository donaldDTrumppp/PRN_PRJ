using Microsoft.VisualBasic.ApplicationServices;
using PRN_PRJ.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PRN_PRJ
{
public partial class Register : Form
{
    public Register()
    {
        InitializeComponent();
    }
    PRN_PRJContext context = new PRN_PRJContext();
    private void btnBack_Click(object sender, EventArgs e)
    {
        Login f = new Login();
        f.Show();
        this.Hide();
    }

    private void btnRes_Click(object sender, EventArgs e)
    {
        try
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string fullname = txtFullName.Text;
            string compass = txtCofPass.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;
            string verify = txtVerify.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(compass) || string.IsNullOrEmpty(fullname) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(verify))
            {
                MessageBox.Show("Missing Information! Please fill up all the information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!PhoneValidate(phone) || !VerificationCodeValidate(verify))
            {
                return;
            }
            string Compass = txtCofPass.Text;
            string Pass = txtPassword.Text;
            if (Pass.Equals(Compass))
            {
                Models.User user = new Models.User()
                {
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                    FullName = txtFullName.Text,
                    PhoneNumber = txtPhone.Text,
                    Address = txtAddress.Text,
                    VerificationCode = txtVerify.Text,
                };

                if (user != null)
                {
                    context.Users.Add(user);
                    if (context.SaveChanges() > 0)
                    {
                        MessageBox.Show("Register Successful!");
                        Login f = new Login();
                        f.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                MessageBox.Show("Passwords do not match. Please confirm your password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        catch (Exception)
        {

            throw;
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

    private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        {
            e.Handled = true;
        }
    }

    private void txtVerify_TextChanged(object sender, EventArgs e)
    {
        if (txtVerify.Text.Length > 6)
        {
            MessageBox.Show("Verification Code is no more than 6 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtVerify.Text = txtVerify.Text.Substring(0, 6);
            txtVerify.SelectionStart = txtVerify.Text.Length;
        }
    }

    private void txtVerify_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        {
            e.Handled = true;
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

    private bool VerificationCodeValidate(string verify)
    {
        string verificationPattern = "^[0-9]{6}$";

        if (!Regex.IsMatch(verify, verificationPattern))
        {
            MessageBox.Show("Verification Code should be 6 numeric digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        return true;
    }
}

}
