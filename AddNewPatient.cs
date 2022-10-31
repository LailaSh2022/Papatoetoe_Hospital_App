using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Papatoetoe_Hospital_App
{
    public partial class AddNewPatient : Form
    {
        public AddNewPatient()
        {
            InitializeComponent();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mn = new MainMenu();
            mn.ShowDialog();
        }

        private void AddNewPatient_btn_Click(object sender, EventArgs e)
        {
            if (EmptyTextBox())
            {
                MessageBox.Show("Please fill the empty fields!", "Add New Patient");
            }
            else
            {
                resetLables();
                string ConnectionString = "server=localhost;user id=root;password=Dbms@2022;persistsecurityinfo=True;database=papatoetoe_hospital";
                string sqlCommand = "select max(P_ID) from patient";
                MySqlConnection mySqlConnection = new MySqlConnection(ConnectionString);
                MySqlCommand cmd = new MySqlCommand(sqlCommand, mySqlConnection);
                mySqlConnection.Open();
                string patient_ID = (string)cmd.ExecuteScalar();
                mySqlConnection.Close();
                string resultString = Regex.Match(patient_ID, @"\d+").Value;
                int ID = Int32.Parse(resultString);
                ID++;
                patient_ID = "PT" + ID.ToString();
                //MessageBox.Show(patient_ID);
                PatientID_tbx.Text = patient_ID;
                string P_FName = FName_btx.Text;
                string P_LName = LName_btx.Text;
                string P_Address = Address_tbx.Text;
                string P_City = City_tbx.Text;
                string P_State = State_tbx.Text;
                string P_PhoneNum = PhoneNum_tbx.Text;
                string P_Email = Email_tbx.Text;

                sqlCommand = "INSERT INTO patient (P_ID,P_FName,P_LName,P_Address,P_City,P_State,P_PhoneNum,P_Email) " +
                    "VALUES (@val1, @val2, @val3, @val4, @val5, @val6, @val7, @val8)";
                using (cmd)
                {

                    cmd.Connection = mySqlConnection;
                    cmd.CommandText = sqlCommand;
                    cmd.Parameters.AddWithValue("@val1", patient_ID);
                    cmd.Parameters.AddWithValue("@val2", P_FName);
                    cmd.Parameters.AddWithValue("@val3", P_LName);
                    cmd.Parameters.AddWithValue("@val4", P_Address);
                    cmd.Parameters.AddWithValue("@val5", P_City);
                    cmd.Parameters.AddWithValue("@val6", P_State);
                    cmd.Parameters.AddWithValue("@val7", P_PhoneNum);
                    cmd.Parameters.AddWithValue("@val8", P_Email);

                    mySqlConnection.Open();
                    cmd.ExecuteNonQuery();
                    mySqlConnection.Close();

                }


            }

        }
        public bool EmptyTextBox()
        {
            bool empty = false;
            if(FName_btx.Text == "")
            {
                FName_lbl.ForeColor = Color.Red;
                empty = true;
            }
            if (LName_btx.Text == "")
            {
                LName_lbl.ForeColor = Color.Red;
                empty = true;
            }
            if (Address_tbx.Text == "")
            {
                address_lbl.ForeColor = Color.Red;
                empty = true;
            }
            if (Email_tbx.Text == "")
            {
                Email_lbl.ForeColor = Color.Red;
                empty = true;
            }
            if (PhoneNum_tbx.Text == "")
            {
                PhoneNum_lbl.ForeColor = Color.Red;
                empty = true;
            }
            if(City_tbx.Text == "")
            {
                city_lbl.ForeColor = Color.Red;
                empty = true;
            }
            if(State_tbx.Text == "")
            {
                state_lbl.ForeColor = Color.Red;
                empty = true;
            }
            
            return empty;
        }
        public void resetLables()
        {
            FName_lbl.ForeColor = Color.Black;
            LName_lbl.ForeColor = Color.Black;
            address_lbl.ForeColor = Color.Black;
            Email_lbl.ForeColor = Color.Black;
            PhoneNum_lbl.ForeColor = Color.Black;
            city_lbl.ForeColor = Color.Black;
            state_lbl.ForeColor = Color.Black;
        }
    }
}
