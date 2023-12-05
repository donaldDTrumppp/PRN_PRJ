namespace PRN_PRJ
{
    partial class ChangePass
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
            btnChange = new Button();
            label1 = new Label();
            label2 = new Label();
            txtPass = new TextBox();
            txtNewPass = new TextBox();
            label3 = new Label();
            txtComNewPass = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtusername = new TextBox();
            btnBack = new Button();
            SuspendLayout();
            // 
            // btnChange
            // 
            btnChange.Location = new Point(240, 370);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(173, 37);
            btnChange.TabIndex = 0;
            btnChange.Text = "Change";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(145, 208);
            label1.Name = "label1";
            label1.Size = new Size(130, 25);
            label1.TabIndex = 1;
            label1.Text = "Old Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(145, 260);
            label2.Name = "label2";
            label2.Size = new Size(138, 25);
            label2.TabIndex = 2;
            label2.Text = "New Password:";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(367, 206);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(188, 27);
            txtPass.TabIndex = 3;
            // 
            // txtNewPass
            // 
            txtNewPass.Location = new Point(367, 261);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.PasswordChar = '*';
            txtNewPass.Size = new Size(188, 27);
            txtNewPass.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(145, 41);
            label3.Name = "label3";
            label3.Size = new Size(414, 67);
            label3.TabIndex = 5;
            label3.Text = "Change Password";
            // 
            // txtComNewPass
            // 
            txtComNewPass.Location = new Point(367, 310);
            txtComNewPass.Name = "txtComNewPass";
            txtComNewPass.PasswordChar = '*';
            txtComNewPass.Size = new Size(188, 27);
            txtComNewPass.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(145, 309);
            label4.Name = "label4";
            label4.Size = new Size(216, 25);
            label4.TabIndex = 7;
            label4.Text = "Comfirm New Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(145, 156);
            label5.Name = "label5";
            label5.Size = new Size(101, 25);
            label5.TabIndex = 8;
            label5.Text = "Username:";
            // 
            // txtusername
            // 
            txtusername.Location = new Point(367, 154);
            txtusername.Name = "txtusername";
            txtusername.ReadOnly = true;
            txtusername.Size = new Size(188, 27);
            txtusername.TabIndex = 9;
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
            btnBack.Text = "Back to Detail";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // ChangePass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 450);
            Controls.Add(btnBack);
            Controls.Add(txtusername);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtComNewPass);
            Controls.Add(label3);
            Controls.Add(txtNewPass);
            Controls.Add(txtPass);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnChange);
            Name = "ChangePass";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangePass";
            Load += ChangePass_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnChange;
        private Label label1;
        private Label label2;
        private TextBox txtPass;
        private TextBox txtNewPass;
        private Label label3;
        private TextBox txtComNewPass;
        private Label label4;
        private Label label5;
        private TextBox txtusername;
        private Button btnBack;
    }
}