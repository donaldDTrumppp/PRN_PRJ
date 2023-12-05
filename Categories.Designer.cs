namespace PRN_PRJ
{
    partial class Categories
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgCate = new DataGridView();
            label1 = new Label();
            txtName = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnBack = new Button();
            txtID = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgCate).BeginInit();
            SuspendLayout();
            // 
            // dgCate
            // 
            dgCate.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCate.Location = new Point(134, 226);
            dgCate.Name = "dgCate";
            dgCate.RowHeadersWidth = 51;
            dgCate.Size = new Size(300, 188);
            dgCate.TabIndex = 0;
            dgCate.CellClick += dgCate_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 116);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 1;
            label1.Text = "Category Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(292, 113);
            txtName.Name = "txtName";
            txtName.Size = new Size(139, 27);
            txtName.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(46, 173);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(144, 29);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add new Category";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(235, 173);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(139, 29);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update Category";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(404, 173);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(126, 29);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete Category";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.White;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.DodgerBlue;
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(139, 38);
            btnBack.TabIndex = 31;
            btnBack.Text = "Back to Home";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(295, 66);
            txtID.Name = "txtID";
            txtID.Size = new Size(139, 27);
            txtID.TabIndex = 33;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(137, 69);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 32;
            label2.Text = "Category Id";
            // 
            // Categories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 450);
            Controls.Add(txtID);
            Controls.Add(label2);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(dgCate);
            Name = "Categories";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Categories";
            Load += Categories_Load;
            ((System.ComponentModel.ISupportInitialize)dgCate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgCate;
        private Label label1;
        private TextBox txtName;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnBack;
        private TextBox txtID;
        private Label label2;
    }
}