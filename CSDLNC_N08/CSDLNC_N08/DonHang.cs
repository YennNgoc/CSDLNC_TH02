﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CSDLNC_N08
{
    public partial class DonHang : Form
    {
        DataTable tb = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable tb_CT = new DataTable();
        SqlConnection con = new SqlConnection(@"Data Source=ICEBEAR-PC\YENNGOCC;Database=CSDLNC;Persist Security Info=True;User ID=guest;Password=1234567");
        public DonHang()
        {
            InitializeComponent();
            con.Open();
            SqlCommand cmd_res = con.CreateCommand();
            cmd_res.CommandText = "sp_taoDonHang";
            cmd_res.CommandType = CommandType.StoredProcedure;
            cmd_res.Parameters.Add("@id", SqlDbType.Char, 8).Value = "id000001";
            //cmd_res.ExecuteNonQuery();
            da.SelectCommand = cmd_res;
            da.Fill(tb);
            bindingNavigator1.BindingSource.DataSource = tb;
            textBox1.DataBindings.Add("Text", tb, "MaHD");
            textBox2.DataBindings.Add("Text", tb, "MaTT");
            textBox3.DataBindings.Add("Text", tb, "MaVC");
            textBox4.DataBindings.Add("Text", tb, "MaKM");
            textBox5.DataBindings.Add("Text", tb, "ThanhTien");

            CT_Load();


        }
        public void CT_Load()
        {

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from ChiTietHoaDon where MaHD= @maHD";
            cmd.Parameters.Add("@maHD", SqlDbType.Char, 8).Value = textBox1.Text;
            DataTable tb_CT = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter();
            da2.SelectCommand = cmd;
            da2.Fill(tb_CT);
            dataGridView1.DataSource = tb_CT;

        }
        private void DonHang_Load(object sender, EventArgs e)
        {

            // tao HD  
            
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            CurrencyManager cm = (CurrencyManager)this.BindingContext[tb];
            if (cm.Position < cm.Count - 1)
            {
                cm.Position++;
                CT_Load();
            }
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            if (this.BindingContext[tb].Position > 0)
            {
                this.BindingContext[tb].Position--;
                CT_Load();
            }
        }

        private void butt_OK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tao ls giao dich");
        }

        private void butt_CANC_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Da huy don hang");
        }

        private void butt_CANCAlll_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ve lai trang chu");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }

       
}