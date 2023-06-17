using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class MeetDto //Burada Görüşme tablosunda doktor  adı,soyadı,hasta adı,soyadı  datagridviewde gözüksün diye bir sınıf oluşturdum
    {
        // Görüşme için ID
        public int Id { get; set; }
        // Görüşme yapan doktorun ID'si
        public int DoctorId { get; set; }
        // Görüşme yapan doktorun adı
        public string DoctorName { get; set; }
        // Görüşme yapan doktorun soyadı
        public string DoctorLastName { get; set; }
        // Görüşme yapılan hastanın ID'si
        public int PatientId { get; set; }
        // Görüşme yapılan hastanın adı
        public string PatientName { get; set; }
        // Görüşme yapılan hastanın soyadı
        public string PatientLastName { get; set; }
        // Görüşmenin açıklaması
        public string Describe { get; set; }
    }
}
