using BussinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinForms
{
    public partial class DoctorLogin : Form
    {
        public DoctorLogin()
        {
            InitializeComponent();

          
        }
        DoctorManager doctorManager= new DoctorManager();
        MeetManager meetManager= new MeetManager(); 
        PatientManager Patientmanager = new PatientManager();
        

        AppDbContext _context= new AppDbContext();
     
        private void button1_Click(object sender, EventArgs e)
        {
            
                string name = textBox1.Text;
                string password = textBox2.Text;

               
                Doctor doctor = doctorManager.Login(name, password);

                if (doctor != null)
                {
                    // Login başarılı, doktorun randevu alan hastalarını DataGridView'de listele
                    var appointments = _context.Apointments
                        .Where(a => a.DoctorId == doctor.Id)
                        .Select(a => new { a.Patient.Id,a.Patient.Name ,a.Patient.LastName, a.Time, a.Hour });
                    dataGridView1.DataSource = appointments.ToList();
                    textBox7.Text= doctor.Id.ToString();
                }
                else
                {
                    // Login başarısız, kullanıcıya hata mesajı verin.
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış");
                }
            






        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {// Seçilen satırdaki hasta adını al
            string hastaAdi = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
            // Seçilen satırdaki hasta soyadını al
            string hastaSoyadi = dataGridView1.CurrentRow.Cells["LastName"].Value.ToString();
            // Seçilen satırdaki hasta Id'sini al
            string hastaId = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();

            // Form alanlarına seçilen hasta bilgilerini yaz
            textBox6.Text = hastaId;
            textBox3.Text = hastaAdi;
            textBox5.Text = hastaSoyadi;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void btnGörüşmeyiKaydet_Click(object sender, EventArgs e)
        {  // Yeni bir görüşme nesnesi oluştur
            Meet meet = new Meet();
            // Form alanlarından hasta Id bilgisini al
            meet.PatientId = Convert.ToInt16(textBox6.Text);
            // Form alanlarından doktor Id bilgisini al
            meet.DoctorId = Convert.ToInt16(textBox7.Text);
            // Form alanından görüşme açıklamasını al
            meet.Describe = textBox4.Text;
            // Görüşme bilgisini veritabanına ekle
            meetManager.Add(meet);

            // Kullanıcıya görüşme eklendi bilgisi ver
            MessageBox.Show("Görüşme Eklendi");

            // Form alanlarını temizle
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

        }

        private void btnGorusmeDetay_Click(object sender, EventArgs e)
        {
            //Doktor Id'si textBox7'den alınır
            int doctorId = Convert.ToInt32(textBox7.Text);


            //Veritabanından doktor Id'sine göre görüşmeler getirilir.
            var meets = _context.Meets
                          .Where(a => a.DoctorId == doctorId)
                          //Doktor Id,Adı,Soyadı, Hasta Id, Adı, Soyadı, Describe bilgileri alınır
                          .Select(a => new MeetDto { DoctorId = a.Doctor.Id, DoctorName = a.Doctor.Name, DoctorLastName = a.Doctor.lastName, PatientId = a.Patient.Id, PatientName = a.Patient.Name, PatientLastName = a.Patient.LastName, Describe = a.Describe });
            MeetDetayForm form2 = new MeetDetayForm();
            form2.Show();
            //Form2'deki dataGridViewdetay kontrolüne getirilen görüşmeler atanır.
            form2.dataGridViewdetay.DataSource = meets.ToList();



        }
    }
}
