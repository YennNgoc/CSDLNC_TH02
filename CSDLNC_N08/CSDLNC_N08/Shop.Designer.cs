namespace CSDLNC_N08
{
    partial class Shop
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sp_view = new System.Windows.Forms.DataGridView();
            this.butt_stat = new System.Windows.Forms.Button();
            this.butt_HotItem = new System.Windows.Forms.Button();
            this.maSP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_SL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hd_view = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.butt_queue = new System.Windows.Forms.Button();
            this.butt_deli = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.butt_eco = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.butt_get = new System.Windows.Forms.Button();
            this.butt_Done = new System.Windows.Forms.Button();
            this.tb_MA = new System.Windows.Forms.TextBox();
            this.butt_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sp_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hd_view)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_view
            // 
            this.sp_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sp_view.DefaultCellStyle = dataGridViewCellStyle5;
            this.sp_view.Location = new System.Drawing.Point(12, 53);
            this.sp_view.Name = "sp_view";
            this.sp_view.RowHeadersWidth = 62;
            this.sp_view.RowTemplate.Height = 20;
            this.sp_view.RowTemplate.ReadOnly = true;
            this.sp_view.Size = new System.Drawing.Size(499, 216);
            this.sp_view.TabIndex = 2;
            // 
            // butt_stat
            // 
            this.butt_stat.Location = new System.Drawing.Point(192, 11);
            this.butt_stat.Name = "butt_stat";
            this.butt_stat.Size = new System.Drawing.Size(173, 36);
            this.butt_stat.TabIndex = 4;
            this.butt_stat.Text = "Thống kê Sản phẩm";
            this.butt_stat.UseMnemonic = false;
            this.butt_stat.UseVisualStyleBackColor = true;
            // 
            // butt_HotItem
            // 
            this.butt_HotItem.Location = new System.Drawing.Point(386, 11);
            this.butt_HotItem.Name = "butt_HotItem";
            this.butt_HotItem.Size = new System.Drawing.Size(125, 36);
            this.butt_HotItem.TabIndex = 5;
            this.butt_HotItem.Text = "Top bán chạy";
            this.butt_HotItem.UseMnemonic = false;
            this.butt_HotItem.UseVisualStyleBackColor = true;
            this.butt_HotItem.Click += new System.EventHandler(this.butt_HotItem_Click);
            // 
            // maSP
            // 
            this.maSP.Location = new System.Drawing.Point(616, 53);
            this.maSP.Name = "maSP";
            this.maSP.Size = new System.Drawing.Size(151, 26);
            this.maSP.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(576, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 29);
            this.label2.TabIndex = 27;
            this.label2.Text = "THÊM HÀNG";
            // 
            // tb_SL
            // 
            this.tb_SL.Location = new System.Drawing.Point(616, 85);
            this.tb_SL.Name = "tb_SL";
            this.tb_SL.Size = new System.Drawing.Size(151, 26);
            this.tb_SL.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(586, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 29);
            this.label1.TabIndex = 29;
            this.label1.Text = "DOANH THU";
            // 
            // hd_view
            // 
            this.hd_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.hd_view.DefaultCellStyle = dataGridViewCellStyle6;
            this.hd_view.Location = new System.Drawing.Point(12, 275);
            this.hd_view.Name = "hd_view";
            this.hd_view.RowHeadersWidth = 62;
            this.hd_view.RowTemplate.Height = 20;
            this.hd_view.RowTemplate.ReadOnly = true;
            this.hd_view.Size = new System.Drawing.Size(499, 163);
            this.hd_view.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(586, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 29);
            this.label3.TabIndex = 31;
            this.label3.Text = "ĐƠN HÀNG";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // butt_queue
            // 
            this.butt_queue.Location = new System.Drawing.Point(527, 330);
            this.butt_queue.Name = "butt_queue";
            this.butt_queue.Size = new System.Drawing.Size(127, 36);
            this.butt_queue.TabIndex = 32;
            this.butt_queue.Text = "Đợi xử lí";
            this.butt_queue.UseMnemonic = false;
            this.butt_queue.UseVisualStyleBackColor = true;
            this.butt_queue.Click += new System.EventHandler(this.butt_queue_Click);
            // 
            // butt_deli
            // 
            this.butt_deli.Location = new System.Drawing.Point(660, 330);
            this.butt_deli.Name = "butt_deli";
            this.butt_deli.Size = new System.Drawing.Size(128, 36);
            this.butt_deli.TabIndex = 33;
            this.butt_deli.Text = "Giao đơn";
            this.butt_deli.UseMnemonic = false;
            this.butt_deli.UseVisualStyleBackColor = true;
            this.butt_deli.Click += new System.EventHandler(this.butt_deli_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(527, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Từ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(527, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Đến";
            // 
            // butt_eco
            // 
            this.butt_eco.Location = new System.Drawing.Point(527, 256);
            this.butt_eco.Name = "butt_eco";
            this.butt_eco.Size = new System.Drawing.Size(261, 31);
            this.butt_eco.TabIndex = 38;
            this.butt_eco.Text = "Thống kê";
            this.butt_eco.UseMnemonic = false;
            this.butt_eco.UseVisualStyleBackColor = true;
            this.butt_eco.Click += new System.EventHandler(this.butt_eco_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(581, 194);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(207, 26);
            this.dateTimePicker1.TabIndex = 39;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(581, 224);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(207, 26);
            this.dateTimePicker2.TabIndex = 40;
            // 
            // tb_id
            // 
            this.tb_id.BackColor = System.Drawing.SystemColors.GrayText;
            this.tb_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_id.Location = new System.Drawing.Point(12, 15);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(136, 23);
            this.tb_id.TabIndex = 41;
            // 
            // butt_get
            // 
            this.butt_get.Location = new System.Drawing.Point(527, 408);
            this.butt_get.Name = "butt_get";
            this.butt_get.Size = new System.Drawing.Size(127, 30);
            this.butt_get.TabIndex = 43;
            this.butt_get.Text = "Đã nhận";
            this.butt_get.UseVisualStyleBackColor = true;
            this.butt_get.Click += new System.EventHandler(this.butt_get_Click);
            // 
            // butt_Done
            // 
            this.butt_Done.Location = new System.Drawing.Point(660, 408);
            this.butt_Done.Name = "butt_Done";
            this.butt_Done.Size = new System.Drawing.Size(128, 30);
            this.butt_Done.TabIndex = 44;
            this.butt_Done.Text = "Đã giao";
            this.butt_Done.UseVisualStyleBackColor = true;
            this.butt_Done.Click += new System.EventHandler(this.butt_Done_Click);
            // 
            // tb_MA
            // 
            this.tb_MA.Location = new System.Drawing.Point(527, 372);
            this.tb_MA.Name = "tb_MA";
            this.tb_MA.Size = new System.Drawing.Size(261, 26);
            this.tb_MA.TabIndex = 45;
            this.tb_MA.TextChanged += new System.EventHandler(this.tb_MA_TextChanged);
            // 
            // butt_add
            // 
            this.butt_add.Location = new System.Drawing.Point(527, 116);
            this.butt_add.Name = "butt_add";
            this.butt_add.Size = new System.Drawing.Size(261, 31);
            this.butt_add.TabIndex = 46;
            this.butt_add.Text = "Thống kê";
            this.butt_add.UseMnemonic = false;
            this.butt_add.UseVisualStyleBackColor = true;
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butt_add);
            this.Controls.Add(this.tb_MA);
            this.Controls.Add(this.butt_Done);
            this.Controls.Add(this.butt_get);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.butt_eco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.butt_deli);
            this.Controls.Add(this.butt_queue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hd_view);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_SL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maSP);
            this.Controls.Add(this.butt_HotItem);
            this.Controls.Add(this.butt_stat);
            this.Controls.Add(this.sp_view);
            this.Name = "Shop";
            this.Text = "Shop";
            ((System.ComponentModel.ISupportInitialize)(this.sp_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hd_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView sp_view;
        private System.Windows.Forms.Button butt_stat;
        private System.Windows.Forms.Button butt_HotItem;
        private System.Windows.Forms.TextBox maSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_SL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView hd_view;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butt_queue;
        private System.Windows.Forms.Button butt_deli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button butt_eco;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Button butt_get;
        private System.Windows.Forms.Button butt_Done;
        private System.Windows.Forms.TextBox tb_MA;
        private System.Windows.Forms.Button butt_add;
    }
}