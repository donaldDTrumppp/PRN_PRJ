
namespace PRN_PRJ
{
    partial class Home
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
            btnTrans = new Button();
            btnAccount = new Button();
            btnAddSpend = new Button();
            dgdata = new DataGridView();
            btnDeleteTrans = new Button();
            btnUpdate = new Button();
            btnGeneral = new Button();
            btnCate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgdata).BeginInit();
            SuspendLayout();
            // 
            // btnTrans
            // 
            btnTrans.BackColor = Color.FromArgb(15, 150, 80);
            btnTrans.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnTrans.ForeColor = Color.Transparent;
            btnTrans.Location = new Point(328, 70);
            btnTrans.Name = "btnTrans";
            btnTrans.Size = new Size(194, 74);
            btnTrans.TabIndex = 0;
            btnTrans.Text = "Transactions";
            btnTrans.UseVisualStyleBackColor = false;
            // 
            // btnAccount
            // 
            btnAccount.Location = new Point(711, 3);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(127, 51);
            btnAccount.TabIndex = 3;
            btnAccount.Text = "Account Detail";
            btnAccount.UseVisualStyleBackColor = true;
            btnAccount.Click += btnAccount_Click;
            // 
            // btnAddSpend
            // 
            btnAddSpend.Location = new Point(111, 171);
            btnAddSpend.Name = "btnAddSpend";
            btnAddSpend.Size = new Size(131, 29);
            btnAddSpend.TabIndex = 4;
            btnAddSpend.Text = "Add Transaction";
            btnAddSpend.UseVisualStyleBackColor = true;
            btnAddSpend.Click += btnAddTrans_Click;
            // 
            // dgdata
            // 
            dgdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgdata.Location = new Point(62, 223);
            dgdata.Name = "dgdata";
            dgdata.RowHeadersWidth = 51;
            dgdata.RowTemplate.Height = 29;
            dgdata.Size = new Size(721, 258);
            dgdata.TabIndex = 7;
            // 
            // btnDeleteTrans
            // 
            btnDeleteTrans.Location = new Point(591, 171);
            btnDeleteTrans.Name = "btnDeleteTrans";
            btnDeleteTrans.Size = new Size(143, 29);
            btnDeleteTrans.TabIndex = 8;
            btnDeleteTrans.Text = "Delete Transaction";
            btnDeleteTrans.UseVisualStyleBackColor = true;
            btnDeleteTrans.Click += btnDeleteTrans_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(336, 171);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(169, 29);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update Transaction";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnGeneral
            // 
            btnGeneral.BackColor = Color.White;
            btnGeneral.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnGeneral.ForeColor = Color.FromArgb(15, 150, 80);
            btnGeneral.Location = new Point(32, 70);
            btnGeneral.Name = "btnGeneral";
            btnGeneral.Size = new Size(194, 74);
            btnGeneral.TabIndex = 10;
            btnGeneral.Text = "General";
            btnGeneral.UseVisualStyleBackColor = false;
            btnGeneral.Click += btnGeneral_Click;
            // 
            // btnCate
            // 
            btnCate.BackColor = Color.White;
            btnCate.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCate.ForeColor = Color.FromArgb(15, 150, 80);
            btnCate.Location = new Point(591, 70);
            btnCate.Name = "btnCate";
            btnCate.Size = new Size(194, 74);
            btnCate.TabIndex = 30;
            btnCate.Text = "Categories Management";
            btnCate.UseVisualStyleBackColor = false;
            btnCate.Click += btnCate_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 513);
            Controls.Add(btnCate);
            Controls.Add(btnGeneral);
            Controls.Add(btnUpdate);
            Controls.Add(btnDeleteTrans);
            Controls.Add(dgdata);
            Controls.Add(btnAddSpend);
            Controls.Add(btnAccount);
            Controls.Add(btnTrans);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)dgdata).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnTrans;
        private Button btnAccount;
        private Button btnAddSpend;
        private DataGridView dgdata;
        private Button btnDeleteTrans;
        private Button btnUpdate;
        private Button btnGeneral;
        private Button btnCate;
    }
}
