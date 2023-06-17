using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category : IEntity
    {
        // Kategori için ID
        public int Id { get; set; }
        // Kategori için ad
        public string Name { get; set; }
        // Bu kategoriye ait doktorların listesi
        public ICollection<Doctor> Doctors { get; set; }
    }

}
