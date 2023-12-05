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
    public partial class Home : Form
    {
        private User LoginUser;
        private Transaction trans;

        public Home()
        {
            InitializeComponent();
        }
        PRN_PRJContext context = new PRN_PRJContext();
        public Home(User user)
        {
            this.LoginUser = user;
            InitializeComponent();
        }


        public Home(User user, Transaction transaction)
        {
            this.trans = transaction;
            this.LoginUser = user;
            InitializeComponent();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            this.Close();
            Account a = new Account(LoginUser);
            a.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            LoadTransactions(LoginUser);
        }

        private void LoadTransactions(User user)
        {
            if (user != null)
            {
                try
                {
                    var list = context.Transactions
                        .Where(item => item.UserId == LoginUser.UserId)
                        .Select(item => new
                        {
                            TransactionId = item.TransactionId,
                            TransactionDate = item.TransactionDate,
                            CategoryName = item.Category.CategoryName,
                            Amount = item.Amount,
                            Description = item.Description,
                            TransactionType = item.TransactionType,
                            //Action = "Edit"
                        }
                        ).ToList();
                    dgdata.DataSource = list;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Load Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Load Error");
            }

        }

        private void btnAddTrans_Click(object sender, EventArgs e)
        {
            AddTrans at = new AddTrans(LoginUser);
            this.Close();
            at.Show();
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgdata.SelectedCells.Count > 0)
            {
                int rowIndex = dgdata.SelectedCells[0].RowIndex;

                int transactionId = Convert.ToInt32(dgdata.Rows[rowIndex].Cells["TransactionId"].Value);

                Transaction transaction = context.Transactions.FirstOrDefault(item => item.TransactionId == transactionId);

                if (transaction != null)
                {
                    UpdateTrans ut = new UpdateTrans(LoginUser, transaction);
                    this.Close();
                    ut.Show();
                }
                else
                {
                    MessageBox.Show("Transaction not found.");
                }
            }
            else
            {
                MessageBox.Show("Please choose a Transaction.");
            }
        }

        private void btnDeleteTrans_Click(object sender, EventArgs e)
        {
            if (dgdata.SelectedCells.Count > 0)
            {
                int rowIndex = dgdata.SelectedCells[0].RowIndex;

                int transactionId = Convert.ToInt32(dgdata.Rows[rowIndex].Cells["TransactionId"].Value);

                Transaction transaction = context.Transactions.FirstOrDefault(item => item.TransactionId == transactionId);

                if (transaction != null)
                {
                    if (MessageBox.Show(this, "Do you want to delete the transaction?", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        context.Transactions.Remove(transaction);
                        if (context.SaveChanges() > 0)
                        {

                            LoadTransactions(LoginUser);
                            MessageBox.Show("Delete Transaction success!");
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Transaction not found.");
                }
            }
            else
            {
                MessageBox.Show("Please choose a Transaction.");
            }
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            General gen = new General(LoginUser);
            gen.Show();
            this.Close();
        }

        private void btnCate_Click(object sender, EventArgs e)
        {
            this.Close();
            Categories c = new Categories(LoginUser);
            c.ShowDialog();
        }
    }
}
