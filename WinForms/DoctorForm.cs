using BussinessLayer.Concrete;
using EntityLayer.Concrete;
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
    public partial class DoctorForm : Form
    {

        DoctorManager doctorManager = new DoctorManager();
        CategoryManager categoryManager = new CategoryManager();
        int _id = 0;
        public DoctorForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = doctorManager.GetDetails(); //doktorları listeler

            cmbCategory.DataSource = categoryManager.GetAll(); // Kategorileri listeler
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";

            //Başlangıçta güncelle ve sil butonunu devre dışı bırakır

            btnDoktorGüncelle.Enabled = false;
            btnDoktorSil.Enabled = false;
        }
        // Form alanlarının doğruluk kontrolünü yapar, hata varsa false döndürür
        private bool alanKontrolleri(
            string ad,
            string soyad,
            string numara,
            string Parola
        )
        {
            if (ad.Length < 2)
            {
                MessageBox.Show("Doktor adı 2 karakterden küçük olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (soyad.Length < 2)
            {
                MessageBox.Show("Doktor soyadı 2 karakterden küçük olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (Parola.Length < 2)
            {
                MessageBox.Show("Doktor şifrsi 2 karakterden küçük olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        //Bu kod, kullanıcının girdiği doktor bilgilerini kontrol ediyor. Eğer bilgiler geçerli ise, doktor nesnesi oluşturuluyor ve bilgiler nesnenin özelliklerine atanıyor.
        //Daha sonra, doktorManager sınıfının Add metodu ile doktor veritabanına ekleniyor ve eklenen doktorların bilgileri dataGridView1 'de görüntüleniyor. En sonunda,
        //ekleme işlemi bittikten sonra, formdaki tüm bilgi alanları temizleniyor.
        private void btnDoktorEkle_Click(object sender, EventArgs e)
        {

            // Kullanıcının girdiği alanların doğruluğunun kontrol edilmesi için alanKontrolleri metodu çağrılıyor.
            if (alanKontrolleri(
            txtDoktorAdi.Text, // Doktor adının kontrol edilmesi
            txtDoktorSoyadi.Text, // Doktor soyadının kontrol edilmesi
            maskedTel.Text, // Doktor telefon numarasının kontrol edilmesi
            txtDoktorParola.Text // Doktor parolasının kontrol edilmesi
            ))
            {
                // Doktor bilgileri için nesne oluşturuluyor
                Doctor doctor = new Doctor();
                doctor.Name = txtDoktorAdi.Text; // Doktor adı set ediliyor
                doctor.lastName = txtDoktorSoyadi.Text; // Doktor soyadı set ediliyor
                doctor.Phone = maskedTel.Text; // Doktor telefon numarası set ediliyor
                doctor.Sifre = txtDoktorParola.Text; // Doktor parolası set ediliyor
                doctor.CategoryId = Int32.Parse(cmbCategory.SelectedValue.ToString()); // Doktorun kategorisinin id'si set ediliyor
                doctorManager.Add(doctor); // Doktor bilgileri veritabanına ekleniyor
                dataGridView1.DataSource = doctorManager.GetDetails(); // Doktorların bilgileri dataGridView'da gösteriliyor
                MessageBox.Show("Doktor Eklendi"); // Kullanıcıya bilgi veriyor
                txtDoktorAdi.Text = ""; // Doktor adı textbox'ı temizleniyor
                txtDoktorSoyadi.Text = ""; // Doktor soyadı textbox'ı temizleniyor
                maskedTel.Text = ""; // Doktor telefon numarası textbox'ı temizleniyor
                txtDoktorParola.Text = ""; // Doktor telefon parola textbox'ı temizleniyor
            }
            btnDoktorGüncelle.Enabled = false;
            btnDoktorSil.Enabled = false;
        }

        private void btnDoktorGüncelle_Click(object sender, EventArgs e)
        {
            //Kullanıcının girdiği alanların kontrol edilmesi için alanKontrolleri metodu çağrılıyor
            if (alanKontrolleri(
            txtDoktorAdi.Text,
            txtDoktorSoyadi.Text,
            maskedTel.Text,
            txtDoktorParola.Text
            ))
            {
                //Seçili olan doktorun id'si ile doktorun bilgileri alınıyor
                Doctor editdoctor = doctorManager.GetById(_id);
                //Doktorun bilgileri güncelleniyor
                editdoctor.Name = txtDoktorAdi.Text;
                editdoctor.lastName = txtDoktorSoyadi.Text;
                editdoctor.Phone = maskedTel.Text;
                editdoctor.CategoryId = Convert.ToInt16(cmbCategory.SelectedValue);
                //Güncellenen doktor bilgileri veritabanında kaydediliyor
                doctorManager.Update(editdoctor);
                MessageBox.Show("Doktor Güncellendi");
                //Datagridview'de güncellenen doktor bilgileri gösteriliyor
                dataGridView1.DataSource = doctorManager.GetDetails();
                //Textboxlar temizleniyor
                txtDoktorAdi.Text = "";
                txtDoktorSoyadi.Text = "";
                maskedTel.Text = "";
                //Güncelle ve Sil butonlarının aktif olmaması için pasifleştiriliyor
                btnDoktorGüncelle.Enabled = false;
                btnDoktorSil.Enabled = false;


            }
        }

        private void btnDoktorSil_Click(object sender, EventArgs e)
        {
            //Seçili olan doktorun Id'si alınıyor
            Doctor sildoctor = doctorManager.GetById(_id);
            //Eğer seçili doktor var ise
            if (sildoctor != null)
            {
                //Doktor silinir
                doctorManager.Delete(sildoctor);
                //DataGridView'de güncel bilgiler gösterilir
                dataGridView1.DataSource = doctorManager.GetDetails();

                //Silme işlemi gerçekleştiği bilgisi verilir
                MessageBox.Show("Doktor Silindi");

                //Güncelle ve Sil butonları devre dışı bırakılır
                btnDoktorGüncelle.Enabled = false;
                btnDoktorSil.Enabled = false;
                //Textboxlar temizlenir
                txtDoktorAdi.Text = "";
                txtDoktorSoyadi.Text = "";
                maskedTel.Text = "";
                txtDoktorParola.Text = "";

            }


        }

    

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Eğer seçilen satır indexi 0'dan büyük veya eşitse
            if (e.RowIndex >= 0)
            {
                // Seçilen satırı al
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                // Seçilen satırdaki ilk hücredeki id'yi _id değişkenine ata
                _id = Int32.Parse(row.Cells[0].Value.ToString());
                // _id değişkenine atanan id ile doctorManager aracılığıyla doktor nesnesini al
                Doctor editdoctor = doctorManager.GetById(_id);
                // Doktorun adını, soyadını, telefon numarasını ve şifresini textbox'lara yaz
                txtDoktorAdi.Text = editdoctor.Name;
                txtDoktorSoyadi.Text = editdoctor.lastName;
                maskedTel.Text = editdoctor.Phone;
                txtDoktorParola.Text = editdoctor.Sifre;
                // Güncelle ve sil butonlarını aktifleştir
                btnDoktorGüncelle.Enabled = true;
                btnDoktorSil.Enabled = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //Evet, bu kod içinde açıklama satırları ekleyebilirim. Özellikle, txtDoktorAra_TextChanged metodu, kullanıcının arama kutusunda yazdıklarına göre datagridview'de
        //gösterilen doktorları filtreleyen bir metoddur. Bu metod içinde, doctorManager sınıfının GetAll metodu çağrılır ve arama kutusunda yazılan değer ile doktorların
        //adlarının içerip içermediği kontrol edilir. Bu kontrolden geçen doktorlar, datagridview'de gösterilir.
        private void txtDoktorAra_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = doctorManager.GetAll(x => x.Name.Contains(txtDoktorAra.Text));
        }
    }
}
