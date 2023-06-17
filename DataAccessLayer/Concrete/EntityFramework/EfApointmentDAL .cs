using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfApointmentDAL : IApointmentDAL
    {

        AppDbContext _context = new AppDbContext();
        // Bu satır Entity Framework Core kullanarak veritabanı ile etkileşim için AppDbContext sınıfının yeni bir örneğini oluşturur.

        public void Add(Apointment apointment)
        {
            _context.Add(apointment);
            // Bu satır, parametre olarak verilen Apointment nesnesini veritabanına eklemek için EF Core'un Add yöntemini kullanır.

            _context.SaveChanges();
            // Bu satır, veritabanına yapılan değişiklikleri kaydeder. Bu işlem eklenen yeni Apointment nesnesini de içermektedir.
        }

        public void Delete(Apointment apointment)
        {
            _context.Apointments.Remove(apointment);
            // Bu satır, parametre olarak verilen Apointment nesnesini veritabanından silmek için EF Core'un Remove yöntemini kullanır.

            _context.SaveChanges();
            // Bu satır, veritabanına yapılan değişiklikleri kaydeder. Bu işlem silinen Apointment nesnesini de içermektedir.
        }

        public List<Apointment> GetAll()
        {
            return _context.Apointments.ToList();
            // Bu satır, veritabanındaki tüm Apointment nesnelerini liste şeklinde döndürmek için EF Core'un ToList yöntemini kullanır.
        }

        public Apointment GetById(int apointmentId)
        {
            return _context.Apointments.Find(apointmentId);
        }

        public List<ApointmentDto> GetDetails()
        {
            // var result = from rnd in _context.Apointments
            // join dktr in _context.Doctors on rnd.DoctorId equals dktr.Id
            // join ptnt in _context.Patients on rnd.PatientId equals ptnt.Id
            // Bu satır "result" adlı bir değişken oluşturur ve Linq kullanarak Apointments tablosunu DoctorId sütunu ile Doctors tablosu ve PatientId sütunu ile Patients tablosu ile birleştiren bir sorguyu tutar.
            var result = from rnd in _context.Apointments
                         join dktr in _context.Doctors on rnd.DoctorId equals dktr.Id
                         join ptnt in _context.Patients on rnd.PatientId equals ptnt.Id

                         //select new ApointmentDto
                         //{
                         //    Id = rnd.Id,
                         //    DoctorName = dktr.Name,
                         //    PatientName = ptnt.Name,
                         //    Time = rnd.Time,
                         //    Hour = rnd.Hour,
                         //};
                         // Bu satır her sonuç satırı için yeni bir ApointmentDto nesnesi oluşturur ve özelliklerini birleştirilmiş tablolardaki karşılık gelen değerlere ayarlar.
                         select new ApointmentDto
                         {
                             Id = rnd.Id,
                             DoctorName = dktr.Name,
                             PatientName = ptnt.Name,
                             Time = rnd.Time,
                             Hour = rnd.Hour,
                         };
            // return result.ToList();
            // Bu satır ToList() yöntemi ile ApointmentDto nesnelerinin listesini döndürür.
            return result.ToList();
        }

        public void Update(Apointment apointment)
        {
            var result = _context.Apointments.Find(apointment.Id);  
                _context.SaveChanges();
            
        }
    }
}
