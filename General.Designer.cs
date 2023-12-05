namespace PRN_PRJ
{
    partial class General
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
            btnGeneral = new Button();
            btnAccount = new Button();
            btnTrans = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblThu = new Label();
            lblChi = new Label();
            label6 = new Label();
            dgView = new DataGridView();
            cbbMonth = new ComboBox();
            cbbYear = new ComboBox();
            btnCate = new Button();
            btnView = new Button();
            ((System.ComponentModel.ISupportInitialize)dgView).BeginInit();
            SuspendLayout();
            // 
            // btnGeneral
            // 
            btnGeneral.BackColor = Color.FromArgb(15, 150, 80);
            btnGeneral.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnGeneral.ForeColor = Color.White;
            btnGeneral.Location = new Point(52, 67);
            btnGeneral.Name = "btnGeneral";
            btnGeneral.Size = new Size(194, 74);
            btnGeneral.TabIndex = 17;
            btnGeneral.Text = "General";
            btnGeneral.UseVisualStyleBackColor = false;
            // 
            // btnAccount
            // 
            btnAccount.Location = new Point(714, 12);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(127, 51);
            btnAccount.TabIndex = 12;
            btnAccount.Text = "Account Detail";
            btnAccount.UseVisualStyleBackColor = true;
            btnAccount.Click += btnAccount_Click;
            // 
            // btnTrans
            // 
            btnTrans.BackColor = Color.White;
            btnTrans.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnTrans.ForeColor = Color.FromArgb(15, 150, 80);
            btnTrans.Location = new Point(337, 67);
            btnTrans.Name = "btnTrans";
            btnTrans.Size = new Size(194, 74);
            btnTrans.TabIndex = 11;
            btnTrans.Text = "Transactions";
            btnTrans.UseVisualStyleBackColor = false;
            btnTrans.Click += btnTrans_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 310);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 18;
            label1.Text = "Tổng Thu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 382);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 19;
            label2.Text = "Tổng Chi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(462, 168);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 20;
            label3.Text = "Năm";
            // 
            // lblThu
            // 
            lblThu.AutoSize = true;
            lblThu.Location = new Point(129, 310);
            lblThu.Name = "lblThu";
            lblThu.Size = new Size(0, 20);
            lblThu.TabIndex = 21;
            // 
            // lblChi
            // 
            lblChi.AutoSize = true;
            lblChi.Location = new Point(129, 382);
            lblChi.Name = "lblChi";
            lblChi.Size = new Size(0, 20);
            lblChi.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(129, 168);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 23;
            label6.Text = "Tháng";
            // 
            // dgView
            // 
            dgView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgView.Location = new Point(311, 256);
            dgView.Name = "dgView";
            dgView.RowHeadersWidth = 51;
            dgView.RowTemplate.Height = 29;
            dgView.Size = new Size(511, 188);
            dgView.TabIndex = 26;
            // 
            // cbbMonth
            // 
            cbbMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbMonth.FormattingEnabled = true;
            cbbMonth.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cbbMonth.Location = new Point(206, 168);
            cbbMonth.Name = "cbbMonth";
            cbbMonth.Size = new Size(139, 28);
            cbbMonth.TabIndex = 27;
            // 
            // cbbYear
            // 
            cbbYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbYear.FormattingEnabled = true;
            cbbYear.Items.AddRange(new object[] { "2023", "2022", "2021", "2020", "2019" });
            cbbYear.Location = new Point(524, 165);
            cbbYear.Name = "cbbYear";
            cbbYear.Size = new Size(117, 28);
            cbbYear.TabIndex = 28;
            // 
            // btnCate
            // 
            btnCate.BackColor = Color.White;
            btnCate.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCate.ForeColor = Color.FromArgb(15, 150, 80);
            btnCate.Location = new Point(595, 67);
            btnCate.Name = "btnCate";
            btnCate.Size = new Size(194, 74);
            btnCate.TabIndex = 29;
            btnCate.Text = "Categories Management";
            btnCate.UseVisualStyleBackColor = false;
            btnCate.Click += btnCate_Click;
            // 
            // btnView
            // 
            btnView.Location = new Point(389, 221);
            btnView.Name = "btnView";
            btnView.Size = new Size(94, 29);
            btnView.TabIndex = 30;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // General
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 513);
            Controls.Add(btnView);
            Controls.Add(btnCate);
            Controls.Add(cbbYear);
            Controls.Add(cbbMonth);
            Controls.Add(dgView);
            Controls.Add(label6);
            Controls.Add(lblChi);
            Controls.Add(lblThu);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGeneral);
            Controls.Add(btnAccount);
            Controls.Add(btnTrans);
            Name = "General";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "General";
            Load += General_Load;
            ((System.ComponentModel.ISupportInitialize)dgView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGeneral;
        private Button btnAccount;
        private Button btnTrans;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblThu;
        private Label lblChi;
        private Label label6;
        private DataGridView dgView;
        private ComboBox cbbMonth;
        private ComboBox cbbYear;
        private Button btnCate;
        private Button btnView;
    }
}