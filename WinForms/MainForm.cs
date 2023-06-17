using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBoxSekreter_Click(object sender, EventArgs e)
        {
            //randevu forma geçiş yapar
            ApointmentForm apointment=new ApointmentForm();
            apointment.ShowDialog();

        }

        //doktor giriş sayfasına geçiş yapar
        private void pictureBoxDoktorGiriş_Click(object sender, EventArgs e)
        {
            DoctorLogin doctorLogin = new DoctorLogin();
            doctorLogin.ShowDialog();
        }
    }
}
