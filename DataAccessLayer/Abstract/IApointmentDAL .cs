using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IApointmentDAL
    {
        // Tüm randevuları getirir
        List<Apointment> GetAll();
        // Belirli bir randevuyu ID'sine göre getirir
        Apointment GetById(int apointmentId);
        // Yeni bir randevu ekler
        void Add(Apointment apointment);
        // Var olan bir randevuyu günceller
        void Update(Apointment apointment);
        // Belirli bir randevuyu siler
        void Delete(Apointment apointment);
        // Randevuların ayrıntılarını getirir
        public List<ApointmentDto> GetDetails();
    }

}
