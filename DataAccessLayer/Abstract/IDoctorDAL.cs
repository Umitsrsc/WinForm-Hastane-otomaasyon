
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IDoctorDAL
    {
        // Doktorun giriş yapmasını sağlar
        public Doctor Login(string name, string password);
        // Tüm doktorları getirir
        List<Doctor> GetAll(Expression<Func<Doctor, bool>> obj = null);
        // Belirli bir doktoru ID'sine göre getirir
        Doctor GetById(int DoctorId);
        // Yeni bir doktor ekler
        void Add(Doctor doctor);
        // Var olan bir doktoru günceller
        void Update(Doctor doctor);
        // Belirli bir doktoru siler
        void Delete(Doctor doctor);
        // Doktorların ayrıntılarını getirir
        public List<CategoryDto> GetDetails();
        // Belirli bir kategoriye göre doktorları getirir
        List<Doctor> getDoktorByCategoryId(Expression<Func<Doctor, bool>> filter);
    }

}
