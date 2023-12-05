namespace PRN_PRJ
{
    partial class UpdateAccount
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
            btnSave = new Button();
            label10 = new Label();
            label8 = new Label();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtID = new TextBox();
            txtUsername = new TextBox();
            txtFullname = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            btnBack = new Button();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(200, 376);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(135, 40);
            btnSave.TabIndex = 24;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(107, 242);
            label10.Name = "label10";
            label10.Size = new Size(87, 23);
            label10.TabIndex = 22;
            label10.Text = "Full Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(107, 285);
            label8.Name = "label8";
            label8.Size = new Size(127, 23);
            label8.TabIndex = 20;
            label8.Text = "Phone Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(107, 329);
            label6.Name = "label6";
            label6.Size = new Size(70, 23);
            label6.TabIndex = 18;
            label6.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(107, 198);
            label4.Name = "label4";
            label4.Size = new Size(96, 23);
            label4.TabIndex = 16;
            label4.Text = "Username: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(107, 157);
            label2.Name = "label2";
            label2.Size = new Size(99, 23);
            label2.TabIndex = 14;
            label2.Text = "Account ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(107, 58);
            label1.Name = "label1";
            label1.Size = new Size(383, 67);
            label1.TabIndex = 13;
            label1.Text = "Account Update";
            // 
            // txtID
            // 
            txtID.Location = new Point(307, 153);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(166, 27);
            txtID.TabIndex = 25;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(307, 194);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(166, 27);
            txtUsername.TabIndex = 26;
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(307, 238);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(166, 27);
            txtFullname.TabIndex = 27;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(307, 281);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(166, 27);
            txtPhone.TabIndex = 28;
            txtPhone.TextChanged += txtPhone_TextChanged;
            txtPhone.KeyPress += txtPhone_KeyPress;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(307, 325);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(166, 27);
            txtAddress.TabIndex = 29;
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
            btnBack.TabIndex = 30;
            btnBack.Text = "Back to Detail";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // UpdateAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 440);
            Controls.Add(btnBack);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtFullname);
            Controls.Add(txtUsername);
            Controls.Add(txtID);
            Controls.Add(btnSave);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpdateAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateAccount";
            Load += UpdateAccount_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Label label10;
        private Label label8;
        private Label label6;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox txtID;
        private TextBox txtUsername;
        private TextBox txtFullname;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private Button btnBack;
    }
}