using Microsoft.VisualBasic.ApplicationServices;
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
using User = PRN_PRJ.Models.User;

namespace PRN_PRJ
{
    public partial class General : Form
    {
        private User LoginUser;
        public General()
        {
            InitializeComponent();
        }
        PRN_PRJContext context = new PRN_PRJContext();
        public General(User user)
        {
            this.LoginUser = user;

            InitializeComponent();
        }

        private void txtMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void General_Load(object sender, EventArgs e)
        {

        }

        private void LoadGen(int month, int year)
        {



            List<Transaction> transactions = context.Transactions.Where(x => x.UserId == LoginUser.UserId).ToList();
            foreach (var transaction in transactions)
            {
                var Amount = transaction.Amount;
            }
            decimal Amounts = (decimal)transactions.Where(x => x.TransactionType == "INC").Sum(x => x.Amount);
            lblThu.Text = Amounts.ToString();
            foreach (var transaction in transactions)
            {
                var thu = transaction.Amount;
            }
            decimal chi = (decimal)transactions.Where(x => x.TransactionType == "EXS").Sum(x => x.Amount);
            lblChi.Text = Amounts.ToString();

        }

        private bool MonthValidate(string month)
        {
            string monthPattern = "^[0-9]{2}$";

            if (!Regex.IsMatch(month, monthPattern))
            {
                MessageBox.Show("The Month should be from 1-12.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }




        private bool PhoneValidate(string year)
        {
            string yearPattern = "^[0-9]{4}$";

            if (!Regex.IsMatch(year, yearPattern))
            {
                MessageBox.Show("Year Invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnTrans_Click(object sender, EventArgs e)
        {
            this.Close();
            Home h = new Home(LoginUser);
            h.Show();
        }

        private void btnCate_Click(object sender, EventArgs e)
        {
            Categories c = new Categories(LoginUser);
            this.Close();
            c.Show();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            Account a = new Account(LoginUser);
            this.Hide();
            a.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {

            var data = (from items in context.Transactions
                        where items.User.UserId == LoginUser.UserId
                        && items.TransactionDate.Value.Month.Equals(cbbMonth.SelectedItem)
                        && items.TransactionDate.Value.Year.Equals(cbbYear.SelectedItem)
                        select new
                        {
                            TransactionId = items.TransactionId,
                            TransactionDate = items.TransactionDate,
                            CategoryName = items.Category.CategoryName,
                            Amount = items.Amount,
                            Description = items.Description,
                            TransactionType = items.TransactionType,
                        }
            ).ToList();
            if (data.Count == 0)
            {
                dgView.DataSource = null;
                MessageBox.Show("There are not Transactions at this time" + cbbMonth.SelectedItem + " " + cbbYear.SelectedItem);
            }
            else
            {
                dgView.DataSource = data;
            }

            decimal totalIncome = 0;
            decimal totalExpense = 0;

            foreach (var transaction in data)
            {
                if (transaction.TransactionType == "INC")
                {
                    totalIncome += decimal.Parse(transaction.Amount.ToString());
                }
                else if (transaction.TransactionType == "EXP")
                {
                    totalExpense += decimal.Parse(transaction.Amount.ToString());
                }
            }

            lblThu.Text = totalIncome.ToString();
            lblChi.Text = totalExpense.ToString();
        }
    }
}
