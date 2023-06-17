using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Doctor : IEntity
    {
        // Doktor için ID
        public int Id { get; set; }
        // Doktorun adı
        public string Name { get; set; }
        // Doktorun soyadı
        public string lastName { get; set; }
        // Doktorun telefon numarası
        public string Phone { get; set; }
        // Doktorun kategori ID'si
        public int CategoryId { get; set; }
        // Doktorun kategori bilgisi
        public virtual Category Category { get; set; }

        // Doktorun şifresi
        public string Sifre { get; set; }

        // Doktorun yaptığı görüşmelerin listesi
        public ICollection<Meet> Meets { get; set; }
        // Doktorun yaptığı randevuların listesi
        public ICollection<Apointment>? Apointments { get; set; }
    }

}
