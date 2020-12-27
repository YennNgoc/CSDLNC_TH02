namespace CSDLNC_N08
{
    partial class Customer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.butt_search = new System.Windows.Forms.Button();
            this.sp_view = new System.Windows.Forms.DataGridView();
            this.butt_PhoBien = new System.Windows.Forms.Button();
            this.button_BanChay = new System.Windows.Forms.Button();
            this.butt_Check = new System.Windows.Forms.Button();
            this.butt_DangKy = new System.Windows.Forms.Button();
            this.GioHang = new System.Windows.Forms.ListBox();
            this.cSDLNCDataSet = new CSDLNC_N08.CSDLNCDataSet();
            this.sanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sanPhamTableAdapter = new CSDLNC_N08.CSDLNCDataSetTableAdapters.SanPhamTableAdapter();
            this.butt_Add = new System.Windows.Forms.Button();
            this.tb_Num = new System.Windows.Forms.TextBox();
            this.cb_Name = new System.Windows.Forms.ComboBox();
            this.butt_Cancel = new System.Windows.Forms.Button();
            this.butt_Order = new System.Windows.Forms.Button();
            this.hd_view = new System.Windows.Forms.DataGridView();
            this.butt_wait = new System.Windows.Forms.Button();
            this.butt_checked = new System.Windows.Forms.Button();
            this.butt_done = new System.Windows.Forms.Button();
            this.butt_get = new System.Windows.Forms.Button();
            this.butt_rate = new System.Windows.Forms.Button();
            this.butt_pay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_MA = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sp_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSDLNCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hd_view)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(169, 19);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(381, 26);
            this.tb_name.TabIndex = 0;
            // 
            // butt_search
            // 
            this.butt_search.Location = new System.Drawing.Point(556, 16);
            this.butt_search.Name = "butt_search";
            this.butt_search.Size = new System.Drawing.Size(74, 32);
            this.butt_search.TabIndex = 1;
            this.butt_search.Text = "Tìm";
            this.butt_search.UseVisualStyleBackColor = true;
            this.butt_search.Click += new System.EventHandler(this.butt_search_Click);
            // 
            // sp_view
            // 
            this.sp_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sp_view.DefaultCellStyle = dataGridViewCellStyle2;
            this.sp_view.Location = new System.Drawing.Point(12, 94);
            this.sp_view.Name = "sp_view";
            this.sp_view.RowHeadersWidth = 62;
            this.sp_view.RowTemplate.Height = 20;
            this.sp_view.RowTemplate.ReadOnly = true;
            this.sp_view.Size = new System.Drawing.Size(618, 344);
            this.sp_view.TabIndex = 1;
            // 
            // butt_PhoBien
            // 
            this.butt_PhoBien.Location = new System.Drawing.Point(12, 51);
            this.butt_PhoBien.Name = "butt_PhoBien";
            this.butt_PhoBien.Size = new System.Drawing.Size(141, 36);
            this.butt_PhoBien.TabIndex = 3;
            this.butt_PhoBien.Text = "Phổ biến";
            this.butt_PhoBien.UseVisualStyleBackColor = true;
            this.butt_PhoBien.Click += new System.EventHandler(this.butt_PhoBien_Click);
            // 
            // button_BanChay
            // 
            this.button_BanChay.Location = new System.Drawing.Point(169, 51);
            this.button_BanChay.Name = "button_BanChay";
            this.button_BanChay.Size = new System.Drawing.Size(141, 36);
            this.button_BanChay.TabIndex = 4;
            this.button_BanChay.Text = "Bán chạy";
            this.button_BanChay.UseVisualStyleBackColor = true;
            this.button_BanChay.Click += new System.EventHandler(this.button_BanChay_Click);
            // 
            // butt_Check
            // 
            this.butt_Check.Location = new System.Drawing.Point(928, 59);
            this.butt_Check.Name = "butt_Check";
            this.butt_Check.Size = new System.Drawing.Size(86, 30);
            this.butt_Check.TabIndex = 6;
            this.butt_Check.Text = "Xem";
            this.butt_Check.UseVisualStyleBackColor = true;
            this.butt_Check.Click += new System.EventHandler(this.butt_DatHang_Click);
            // 
            // butt_DangKy
            // 
            this.butt_DangKy.Location = new System.Drawing.Point(489, 51);
            this.butt_DangKy.Name = "butt_DangKy";
            this.butt_DangKy.Size = new System.Drawing.Size(141, 36);
            this.butt_DangKy.TabIndex = 7;
            this.butt_DangKy.Text = "Đăng Ký Bán";
            this.butt_DangKy.UseVisualStyleBackColor = true;
            // 
            // GioHang
            // 
            this.GioHang.FormattingEnabled = true;
            this.GioHang.ItemHeight = 20;
            this.GioHang.Location = new System.Drawing.Point(648, 61);
            this.GioHang.Name = "GioHang";
            this.GioHang.Size = new System.Drawing.Size(184, 64);
            this.GioHang.TabIndex = 8;
            this.GioHang.SelectedIndexChanged += new System.EventHandler(this.GioHang_SelectedIndexChanged);
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
            this.butt_Add.Location = new System.Drawing.Point(836, 59);
            this.butt_Add.Name = "butt_Add";
            this.butt_Add.Size = new System.Drawing.Size(86, 30);
            this.butt_Add.TabIndex = 9;
            this.butt_Add.Text = "Thêm";
            this.butt_Add.UseVisualStyleBackColor = true;
            this.butt_Add.Click += new System.EventHandler(this.butt_Add_Click);
            // 
            // tb_Num
            // 
            this.tb_Num.Location = new System.Drawing.Point(768, 19);
            this.tb_Num.Name = "tb_Num";
            this.tb_Num.Size = new System.Drawing.Size(64, 26);
            this.tb_Num.TabIndex = 11;
            // 
            // cb_Name
            // 
            this.cb_Name.DataSource = this.sanPhamBindingSource;
            this.cb_Name.DisplayMember = "MaSP";
            this.cb_Name.FormattingEnabled = true;
            this.cb_Name.Location = new System.Drawing.Point(645, 17);
            this.cb_Name.Name = "cb_Name";
            this.cb_Name.Size = new System.Drawing.Size(108, 28);
            this.cb_Name.TabIndex = 12;
            // 
            // butt_Cancel
            // 
            this.butt_Cancel.Location = new System.Drawing.Point(835, 95);
            this.butt_Cancel.Name = "butt_Cancel";
            this.butt_Cancel.Size = new System.Drawing.Size(87, 30);
            this.butt_Cancel.TabIndex = 14;
            this.butt_Cancel.Text = "Hủy";
            this.butt_Cancel.UseVisualStyleBackColor = true;
            this.butt_Cancel.Click += new System.EventHandler(this.butt_Cancel_Click);
            // 
            // butt_Order
            // 
            this.butt_Order.Location = new System.Drawing.Point(928, 95);
            this.butt_Order.Name = "butt_Order";
            this.butt_Order.Size = new System.Drawing.Size(86, 30);
            this.butt_Order.TabIndex = 15;
            this.butt_Order.Text = "Đặt hàng";
            this.butt_Order.UseVisualStyleBackColor = true;
            this.butt_Order.Click += new System.EventHandler(this.butt_Order_Click);
            // 
            // hd_view
            // 
            this.hd_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hd_view.Location = new System.Drawing.Point(646, 215);
            this.hd_view.Name = "hd_view";
            this.hd_view.RowHeadersWidth = 62;
            this.hd_view.RowTemplate.Height = 28;
            this.hd_view.Size = new System.Drawing.Size(368, 148);
            this.hd_view.TabIndex = 16;
            // 
            // butt_wait
            // 
            this.butt_wait.Location = new System.Drawing.Point(645, 175);
            this.butt_wait.Name = "butt_wait";
            this.butt_wait.Size = new System.Drawing.Size(119, 34);
            this.butt_wait.TabIndex = 17;
            this.butt_wait.Text = "Chờ xử lý";
            this.butt_wait.UseVisualStyleBackColor = true;
            this.butt_wait.Click += new System.EventHandler(this.butt_wait_Click);
            // 
            // butt_checked
            // 
            this.butt_checked.Location = new System.Drawing.Point(770, 175);
            this.butt_checked.Name = "butt_checked";
            this.butt_checked.Size = new System.Drawing.Size(119, 34);
            this.butt_checked.TabIndex = 18;
            this.butt_checked.Text = "Đang giao";
            this.butt_checked.UseVisualStyleBackColor = true;
            this.butt_checked.Click += new System.EventHandler(this.butt_checked_Click);
            // 
            // butt_done
            // 
            this.butt_done.Location = new System.Drawing.Point(895, 175);
            this.butt_done.Name = "butt_done";
            this.butt_done.Size = new System.Drawing.Size(119, 34);
            this.butt_done.TabIndex = 19;
            this.butt_done.Text = "Đã mua";
            this.butt_done.UseVisualStyleBackColor = true;
            this.butt_done.Click += new System.EventHandler(this.butt_done_Click);
            // 
            // butt_get
            // 
            this.butt_get.Location = new System.Drawing.Point(840, 372);
            this.butt_get.Name = "butt_get";
            this.butt_get.Size = new System.Drawing.Size(174, 30);
            this.butt_get.TabIndex = 22;
            this.butt_get.Text = "Đã nhận";
            this.butt_get.UseVisualStyleBackColor = true;
            this.butt_get.Click += new System.EventHandler(this.butt_get_Click);
            // 
            // butt_rate
            // 
            this.butt_rate.Location = new System.Drawing.Point(648, 408);
            this.butt_rate.Name = "butt_rate";
            this.butt_rate.Size = new System.Drawing.Size(174, 30);
            this.butt_rate.TabIndex = 23;
            this.butt_rate.Text = "Đánh giá";
            this.butt_rate.UseVisualStyleBackColor = true;
            // 
            // butt_pay
            // 
            this.butt_pay.Location = new System.Drawing.Point(840, 408);
            this.butt_pay.Name = "butt_pay";
            this.butt_pay.Size = new System.Drawing.Size(174, 30);
            this.butt_pay.TabIndex = 24;
            this.butt_pay.Text = "Thanh toán";
            this.butt_pay.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(709, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 29);
            this.label1.TabIndex = 25;
            this.label1.Text = "ĐƠN HÀNG CỦA BẠN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(856, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 29);
            this.label2.TabIndex = 26;
            this.label2.Text = "MUA HÀNG";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tb_id
            // 
            this.tb_id.BackColor = System.Drawing.SystemColors.GrayText;
            this.tb_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_id.Location = new System.Drawing.Point(12, 21);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(141, 23);
            this.tb_id.TabIndex = 27;
            this.tb_id.TextChanged += new System.EventHandler(this.tb_id_TextChanged);
            // 
            // tb_MA
            // 
            this.tb_MA.Location = new System.Drawing.Point(648, 373);
            this.tb_MA.Name = "tb_MA";
            this.tb_MA.Size = new System.Drawing.Size(176, 26);
            this.tb_MA.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 36);
            this.button1.TabIndex = 29;
            this.button1.Text = "Theo Đại Lý";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1026, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_MA);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butt_pay);
            this.Controls.Add(this.butt_rate);
            this.Controls.Add(this.butt_get);
            this.Controls.Add(this.butt_done);
            this.Controls.Add(this.butt_checked);
            this.Controls.Add(this.butt_wait);
            this.Controls.Add(this.hd_view);
            this.Controls.Add(this.butt_Order);
            this.Controls.Add(this.butt_Cancel);
            this.Controls.Add(this.cb_Name);
            this.Controls.Add(this.tb_Num);
            this.Controls.Add(this.butt_Add);
            this.Controls.Add(this.GioHang);
            this.Controls.Add(this.butt_DangKy);
            this.Controls.Add(this.butt_Check);
            this.Controls.Add(this.button_BanChay);
            this.Controls.Add(this.butt_PhoBien);
            this.Controls.Add(this.sp_view);
            this.Controls.Add(this.butt_search);
            this.Controls.Add(this.tb_name);
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Customer_FormClosing);
            this.Load += new System.EventHandler(this.listSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSDLNCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hd_view)).EndInit();
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
        private System.Windows.Forms.Button butt_DangKy;
        private System.Windows.Forms.ListBox GioHang;
        private CSDLNCDataSet cSDLNCDataSet;
        private System.Windows.Forms.BindingSource sanPhamBindingSource;
        private CSDLNCDataSetTableAdapters.SanPhamTableAdapter sanPhamTableAdapter;
        private System.Windows.Forms.Button butt_Add;
        private System.Windows.Forms.TextBox tb_Num;
        private System.Windows.Forms.ComboBox cb_Name;
        private System.Windows.Forms.Button butt_Cancel;
        private System.Windows.Forms.Button butt_Order;
        private System.Windows.Forms.DataGridView hd_view;
        private System.Windows.Forms.Button butt_wait;
        private System.Windows.Forms.Button butt_checked;
        private System.Windows.Forms.Button butt_done;
        private System.Windows.Forms.Button butt_get;
        private System.Windows.Forms.Button butt_rate;
        private System.Windows.Forms.Button butt_pay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_MA;
        private System.Windows.Forms.Button button1;
    }
}

