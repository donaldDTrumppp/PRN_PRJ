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
    public partial class Categories : Form
    {
        private User LoginUser;
        public Categories()
        {
            InitializeComponent();
        }
        public Categories(User user)
        {
            this.LoginUser = user;
            InitializeComponent();
        }
        PRN_PRJContext context = new PRN_PRJContext();
        private void Categories_Load(object sender, EventArgs e)
        {
            LoadCategory();
        }

        private void LoadCategory()
        {
            var list = context.Categories.Select(item => new
            {
                Id = item.CategoryId,
                Name = item.CategoryName
            }).ToList();

            dgCate.DataSource = list;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home(LoginUser);
            h.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtName.Text) == true)
            {
                MessageBox.Show("Please enter Category Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtName.Text.Equals(context.Categories.FirstOrDefault().CategoryName.ToString()))
            {
                MessageBox.Show("Category already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Category category = new Category()
                    {
                        CategoryName = txtName.Text,
                    };
                    if (category != null)
                    {
                        context.Categories.Add(category);
                        if (context.SaveChanges() > 0)
                        {
                            MessageBox.Show("Add success full");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtName.Text.Equals(context.Categories.FirstOrDefault().CategoryName.ToString()))
            {
                MessageBox.Show("Category already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Category category = context.Categories.FirstOrDefault(item => item.CategoryId == Int32.Parse(txtID.Text));
                    if (category != null)
                    {
                        category.CategoryName = txtName.Text;
                        if (context.SaveChanges() > 0)
                        {
                            MessageBox.Show("Update success");
                            LoadCategory();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update error" + ex.Message);
                }
            }
        }

        private void dgCate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgCate.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtName.Text = dgCate.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtID.Text) || String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Please choose a Category");
            }
            else
            {
                try
                {
                    Category category = context.Categories.FirstOrDefault(item => item.CategoryId == Int32.Parse(txtID.Text));
                    if (category != null)
                    {
                        context.Categories.Remove(category);
                        if (context.SaveChanges() > 0)
                        {
                            MessageBox.Show("Delete success");
                            LoadCategory();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Delete error" + ex.Message);
                }

            }
        }
    }
}
