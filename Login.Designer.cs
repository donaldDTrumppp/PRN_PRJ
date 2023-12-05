namespace PRN_PRJ
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUser = new TextBox();
            txtPass = new TextBox();
            lblLogin = new Label();
            btnLogin = new Button();
            btnRegister = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtVerify = new TextBox();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.ForeColor = SystemColors.ControlDark;
            txtUser.Location = new Point(93, 175);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(281, 32);
            txtUser.TabIndex = 0;
            txtUser.Text = "Username or Email";
            txtUser.Enter += txtUser_Enter;
            txtUser.Leave += txtUser_Leave;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.ForeColor = SystemColors.ControlDark;
            txtPass.Location = new Point(93, 264);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(281, 32);
            txtPass.TabIndex = 2;
            txtPass.Text = "Password";
            txtPass.Enter += txtPass_Enter;
            txtPass.Leave += txtPass_Leave;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogin.Location = new Point(167, 31);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(151, 67);
            lblLogin.TabIndex = 3;
            lblLogin.Text = "Login";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(15, 150, 80);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(93, 470);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(281, 56);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.White;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.ForeColor = Color.FromArgb(15, 150, 80);
            btnRegister.Location = new Point(93, 397);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(281, 56);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(98, 136);
            label1.Name = "label1";
            label1.Size = new Size(87, 23);
            label1.TabIndex = 7;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(93, 226);
            label2.Name = "label2";
            label2.Size = new Size(80, 23);
            label2.TabIndex = 8;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(98, 312);
            label3.Name = "label3";
            label3.Size = new Size(140, 23);
            label3.TabIndex = 9;
            label3.Text = "Verification Code";
            // 
            // txtVerify
            // 
            txtVerify.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtVerify.ForeColor = SystemColors.ControlDark;
            txtVerify.Location = new Point(93, 348);
            txtVerify.Name = "txtVerify";
            txtVerify.PasswordChar = '*';
            txtVerify.Size = new Size(281, 32);
            txtVerify.TabIndex = 10;
            txtVerify.Text = "eg. 123456";
            txtVerify.Enter += txtVerify_Enter;
            txtVerify.Leave += txtVerify_Leave;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 611);
            Controls.Add(txtVerify);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(lblLogin);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUser;
        private TextBox txtPass;
        private Label lblLogin;
        private Button btnLogin;
        private Button btnRegister;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtVerify;
    }
}
