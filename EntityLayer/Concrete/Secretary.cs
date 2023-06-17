using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Secretary : IEntity
    {
        // Sekreterin ID'si
        public int Id { get; set; }
        // Sekreterin adı
        public string Name { get; set; }
        // Sekreterin soyadı
        public string LastName { get; set; }
        // Sekreterin telefon numarası
        public string Phone { get; set; }
    }

}
