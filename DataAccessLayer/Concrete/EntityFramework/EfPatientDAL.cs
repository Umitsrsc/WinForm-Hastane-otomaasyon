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
    public class EfPatientDAL : IPatientDAL
    {

        AppDbContext _context = new AppDbContext();
        public void Add(Patient patient)
        {
            // Bu satır, veritabanına eklemek için gönderilen Patient nesnesini _context nesnesine ekler.
            _context.Add(patient);
            _context.SaveChanges();
            // Bu satır, veritabanına yapılan ekleme işlemlerini kaydeder.
        }

        public void Delete(Patient patient)
        {
            // Bu satır, veritabanından silmek için gönderilen Patient nesnesini _context.Patients.Remove(patient) yöntemi ile siler.
            _context.Patients.Remove(patient);
            _context.SaveChanges();
            // Bu satır, veritabanına yapılan silme işlemlerini kaydeder.
        }


        public List<Patient> GetAll(Expression<Func<Patient, bool>> obj = null)
        {
            List<Patient> liste;
            // Bu satır, obj parametresi null ise tüm Patient nesnelerini veritabanından alır.
            if (obj == null)
            {
                liste = _context.Set<Patient>().ToList();
            }
            // Bu satır, obj parametresi null değilse veritabanındaki Patient nesnelerinden filtre uygulanarak istenilen nesnelerin alınması için _context.Set<Patient>().Where(obj).ToList() yöntemi kullanılır.
            else
                liste = _context.Set<Patient>().Where(obj).ToList();

            return liste;
            // Bu satır, veritabanından alınan Patient nesnelerinin listesini döndürür.
        }

        public Patient GetById(int patientId)
        {
            // Bu satır, veritabanındaki Patient nesnelerinden verilen patientId ile eşleşen nesnenin alınması için _context.Patients.Find(patientId) yöntemi kullanılır.
            return _context.Patients.Find(patientId);
        }


        public void Update(Patient patient)
        {
            // Bu satır, veritabanındaki Patient nesnelerinden verilen patient.Id ile eşleşen nesnenin alınması için _context.Patients.Find(patient.Id) yöntemi kullanılır.
            var result = _context.Patients.Find(patient.Id);
            if (result != null)
            {
                // Bu satır, eşleşen nesnenin null olmadığını kontrol eder.
                result.Name = patient.Name;
                _context.SaveChanges();
                // Bu satır, veritabanına yapılan güncelleme işlemlerini kaydeder.
            }
        }

    }
}
