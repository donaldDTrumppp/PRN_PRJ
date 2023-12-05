namespace PRN_PRJ
{
    partial class Account
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
            lblID = new Label();
            label4 = new Label();
            lblUsername = new Label();
            label6 = new Label();
            lblFullname = new Label();
            label8 = new Label();
            lblPhone = new Label();
            label10 = new Label();
            lblAddress = new Label();
            btnChangePass = new Button();
            btnUpdate = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(93, 77);
            label1.Name = "label1";
            label1.Size = new Size(350, 67);
            label1.TabIndex = 0;
            label1.Text = "Account Detail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(93, 176);
            label2.Name = "label2";
            label2.Size = new Size(99, 23);
            label2.TabIndex = 1;
            label2.Text = "Account ID:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblID.Location = new Point(389, 176);
            lblID.Name = "lblID";
            lblID.Size = new Size(0, 23);
            lblID.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(93, 217);
            label4.Name = "label4";
            label4.Size = new Size(96, 23);
            label4.TabIndex = 3;
            label4.Text = "Username: ";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.Location = new Point(389, 217);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(0, 23);
            lblUsername.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(93, 348);
            label6.Name = "label6";
            label6.Size = new Size(70, 23);
            label6.TabIndex = 5;
            label6.Text = "Address";
            // 
            // lblFullname
            // 
            lblFullname.AutoSize = true;
            lblFullname.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblFullname.Location = new Point(389, 261);
            lblFullname.Name = "lblFullname";
            lblFullname.Size = new Size(0, 23);
            lblFullname.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(93, 304);
            label8.Name = "label8";
            label8.Size = new Size(127, 23);
            label8.TabIndex = 7;
            label8.Text = "Phone Number";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhone.Location = new Point(389, 304);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(0, 23);
            lblPhone.TabIndex = 8;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(93, 261);
            label10.Name = "label10";
            label10.Size = new Size(87, 23);
            label10.TabIndex = 9;
            label10.Text = "Full Name";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddress.Location = new Point(389, 348);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(0, 23);
            lblAddress.TabIndex = 10;
            // 
            // btnChangePass
            // 
            btnChangePass.Location = new Point(93, 429);
            btnChangePass.Name = "btnChangePass";
            btnChangePass.Size = new Size(135, 40);
            btnChangePass.TabIndex = 11;
            btnChangePass.Text = "Change Password";
            btnChangePass.UseVisualStyleBackColor = true;
            btnChangePass.Click += btnChangePass_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(307, 429);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(137, 40);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update Account";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
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
            btnBack.TabIndex = 13;
            btnBack.Text = "Back to Home";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 495);
            Controls.Add(btnBack);
            Controls.Add(btnUpdate);
            Controls.Add(btnChangePass);
            Controls.Add(lblAddress);
            Controls.Add(label10);
            Controls.Add(lblPhone);
            Controls.Add(label8);
            Controls.Add(lblFullname);
            Controls.Add(label6);
            Controls.Add(lblUsername);
            Controls.Add(label4);
            Controls.Add(lblID);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Account";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Account";
            Load += Account_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblID;
        private Label label4;
        private Label lblUsername;
        private Label label6;
        private Label lblFullname;
        private Label label8;
        private Label lblPhone;
        private Label label10;
        private Label lblAddress;
        private Button btnChangePass;
        private Button btnUpdate;
        private Button btnBack;
    }
}