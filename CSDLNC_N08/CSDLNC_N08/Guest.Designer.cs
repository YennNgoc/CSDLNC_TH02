namespace CSDLNC_N08
{
    partial class Guest
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.butt_DangNhap = new System.Windows.Forms.Button();
            this.button_BanChay = new System.Windows.Forms.Button();
            this.butt_PhoBien = new System.Windows.Forms.Button();
            this.sp_view = new System.Windows.Forms.DataGridView();
            this.butt_search = new System.Windows.Forms.Button();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sp_view)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 36);
            this.button1.TabIndex = 37;
            this.button1.Text = "Theo Đại Lý";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // butt_DangNhap
            // 
            this.butt_DangNhap.Location = new System.Drawing.Point(488, 44);
            this.butt_DangNhap.Name = "butt_DangNhap";
            this.butt_DangNhap.Size = new System.Drawing.Size(141, 36);
            this.butt_DangNhap.TabIndex = 35;
            this.butt_DangNhap.Text = "Đăng Nhập";
            this.butt_DangNhap.UseVisualStyleBackColor = true;
            this.butt_DangNhap.Click += new System.EventHandler(this.butt_DangNhap_Click);
            // 
            // button_BanChay
            // 
            this.button_BanChay.Location = new System.Drawing.Point(168, 44);
            this.button_BanChay.Name = "button_BanChay";
            this.button_BanChay.Size = new System.Drawing.Size(141, 36);
            this.button_BanChay.TabIndex = 34;
            this.button_BanChay.Text = "Bán chạy";
            this.button_BanChay.UseVisualStyleBackColor = true;
            this.button_BanChay.Click += new System.EventHandler(this.button_BanChay_Click);
            // 
            // butt_PhoBien
            // 
            this.butt_PhoBien.Location = new System.Drawing.Point(11, 44);
            this.butt_PhoBien.Name = "butt_PhoBien";
            this.butt_PhoBien.Size = new System.Drawing.Size(146, 36);
            this.butt_PhoBien.TabIndex = 33;
            this.butt_PhoBien.Text = "Phổ biến";
            this.butt_PhoBien.UseVisualStyleBackColor = true;
            this.butt_PhoBien.Click += new System.EventHandler(this.butt_PhoBien_Click);
            // 
            // sp_view
            // 
            this.sp_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sp_view.DefaultCellStyle = dataGridViewCellStyle10;
            this.sp_view.Location = new System.Drawing.Point(11, 87);
            this.sp_view.Name = "sp_view";
            this.sp_view.RowHeadersWidth = 62;
            this.sp_view.RowTemplate.Height = 20;
            this.sp_view.RowTemplate.ReadOnly = true;
            this.sp_view.Size = new System.Drawing.Size(618, 344);
            this.sp_view.TabIndex = 31;
            // 
            // butt_search
            // 
            this.butt_search.Location = new System.Drawing.Point(555, 9);
            this.butt_search.Name = "butt_search";
            this.butt_search.Size = new System.Drawing.Size(74, 32);
            this.butt_search.TabIndex = 32;
            this.butt_search.Text = "Tìm";
            this.butt_search.UseVisualStyleBackColor = true;
            this.butt_search.Click += new System.EventHandler(this.butt_search_Click);
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(168, 12);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(381, 26);
            this.tb_name.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "CSDLNC_ N08";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Guest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.butt_DangNhap);
            this.Controls.Add(this.button_BanChay);
            this.Controls.Add(this.butt_PhoBien);
            this.Controls.Add(this.sp_view);
            this.Controls.Add(this.butt_search);
            this.Controls.Add(this.tb_name);
            this.Name = "Guest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guest";
            ((System.ComponentModel.ISupportInitialize)(this.sp_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button butt_DangNhap;
        private System.Windows.Forms.Button button_BanChay;
        private System.Windows.Forms.Button butt_PhoBien;
        private System.Windows.Forms.DataGridView sp_view;
        private System.Windows.Forms.Button butt_search;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label1;
    }
}