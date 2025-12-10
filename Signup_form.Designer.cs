namespace POSapp
{
    partial class signup_form
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
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_phno = new System.Windows.Forms.Label();
            this.lbl_pswd = new System.Windows.Forms.Label();
            this.lbl_cnfrmpswd = new System.Windows.Forms.Label();
            this.txt_pswd = new System.Windows.Forms.TextBox();
            this.txt_cpswd = new System.Windows.Forms.TextBox();
            this.txt_phno = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.btn_signup = new System.Windows.Forms.Button();
            this.lblUsertype = new System.Windows.Forms.Label();
            this.txt_usertype = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtuserid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(341, 111);
            this.lbl_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(88, 17);
            this.lbl_username.TabIndex = 1;
            this.lbl_username.Text = "User Name";
            this.lbl_username.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(339, 140);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(47, 17);
            this.lbl_email.TabIndex = 2;
            this.lbl_email.Text = "Email";
            // 
            // lbl_phno
            // 
            this.lbl_phno.AutoSize = true;
            this.lbl_phno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phno.Location = new System.Drawing.Point(339, 172);
            this.lbl_phno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_phno.Name = "lbl_phno";
            this.lbl_phno.Size = new System.Drawing.Size(79, 17);
            this.lbl_phno.TabIndex = 3;
            this.lbl_phno.Text = "Phone No";
            // 
            // lbl_pswd
            // 
            this.lbl_pswd.AutoSize = true;
            this.lbl_pswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pswd.Location = new System.Drawing.Point(339, 226);
            this.lbl_pswd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pswd.Name = "lbl_pswd";
            this.lbl_pswd.Size = new System.Drawing.Size(77, 17);
            this.lbl_pswd.TabIndex = 6;
            this.lbl_pswd.Text = "Password";
            // 
            // lbl_cnfrmpswd
            // 
            this.lbl_cnfrmpswd.AutoSize = true;
            this.lbl_cnfrmpswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cnfrmpswd.Location = new System.Drawing.Point(339, 256);
            this.lbl_cnfrmpswd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cnfrmpswd.Name = "lbl_cnfrmpswd";
            this.lbl_cnfrmpswd.Size = new System.Drawing.Size(137, 17);
            this.lbl_cnfrmpswd.TabIndex = 7;
            this.lbl_cnfrmpswd.Text = "Confirm Password";
            // 
            // txt_pswd
            // 
            this.txt_pswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pswd.Location = new System.Drawing.Point(480, 225);
            this.txt_pswd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_pswd.Name = "txt_pswd";
            this.txt_pswd.Size = new System.Drawing.Size(144, 23);
            this.txt_pswd.TabIndex = 10;
            this.txt_pswd.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txt_cpswd
            // 
            this.txt_cpswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cpswd.Location = new System.Drawing.Point(480, 254);
            this.txt_cpswd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_cpswd.Name = "txt_cpswd";
            this.txt_cpswd.Size = new System.Drawing.Size(144, 23);
            this.txt_cpswd.TabIndex = 11;
            // 
            // txt_phno
            // 
            this.txt_phno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phno.Location = new System.Drawing.Point(480, 168);
            this.txt_phno.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_phno.Name = "txt_phno";
            this.txt_phno.Size = new System.Drawing.Size(144, 23);
            this.txt_phno.TabIndex = 13;
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(480, 139);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(144, 23);
            this.txt_email.TabIndex = 14;
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(480, 109);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(144, 23);
            this.txt_username.TabIndex = 15;
            // 
            // btn_signup
            // 
            this.btn_signup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signup.Location = new System.Drawing.Point(443, 309);
            this.btn_signup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(105, 36);
            this.btn_signup.TabIndex = 16;
            this.btn_signup.Text = "Sign Up";
            this.btn_signup.UseVisualStyleBackColor = false;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // lblUsertype
            // 
            this.lblUsertype.AutoSize = true;
            this.lblUsertype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsertype.Location = new System.Drawing.Point(341, 199);
            this.lblUsertype.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsertype.Name = "lblUsertype";
            this.lblUsertype.Size = new System.Drawing.Size(83, 17);
            this.lblUsertype.TabIndex = 19;
            this.lblUsertype.Text = "User Type";
            // 
            // txt_usertype
            // 
            this.txt_usertype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usertype.Location = new System.Drawing.Point(480, 198);
            this.txt_usertype.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_usertype.Name = "txt_usertype";
            this.txt_usertype.ReadOnly = true;
            this.txt_usertype.Size = new System.Drawing.Size(144, 23);
            this.txt_usertype.TabIndex = 20;
            this.txt_usertype.Text = "user";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.Location = new System.Drawing.Point(39, 416);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 32);
            this.button1.TabIndex = 29;
            this.button1.Text = "< Back to Dashboard";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 53);
            this.panel1.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(418, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "User Sign UP";
            // 
            // txtuserid
            // 
            this.txtuserid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuserid.Location = new System.Drawing.Point(480, 82);
            this.txtuserid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtuserid.Name = "txtuserid";
            this.txtuserid.ReadOnly = true;
            this.txtuserid.Size = new System.Drawing.Size(144, 23);
            this.txtuserid.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "User ID";
            // 
            // signup_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(933, 469);
            this.Controls.Add(this.txtuserid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_usertype);
            this.Controls.Add(this.lblUsertype);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_phno);
            this.Controls.Add(this.txt_cpswd);
            this.Controls.Add(this.txt_pswd);
            this.Controls.Add(this.lbl_cnfrmpswd);
            this.Controls.Add(this.lbl_pswd);
            this.Controls.Add(this.lbl_phno);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_username);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "signup_form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_phno;
        private System.Windows.Forms.Label lbl_pswd;
        private System.Windows.Forms.Label lbl_cnfrmpswd;
        private System.Windows.Forms.TextBox txt_pswd;
        private System.Windows.Forms.TextBox txt_cpswd;
        private System.Windows.Forms.TextBox txt_phno;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.Label lblUsertype;
        private System.Windows.Forms.TextBox txt_usertype;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtuserid;
        private System.Windows.Forms.Label label1;
    }
}

