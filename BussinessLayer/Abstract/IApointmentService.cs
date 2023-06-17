using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface IApointmentService
    {
        // Tüm Apointment nesnelerini liste olarak döndürür.
        List<Apointment> GetAll();
        // Verilen apointmentId ile eşleşen Apointment nesnesini döndürür.
        Apointment GetById(int apointmentId);
        // Verilen Apointment nesnesini veritabanına ekler.
        void Add(Apointment apointment);
        // Verilen Apointment nesnesini veritabanındaki eşleşen nesne ile günceller.
        void Update(Apointment apointment);
        // Verilen Apointment nesnesini veritabanından siler.
        void Delete(Apointment apointment);
        // Apointment nesnelerinin detaylarını döndürür.
        public List<ApointmentDto> GetDetails();
    }

}
