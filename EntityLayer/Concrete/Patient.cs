using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Patient : IEntity
    {
        // Hastanın ID'si
        public int Id { get; set; }
        // Hastanın adı
        public string Name { get; set; }
        // Hastanın soyadı
        public string LastName { get; set; }
        // Hastanın telefon numarası
        public string Phone { get; set; }
        // Hastanın email adresi
        public string Email { get; set; }
        // Hastanın randevularının listesi
        public ICollection<Apointment>? Apointments { get; set; }
        // Hastanın yaptığı görüşmelerin listesi
        public ICollection<Meet> Meets { get; set; }
    }

}
