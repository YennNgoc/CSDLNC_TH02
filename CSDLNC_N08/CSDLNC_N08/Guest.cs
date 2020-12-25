using System;
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
   
    public partial class Guest : Form
    {
        public Guest()
        {
            InitializeComponent();
        }

        private void butt_search_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ICEBEAR-PC\YENNGOCC;Database=CSDLNC;Persist Security Info=True;User ID=guest;Password=1234567");
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select * from SanPham";
                //cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                sp_view.DataSource = dt;
            }
            catch (SqlException)
            {
                MessageBox.Show("lalala");
            }
            
        }

        private void butt_PhoBien_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=ICEBEAR-PC\YENNGOCC;Database=CSDLNC;Persist Security Info=True;User ID=guest;Password=1234567");
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select TenSP, DonGia, MoTa, Rating from SanPham order by SoLuotXem DESC";
                //cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                sp_view.DataSource = dt;
            }
            catch (SqlException)
            {
                MessageBox.Show("lalala");
            }
        }

        private void button_BanChay_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=ICEBEAR-PC\YENNGOCC;Database=CSDLNC;Persist Security Info=True;User ID=guest;Password=1234567");
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select * from SanPham order by SoLuotMua DESC";
                //cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                sp_view.DataSource = dt;
            }

            catch (SqlException)
            {
                MessageBox.Show("lalala");
            }
        }

    }
}
