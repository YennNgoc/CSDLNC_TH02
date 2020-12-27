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
            catch(SqlException)
            {
                checkLog = false;
            }
            if (checkLog)
            {
               
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "Login_Role";
                cmd.CommandType = CommandType.StoredProcedure;
                
                cmd.Parameters.Add("@username", SqlDbType.Char,20).Value = Account.username;
                SqlParameter returnParameter = cmd.Parameters.Add("@role", SqlDbType.VarChar,20);
                returnParameter.Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                string result = (string)returnParameter.Value;
                    MessageBox.Show("Hello " + Account.username + " !");
                    //MessageBox.Show("Connection Open for " +result +" !");
                switch(result)
                {
                    
                    case "DaiLy":
                        {
                            Shop fr = new Shop();
                            fr.Show();
                            this.Hide();
                            break;
                        }
                    case "NguoiMua":
                        {
                            Customer fr = new Customer();
                            fr.Show();
                            this.Hide();
                            break;
                        }
                    default:
                        {
                            MessageBox.Show("Something Wrong!");
                            break;
                        }
                }    

            
                
            }
            else MessageBox.Show("Login fail!");
        }
    }
}
