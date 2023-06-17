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
    public partial class SecretaryForm : Form
    {
        SecretaryManager secrateryManager = new SecretaryManager();
        int _id = 0;
        public SecretaryForm()
        {
            InitializeComponent();
            // Veritabanındaki tüm sekreterleri getirir
            dataGridView1.DataSource = secrateryManager.GetAll();
            // Güncelleme ve silme butonlarını başlangıçta devre dışı bırakır
            btnSekreterGüncelle.Enabled = false;
            btnSekreterSil.Enabled = false;

        }
        // Form alanlarının doğruluk kontrolünü yapar, hata varsa false döndürür
        private bool alanKontrolleri(
           string ad,
           string soyad,
           string numara
       )
        {
            if (ad.Length < 2)
            {
                MessageBox.Show("Sekreter adı 2 karakterden küçük olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (soyad.Length < 2)
            {
                MessageBox.Show("Sekreter soyadı 2 karakterden küçük olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
           
            return true;
        }

       // "Ekle" butonuna tıklandığında formdaki alanların doğruluk kontrolünü yapar, alanlar doğruysa yeni bir Secretary nesnesi oluşturur ve
       // veritabanına ekler, son olarak DataGridView'i günceller ve "Sekreter Eklendi" mesajı verir. Form alanları temizlenir.
        private void btnSekreterEkle_Click(object sender, EventArgs e)
        {
            // Form alanlarının doğruluk kontrolü yapılır
            if (alanKontrolleri(
              txtSekreterAdi.Text,
              txtSekreterSoyadi.Text,
              maskedSekreterNumara.Text
          ))
            {
                // Yeni bir Secretary nesnesi oluşturulur
                Secretary secretary = new Secretary();
                // Nesnenin alanları form alanlarından doldurulur
                secretary.Name = txtSekreterAdi.Text;
                secretary.LastName = txtSekreterSoyadi.Text;
                secretary.Phone = maskedSekreterNumara.Text;
                // Oluşturulan nesne veritabanına eklenir
                secrateryManager.Add(secretary);
                // DataGridView'e veritabanındaki tüm sekreterler getirilir
                dataGridView1.DataSource = secrateryManager.GetAll();
                // Ekleme işlemi başarılı mesajı verilir
                MessageBox.Show("Sekreter Eklendi");
                // Form alanları temizlenir
                txtSekreterAdi.Text = "";
                txtSekreterSoyadi.Text = "";
                maskedSekreterNumara.Text = "";

            }
        }
        //Bu kod parçası, "Sil" butonuna tıklandığında formdaki veritabanından seçilen sekreteri getirir, eğer sekreter varsa veritabanından siler ve
        //DataGridView'i günceller, kullanıcıya "Sekreter Silindi" mesajı verir, "Güncelle" ve "Sil" butonlarını devre dışı bırakır,
        //form alanlarını temizler.
        private void btnSekreterSil_Click(object sender, EventArgs e)
        {
            // Öncelikle veritabanından seçilen sekreteri getirir
            Secretary silsecreter = secrateryManager.GetById(_id);
            if (silsecreter != null)
            {
                // Seçilen sekreteri veritabanından siler
                secrateryManager.Delete(silsecreter);
                // DataGridView'i günceller
                dataGridView1.DataSource = secrateryManager.GetAll();
                // Kullanıcıya silme işlemi başarılı mesajı verir
                MessageBox.Show("Sekreter Silindi");
                // Güncelleme ve silme butonlarını devre dışı bırakır
                btnSekreterGüncelle.Enabled = false;
                btnSekreterSil.Enabled = false;
                // Form alanlarını temizler
                txtSekreterAdi.Text = "";
                txtSekreterSoyadi.Text = "";
                maskedSekreterNumara.Text = "";

            }
        }
       // Bu kod parçası, "Güncelle" butonuna tıklandığında formdaki veritabanından seçilen sekreteri getirir, formdaki alanları sekreter nesnesine atar,
       // güncellenen sekreteri veritabanına kaydeder, DataGridView'i günceller,
        private void btnSekreterGüncelle_Click(object sender, EventArgs e)
        {

            // Alan kontrollerini yapar
            if (alanKontrolleri(
              txtSekreterAdi.Text,
              txtSekreterSoyadi.Text,
              maskedSekreterNumara.Text
          ))
            {
                // Veritabanından seçilen sekreteri getirir
                Secretary editsecretary = secrateryManager.GetById(_id);
                // Formdaki alanları sekreter nesnesine atar
                editsecretary.Name = txtSekreterAdi.Text;
                editsecretary.LastName = txtSekreterSoyadi.Text;
                editsecretary.Phone = maskedSekreterNumara.Text;
                // Güncellenen sekreteri veritabanına kaydeder
                secrateryManager.Update(editsecretary);
                // DataGridView'i günceller
                dataGridView1.DataSource = secrateryManager.GetAll();
                // Kullanıcıya güncelleme işlemi başarılı mesajı verir
                MessageBox.Show("Sekreter Güncellendi");
                // Form alanlarını temizler
                txtSekreterAdi.Text = "";
                txtSekreterSoyadi.Text = "";
                maskedSekreterNumara.Text = "";
                // Güncelleme ve silme butonlarını devre dışı bırakır
                btnSekreterGüncelle.Enabled = false;
                btnSekreterSil.Enabled = false;
            }
        }
       //Bu kod parçasında, kullanıcının dataGridView'de seçtiği bir sekreterin bilgilerini düzenlemek için kullanabileceği bir sistem oluşturulmuş.
       //Öncelikle kullanıcının seçtiği satırın satır indeksi alınıyor, daha sonra seçilen satırdaki ilk sütunun değeri "_id" değişkenine atanıyor.
       //Bu _id değişkeni kullanılarak seçilen sekreterin bilgileri getirilip, textbox'lara yazdırılıyor.Son olarak "Güncelle" ve "Sil" butonları
       //aktif hale getiriliyor.
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Seçilen satırın satır indeksini alıyoruz
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            //Seçilen satırdaki ilk sütunun değerini _id değişkenine atıyoruz
            _id = Int32.Parse(row.Cells[0].Value.ToString());
            //Seçilen sekreterin bilgilerini getiriyoruz
            Secretary editsekreter = secrateryManager.GetById(_id);
            //Sekreterin bilgilerini textbox'lara yazıyoruz
            txtSekreterAdi.Text = editsekreter.Name;
            txtSekreterSoyadi.Text = editsekreter.LastName;
            maskedSekreterNumara.Text = editsekreter.Phone;
            //Güncelle ve sil butonlarını aktif hale getiriyoruz
            btnSekreterGüncelle.Enabled = true;
            btnSekreterSil.Enabled = true;
        }

        private void txtSekreterAra_TextChanged(object sender, EventArgs e)
        {
            // Textbox'ta yazılan değer ile adı içeren sekreterlerin listesini getirir
            dataGridView1.DataSource = secrateryManager.GetAll(x => x.Name.Contains(txtSekreterAra.Text));

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
