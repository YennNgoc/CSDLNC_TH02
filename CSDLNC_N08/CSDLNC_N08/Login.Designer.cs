﻿namespace CSDLNC_N08
{
    partial class Login
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
            this.butt_login = new System.Windows.Forms.Button();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.butt_logup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butt_login
            // 
            this.butt_login.Location = new System.Drawing.Point(116, 139);
            this.butt_login.Name = "butt_login";
            this.butt_login.Size = new System.Drawing.Size(97, 28);
            this.butt_login.TabIndex = 5;
            this.butt_login.Text = "Đăng nhập";
            this.butt_login.UseVisualStyleBackColor = true;
            this.butt_login.Click += new System.EventHandler(this.butt_log_Click);
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(12, 106);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(201, 26);
            this.tb_pass.TabIndex = 4;
            this.tb_pass.Text = "password";
            this.tb_pass.UseSystemPasswordChar = true;
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(12, 73);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(201, 26);
            this.tb_username.TabIndex = 3;
            this.tb_username.Text = "username";
            // 
            // butt_logup
            // 
            this.butt_logup.Location = new System.Drawing.Point(13, 139);
            this.butt_logup.Name = "butt_logup";
            this.butt_logup.Size = new System.Drawing.Size(97, 28);
            this.butt_logup.TabIndex = 6;
            this.butt_logup.Text = "Đăng ký";
            this.butt_logup.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 42);
            this.label1.TabIndex = 39;
            this.label1.Text = "CSDLNC_ N08";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.ClientSize = new System.Drawing.Size(229, 175);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butt_logup);
            this.Controls.Add(this.butt_login);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_username);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butt_login;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Button butt_logup;
        private System.Windows.Forms.Label label1;
    }
}