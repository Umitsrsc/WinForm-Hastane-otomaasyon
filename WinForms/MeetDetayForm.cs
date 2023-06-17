using System.Drawing.Printing;
using System.Reflection.Metadata;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;
//using iTextSharp.text.pdf.qrcode;
using EntityLayer.Concrete;
using BussinessLayer.Concrete;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinForms
{
    public partial class MeetDetayForm : Form
    {
        public MeetDetayForm()
        {
            InitializeComponent();
            dataGridViewdetay.Columns[0].Visible = false;
            
        }
        MeetManager meetManager=new MeetManager();
        MeetDto meetdto=new MeetDto();
       
        private void MeetDetayForm_Load(object sender, EventArgs e)
        {
        }
        //Bu kod parçası, "btnpdf" adlı butona tıklandığında çalışır. Öncelikle kullanıcıya bir dosya kaydetme penceresi açılır.
        //Kullanıcının seçebileceği dosya türü olarak sadece pdf dosyaları seçilir. Kullanıcı dosya kaydetme penceresinde "OK" tuşuna basarsa,
        //seçilen dosya yolu ile bir dosya oluşturulur. Bu dosya, iTextSharp kütüphanesi kullanılarak pdf formatında oluşturulur. pdf dosyasına
        //form alanlarından veriler eklenir. Son olarak pdf dosyası kapatılır ve dosya streami kapatılır. Böylece kullanıcının seçtiği yere pdf
        //dosyası oluşmuş olur ve içerisinde form alanlarındaki bilgiler mevcut.
        private void btnpdf_Click(object sender, EventArgs e)
        {
            //Dosya kaydetme penceresi açılır
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                //Filtre olarak pdf dosyaları seçilir
                saveFileDialog.Filter = "pdf dosyası(*.pdf)|*.pdf";
                //Dosyanın varsayılan adı belirlenir
                saveFileDialog.FileName = "Randevu Bilgileri.pdf";

                //Kullanıcı dosya kaydetme penceresinde OK tuşuna basarsa
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Seçilen dosya yolu ile dosya oluşturulur
                    using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        //pdf dosyası oluşturulur
                        iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(PageSize.A4, 10f, 10f, 10f, 0f);
                        PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();

                        //pdf dosyasına form alanlarından veriler eklenir
                        pdfDoc.Add(new Paragraph("Doktor Adi " + txtDoktorAdı.Text));
                        pdfDoc.Add(new Paragraph("Doktor Soyadi " + txtDoktorSoyadı.Text));
                        pdfDoc.Add(new Paragraph("Hasta Adi " + txtHastaAdı.Text));
                        pdfDoc.Add(new Paragraph("Hasta Soyadi " + txtHastaSoyadı.Text));
                        pdfDoc.Add(new Paragraph("Görüs " + txtDoktorGorus.Text));

                        //pdf dosyası kapatılır ve dosya streami kapatılır
                        pdfDoc.Close();
                        stream.Close();
                    }
                }
            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewdetay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        //Bu kod parçası, "dataGridViewdetay" adlı datagridview nesnesinin "RowHeaderMouseDoubleClick" olayına tanımlanmıştır.
        //Bu olay, kullanıcının datagridview nesnesinde iki kez satır başlığına tıklaması durumunda tetiklenir.
        //Olay tetiklendiğinde, dataGridViewdetay nesnesinden seçilen satırdaki doktor adı, doktor soyadı, hasta adı, hasta soyadı ve
        //görüş bilgileri alınır. Daha sonra form alanlarına bu bilgiler yazılır. Bu şekilde kullanıcı dataGridViewdetay nesnesinde bir
        //satır seçtiğinde, form alanlarına seçilen satırdaki bilgiler yazılır ve kullanıcı bu bilgileri kullanabilir.

        private void dataGridViewdetay_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //dataGridViewdetay nesnesinden seçilen satırdaki doktor adı alınır
            string DoktorAdi = dataGridViewdetay.CurrentRow.Cells["DoctorName"].Value.ToString();
            //dataGridViewdetay nesnesinden seçilen satırdaki doktor soyadı alınır
            string DoktorSoyadi = dataGridViewdetay.CurrentRow.Cells["DoctorLastName"].Value.ToString();

            //dataGridViewdetay nesnesinden seçilen satırdaki hasta adı alınır
            string HastaAdi = dataGridViewdetay.CurrentRow.Cells["PatientName"].Value.ToString();
            //dataGridViewdetay nesnesinden seçilen satırdaki hasta soyadı alınır
            string HastaSoyadi = dataGridViewdetay.CurrentRow.Cells["PatientLastName"].Value.ToString();

            //dataGridViewdetay nesnesinden seçilen satırdaki görüş alınır
            string gorus = dataGridViewdetay.CurrentRow.Cells["Describe"].Value.ToString();

            //form alanlarına alınan veriler yazılır
            txtDoktorAdı.Text = DoktorAdi;
            txtDoktorSoyadı.Text = DoktorSoyadi;

            txtHastaAdı.Text = HastaAdi;
            txtHastaSoyadı.Text = HastaSoyadi;

            txtDoktorGorus.Text = gorus;

        }

        private void txtDoktorAdı_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
