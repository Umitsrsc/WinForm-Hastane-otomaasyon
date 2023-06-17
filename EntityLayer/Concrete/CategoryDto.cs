using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class CategoryDto //Burada doktorlar tablosunda doktor kategori adı  datagridviewde gözüksün diye bir sınıf oluşturdum
    {
        // Doktorun ID'si
        public int Id { get; set; }
        // Doktorun adı
        public string Name { get; set; }
        // Doktorun soyadı
        public string LastName { get; set; }
        // Doktorun telefon numarası
        public string Phone { get; set; }
        // Doktorun kategori adı
        public string CategoryName { get; set; }
        // Doktorun şifresi
        public string Sifre { get; set; }


    }
}
