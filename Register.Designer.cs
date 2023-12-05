namespace PRN_PRJ
{
    partial class Register
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
            btnRes = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnBack = new Button();
            txtFullName = new TextBox();
            txtPassword = new TextBox();
            txtPhone = new TextBox();
            txtCofPass = new TextBox();
            txtUsername = new TextBox();
            label6 = new Label();
            txtAddress = new TextBox();
            label7 = new Label();
            txtVerify = new TextBox();
            SuspendLayout();
            // 
            // btnRes
            // 
            btnRes.BackColor = Color.FromArgb(15, 150, 80);
            btnRes.FlatAppearance.BorderSize = 0;
            btnRes.FlatStyle = FlatStyle.Flat;
            btnRes.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnRes.ForeColor = Color.White;
            btnRes.Location = new Point(76, 437);
            btnRes.Name = "btnRes";
            btnRes.Size = new Size(316, 56);
            btnRes.TabIndex = 5;
            btnRes.Text = "Register";
            btnRes.UseVisualStyleBackColor = false;
            btnRes.Click += btnRes_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 70);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 6;
            label1.Text = "Full Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 228);
            label2.Name = "label2";
            label2.Size = new Size(132, 20);
            label2.TabIndex = 7;
            label2.Text = "Comfirm Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 173);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 8;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(76, 119);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 9;
            label4.Text = "Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(76, 282);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 10;
            label5.Text = "Phone Number";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.White;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.DodgerBlue;
            btnBack.Location = new Point(12, 10);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(139, 38);
            btnBack.TabIndex = 11;
            btnBack.Text = "Back to Login";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(227, 67);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(165, 27);
            txtFullName.TabIndex = 12;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(227, 170);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(165, 27);
            txtPassword.TabIndex = 14;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(227, 282);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(165, 27);
            txtPhone.TabIndex = 15;
            txtPhone.TextChanged += txtPhone_TextChanged;
            txtPhone.KeyPress += txtPhone_KeyPress;
            // 
            // txtCofPass
            // 
            txtCofPass.Location = new Point(227, 225);
            txtCofPass.Name = "txtCofPass";
            txtCofPass.PasswordChar = '*';
            txtCofPass.Size = new Size(165, 27);
            txtCofPass.TabIndex = 16;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(227, 116);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(165, 27);
            txtUsername.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(75, 336);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 18;
            label6.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(227, 333);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(165, 27);
            txtAddress.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(75, 386);
            label7.Name = "label7";
            label7.Size = new Size(123, 20);
            label7.TabIndex = 20;
            label7.Text = "Verification Code";
            // 
            // txtVerify
            // 
            txtVerify.Location = new Point(227, 383);
            txtVerify.Name = "txtVerify";
            txtVerify.Size = new Size(165, 27);
            txtVerify.TabIndex = 21;
            txtVerify.TextChanged += txtVerify_TextChanged;
            txtVerify.KeyPress += txtVerify_KeyPress;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 549);
            Controls.Add(txtVerify);
            Controls.Add(label7);
            Controls.Add(txtAddress);
            Controls.Add(label6);
            Controls.Add(txtUsername);
            Controls.Add(txtCofPass);
            Controls.Add(txtPhone);
            Controls.Add(txtPassword);
            Controls.Add(txtFullName);
            Controls.Add(btnBack);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRes);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRes;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnBack;
        private TextBox txtFullName;
        private TextBox txtPassword;
        private TextBox txtPhone;
        private TextBox txtCofPass;
        private TextBox txtUsername;
        private Label label6;
        private TextBox txtAddress;
        private Label label7;
        private TextBox txtVerify;
    }
}