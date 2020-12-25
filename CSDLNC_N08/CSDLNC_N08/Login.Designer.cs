namespace CSDLNC_N08
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
            this.butt_log = new System.Windows.Forms.Button();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // butt_log
            // 
            this.butt_log.Location = new System.Drawing.Point(90, 149);
            this.butt_log.Name = "butt_log";
            this.butt_log.Size = new System.Drawing.Size(98, 40);
            this.butt_log.TabIndex = 5;
            this.butt_log.Text = "button1";
            this.butt_log.UseVisualStyleBackColor = true;
            this.butt_log.Click += new System.EventHandler(this.butt_log_Click);
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(57, 101);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(165, 26);
            this.tb_pass.TabIndex = 4;
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(57, 55);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(165, 26);
            this.tb_username.TabIndex = 3;
            // 
            // Login
            // 
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Controls.Add(this.butt_log);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_username);
            this.Name = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butt_log;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.TextBox tb_username;
    }
}