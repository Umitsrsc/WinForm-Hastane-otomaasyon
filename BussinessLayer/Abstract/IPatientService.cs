using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface IPatientService
    {
        //Verilen filtreye göre hastaları döndürür.
        List<Patient> GetAll(Expression<Func<Patient, bool>> obj = null);
        //Id'si verilen hastayı döndürür.
        Patient GetById(int patientId);
        //Verilen hastayı ekler
        void Add(Patient patient);
        //Verilen hastayı günceller
        void Update(Patient patient);
        //Verilen hastayı siler
        void Delete(Patient patient);
    }

}
