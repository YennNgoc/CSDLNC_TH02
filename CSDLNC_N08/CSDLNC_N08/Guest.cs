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

        List<string> list_SP;
        List<int> list_SL;
        public Guest()
        {
            list_SP = new List<string>();
            list_SL = new List<int>();
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
                cmd.CommandText = "select * from SanPham order by SoLuotXem DESC";
                //cmd.CommandType = CommandType.StoredProcedure;G
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

        private void listSP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cSDLNCDataSet.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter.Fill(this.cSDLNCDataSet.SanPham);

        }

        private void butt_Add_Click(object sender, EventArgs e)
        {
            string s = cb_Name.Text;
            if ( s != "" && tb_Num.Text != "")
            {
                list_SP.Add(s);
                int x = 0;
                if (Int32.TryParse(tb_Num.Text, out x))
                {
                    list_SL.Add(x);
                }
                GioHang.Items.Add(s.ToUpper() + " \t Số lượng:  " + tb_Num.Text.ToUpper());
                tb_name.Clear();
                tb_Num.Clear();

                tb_name.Focus();
            }
            else
                MessageBox.Show("Vui lòng cung cấp thông tin sản phẩm");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void butt_Xoa_Click(object sender, EventArgs e)
        {
            if (GioHang.Items.Count > 0)
            {
                GioHang.Items.Remove(GioHang.SelectedItem);
                
            }
        }

        private void butt_DatHang_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ICEBEAR-PC\YENNGOCC;Database=CSDLNC;Persist Security Info=True;User ID=guest;Password=1234567");
            con.Open();
            SqlCommand cmd_res = con.CreateCommand();
            cmd_res.CommandText = "DELETE from GioHang where IDNguoiMua=@id";
            cmd_res.Parameters.Add("@id", SqlDbType.Char, 8).Value = "id000001";
            cmd_res.ExecuteNonQuery();
            if (list_SL.Count==0)
            {
                cmd_res.CommandText = "select * from GioHang where IDNguoiMua=@id";
                //cmd_res.Parameters.Add("@id", SqlDbType.Char, 8).Value = "id000001";
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd_res;
                DataTable dt = new DataTable();
                da.Fill(dt);
                sp_view.DataSource = dt;
            }
            else
            {     
                for (var i = 0; i < list_SL.Count; i++)
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "sp_taoDSMuaHang";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@SP", SqlDbType.Char, 10).Value = list_SP[i].ToString();
                    cmd.Parameters.Add("@SL", SqlDbType.Int, 4).Value = list_SL[i];
                    cmd.Parameters.Add("@id", SqlDbType.Char, 10).Value = "id000001";
                    //cmd.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    sp_view.DataSource = dt;
                    //MessageBox.Show(list_SP[i], list_SL[i].ToString());
                
                }
            }

        }

        private void butt_Cancel_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ICEBEAR-PC\YENNGOCC;Database=CSDLNC;Persist Security Info=True;User ID=guest;Password=1234567");
            con.Open();
            SqlCommand cmd_res = con.CreateCommand();
            cmd_res.CommandText = "delete GioHang where IDNguoiMua=@id";
            cmd_res.Parameters.Add("@id", SqlDbType.Char, 8).Value = "id000001";
            cmd_res.ExecuteNonQuery();
            GioHang.Items.Clear();
            list_SL.Clear();
            list_SP.Clear();
        }

        private void butt_Order_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ICEBEAR-PC\YENNGOCC;Database=CSDLNC;Persist Security Info=True;User ID=guest;Password=1234567");
            con.Open();
            SqlCommand cmd_res = con.CreateCommand();
            cmd_res.CommandText = "DELETE from GioHang where IDNguoiMua=@id";
            cmd_res.Parameters.Add("@id", SqlDbType.Char, 8).Value = "id000001";
            cmd_res.ExecuteNonQuery();
            if (list_SL.Count == 0)
            {
                MessageBox.Show("Không có SP");
            }
            else
            {
                for (var i = 0; i < list_SL.Count; i++)
                {
                    
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "sp_taoDSMuaHang";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@SP", SqlDbType.Char, 10).Value = list_SP[i].ToString();
                    cmd.Parameters.Add("@SL", SqlDbType.Int, 4).Value = list_SL[i];
                    cmd.Parameters.Add("@id", SqlDbType.Char, 10).Value = "id000001";
                    //cmd.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    sp_view.DataSource = dt;
                    //MessageBox.Show(list_SP[i], list_SL[i].ToString());

                }
            }
            DonHang fr = new DonHang();
            fr.Show();
            this.Hide();
            
        }
    }
}
