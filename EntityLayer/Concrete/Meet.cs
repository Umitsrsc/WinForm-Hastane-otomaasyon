using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Meet
    {
        // Görüşme için ID
        public int Id { get; set; }
        // Görüşme yapan doktorun ID'si
        public int DoctorId { get; set; }
        // Görüşme yapan doktor
        public virtual Doctor Doctor { get; set; }
        // Görüşme yapılan hastanın ID'si
        public int PatientId { get; set; }
        // Görüşme yapılan hasta
        public virtual Patient Patient { get; set; }
        // Görüşmenin açıklaması
        public string Describe { get; set; }
    }

}
