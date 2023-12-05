namespace PRN_PRJ
{
    partial class UpdateTrans
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
            btnBack = new Button();
            label5 = new Label();
            txtAmount = new TextBox();
            label4 = new Label();
            btnUpdate = new Button();
            txtDescription = new RichTextBox();
            date = new DateTimePicker();
            cbCateName = new ComboBox();
            cbCate = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            txtID = new TextBox();
            SuspendLayout();
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
            btnBack.TabIndex = 24;
            btnBack.Text = "Back to Home";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(68, 225);
            label5.Name = "label5";
            label5.Size = new Size(83, 28);
            label5.TabIndex = 23;
            label5.Text = "Amount";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(261, 225);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(151, 27);
            txtAmount.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(68, 331);
            label4.Name = "label4";
            label4.Size = new Size(112, 28);
            label4.TabIndex = 21;
            label4.Text = "Description";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ActiveBorder;
            btnUpdate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.SeaGreen;
            btnUpdate.Location = new Point(186, 473);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(177, 60);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(261, 331);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(250, 102);
            txtDescription.TabIndex = 19;
            txtDescription.Text = "";
            // 
            // date
            // 
            date.Location = new Point(261, 278);
            date.Name = "date";
            date.Size = new Size(250, 27);
            date.TabIndex = 18;
            // 
            // cbCateName
            // 
            cbCateName.FormattingEnabled = true;
            cbCateName.Location = new Point(261, 172);
            cbCateName.Name = "cbCateName";
            cbCateName.Size = new Size(151, 28);
            cbCateName.TabIndex = 17;
            // 
            // cbCate
            // 
            cbCate.FormattingEnabled = true;
            cbCate.Items.AddRange(new object[] { "EXS", "INC" });
            cbCate.Location = new Point(261, 116);
            cbCate.Name = "cbCate";
            cbCate.Size = new Size(151, 28);
            cbCate.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(68, 172);
            label3.Name = "label3";
            label3.Size = new Size(167, 28);
            label3.TabIndex = 15;
            label3.Text = "Transaction Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(68, 276);
            label2.Name = "label2";
            label2.Size = new Size(53, 28);
            label2.TabIndex = 14;
            label2.Text = "Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(68, 116);
            label1.Name = "label1";
            label1.Size = new Size(156, 28);
            label1.TabIndex = 13;
            label1.Text = "Transaction Type";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(68, 73);
            label6.Name = "label6";
            label6.Size = new Size(134, 28);
            label6.TabIndex = 25;
            label6.Text = "Transaction ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(261, 74);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(151, 27);
            txtID.TabIndex = 26;
            // 
            // UpdateTrans
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 570);
            Controls.Add(txtID);
            Controls.Add(label6);
            Controls.Add(btnBack);
            Controls.Add(label5);
            Controls.Add(txtAmount);
            Controls.Add(label4);
            Controls.Add(btnUpdate);
            Controls.Add(txtDescription);
            Controls.Add(date);
            Controls.Add(cbCateName);
            Controls.Add(cbCate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpdateTrans";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateTrans";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label label5;
        private TextBox txtAmount;
        private Label label4;
        private Button btnUpdate;
        private RichTextBox txtDescription;
        private DateTimePicker date;
        private ComboBox cbCateName;
        private ComboBox cbCate;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private TextBox txtID;
    }
}