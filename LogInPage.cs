using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Papatoetoe_Hospital_App
{
    public partial class LogInPage : Form
    {
        public LogInPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SignIn_btn_Click(object sender, EventArgs e)
        {
            int counter = 0;
            string ConnectionString = "server=localhost;user id=root;password=Dbms@2022;persistsecurityinfo=True;database=papatoetoe_hospital";
            string sqlCommand = "select * from login where User_Name = '" + UserName_tbx.Text + "'and User_Password = '" + Password_tbx.Text + "'"; 
            MySqlConnection mySqlConnection = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand(sqlCommand, mySqlConnection);
            mySqlConnection.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            mySqlConnection.Close();
            foreach (DataRow dr in dt.Rows)
            {
                counter++;
                    
            }
            //string name = dr["User_Name"].ToString();
            //string pass = dr["User_Password"].ToString();
            if (counter == 1)
            {
                UserName_lbl.ForeColor = Color.Black;
                Password_lbl.ForeColor = Color.Black;
                this.Hide();
                MainMenu mn = new MainMenu();
                mn.ShowDialog();
            }
            else
            {
                UserName_lbl.ForeColor = Color.Red;
                Password_lbl.ForeColor = Color.Red;
                MessageBox.Show(" User Name or Password Incorrect!", "login page");
            }
            
        }

        private void SignUp_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp sUp = new SignUp();
            sUp.ShowDialog();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
