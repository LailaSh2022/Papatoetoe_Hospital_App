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
    public partial class NewAppointment : Form
    {
        public string patient_ID, pName;
        public string ConnectionString = "server=localhost;user id=root;password=Dbms@2022;persistsecurityinfo=True;database=papatoetoe_hospital";
        
        public NewAppointment()
        {
            
            InitializeComponent();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mn = new MainMenu();
            mn.ShowDialog();
        }

        private void NewAppointment_Load(object sender, EventArgs e)
        {
            ContTime_pkr.Format = DateTimePickerFormat.Time;
            ContTime_pkr.ShowUpDown = true;
            fillDropDownList();
            

        }
        public void fillDropDownList()
        {
            string sqlCommand = "SELECT doc_physician_Id,concat(doc_FName,' ',doc_LName) as Name FROM doctor";
            MySqlConnection mySqlConnection = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand(sqlCommand, mySqlConnection);
            mySqlConnection.Open();
            DataSet ds = new DataSet();
            
            DataTable dt = new DataTable();
            dt.Columns.Add("DC_ID", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Load(cmd.ExecuteReader());
            Doctor_cbx.ValueMember = "DC_ID";
            Doctor_cbx.DisplayMember = "Name";
            Doctor_cbx.DataSource = dt;
            mySqlConnection.Close();
           
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            if (Patient_tbx.Text == "")
            {
                ErrorPIDMsg();          // Show error message box.
            }
            else
            {
                if (!patientExist(Patient_tbx.Text))
                {
                    ErrorPIDMsg();      // Show error message box.
                }
                else
                {
                     patient_ID = Patient_tbx.Text;
                     pName = PName_tbx.Text;
                }

            }
        }
        public void ErrorPIDMsg()
        {
            PatientID_lbl.ForeColor = Color.Red;
            MessageBox.Show("Please enter correct patient Id!", "NewAppointment");
        }

        private void NewApp_btn_Click(object sender, EventArgs e)
        {
            string patientID = Patient_tbx.Text;
            string appDate = AppDate_pkr.Value.ToString("yyyy-MM-dd");
            string time = ContTime_pkr.Value.ToString("HH:mm");
            string doctorID = Doctor_cbx.ValueMember;
            double duration = Convert.ToDouble(Duration_tbx.Text);
            string reason = Reason_rtbx.Text;

            

        }

        private void Time_pkr_ValueChanged(object sender, EventArgs e)
        {
        
        }

        public Boolean patientExist(string P_ID)
        {
            int counter = 0;
            //string ConnectionString = "server=localhost;user id=root;password=Dbms@2022;persistsecurityinfo=True;database=papatoetoe_hospital";
            string sqlCommand = "select concat(P_FName,' ', P_LName) as P_Name from patient where P_ID = '" + P_ID + "'";
            MySqlConnection mySqlConnection = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand(sqlCommand, mySqlConnection);
            mySqlConnection.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            mySqlConnection.Close();
            try
            {
                foreach (DataRow dr in dt.Rows)
                {
                 
                    PName_tbx.Text = dr["P_Name"].ToString();
                    counter++;
                }
            }
            catch
            {
                ErrorPIDMsg();
                return false;
            }

            if (counter > 0)
                return true;
            else
                return false;
            //string pass = dr["User_Password"].ToString();

        }
    }
}
