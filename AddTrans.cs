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
    public partial class AddTrans : Form
    {
        private User LoginUser;
        public AddTrans()
        {
            InitializeComponent();
        }
        PRN_PRJContext context = new PRN_PRJContext();
        public AddTrans(User user)
        {
            this.LoginUser = user;
            InitializeComponent();
        }

        private void AddTrans_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var trans = context.Categories.ToList();
            cbCateName.Items.Clear();
            cbCateName.DataSource = trans;
            cbCateName.DisplayMember = "CategoryName";
            cbCateName.ValueMember = "CategoryID";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Transaction transaction = new Transaction()
                {
                    UserId = LoginUser.UserId,
                    TransactionDate = date.Value,
                    CategoryId = (int)cbCateName.SelectedValue,
                    Amount = decimal.Parse(txtAmount.Text),
                    Description = txtDescription.Text,
                    TransactionType = cbCate.Text
                };
                if (transaction != null)
                {
                    context.Transactions.Add(transaction);
                    if (context.SaveChanges() > 0)
                    {
                        MessageBox.Show("Add Success!");
                        Home h = new Home(LoginUser);
                        this.Hide();
                        h.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add error " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Home h = new Home(LoginUser);
            h.Show();
            this.Hide();
        }
    }
}
