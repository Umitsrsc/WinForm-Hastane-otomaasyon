using BussinessLayer.Concrete;
using EntityLayer.Concrete;
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

namespace WinForms
{
    public partial class ApointmentForm : Form
    {
        PatientManager Patientmanager = new PatientManager();
        DoctorManager doctorManager = new DoctorManager();
        ApointmentManager apointmentManager = new ApointmentManager();
        private Apointment eklemeIslem = new Apointment();
        CategoryManager categoryManager = new CategoryManager();

        int _id = 0;
        public ApointmentForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = apointmentManager.GetDetails();//randevuları listeler

            cmbCategory.DataSource = categoryManager.GetAll();//kategorileri listeler
           
            cmbDoctor.DataSource = doctorManager.GetAll();//doktorları listeler
            //başlangıçta güncelle ve sil butonlarını devre deışı bırakır
            btnRandevuGuncelle.Enabled = false;
            btnRandevuSil.Enabled= false;
        }

        private void ApointmentForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = apointmentManager.GetDetails();//randevuları listler
            dateTimeGün.MinDate= DateTime.Now;//takvimde şimdiki günü gösteriri
           
        }
        //butona basılınca doktorforma götürür
        private void btnDoktorlar_Click(object sender, EventArgs e)
        {
            DoctorForm doctorform = new DoctorForm();
            doctorform.ShowDialog();

        
        }
        //butona basılınca patientforma götürür
        private void btnHastalar_Click(object sender, EventArgs e)
        {
            PatientForm patientform = new PatientForm();
            patientform.ShowDialog();
        }

        private void cmbDoctor_MouseClick(object sender, MouseEventArgs e)
        {
            // Seçilen kategori id'sini al
            int id = Convert.ToInt16(cmbCategory.SelectedValue);
            // Kategoriye göre doktorları getiren metodu çağır
            cmbDoctor.DataSource = doctorManager.getDoktorByCategoryId(id);
        }

        private void cmbCategory_MouseClick(object sender, MouseEventArgs e)
        {
            // Kategori verilerini combobox'a bağlamak için categoryManager.GetAll() metodunu çağırıyoruz.
            cmbCategory.DataSource = categoryManager.GetAll();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            // Yeni bir HastaSecForm oluşturuluyor
            HastaSecForm hastaSecForm = new HastaSecForm();
            // Form açılıyor
            hastaSecForm.ShowDialog();


            if (hastaSecForm.IptalEdildiMi() == false)
            {
                // eklemeIslem nesnesinin Patient özelliğine seçilen hasta atanıyor
                eklemeIslem.Patient = hastaSecForm.GetOgrenci();
                // TextBoxlar'a seçilen hastanın bilgileri atanıyor
                txtHastaId.Text = eklemeIslem.Patient.Id.ToString();
                txtHastaAdi.Text = eklemeIslem.Patient.Name;
                txtHastaSoyadi.Text = eklemeIslem.Patient.LastName;
                txtHastaNumara.Text = eklemeIslem.Patient.Phone;
                txtHastaMail.Text = eklemeIslem.Patient.Email;

            }
        }
        //Bu kod, kullanıcının kategori seçiminden sonra, seçilen kategoriye ait doktorların listesini cmbDoctor nesnesine bağlamak için
        //kullanılıyor. Öncelikle, cmbCategory nesnesinin seçilen değeri alınıyor ve bu değer Int16 tipine dönüştürülüyor. Daha sonra,
        //doctorManager nesnesinin getDoktorByCategoryId() metodu kullanılarak, seçilen kategoriye ait doktorların listesi alınıyor ve
        //cmbDoctor nesnesine bu liste bağlanıyor. Bu kod, kullanıcının kategori seçiminden sonra doktorların listesinin güncellenmesini
        //sağlar.
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(cmbCategory.SelectedValue);
            cmbDoctor.DataSource = doctorManager.getDoktorByCategoryId(id);
        }

        //bütün buttunları bağlıyor
        private void BaglaTexte(object sender, EventArgs e)
        {

            textSaat.Text = (sender as Button).Text;
        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            //Yeni bir randevu oluşturuluyor
            Apointment apointment = new Apointment();



            //Randevunun hasta Id'si, doktor Id'si, tarihi ve saati alınıyor
            apointment.PatientId = Convert.ToInt16(txtHastaId.Text);
            apointment.DoctorId = Convert.ToInt16(cmbDoctor.SelectedValue);
            apointment.Time = dateTimeGün.Value;
            apointment.Hour = textSaat.Text;

            //Randevu ekleniyor
            apointmentManager.Add(apointment);
            //Randevular güncelleniyor
            dataGridView1.DataSource = apointmentManager.GetDetails();

            //Kullanıcıya randevu alındı bilgisi veriliyor
            MessageBox.Show("Randevu Eklendi");

            //Hasta bilgileri temizleniyor
            txtHastaId.Text = "";
            txtHastaAdi.Text = "";
            txtHastaSoyadi.Text = "";
            txtHastaNumara.Text = "";
            txtHastaMail.Text = "";


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRandevuGuncelle_Click(object sender, EventArgs e)
        {
            //Güncellenecek randevunun Id'si ile randevu bulunuyor
            Apointment editapointment = apointmentManager.GetById(_id);
            //Yeni bilgilerle güncelleniyor
            editapointment.DoctorId = Convert.ToInt16(cmbDoctor.SelectedValue);
            editapointment.Time = dateTimeGün.Value;
            editapointment.Hour = textSaat.Text;
            //Güncellenen randevu veritabanına kaydediliyor
            apointmentManager.Update(editapointment);
            //DataGridView'da güncellenen randevular gösteriliyor
            dataGridView1.DataSource = apointmentManager.GetDetails();
            //Kullanıcıya bilgi veriliyor
            MessageBox.Show("Randevu Güncellendi");
            //Güncelle ve Sil butonları devre dışı bırakılıyor
            btnRandevuGuncelle.Enabled = false;
            btnRandevuSil.Enabled = false;
            //Textboxlar temizleniyor
            txtHastaId.Text = "";
            textSaat.Text = "";

        }

        private void btnRandevuSil_Click(object sender, EventArgs e)
        {
            // Seçilen randevuyu silme işlemi gerçekleştirir.
            Apointment silapointment = apointmentManager.GetById(_id);
            if (silapointment != null)
            {
                apointmentManager.Delete(silapointment);
                dataGridView1.DataSource = apointmentManager.GetDetails();
                MessageBox.Show("Randevu Silindi");
                btnRandevuGuncelle.Enabled = false;
                btnRandevuSil.Enabled = false;

                // Textboxları temizler.
                txtHastaId.Text = "";
                textSaat.Text = "";
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kullanıcının seçtiği satırın index numarasını alıyoruz
            if (e.RowIndex >= 0)
            {
                // Kullanıcının seçtiği satırı alıyoruz
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                // Seçilen satırdaki ilk sütunun değerini (id) _id değişkenine atıyoruz
                _id = Int32.Parse(row.Cells[0].Value.ToString());
                // Seçilen randevunun bilgilerini alıyoruz
                Apointment editapointment = apointmentManager.GetById(_id);
                // Güncelle ve Sil butonlarını aktif hale getiriyoruz
                btnRandevuGuncelle.Enabled = true;
                btnRandevuSil.Enabled = true;
            }   }
        //Butona basılınca sekreter forma götürür.
        private void btnSekreterler_Click(object sender, EventArgs e)
        {
            SecretaryForm secretaryform = new SecretaryForm();
            secretaryform.ShowDialog();
        }

        private void txtHastaSoyadi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
