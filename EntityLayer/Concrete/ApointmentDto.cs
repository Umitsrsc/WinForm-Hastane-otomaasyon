using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ApointmentDto //Burada randevular tablosunda doktor adı ve hasta adı datagridviewde gözüksün diye bir sınıf oluşturdum
    {
        // Randevunun ID'si
        public int Id { get; set; }
        // Randevu yapan doktorun adı
        public string DoctorName { get; set; }
        // Randevu yapan hastanın adı
        public string PatientName { get; set; }
        // Randevunun tarihi ve saati
        public DateTime Time { get; set; }
        // Randevunun saati
        public string Hour { get; set; }
    }

}
