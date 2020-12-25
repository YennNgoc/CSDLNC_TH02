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
    
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void butt_log_Click(object sender, EventArgs e)
        {
            Account.username = tb_username.Text;
            Account.password = tb_pass.Text;
            if (string.IsNullOrWhiteSpace(Account.username) || string.IsNullOrWhiteSpace(Account.password))
            {
                MessageBox.Show("Please provide Username and Password");
                return;
            }
            Account.connectString = @"Data Source=ICEBEAR-PC\YENNGOCC;Database=CSDLNC;Persist Security Info=True;User ID=" + Account.username + ";Password=" + Account.password;
            SqlConnection con = new SqlConnection(Account.connectString);

            bool checkLog = true;
            try
            {
                con.Open();
            }
            catch (SqlException)
            {
                checkLog = false;
            }
            if (checkLog)
            {
                MessageBox.Show("Hello " + Account.username + " !");
                User fr = new User();
                fr.Show();
            }
            else MessageBox.Show("Login fail!");
        }
    }
}
