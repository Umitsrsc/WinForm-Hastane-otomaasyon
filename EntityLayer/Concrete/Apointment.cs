using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Apointment : IEntity
    {
        // Randevunun ID'si
        public int Id { get; set; }

        // Bu randevuyla ilişkili doktorun ID'si
        public int DoctorId { get; set; }
        // Bu randevuyla ilişkili doktor
        public virtual Doctor Doctor { get; set; }
        // Bu randevuyla ilişkili hastanın ID'si
        public int PatientId { get; set; }
        // Bu randevuyla ilişkili hasta
        public virtual Patient Patient { get; set; }

        // Randevunun zamanı
        public DateTime Time { get; set; }
        // Randevunun saati
        public string Hour { get; set; }
    }

}
