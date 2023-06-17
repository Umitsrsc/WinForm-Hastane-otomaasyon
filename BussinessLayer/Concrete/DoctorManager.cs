using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;

using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class DoctorManager : IDoctorService
    {

        EfDoctorDAL _doctorDAL = new EfDoctorDAL();
        //Doctor sınıfından nesnelerin eklenmesini sağlar
        public void Add(Doctor doctor)
        {
            _doctorDAL.Add(doctor);
        }
        //Doctor sınıfından nesnelerin silinmesini sağlar
        public void Delete(Doctor doctor)
        {
            _doctorDAL.Delete(doctor);
        }
        //Doctor sınıfından nesnelerin listelenmesini sağlar
        public List<Doctor> GetAll(Expression<Func<Doctor, bool>> obj = null)
        {
            return _doctorDAL.GetAll(obj);
        }
        //Doctor sınıfından nesnelerin detaylarının listelenmesini sağlar
        public List<CategoryDto> GetDetails()
        {
            return _doctorDAL.GetDetails();
        }
        //Doctor sınıfından nesnelerin Id'ye göre getirilmesini sağlar
        public Doctor GetById(int doctorId)
        {
            return _doctorDAL.GetById(doctorId);
        }
        //Doctor sınıfından kategoriye göre nesnelerin getirilmesini sağlar
        public List<Doctor> getDoktorByCategoryId(int categoryId)
        {
            return _doctorDAL.getDoktorByCategoryId(d => d.CategoryId == categoryId);
        }
        //Doctor sınıfından nesnelerin güncellenmesini sağlar
        public void Update(Doctor doctor)
        {
            _doctorDAL.Update(doctor);
        }

        // Doctor girişi için metod
        public Doctor Login(string name, string password)
        {
            // Veri erişim katmanı sınıfındaki Login metodunu çağır ve kullanıcının girdiği name ve password değerlerini kullan
            return _doctorDAL.Login(name, password);
        }
    }
}
