using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Papatoetoe_Hospital_App
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void addNewPatient_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddNewPatient ap = new AddNewPatient();
            ap.ShowDialog();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInPage lgn = new LogInPage();
            lgn.ShowDialog();
        }

        private void newAppointment_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewAppointment nAp = new NewAppointment();
            nAp.ShowDialog();
        }
    }
}
