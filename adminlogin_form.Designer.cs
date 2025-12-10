namespace POSapp
{
    partial class adminlogin_form
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
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_pswd = new System.Windows.Forms.Label();
            this.txt_pswd = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_usertype = new System.Windows.Forms.TextBox();
            this.lblUsertype = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(346, 103);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(47, 17);
            this.lbl_email.TabIndex = 3;
            this.lbl_email.Text = "Email";
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.Color.LightGray;
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_email.Location = new System.Drawing.Point(428, 103);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(163, 16);
            this.txt_email.TabIndex = 15;
            this.txt_email.TextChanged += new System.EventHandler(this.txt_email_TextChanged);
            // 
            // lbl_pswd
            // 
            this.lbl_pswd.AutoSize = true;
            this.lbl_pswd.Location = new System.Drawing.Point(346, 153);
            this.lbl_pswd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pswd.Name = "lbl_pswd";
            this.lbl_pswd.Size = new System.Drawing.Size(77, 17);
            this.lbl_pswd.TabIndex = 16;
            this.lbl_pswd.Text = "Password";
            // 
            // txt_pswd
            // 
            this.txt_pswd.BackColor = System.Drawing.Color.LightGray;
            this.txt_pswd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pswd.Location = new System.Drawing.Point(428, 150);
            this.txt_pswd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_pswd.Name = "txt_pswd";
            this.txt_pswd.Size = new System.Drawing.Size(163, 16);
            this.txt_pswd.TabIndex = 17;
            this.txt_pswd.TextChanged += new System.EventHandler(this.txt_pswd_TextChanged);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_login.Location = new System.Drawing.Point(413, 248);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(120, 42);
            this.btn_login.TabIndex = 18;
            this.btn_login.Text = "Log In";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_usertype
            // 
            this.txt_usertype.BackColor = System.Drawing.Color.LightGray;
            this.txt_usertype.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_usertype.Location = new System.Drawing.Point(428, 194);
            this.txt_usertype.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_usertype.Name = "txt_usertype";
            this.txt_usertype.ReadOnly = true;
            this.txt_usertype.Size = new System.Drawing.Size(163, 16);
            this.txt_usertype.TabIndex = 22;
            this.txt_usertype.TextChanged += new System.EventHandler(this.txt_usertype_TextChanged);
            // 
            // lblUsertype
            // 
            this.lblUsertype.AutoSize = true;
            this.lblUsertype.Location = new System.Drawing.Point(344, 200);
            this.lblUsertype.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsertype.Name = "lblUsertype";
            this.lblUsertype.Size = new System.Drawing.Size(83, 17);
            this.lblUsertype.TabIndex = 21;
            this.lblUsertype.Text = "User Type";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.Location = new System.Drawing.Point(58, 344);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 31);
            this.button1.TabIndex = 23;
            this.button1.Text = "< Back to Dashboard";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(481, 310);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(70, 17);
            this.linkLabel1.TabIndex = 27;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sign Up ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 310);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "New Admin?  ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 54);
            this.panel1.TabIndex = 28;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(379, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Admin Login";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel14.Controls.Add(this.panel2);
            this.panel14.Location = new System.Drawing.Point(423, 171);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(163, 3);
            this.panel14.TabIndex = 126;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(-1, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(163, 3);
            this.panel2.TabIndex = 126;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(423, 124);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(163, 3);
            this.panel3.TabIndex = 126;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(423, 215);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(163, 3);
            this.panel4.TabIndex = 127;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(-1, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(163, 3);
            this.panel5.TabIndex = 126;
            // 
            // adminlogin_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(892, 396);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_usertype);
            this.Controls.Add(this.lblUsertype);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_pswd);
            this.Controls.Add(this.lbl_pswd);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_email);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "adminlogin_form";
            this.Text = "login_form";
            this.Load += new System.EventHandler(this.login_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_pswd;
        private System.Windows.Forms.TextBox txt_pswd;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_usertype;
        private System.Windows.Forms.Label lblUsertype;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}