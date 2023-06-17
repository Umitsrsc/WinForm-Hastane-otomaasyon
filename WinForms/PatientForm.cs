using BussinessLayer.Concrete;
using EntityLayer.Concrete;
using iTextSharp.text.pdf.codec.wmf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace WinForms
{
    public partial class PatientForm : Form
    {
        PatientManager patientManager = new PatientManager();
        int _id = 0;
        public PatientForm()
        {
            InitializeComponent();
            //Hastaları listeler
            dataGridView1.DataSource = patientManager.GetAll();
            // Veritabanından çekilen hasta bilgilerinin 5. sütununun görünürlüğünü kapatır
            dataGridView1.Columns[5].Visible = false;
            // Güncelleme ve silme butonlarının başlangıçta kapalı olmasını sağlar
            btnHastaGüncelle.Enabled = false;
            btnHastaSil.Enabled = false;


        }
        // Form alanlarının doğruluk kontrolünü yapar, hata varsa false döndürür
        private bool alanKontrolleri(
            string ad,
            string soyad,
            string numara,
            string mail
        )
        {
            if (ad.Length < 2)
            {
                MessageBox.Show("Hasta adı 2 karakterden küçük olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (soyad.Length < 2)
            {
                MessageBox.Show("Hasta soyadı 2 karakterden küçük olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
           
            if (mail.Length < 2)
            {
                MessageBox.Show("Hasta maili 2 karakterden küçük olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        //bu kod, "btnHastaEkle" adlı bir butona tıklandığında çalışır.İlk olarak "alanKontrolleri" adlı fonksiyon çağrılır.
         //Bu fonksiyon kullanıcının "Hasta Adı", "Hasta Soyadı", "Hasta Numarası" ve "Hasta Email" alanlarının doldurulup doldurulmadığını kontrol eder.
         //Eğer alanlar doldurulmuşsa, kullanıcının girdiği bilgileri kullanarak yeni bir "Patient" (Hasta) nesnesi oluşturulur. "patientManager" adlı
         //nesnenin "Add" metodu kullanılarak yeni hasta veritabanına eklenir.
        private void btnHastaEkle_Click(object sender, EventArgs e)
        {
            //Kullanıcının girdiği alanların doldurulup doldurulmadığını kontrol eder
            if (alanKontrolleri(
               txtHastaAdi.Text,  //Hasta Adı alanı
               txtHastaSoyadi.Text,  //Hasta Soyadı alanı
              mtxthastaNumara.Text,  //Hasta Numarası alanı
               txtHastaEmail.Text  //Hasta Email alanı
           ))
            {
                //Kullanıcının girdiği bilgileri kullanarak yeni bir hasta nesnesi oluşturur
                Patient patient = new Patient();
                patient.Name = txtHastaAdi.Text;  //Hasta Adı
                patient.LastName = txtHastaSoyadi.Text; //Hasta Soyadı
                patient.Phone = mtxthastaNumara.Text; //Hasta Numarası
                patient.Email = txtHastaEmail.Text;  //Hasta Email
                //patientManager nesnesinin add metodunu kullanarak yeni hastayı veritabanına ekler
                patientManager.Add(patient);
                //Veritabanındaki tüm hastaları listeleyen dataGridView1 nesnesinin DataSource özelliğine atar
                dataGridView1.DataSource = patientManager.GetAll();
                //Kullanıcıya "Hasta Eklendi" mesajı gösterir
                MessageBox.Show("Hasta Eklendi");
                //Tüm alanları temizler
                txtHastaAdi.Text = "";
                txtHastaSoyadi.Text = "";
                mtxthastaNumara.Text = "";
                txtHastaEmail.Text = "";
            }
        }
        //Bu kod, "Hasta Güncelle" butonuna tıklandığında çalışır. Öncelikle "alanKontrolleri" adlı fonksiyon çağrılır.
        //Bu fonksiyon kullanıcının "txtHastaAdi.Text", "txtHastaSoyadi.Text", "mtxthastaNumara.Text" ve "txtHastaEmail.Text" alanlarının
        //doldurulup doldurulmadığını kontrol eder. Eğer alanlar doldurulmuşsa, veritabanından _id değerine göre hasta nesnesi getirilir.
        //Kullanıcının girdiği bilgiler hasta nesnesine atanır. 
        private void btnHastaGüncelle_Click(object sender, EventArgs e)
        {
            //Kullanıcının girdiği alanların doldurulup doldurulmadığını kontrol eder. Eğer doldurulmuşsa
            if (alanKontrolleri(txtHastaAdi.Text, txtHastaSoyadi.Text, mtxthastaNumara.Text, txtHastaEmail.Text))
            {
                //Veritabanından _id değerine göre hasta nesnesi getirir
                Patient editpatient = patientManager.GetById(_id);
                //Kullanıcının girdiği bilgileri hasta nesnesine atar
                editpatient.Name = txtHastaAdi.Text;
                editpatient.LastName = txtHastaSoyadi.Text;
                editpatient.Phone = mtxthastaNumara.Text;
                editpatient.Email = txtHastaEmail.Text;
                //patientManager nesnesinin Update metodunu kullanarak hasta bilgilerini veritabanında günceller
                patientManager.Update(editpatient);
                //Veritabanındaki tüm hastaları listeleyen dataGridView1 nesnesinin DataSource özelliğine atar
                dataGridView1.DataSource = patientManager.GetAll();
                //Kullanıcıya "Hasta Güncellendi" mesajı gösterir
                MessageBox.Show("Hasta Güncellendi");
                //Tüm alanları temizler
                txtHastaAdi.Text = "";
                txtHastaSoyadi.Text = "";
                mtxthastaNumara.Text = "";
                txtHastaEmail.Text = "";
            }
            //Güncelle ve Sil butonlarının etkinliğini kapatır
            btnHastaGüncelle.Enabled = false;
            btnHastaSil.Enabled = false;

        }

        private void PatientForm_Click(object sender, EventArgs e)
        {

        }
        //Bu kod parçası, "dataGridView1" adlı nesnenin "CellClick" olayını işler. Bu olay, kullanıcının "dataGridView1" nesnesindeki bir hücreye tıkladığında çalışır.
        //İlk olarak, kullanıcının tıkladığı hücrenin sırasının sıfırdan büyük olup olmadığı kontrol edilir. Eğer sıra sıfırdan büyükse, kullanıcının tıkladığı hücrenin satırı
        //"row" adlı bir değişkene atanır. "row" değişkeninin ilk hücresindeki değer "_id" adlı bir değişkene atanır. Daha sonra veritabanından _id değerine göre hasta nesnesi getirilir
        //ve hasta nesnesinin bilgileri form alanlarına atanır. En son olarak "btnHastaGüncelle.Enabled" ve "btnHastaSil.Enabled" özellikleri true olarak değiştirilir,
        //bu sayede kullanıcı Güncelle ve Sil butonlarını kullanabilir.
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        { //Kullanıcının tıkladığı hücrenin sırasının sıfırdan büyük olup olmadığını kontrol eder
            if (e.RowIndex >= 0)
            {
                //Kullanıcının tıkladığı hücrenin satırı row değişkenine atar
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                //row değişkeninin ilk hücresindeki değeri _id değişkenine atar
                _id = Int32.Parse(row.Cells[0].Value.ToString());
                //_id değerine göre hasta nesnesi getirir
                Patient editpatient = patientManager.GetById(_id);
                //Hasta nesnesinin bilgilerini form alanlarına atar
                txtHastaAdi.Text = editpatient.Name;
                txtHastaSoyadi.Text = editpatient.LastName;
                mtxthastaNumara.Text = editpatient.Phone;
                txtHastaEmail.Text = editpatient.Email;
                //Güncelle ve Sil butonlarının etkinliğini açar
                btnHastaGüncelle.Enabled = true;
                btnHastaSil.Enabled = true;
            }
        }
        //Bu kod parçası, "Hasta Sil" butonuna tıklandığında çalışır. Öncelikle "_id" değerine göre hasta nesnesi getirilir.
        //Eğer hasta nesnesi null değilse, "patientManager" nesnesinin "Delete" metodu kullanılarak hasta veritabanından silinir.
        //Veritabanındaki tüm hastaları listeleyen "dataGridView1" nesnesinin "DataSource" özelliğine atanır. Kullanıcıya "Hasta Silindi" mesajı gösterilir
        //. Güncelle ve Sil butonlarının etkinliği kapatılır ve tüm alanlar temizlenir.
        private void btnHastaSil_Click(object sender, EventArgs e)
        {
            //_id değerine göre hasta nesnesi getirir
            Patient silpatient = patientManager.GetById(_id);
            //Eğer hasta nesnesi null değilse
            if (silpatient != null)
            {
                //patientManager nesnesinin Delete metodunu kullanarak hasta bilgilerini veritabanından siler
                patientManager.Delete(silpatient);
                //Veritabanındaki tüm hastaları listeleyen dataGridView1 nesnesinin DataSource özelliğine atar
                dataGridView1.DataSource = patientManager.GetAll();
                //Kullanıcıya "Hasta Silindi" mesajı gösterir
                MessageBox.Show("Hasta Silindi");
                //Güncelle ve Sil butonlarının etkinliğini kapatır
                btnHastaGüncelle.Enabled = false;
                btnHastaSil.Enabled = false;
                //Tüm alanları temizler
                txtHastaAdi.Text = "";
                txtHastaSoyadi.Text = "";
                mtxthastaNumara.Text = "";
                txtHastaEmail.Text = "";

            

             }
        }
        //Bu kod parçası, "txtHastaAra" adlı metin kutusunun "TextChanged" olayını işler.
        //Bu olay, kullanıcının "txtHastaAra" metin kutusunda bir değişiklik yaptığında çalışır. Kod parçası içinde "patientManager"
        //nesnesinin "GetAll" metodu kullanılır. Bu metod "x => x.Name.Contains(txtHastaAra.Text)" şeklinde bir lambda ifadesi alır.
        //Bu lambda ifadesi veritabanındaki tüm hastalar arasında arama yapar ve aranan hasta ismini içeren hasta bilgilerini "dataGridView1"
        //nesnesinin "DataSource" özelliğine atar. Bu şekilde kullanıcı arama yaptıkça aradığı hasta bilgileri "dataGridView1" nesnesinde görüntülenir.
        private void txtHastaAra_TextChanged(object sender, EventArgs e)
        {
            //Aranan hasta ismini içeren hasta bilgilerini dataGridView1 nesnesinin DataSource özelliğine atar
            dataGridView1.DataSource = patientManager.GetAll(x => x.Name.Contains(txtHastaAra.Text));
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
