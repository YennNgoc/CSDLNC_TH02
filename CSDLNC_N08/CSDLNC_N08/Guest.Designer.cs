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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.butt_search = new System.Windows.Forms.Button();
            this.sp_view = new System.Windows.Forms.DataGridView();
            this.butt_PhoBien = new System.Windows.Forms.Button();
            this.button_BanChay = new System.Windows.Forms.Button();
            this.butt_Check = new System.Windows.Forms.Button();
            this.butt_DangNhap = new System.Windows.Forms.Button();
            this.butt_DangKy = new System.Windows.Forms.Button();
            this.GioHang = new System.Windows.Forms.ListBox();
            this.cSDLNCDataSet = new CSDLNC_N08.CSDLNCDataSet();
            this.sanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sanPhamTableAdapter = new CSDLNC_N08.CSDLNCDataSetTableAdapters.SanPhamTableAdapter();
            this.butt_Add = new System.Windows.Forms.Button();
            this.tb_Num = new System.Windows.Forms.TextBox();
            this.cb_Name = new System.Windows.Forms.ComboBox();
            this.butt_Xoa = new System.Windows.Forms.Button();
            this.butt_Cancel = new System.Windows.Forms.Button();
            this.butt_Order = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sp_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSDLNCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).BeginInit();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sp_view.DefaultCellStyle = dataGridViewCellStyle1;
            this.sp_view.Location = new System.Drawing.Point(12, 94);
            this.sp_view.Name = "sp_view";
            this.sp_view.RowHeadersWidth = 62;
            this.sp_view.RowTemplate.Height = 20;
            this.sp_view.RowTemplate.ReadOnly = true;
            this.sp_view.Size = new System.Drawing.Size(776, 344);
            this.sp_view.TabIndex = 1;
            // 
            // butt_PhoBien
            // 
            this.butt_PhoBien.Location = new System.Drawing.Point(12, 51);
            this.butt_PhoBien.Name = "butt_PhoBien";
            this.butt_PhoBien.Size = new System.Drawing.Size(136, 36);
            this.butt_PhoBien.TabIndex = 3;
            this.butt_PhoBien.Text = "Phổ biến";
            this.butt_PhoBien.UseVisualStyleBackColor = true;
            this.butt_PhoBien.Click += new System.EventHandler(this.butt_PhoBien_Click);
            // 
            // button_BanChay
            // 
            this.button_BanChay.Location = new System.Drawing.Point(154, 51);
            this.button_BanChay.Name = "button_BanChay";
            this.button_BanChay.Size = new System.Drawing.Size(132, 36);
            this.button_BanChay.TabIndex = 4;
            this.button_BanChay.Text = "Bán chạy";
            this.button_BanChay.UseVisualStyleBackColor = true;
            this.button_BanChay.Click += new System.EventHandler(this.button_BanChay_Click);
            // 
            // butt_Check
            // 
            this.butt_Check.Location = new System.Drawing.Point(794, 176);
            this.butt_Check.Name = "butt_Check";
            this.butt_Check.Size = new System.Drawing.Size(86, 36);
            this.butt_Check.TabIndex = 6;
            this.butt_Check.Text = "Xem";
            this.butt_Check.UseVisualStyleBackColor = true;
            this.butt_Check.Click += new System.EventHandler(this.butt_DatHang_Click);
            // 
            // butt_DangNhap
            // 
            this.butt_DangNhap.Location = new System.Drawing.Point(656, 9);
            this.butt_DangNhap.Name = "butt_DangNhap";
            this.butt_DangNhap.Size = new System.Drawing.Size(132, 36);
            this.butt_DangNhap.TabIndex = 5;
            this.butt_DangNhap.Text = "Đăng Nhập";
            this.butt_DangNhap.UseVisualStyleBackColor = true;
            // 
            // butt_DangKy
            // 
            this.butt_DangKy.Location = new System.Drawing.Point(514, 9);
            this.butt_DangKy.Name = "butt_DangKy";
            this.butt_DangKy.Size = new System.Drawing.Size(136, 36);
            this.butt_DangKy.TabIndex = 7;
            this.butt_DangKy.Text = "Đăng Ký";
            this.butt_DangKy.UseVisualStyleBackColor = true;
            // 
            // GioHang
            // 
            this.GioHang.FormattingEnabled = true;
            this.GioHang.ItemHeight = 20;
            this.GioHang.Location = new System.Drawing.Point(794, 9);
            this.GioHang.Name = "GioHang";
            this.GioHang.Size = new System.Drawing.Size(185, 84);
            this.GioHang.TabIndex = 8;
            // 
            // cSDLNCDataSet
            // 
            this.cSDLNCDataSet.DataSetName = "CSDLNCDataSet";
            this.cSDLNCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sanPhamBindingSource
            // 
            this.sanPhamBindingSource.DataMember = "SanPham";
            this.sanPhamBindingSource.DataSource = this.cSDLNCDataSet;
            // 
            // sanPhamTableAdapter
            // 
            this.sanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // butt_Add
            // 
            this.butt_Add.Location = new System.Drawing.Point(794, 133);
            this.butt_Add.Name = "butt_Add";
            this.butt_Add.Size = new System.Drawing.Size(86, 37);
            this.butt_Add.TabIndex = 9;
            this.butt_Add.Text = "Thêm";
            this.butt_Add.UseVisualStyleBackColor = true;
            this.butt_Add.Click += new System.EventHandler(this.butt_Add_Click);
            // 
            // tb_Num
            // 
            this.tb_Num.Location = new System.Drawing.Point(915, 99);
            this.tb_Num.Name = "tb_Num";
            this.tb_Num.Size = new System.Drawing.Size(64, 26);
            this.tb_Num.TabIndex = 11;
            // 
            // cb_Name
            // 
            this.cb_Name.DataSource = this.sanPhamBindingSource;
            this.cb_Name.DisplayMember = "MaSP";
            this.cb_Name.FormattingEnabled = true;
            this.cb_Name.Location = new System.Drawing.Point(794, 99);
            this.cb_Name.Name = "cb_Name";
            this.cb_Name.Size = new System.Drawing.Size(110, 28);
            this.cb_Name.TabIndex = 12;
            // 
            // butt_Xoa
            // 
            this.butt_Xoa.Location = new System.Drawing.Point(886, 133);
            this.butt_Xoa.Name = "butt_Xoa";
            this.butt_Xoa.Size = new System.Drawing.Size(93, 37);
            this.butt_Xoa.TabIndex = 13;
            this.butt_Xoa.Text = "Xóa";
            this.butt_Xoa.UseVisualStyleBackColor = true;
            this.butt_Xoa.Click += new System.EventHandler(this.butt_Xoa_Click);
            // 
            // butt_Cancel
            // 
            this.butt_Cancel.Location = new System.Drawing.Point(886, 176);
            this.butt_Cancel.Name = "butt_Cancel";
            this.butt_Cancel.Size = new System.Drawing.Size(93, 37);
            this.butt_Cancel.TabIndex = 14;
            this.butt_Cancel.Text = "Hủy";
            this.butt_Cancel.UseVisualStyleBackColor = true;
            this.butt_Cancel.Click += new System.EventHandler(this.butt_Cancel_Click);
            // 
            // butt_Order
            // 
            this.butt_Order.Location = new System.Drawing.Point(794, 219);
            this.butt_Order.Name = "butt_Order";
            this.butt_Order.Size = new System.Drawing.Size(185, 37);
            this.butt_Order.TabIndex = 15;
            this.butt_Order.Text = "Đặt hàng";
            this.butt_Order.UseVisualStyleBackColor = true;
            this.butt_Order.Click += new System.EventHandler(this.butt_Order_Click);
            // 
            // Guest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 450);
            this.Controls.Add(this.butt_Order);
            this.Controls.Add(this.butt_Cancel);
            this.Controls.Add(this.butt_Xoa);
            this.Controls.Add(this.cb_Name);
            this.Controls.Add(this.tb_Num);
            this.Controls.Add(this.butt_Add);
            this.Controls.Add(this.GioHang);
            this.Controls.Add(this.butt_DangKy);
            this.Controls.Add(this.butt_Check);
            this.Controls.Add(this.butt_DangNhap);
            this.Controls.Add(this.button_BanChay);
            this.Controls.Add(this.butt_PhoBien);
            this.Controls.Add(this.sp_view);
            this.Controls.Add(this.butt_search);
            this.Controls.Add(this.tb_name);
            this.Name = "Guest";
            this.Text = "Guest";
            this.Load += new System.EventHandler(this.listSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSDLNCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Button butt_search;
        private System.Windows.Forms.DataGridView sp_view;
        private System.Windows.Forms.Button butt_PhoBien;
        private System.Windows.Forms.Button button_BanChay;
        private System.Windows.Forms.Button butt_Check;
        private System.Windows.Forms.Button butt_DangNhap;
        private System.Windows.Forms.Button butt_DangKy;
        private System.Windows.Forms.ListBox GioHang;
        private CSDLNCDataSet cSDLNCDataSet;
        private System.Windows.Forms.BindingSource sanPhamBindingSource;
        private CSDLNCDataSetTableAdapters.SanPhamTableAdapter sanPhamTableAdapter;
        private System.Windows.Forms.Button butt_Add;
        private System.Windows.Forms.TextBox tb_Num;
        private System.Windows.Forms.ComboBox cb_Name;
        private System.Windows.Forms.Button butt_Xoa;
        private System.Windows.Forms.Button butt_Cancel;
        private System.Windows.Forms.Button butt_Order;
    }
}

