namespace PRN_PRJ
{
    partial class AddTrans
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cbCate = new ComboBox();
            cbCateName = new ComboBox();
            date = new DateTimePicker();
            txtDescription = new RichTextBox();
            btnAdd = new Button();
            label4 = new Label();
            txtAmount = new TextBox();
            label5 = new Label();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(68, 80);
            label1.Name = "label1";
            label1.Size = new Size(156, 28);
            label1.TabIndex = 0;
            label1.Text = "Transaction Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(68, 253);
            label2.Name = "label2";
            label2.Size = new Size(53, 28);
            label2.TabIndex = 1;
            label2.Text = "Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(68, 149);
            label3.Name = "label3";
            label3.Size = new Size(167, 28);
            label3.TabIndex = 2;
            label3.Text = "Transaction Name";
            // 
            // cbCate
            // 
            cbCate.FormattingEnabled = true;
            cbCate.Items.AddRange(new object[] { "EXS", "INC" });
            cbCate.Location = new Point(261, 80);
            cbCate.Name = "cbCate";
            cbCate.Size = new Size(151, 28);
            cbCate.TabIndex = 3;
            // 
            // cbCateName
            // 
            cbCateName.FormattingEnabled = true;
            cbCateName.Location = new Point(261, 149);
            cbCateName.Name = "cbCateName";
            cbCateName.Size = new Size(151, 28);
            cbCateName.TabIndex = 4;
            // 
            // date
            // 
            date.Location = new Point(261, 255);
            date.Name = "date";
            date.Size = new Size(250, 27);
            date.TabIndex = 5;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(261, 308);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(250, 102);
            txtDescription.TabIndex = 7;
            txtDescription.Text = "";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ActiveBorder;
            btnAdd.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.SeaGreen;
            btnAdd.Location = new Point(206, 448);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(177, 60);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(68, 308);
            label4.Name = "label4";
            label4.Size = new Size(112, 28);
            label4.TabIndex = 9;
            label4.Text = "Description";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(261, 202);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(151, 27);
            txtAmount.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(68, 202);
            label5.Name = "label5";
            label5.Size = new Size(83, 28);
            label5.TabIndex = 11;
            label5.Text = "Amount";
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
            btnBack.TabIndex = 12;
            btnBack.Text = "Back to Home";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // AddTrans
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 569);
            Controls.Add(btnBack);
            Controls.Add(label5);
            Controls.Add(txtAmount);
            Controls.Add(label4);
            Controls.Add(btnAdd);
            Controls.Add(txtDescription);
            Controls.Add(date);
            Controls.Add(cbCateName);
            Controls.Add(cbCate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddTrans";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddTrans";
            Load += AddTrans_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbCate;
        private ComboBox cbCateName;
        private DateTimePicker date;
        private RichTextBox txtDescription;
        private Button btnAdd;
        private Label label4;
        private TextBox txtAmount;
        private Label label5;
        private Button btnBack;
    }
}