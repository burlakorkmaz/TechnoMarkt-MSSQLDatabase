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
using System.Diagnostics;

namespace TechnoMarkt
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {           
            try
            {
                string un = username.Text;
                string pss = password.Text;

                if (un.Contains("'") || un.Contains("/") || un.Contains("*") || un.Contains("\\") || un.Contains("\"") || un.Contains("$") || pss.Contains("'") || pss.Contains("/") || pss.Contains("*") || pss.Contains("\\") || pss.Contains("\"") || pss.Contains("$"))
                {
                    MessageBox.Show("You cannot use special chars!! ");
                }
                else
                {
                    SqlConnection con = new SqlConnection("Data Source=ABRA;Initial Catalog=TechnoMarkt;Integrated Security=True");
                    SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From MyCompany.Passwords Where ID= '" + @un + "' and PW='" + @pss + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        this.Hide();
                        QueryWindow ss = new QueryWindow();
                        ss.Show();
                    }
                    else
                    {
                        MessageBox.Show("Please Check Your Username or Password");
                    }
                }               
            }
            catch(Exception en)
            {
                Debug.WriteLine("Exception Message: " + en.Message);
            }

        }
    }
}
