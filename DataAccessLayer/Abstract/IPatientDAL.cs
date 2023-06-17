using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IPatientDAL
    {
        // Tüm hastaları getirir
        List<Patient> GetAll(Expression<Func<Patient, bool>> obj = null);
        // Belirli bir hastayı ID'sine göre getirir
        Patient GetById(int patientId);
        // Yeni bir hasta ekler
        void Add(Patient patient);
        // Var olan bir hastayı günceller
        void Update(Patient patient);
        // Belirli bir hastayı siler
        void Delete(Patient patient);
    }

}
