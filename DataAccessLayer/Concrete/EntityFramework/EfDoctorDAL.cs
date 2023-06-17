using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;


namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfDoctorDAL : IDoctorDAL
    {

        AppDbContext _context = new AppDbContext();
        // Bu satır, Entity Framework Core kullanarak veritabanı ile etkileşim için AppDbContext sınıfının yeni bir örneğini oluşturur.

        public void Add(Doctor doctor)
        {
            _context.Add(doctor);
            // Bu satır, parametre olarak verilen Doctor nesnesini veritabanına eklemek için EF Core'un Add yöntemini kullanır.

            _context.SaveChanges();
            // Bu satır, veritabanına yapılan değişiklikleri kaydeder. Bu işlem eklenen yeni Doctor nesnesini de içermektedir.
        }

        public void Delete(Doctor doctor)
        {
            _context.Doctors.Remove(doctor);
            // Bu satır, parametre olarak verilen Doctor nesnesini veritabanından silmek için EF Core'un Remove yöntemini kullanır.
            _context.SaveChanges();
        }

        public List<Doctor> GetAll(Expression<Func<Doctor, bool>> obj = null)
        {
            List<Doctor> liste;
            // Bu satır, Doctor nesnelerinin listesini tutmak için bir List<Doctor> tipinde bir değişken oluşturur.
            if (obj == null)
            {
                liste = _context.Set<Doctor>().ToList();
                // Bu satır, obj parametresi null ise, veritabanındaki tüm Doctor nesnelerini _context.Set<Doctor>().ToList() yöntemi ile alır.
            }
            else
            {
                liste = _context.Set<Doctor>().Where(obj).ToList();
                // Bu satır, obj parametresi null değilse, obj parametresi ile belirtilen filtre kriterlerine göre veritabanındaki Doctor nesnelerini _context.Set<Doctor>().Where(obj).ToList() yöntemi ile alır.
            }
            return liste;
            // Bu satır, Doctor nesnelerinin listesini döndürür.
        }

        public Doctor GetById(int DoctorId)
        {
            return _context.Doctors.Find(DoctorId);
            // Bu satır, veritabanındaki Doctor nesnelerinden verilen DoctorId ile eşleşen nesnenin alınması için _context.Doctors.Find(DoctorId) yöntemini kullanır.
        }




        public List<Doctor> getDoktorByCategoryId(Expression<Func<Doctor, bool>> filter)
        {
            // Bu satır, verilen filtre kriterlerine göre veritabanındaki Doctor nesnelerini _context.Set<Doctor>().Where(filter).ToList() yöntemi ile alır ve döndürür.
            return _context.Set<Doctor>().Where(filter).ToList();
        }

        public Doctor Login(string name, string password)
        {
            // Bu satır, veritabanındaki Doctor nesnelerinden kullanıcının girdiği kullanıcı adı ve şifreye eşleşen nesnenin alınması için _context.Doctors.SingleOrDefault(d => d.Name == name && d.Sifre == password) yöntemini kullanır.
            var doctor = _context.Doctors.SingleOrDefault(d => d.Name == name && d.Sifre == password);
            return doctor;
        }

        public void Update(Doctor doctor)
        {
            // Bu satır, veritabanındaki Doctor nesnelerinden verilen doctor.Id ile eşleşen nesnenin alınması için _context.Doctors.Find(doctor.Id) yöntemini kullanır.
            var result = _context.Doctors.Find(doctor.Id);
            if (result != null)
            {
                // Bu satır, eşleşen Doctor nesnesi null değilse, verilen Doctor nesnesinin adını result nesnesinin adına atar.
                result.Name = doctor.Name;
                _context.SaveChanges();
                // Bu satır, veritabanına yapılan değişiklikleri kaydeder. Bu işlem güncellenen Doctor nesnesini de içermektedir.
            }
        }

        public List<CategoryDto> GetDetails()
        {
            // Bu satır, veritabanındaki Doctor ve Category nesnelerinin birleştirilmiş hali için bir sorgu oluşturur.
            var result = from dktr in _context.Doctors
                         join ctgry in _context.Categories on dktr.CategoryId equals ctgry.Id
                         // Bu satır, Doctor nesnelerinin CategoryId'si ile Category nesnelerinin Id'si arasında eşleşme olduğunda, Doctor ve Category nesnelerinin bilgilerini birleştirir.

                         select new CategoryDto
                         {
                             Id = dktr.Id,
                             Name = dktr.Name,
                             LastName = dktr.lastName,
                             Phone = dktr.Phone,
                             CategoryName = ctgry.Name,
                             Sifre = dktr.Sifre,
                             // Bu satır, oluşan birleştirilmiş bilgileri CategoryDto nesnesine atar.
                         };

            return result.ToList();
            // Bu satır, oluşan sorgudan dönen sonucu List<CategoryDto> tipinde döndürür.
        }


    }
}
