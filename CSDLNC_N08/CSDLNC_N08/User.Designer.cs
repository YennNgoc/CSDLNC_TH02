namespace CSDLNC_N08
{
    partial class User
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
            this.butt_DatHang = new System.Windows.Forms.Button();
            this.button_BanChay = new System.Windows.Forms.Button();
            this.butt_PhoBien = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.butt_search = new System.Windows.Forms.Button();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // butt_DatHang
            // 
            this.butt_DatHang.Location = new System.Drawing.Point(656, 404);
            this.butt_DatHang.Name = "butt_DatHang";
            this.butt_DatHang.Size = new System.Drawing.Size(132, 36);
            this.butt_DatHang.TabIndex = 12;
            this.butt_DatHang.Text = "Đặt Hàng";
            this.butt_DatHang.UseVisualStyleBackColor = true;
            // 
            // button_BanChay
            // 
            this.button_BanChay.Location = new System.Drawing.Point(656, 11);
            this.button_BanChay.Name = "button_BanChay";
            this.button_BanChay.Size = new System.Drawing.Size(132, 36);
            this.button_BanChay.TabIndex = 11;
            this.button_BanChay.Text = "Bán chạy";
            this.button_BanChay.UseVisualStyleBackColor = true;
            // 
            // butt_PhoBien
            // 
            this.butt_PhoBien.Location = new System.Drawing.Point(514, 11);
            this.butt_PhoBien.Name = "butt_PhoBien";
            this.butt_PhoBien.Size = new System.Drawing.Size(136, 36);
            this.butt_PhoBien.TabIndex = 10;
            this.butt_PhoBien.Text = "Phổ biến";
            this.butt_PhoBien.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dataGridView1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(485, 387);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 0;
            // 
            // butt_search
            // 
            this.butt_search.Location = new System.Drawing.Point(423, 11);
            this.butt_search.Name = "butt_search";
            this.butt_search.Size = new System.Drawing.Size(74, 36);
            this.butt_search.TabIndex = 8;
            this.butt_search.Text = "Tìm";
            this.butt_search.UseVisualStyleBackColor = true;
            this.butt_search.Click += new System.EventHandler(this.butt_search_Click);
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(12, 21);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(405, 26);
            this.tb_name.TabIndex = 7;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(514, 91);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(274, 99);
            this.dataGridView2.TabIndex = 13;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.butt_DatHang);
            this.Controls.Add(this.button_BanChay);
            this.Controls.Add(this.butt_PhoBien);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.butt_search);
            this.Controls.Add(this.tb_name);
            this.Name = "User";
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butt_DatHang;
        private System.Windows.Forms.Button button_BanChay;
        private System.Windows.Forms.Button butt_PhoBien;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butt_search;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}