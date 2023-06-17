using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfSecretaryDAL : ISecretaryDAL
    {
        AppDbContext _context = new AppDbContext();
        public void Add(Secretary secretary)
        {
            // Bu satır, veritabanına yeni bir Secretary nesnesi eklemek için _context.Add(secretary) yöntemi kullanılır.
            _context.Add(secretary);
            // Bu satır, veritabanına eklenen Secretary nesnesinin kaydedilmesi için _context.SaveChanges() yöntemi kullanılır.
            _context.SaveChanges();
        }

        public void Delete(Secretary secretary)
        {
            // Bu satır, veritabanındaki Secretary nesnelerinden verilen secretary nesnesini silmek için _context.secretaries.Remove(secretary) yöntemi kullanılır.
            _context.secretaries.Remove(secretary);
            // Bu satır, veritabanındaki silinen Secretary nesnesinin kaydedilmesi için _context.SaveChanges() yöntemi kullanılır.
            _context.SaveChanges();
        }

        public List<Secretary> GetAll(Expression<Func<Secretary, bool>> obj = null)
        {
            List<Secretary> liste;
            // Bu if statementı, obj eğer null ise tüm Secretary nesnelerini listeye atar
            if (obj == null)
            {
                liste = _context.Set<Secretary>().ToList();
            }
            // obj null değilse  where methodu ile obj'a göre filtreleme yapar ve bu filtrelenen nesneleri listeye atar
            else
                liste = _context.Set<Secretary>().Where(obj).ToList();

            //listeyi geri döndürür
            return liste;
        }

        public Secretary GetById(int secretaryId)
        {
            // secretaryId ile eşleşen Secretary nesnesini veritabanından çekmek için kullanılır.
            return _context.secretaries.Find(secretaryId);
        }

        public void Update(Secretary secretary)
        {
            // Bu satır, veritabanındaki Secretary nesnelerinden verilen secretary.Id ile eşleşen nesnenin alınması için _context.secretaries.Find(secretary.Id) yöntemi kullanılır.
            var result = _context.secretaries.Find(secretary.Id);
            if (result != null)
            {
                // Bu satır, eşleşen nesnenin null olmadığını kontrol eder.
                result.Name = secretary.Name;
                _context.SaveChanges();
                // Bu satır, veritabanına yapılan güncelleme işlemlerini kaydeder.
            }
        }


    }
}
