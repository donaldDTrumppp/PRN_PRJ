using PRN_PRJ.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN_PRJ
{
    public partial class UpdateTrans : Form
    {
        private User LoginUser;
        private Transaction trans;
        public UpdateTrans()
        {
            InitializeComponent();
        }
        PRN_PRJContext context = new PRN_PRJContext();
        public UpdateTrans(User user, Transaction transaction)
        {
            this.LoginUser = user;
            InitializeComponent();
            txtID.Text = transaction.TransactionId.ToString();
            txtAmount.Text = transaction.Amount.ToString();
            txtDescription.Text = transaction.Description;
            date.Value = transaction.TransactionDate.Value;
            var categories = context.Categories.ToList();
            cbCateName.DataSource = categories;
            cbCateName.DisplayMember = "CategoryName";
            cbCateName.ValueMember = "CategoryID";
            cbCateName.SelectedValue = transaction.CategoryId;
            cbCate.Text = transaction.TransactionType;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Home h = new Home(LoginUser);
            h.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Transaction transaction = context.Transactions.FirstOrDefault(item => item.TransactionId == Int32.Parse(txtID.Text));
                if (transaction != null)
                {
                    transaction.UserId = LoginUser.UserId;
                    transaction.TransactionType = cbCate.Text;
                    transaction.CategoryId = (int)cbCateName.SelectedValue;
                    transaction.TransactionDate = DateTime.Now;
                    transaction.Description = txtDescription.Text;
                    transaction.Amount = decimal.Parse(txtAmount.Text);
                    if (context.SaveChanges() > 0)
                    {
                        MessageBox.Show("Update Success");
                        Home h = new Home(LoginUser);
                        this.Hide();
                        h.Show();
                    }
                }
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Error" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
