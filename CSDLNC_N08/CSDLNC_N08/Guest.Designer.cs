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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.butt_search = new System.Windows.Forms.Button();
            this.sp_view = new System.Windows.Forms.DataGridView();
            this.butt_PhoBien = new System.Windows.Forms.Button();
            this.button_BanChay = new System.Windows.Forms.Button();
            this.butt_DatHang = new System.Windows.Forms.Button();
            this.butt_DangNhap = new System.Windows.Forms.Button();
            this.butt_DangKy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sp_view)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(12, 19);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(405, 26);
            this.tb_name.TabIndex = 0;
            // 
            // butt_search
            // 
            this.butt_search.Location = new System.Drawing.Point(423, 9);
            this.butt_search.Name = "butt_search";
            this.butt_search.Size = new System.Drawing.Size(74, 36);
            this.butt_search.TabIndex = 1;
            this.butt_search.Text = "Tìm";
            this.butt_search.UseVisualStyleBackColor = true;
            this.butt_search.Click += new System.EventHandler(this.butt_search_Click);
            // 
            // sp_view
            // 
            this.sp_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sp_view.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sp_view.DefaultCellStyle = dataGridViewCellStyle1;
            this.sp_view.Location = new System.Drawing.Point(12, 51);
            this.sp_view.Name = "sp_view";
            this.sp_view.RowHeadersWidth = 62;
            this.sp_view.RowTemplate.Height = 20;
            this.sp_view.RowTemplate.ReadOnly = true;
            this.sp_view.Size = new System.Drawing.Size(485, 387);
            this.sp_view.TabIndex = 1;
            // 
            // butt_PhoBien
            // 
            this.butt_PhoBien.Location = new System.Drawing.Point(514, 9);
            this.butt_PhoBien.Name = "butt_PhoBien";
            this.butt_PhoBien.Size = new System.Drawing.Size(136, 36);
            this.butt_PhoBien.TabIndex = 3;
            this.butt_PhoBien.Text = "Phổ biến";
            this.butt_PhoBien.UseVisualStyleBackColor = true;
            this.butt_PhoBien.Click += new System.EventHandler(this.butt_PhoBien_Click);
            // 
            // button_BanChay
            // 
            this.button_BanChay.Location = new System.Drawing.Point(656, 9);
            this.button_BanChay.Name = "button_BanChay";
            this.button_BanChay.Size = new System.Drawing.Size(132, 36);
            this.button_BanChay.TabIndex = 4;
            this.button_BanChay.Text = "Bán chạy";
            this.button_BanChay.UseVisualStyleBackColor = true;
            this.button_BanChay.Click += new System.EventHandler(this.button_BanChay_Click);
            // 
            // butt_DatHang
            // 
            this.butt_DatHang.Location = new System.Drawing.Point(656, 402);
            this.butt_DatHang.Name = "butt_DatHang";
            this.butt_DatHang.Size = new System.Drawing.Size(132, 36);
            this.butt_DatHang.TabIndex = 6;
            this.butt_DatHang.Text = "Đặt Hàng";
            this.butt_DatHang.UseVisualStyleBackColor = true;
            // 
            // butt_DangNhap
            // 
            this.butt_DangNhap.Location = new System.Drawing.Point(656, 51);
            this.butt_DangNhap.Name = "butt_DangNhap";
            this.butt_DangNhap.Size = new System.Drawing.Size(132, 36);
            this.butt_DangNhap.TabIndex = 5;
            this.butt_DangNhap.Text = "Đăng Nhập";
            this.butt_DangNhap.UseVisualStyleBackColor = true;
            // 
            // butt_DangKy
            // 
            this.butt_DangKy.Location = new System.Drawing.Point(514, 51);
            this.butt_DangKy.Name = "butt_DangKy";
            this.butt_DangKy.Size = new System.Drawing.Size(136, 36);
            this.butt_DangKy.TabIndex = 7;
            this.butt_DangKy.Text = "Đăng Ký";
            this.butt_DangKy.UseVisualStyleBackColor = true;
            // 
            // Guest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butt_DangKy);
            this.Controls.Add(this.butt_DatHang);
            this.Controls.Add(this.butt_DangNhap);
            this.Controls.Add(this.button_BanChay);
            this.Controls.Add(this.butt_PhoBien);
            this.Controls.Add(this.sp_view);
            this.Controls.Add(this.butt_search);
            this.Controls.Add(this.tb_name);
            this.Name = "Guest";
            this.Text = "Guest";
            ((System.ComponentModel.ISupportInitialize)(this.sp_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Button butt_search;
        private System.Windows.Forms.DataGridView sp_view;
        private System.Windows.Forms.Button butt_PhoBien;
        private System.Windows.Forms.Button button_BanChay;
        private System.Windows.Forms.Button butt_DatHang;
        private System.Windows.Forms.Button butt_DangNhap;
        private System.Windows.Forms.Button butt_DangKy;
    }
}

