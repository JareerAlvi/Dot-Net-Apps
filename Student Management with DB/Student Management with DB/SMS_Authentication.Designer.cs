namespace Student_Management_with_DB
{
    partial class SMS_Authentication
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShowPass = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPassMsg = new System.Windows.Forms.Label();
            this.lbNameMsg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnShowPass);
            this.panel1.Controls.Add(this.tbPassword);
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbPassMsg);
            this.panel1.Controls.Add(this.lbNameMsg);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(243, 133);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 256);
            this.panel1.TabIndex = 0;
            // 
            // btnShowPass
            // 
            this.btnShowPass.Location = new System.Drawing.Point(436, 172);
            this.btnShowPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowPass.Name = "btnShowPass";
            this.btnShowPass.Size = new System.Drawing.Size(63, 28);
            this.btnShowPass.TabIndex = 9;
            this.btnShowPass.Text = "show";
            this.btnShowPass.UseVisualStyleBackColor = true;
            this.btnShowPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnShowPass_MouseDown);
            this.btnShowPass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnShowPass_MouseUp);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(169, 169);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '•';
            this.tbPassword.Size = new System.Drawing.Size(257, 30);
            this.tbPassword.TabIndex = 8;
            this.tbPassword.Text = "test";
            this.tbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPassword_KeyDown);
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(169, 64);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(257, 30);
            this.tbName.TabIndex = 7;
            this.tbName.Text = "test";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // lbPassMsg
            // 
            this.lbPassMsg.AutoSize = true;
            this.lbPassMsg.Location = new System.Drawing.Point(165, 212);
            this.lbPassMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPassMsg.Name = "lbPassMsg";
            this.lbPassMsg.Size = new System.Drawing.Size(132, 16);
            this.lbPassMsg.TabIndex = 5;
            this.lbPassMsg.Text = "Enter Your Password";
            // 
            // lbNameMsg
            // 
            this.lbNameMsg.AutoSize = true;
            this.lbNameMsg.Location = new System.Drawing.Point(165, 111);
            this.lbNameMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNameMsg.Name = "lbNameMsg";
            this.lbNameMsg.Size = new System.Drawing.Size(109, 16);
            this.lbNameMsg.TabIndex = 4;
            this.lbNameMsg.Text = "Enter Your Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogin.Location = new System.Drawing.Point(453, 431);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(131, 48);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(380, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 54);
            this.label3.TabIndex = 3;
            this.label3.Text = "Log-in Page";
            // 
            // SMS_Authentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "SMS_Authentication";
            this.Text = "SMS";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbPassMsg;
        private System.Windows.Forms.Label lbNameMsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnShowPass;
    }
}