using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfMeetDAL : IMeetDAL
    {
        AppDbContext _context = new AppDbContext();
        public void Add(Meet meet)
        {
            // Bu satır, veritabanına eklemek için gönderilen Meet nesnesini _context nesnesine ekler.
            _context.Add(meet);
            _context.SaveChanges();
            // Bu satır, veritabanına yapılan ekleme işlemlerini kaydeder.
        }

        public void Delete(Meet meet)
        {
            // Bu satır, veritabanından silmek için gönderilen Meet nesnesini _context.Meets.Remove(meet) yöntemi ile siler.
            _context.Meets.Remove(meet);
            _context.SaveChanges();
            // Bu satır, veritabanına yapılan silme işlemlerini kaydeder.
        }

        public Meet GetById(int meetId)
        {
            // Bu satır, veritabanındaki Meet nesnelerinden verilen meetId ile eşleşen nesnenin alınması için _context.Meets.Find(meetId) yöntemini kullanır ve döndürür.
            return _context.Meets.Find(meetId);
        }


        public List<MeetDto> GetDetails()
        {
            // Bu satır, veritabanındaki Meet, Doctor ve Patient nesnelerinin birleştirilmiş hali için bir sorgu oluşturur.
            var result = from meet in _context.Meets
                         join dktr in _context.Doctors on meet.DoctorId equals dktr.Id
                         join ptnt in _context.Patients on meet.PatientId equals ptnt.Id
                         // Bu satır, Meet nesnelerinin DoctorId'si ile Doctor nesnelerinin Id'si arasında eşleşme olduğunda, Meet ve Doctor nesnelerinin bilgilerini birleştirir.
                         // Bu satır, Meet nesnelerinin PatientId'si ile Patient nesnelerinin Id'si arasında eşleşme olduğunda, Meet ve Patient nesnelerinin bilgilerini birleştirir.

                         select new MeetDto
                         {
                             Id = meet.Id,
                             DoctorName = dktr.Name,
                             DoctorLastName = dktr.lastName,
                             PatientName = ptnt.Name,
                             PatientLastName = ptnt.LastName,
                             Describe = meet.Describe,
                             // Bu satır, oluşan birleştirilmiş bilgileri MeetDto nesnesine atar.
                         };

            return result.ToList();
            // Bu satır, oluşan sorgudan dönen sonucu List<MeetDto> tipinde döndürür.
        }


        public void Update(Meet meet)
        {
            // Bu satır, veritabanındaki Meet nesnelerinden verilen meet.Id ile eşleşen nesnenin alınması için _context.Meets.Find(meet.Id) yöntemini kullanır.
            var result = _context.Meets.Find(meet.Id);
            if (result != null)
            {
                // Bu satır, eşleşen nesnenin null olmadığını kontrol eder.
                result.Id = meet.Id;
                _context.SaveChanges();
                // Bu satır, veritabanına yapılan güncelleme işlemlerini kaydeder.
            }
        }

    }
}
