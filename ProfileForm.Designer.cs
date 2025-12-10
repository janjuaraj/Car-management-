namespace POSapp
{
    partial class ProfileForm
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
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_phno = new System.Windows.Forms.TextBox();
            this.txt_cpswd = new System.Windows.Forms.TextBox();
            this.txt_pswd = new System.Windows.Forms.TextBox();
            this.lbl_cnfrmpswd = new System.Windows.Forms.Label();
            this.lbl_pswd = new System.Windows.Forms.Label();
            this.lbl_phno = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.btn_updateProfile = new System.Windows.Forms.Button();
            this.txt_userid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.LightGray;
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_username.Location = new System.Drawing.Point(486, 166);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(132, 15);
            this.txt_username.TabIndex = 29;
            this.txt_username.TextChanged += new System.EventHandler(this.txt_username_TextChanged);
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.Color.LightGray;
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_email.Location = new System.Drawing.Point(486, 200);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(132, 15);
            this.txt_email.TabIndex = 28;
            this.txt_email.TextChanged += new System.EventHandler(this.txt_email_TextChanged);
            // 
            // txt_phno
            // 
            this.txt_phno.BackColor = System.Drawing.Color.LightGray;
            this.txt_phno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_phno.Location = new System.Drawing.Point(486, 230);
            this.txt_phno.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_phno.Name = "txt_phno";
            this.txt_phno.Size = new System.Drawing.Size(132, 15);
            this.txt_phno.TabIndex = 27;
            this.txt_phno.TextChanged += new System.EventHandler(this.txt_phno_TextChanged);
            // 
            // txt_cpswd
            // 
            this.txt_cpswd.BackColor = System.Drawing.Color.LightGray;
            this.txt_cpswd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cpswd.Location = new System.Drawing.Point(486, 290);
            this.txt_cpswd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_cpswd.Name = "txt_cpswd";
            this.txt_cpswd.Size = new System.Drawing.Size(132, 15);
            this.txt_cpswd.TabIndex = 25;
            this.txt_cpswd.TextChanged += new System.EventHandler(this.txt_cpswd_TextChanged);
            // 
            // txt_pswd
            // 
            this.txt_pswd.BackColor = System.Drawing.Color.LightGray;
            this.txt_pswd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pswd.Location = new System.Drawing.Point(486, 259);
            this.txt_pswd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_pswd.Name = "txt_pswd";
            this.txt_pswd.Size = new System.Drawing.Size(132, 15);
            this.txt_pswd.TabIndex = 24;
            this.txt_pswd.TextChanged += new System.EventHandler(this.txt_pswd_TextChanged);
            // 
            // lbl_cnfrmpswd
            // 
            this.lbl_cnfrmpswd.AutoSize = true;
            this.lbl_cnfrmpswd.Location = new System.Drawing.Point(330, 294);
            this.lbl_cnfrmpswd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cnfrmpswd.Name = "lbl_cnfrmpswd";
            this.lbl_cnfrmpswd.Size = new System.Drawing.Size(137, 17);
            this.lbl_cnfrmpswd.TabIndex = 22;
            this.lbl_cnfrmpswd.Text = "Confirm Password";
            // 
            // lbl_pswd
            // 
            this.lbl_pswd.AutoSize = true;
            this.lbl_pswd.Location = new System.Drawing.Point(330, 264);
            this.lbl_pswd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pswd.Name = "lbl_pswd";
            this.lbl_pswd.Size = new System.Drawing.Size(77, 17);
            this.lbl_pswd.TabIndex = 21;
            this.lbl_pswd.Text = "Password";
            // 
            // lbl_phno
            // 
            this.lbl_phno.AutoSize = true;
            this.lbl_phno.Location = new System.Drawing.Point(330, 235);
            this.lbl_phno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_phno.Name = "lbl_phno";
            this.lbl_phno.Size = new System.Drawing.Size(79, 17);
            this.lbl_phno.TabIndex = 18;
            this.lbl_phno.Text = "Phone No";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(330, 203);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(47, 17);
            this.lbl_email.TabIndex = 17;
            this.lbl_email.Text = "Email";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(331, 170);
            this.lbl_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(88, 17);
            this.lbl_username.TabIndex = 16;
            this.lbl_username.Text = "User Name";
            // 
            // btn_updateProfile
            // 
            this.btn_updateProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_updateProfile.Location = new System.Drawing.Point(437, 356);
            this.btn_updateProfile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_updateProfile.Name = "btn_updateProfile";
            this.btn_updateProfile.Size = new System.Drawing.Size(142, 45);
            this.btn_updateProfile.TabIndex = 32;
            this.btn_updateProfile.Text = "Update Profile";
            this.btn_updateProfile.UseVisualStyleBackColor = false;
            this.btn_updateProfile.Click += new System.EventHandler(this.btn_updateProfile_Click_1);
            // 
            // txt_userid
            // 
            this.txt_userid.BackColor = System.Drawing.Color.LightGray;
            this.txt_userid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_userid.Location = new System.Drawing.Point(486, 136);
            this.txt_userid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_userid.Name = "txt_userid";
            this.txt_userid.ReadOnly = true;
            this.txt_userid.Size = new System.Drawing.Size(132, 15);
            this.txt_userid.TabIndex = 34;
            this.txt_userid.TextChanged += new System.EventHandler(this.txt_userid_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "User ID";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.Location = new System.Drawing.Point(45, 464);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 42);
            this.button1.TabIndex = 35;
            this.button1.Text = "< Back to User Homepage";
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
            this.panel1.Size = new System.Drawing.Size(1067, 53);
            this.panel1.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(422, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "User profile update";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(472, 157);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(163, 3);
            this.panel3.TabIndex = 127;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(472, 184);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(163, 3);
            this.panel2.TabIndex = 128;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(472, 218);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(163, 3);
            this.panel4.TabIndex = 128;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(472, 250);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(163, 3);
            this.panel5.TabIndex = 128;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(472, 278);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(163, 3);
            this.panel6.TabIndex = 128;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(472, 309);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(163, 3);
            this.panel7.TabIndex = 128;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1067, 516);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_userid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_updateProfile);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ProfileForm";
            this.Text = "ProfileForm";
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_phno;
        private System.Windows.Forms.TextBox txt_cpswd;
        private System.Windows.Forms.TextBox txt_pswd;
        private System.Windows.Forms.Label lbl_cnfrmpswd;
        private System.Windows.Forms.Label lbl_pswd;
        private System.Windows.Forms.Label lbl_phno;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Button btn_updateProfile;
        private System.Windows.Forms.TextBox txt_userid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
    }
}