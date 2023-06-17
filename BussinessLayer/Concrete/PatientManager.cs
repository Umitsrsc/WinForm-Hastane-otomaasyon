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
    public class PatientManager : IPatientService
    {
        // Patient sınıfı için veri erişim katmanı sınıfı 
        EfPatientDAL _patientDAL = new EfPatientDAL();

        // Veritabanına Patient eklemek için metod
        public void Add(Patient patient)
        {
            _patientDAL.Add(patient);
        }

        // Veritabanından Patient silmek için metod
        public void Delete(Patient patient)
        {
            _patientDAL.Delete(patient);
        }

        // Veritabanındaki tüm Patient'leri getirmek için metod, filtre uygulanabilir
        public List<Patient> GetAll(Expression<Func<Patient, bool>> obj = null)
        {
            return _patientDAL.GetAll(obj);
        }

        // patientId değerine göre veritabanından Patient getirmek için metod
        public Patient GetById(int patientId)
        {
            return _patientDAL.GetById(patientId);
        }

        // Veritabanındaki Patient güncellemek için metod
        public void Update(Patient patient)
        {
            _patientDAL.Update(patient);
        }
    }

}
