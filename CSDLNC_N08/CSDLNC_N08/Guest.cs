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
            Account.username = "guest";
            Account.password = "123456";
            Account.connectString = @"Data Source=ICEBEAR-PC\YENNGOCC;Database=CSDLNC;Persist Security Info=True;User ID=" + Account.username + ";Password=" + Account.password;

        }

        private void butt_search_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Account.connectString);
            try
            {

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
                SqlConnection con = new SqlConnection(Account.connectString);
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
                SqlConnection con = new SqlConnection(Account.connectString);
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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Account.connectString);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from SanPham order by IDDaiLy";
            //cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            sp_view.DataSource = dt;
        }

        private void butt_DangNhap_Click(object sender, EventArgs e)
        {
            Login fr = new Login();
            fr.Show();
            this.Hide();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
