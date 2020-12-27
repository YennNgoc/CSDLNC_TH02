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
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(Account.connectString);
            con.Open(); SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select ID from DaiLy where Username=@usn";
            cmd.Parameters.Add("@usn", SqlDbType.Char, 8).Value = Account.username;
            Account.id = Convert.ToString(cmd.ExecuteScalar());
            //MessageBox.Show(Account.id);
            tb_id.Text = Account.id.ToString();
        }

        private void butt_queue_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Account.connectString);
            con.Open();
            SqlCommand cmd_res = con.CreateCommand();
            cmd_res.CommandText = "EXEC sp_set_session_context 'id_ban', @id; SELECT* FROM v_DonHangDL v where v.TinhTrang=N'Chờ xác nhận' and not exists (select * from v_DonHangKH ls where ls.ThoiGian>v.ThoiGian and ls.MaHD=v.MaHD) ";
            cmd_res.Parameters.Add("@id", SqlDbType.Char, 8).Value = Account.id;
            cmd_res.ExecuteNonQuery();
            SqlDataAdapter da_hd = new SqlDataAdapter();
            da_hd.SelectCommand = cmd_res;
            DataTable dt_hd = new DataTable();
            da_hd.Fill(dt_hd);
            hd_view.DataSource = dt_hd;
            
        }

        private void butt_get_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(Account.connectString);
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "sp_NhanDonHang";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@mahoadon", SqlDbType.Char, 10).Value = tb_MA.Text;
                MessageBox.Show("Da xac nhan");
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butt_deli_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Account.connectString);
            con.Open();
            SqlCommand cmd_res = con.CreateCommand();
            cmd_res.CommandText = "EXEC sp_set_session_context 'id_ban', @id; SELECT* FROM v_DonHangDL v where v.TinhTrang=N'Đã xác nhận' and not exists (select * from v_DonHangKH ls where ls.ThoiGian>v.ThoiGian and ls.MaHD=v.MaHD) ";
            cmd_res.Parameters.Add("@id", SqlDbType.Char, 8).Value = Account.id;
            cmd_res.ExecuteNonQuery();
            SqlDataAdapter da_hd = new SqlDataAdapter();
            da_hd.SelectCommand = cmd_res;
            DataTable dt_hd = new DataTable();
            da_hd.Fill(dt_hd);
            hd_view.DataSource = dt_hd;
            
        }

        private void butt_Done_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(Account.connectString);
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "sp_GiaoDonHang";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@mahoadon", SqlDbType.Char, 10).Value = tb_MA.Text;
                cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        private void butt_eco_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Account.connectString);
            con.Open();
            SqlCommand cmd_res = con.CreateCommand();
            cmd_res.CommandText = "sp_DaiLy_TongHDvaDoanhThu_between";
            cmd_res.CommandType = CommandType.StoredProcedure;
            cmd_res.Parameters.Add("@id", SqlDbType.Char, 8).Value = Account.id;
            cmd_res.Parameters.Add("@StartTime", SqlDbType.DateTime, 8).Value = dateTimePicker1.Value;
            cmd_res.Parameters.Add("@EndTime", SqlDbType.DateTime, 8).Value = dateTimePicker2.Value;
            cmd_res.ExecuteNonQuery();
            SqlDataAdapter da_hd = new SqlDataAdapter();
            da_hd.SelectCommand = cmd_res;
            DataTable dt_hd = new DataTable();
            da_hd.Fill(dt_hd);
            sp_view.DataSource = dt_hd;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tb_MA_TextChanged(object sender, EventArgs e)
        {

        }

        private void butt_HotItem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Account.connectString);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "EXEC sp_set_session_context 'id_ban', @id;select * from v_SPthuocDL order by SoLuotMua DESC";
            //cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.Char, 8).Value = Account.id;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            sp_view.DataSource = dt;
        }

        private void butt_stat_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(Account.connectString);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "EXEC sp_set_session_context 'id_ban', @id;select * from v_SPthuocDL";
            //cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.Char, 8).Value = Account.id;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            sp_view.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Account.connectString);
            con.Open();
            SqlCommand cmd_res = con.CreateCommand();
            cmd_res.CommandText = "EXEC sp_set_session_context 'id_ban', @id; SELECT* FROM v_DonHangDL v where v.TinhTrang=N'Giao thành công' and not exists (select * from v_DonHangKH ls where ls.ThoiGian>v.ThoiGian and ls.MaHD=v.MaHD) ";
            cmd_res.Parameters.Add("@id", SqlDbType.Char, 8).Value = Account.id;
            cmd_res.ExecuteNonQuery();
            SqlDataAdapter da_hd = new SqlDataAdapter();
            da_hd.SelectCommand = cmd_res;
            DataTable dt_hd = new DataTable();
            da_hd.Fill(dt_hd);
            hd_view.DataSource = dt_hd;
        }

        private void Shop_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Account.connectString);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "sp_themsanpham";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@iddaily", SqlDbType.Char, 8).Value = Account.id;
            cmd.Parameters.Add("@tensanpham", SqlDbType.Char, 8).Value = tb_ten.Text;
            cmd.Parameters.Add("@dongia", SqlDbType.Char, 8).Value = tb_gia.Text;
            cmd.Parameters.Add("@mota", SqlDbType.Char, 8).Value = tb_mota.Text;
            cmd.Parameters.Add("@loaisanpham", SqlDbType.Char, 8).Value = tb_loai.Text;
            cmd.Parameters.Add("@sltonkho", SqlDbType.Char, 8).Value = tb_sl.Text;
            cmd.Parameters.Add("@masp", SqlDbType.Char, 8).Value = tb_maSP.Text;
            cmd.ExecuteNonQuery();

        }

        private void butt_add_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Account.connectString);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "sp_capnhatsanpham";
            cmd.CommandType = CommandType.StoredProcedure;           
            cmd.Parameters.Add("@dongia", SqlDbType.Char, 8).Value = tb_gia.Text;   
            cmd.Parameters.Add("@soluong", SqlDbType.Char, 8).Value = tb_sl.Text;
            cmd.Parameters.Add("@masanpham", SqlDbType.Char, 8).Value = tb_maSP.Text;

            cmd.ExecuteNonQuery();
        }
    }
}
