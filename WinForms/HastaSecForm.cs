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
    public partial class HastaSecForm : Form
    {
        PatientManager patientManager = new PatientManager();
        private bool iptalEdildiMi = true;
        private Patient seciliOgrenci = new Patient();
        public HastaSecForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = patientManager.GetAll();
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
        }
       
        private void btnSeç_Click(object sender, EventArgs e)
        {

            // iptal edildi mi bilgisi false olarak atanır
            iptalEdildiMi = false;
            // Tablodan seçilen satırın indexini al
            int selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
            // seçilen satıra göre hastaıd yi seç
            seciliOgrenci.Id = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells[0].Value);
            // seçilen satıra göre hasta adını seç
            seciliOgrenci.Name = Convert.ToString(dataGridView1.Rows[selectedRowIndex].Cells[1].Value);
            // seçilen satıra göre hasta soyadını seç
            seciliOgrenci.LastName = Convert.ToString(dataGridView1.Rows[selectedRowIndex].Cells[2].Value);
            // seçilen satıra göre hasta telefon numarasını seç
            seciliOgrenci.Phone = Convert.ToString(dataGridView1.Rows[selectedRowIndex].Cells[3].Value);
            // seçilen satıra göre hasta emailin seç
            seciliOgrenci.Email = Convert.ToString(dataGridView1.Rows[selectedRowIndex].Cells[4].Value);

            // Form kapatılır
            this.Close();
        }


        public bool IptalEdildiMi()  
        {
            return this.iptalEdildiMi;
        }
        public Patient GetOgrenci()   // private hasta nesnesini değerini geri döndürmek için fonksiyon oluşturuldu
        {
            return this.seciliOgrenci;
        }
        //formdan işlam ypmadan iptal eder
        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtHastaAra_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = patientManager.GetAll(x => x.Name.Contains(txtHastaAra.Text));
        }
    }
}
