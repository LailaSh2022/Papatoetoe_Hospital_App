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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void AddNew_btn_Click(object sender, EventArgs e)
        {
            if (EmptyTextBox())
            {
                MessageBox.Show("Please fill the empty fields!", "Sign Up");
            }
            else if (NewPassword_tbx.Text != reEnterPassword_tbx.Text)
            {
                NewPassword_lbl.ForeColor = Color.Red;
                reEnterPassword_lbl.ForeColor = Color.Red;
                MessageBox.Show("The two passwords you entered are not the same. Please re-enter your passwords!", "Sign Up");
            }
            else
            {

                resetLables();
                int counter = 0;
                string ConnectionString = "server=localhost;user id=root;password=Dbms@2022;persistsecurityinfo=True;database=papatoetoe_hospital";
                string sqlCommand = "select * from login where User_Name = '" + NewUserName_tbx.Text + "'";
                MySqlConnection mySqlConnection = new MySqlConnection(ConnectionString);
                MySqlCommand cmd = new MySqlCommand(sqlCommand, mySqlConnection);
                mySqlConnection.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                //cmd.ExecuteNonQuery();
                mySqlConnection.Close();
                foreach (DataRow dr in dt.Rows)
                {
                    counter++;
                }
                
                if (counter == 1)
                {
                    NewUserName_lbl.ForeColor = Color.Red;
                    MessageBox.Show("The user name you entered already exists in the system. Please use another user name!", "Sign Up");
                }
                else
                {

                    resetLables();
                    string userPosition = "Emp";
                    //string ConnectionString = "server=localhost;user id=root;password=Dbms@2022;persistsecurityinfo=True;database=papatoetoe_hospital";
                    sqlCommand = "select max(User_ID) from login ";
                    //MySqlConnection mySqlConnection = new MySqlConnection(ConnectionString);
                    cmd = new MySqlCommand(sqlCommand, mySqlConnection);
                        mySqlConnection.Open();
                        
                        int userID = (int)cmd.ExecuteScalar();
                        mySqlConnection.Close();

                        sqlCommand = "INSERT INTO login (User_ID,User_Name,User_Password,User_Admin) VALUES (@val1, @val2, @val3, @val4)";
                        using (cmd)
                        {
                            string newUserName = NewUserName_tbx.Text;
                            string newPassword = NewPassword_tbx.Text;
                            if (admin_ch_bx.Checked)
                                userPosition = "Adm";
                            userID++;
                            
                            cmd.Connection = mySqlConnection;
                            cmd.CommandText = sqlCommand;
                            cmd.Parameters.AddWithValue("@val1", userID);
                            cmd.Parameters.AddWithValue("@val2", newUserName);
                            cmd.Parameters.AddWithValue("@val3", newPassword);
                            cmd.Parameters.AddWithValue("@val4", userPosition);

                            mySqlConnection.Open();
                            cmd.ExecuteNonQuery();
                            mySqlConnection.Close();


                        }
                    
                    

                }
            }
        }

        private void LogIn_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInPage lgn = new LogInPage();
            lgn.ShowDialog();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool EmptyTextBox()
        {
            bool empty = false;
            if (NewUserName_tbx.Text == "")
            {
                NewUserName_lbl.ForeColor = Color.Red;
                empty = true;
            }
            if (NewPassword_tbx.Text == "")
            {
                NewPassword_lbl.ForeColor = Color.Red;
                empty = true;
            }
            if (reEnterPassword_tbx.Text == "")
            {
                reEnterPassword_lbl.ForeColor = Color.Red;
                empty = true;
            }
            

            return empty;
        }
        public void resetLables()
        {
            
            NewUserName_lbl.ForeColor = Color.Black;
            NewPassword_lbl.ForeColor = Color.Black;
            reEnterPassword_lbl.ForeColor = Color.Black;
                            
        }
    }
}
