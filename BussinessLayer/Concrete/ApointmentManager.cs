using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class ApointmentManager : IApointmentService
    {
        //Data Acces Layer'ı oluşturalım.
        EfApointmentDAL _apointmentDAL = new EfApointmentDAL();
        //randevu ekleyebilmek için metod
        public void Add(Apointment apointment)
        {
            _apointmentDAL.Add(apointment);
        }
        //randevu silmek için metod
        public void Delete(Apointment apointment)
        {
            _apointmentDAL.Delete(apointment);
        }
        //tüm randevuları getirmek için metod
        public List<Apointment> GetAll()
        {
            return _apointmentDAL.GetAll();
        }
        //belirli bir randevuyu getirmek için metod
        public Apointment GetById(int apointmentId)
        {
            return _apointmentDAL.GetById(apointmentId);
        }
        //randevuların detaylarını getirmek için metod
        public List<ApointmentDto> GetDetails()
        {
            return _apointmentDAL.GetDetails();
        }
        //randevu güncellemek için metod
        public void Update(Apointment apointment)
        {
            _apointmentDAL.Update(apointment);
        }
    }

}
