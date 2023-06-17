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
    public class SecretaryManager : ISecretaryService
    {
        EfSecretaryDAL _secretaryDAL = new EfSecretaryDAL();

        // Veritabanına Secretary eklemek için metod
        public void Add(Secretary secretary)
        {
            _secretaryDAL.Add(secretary);
        }

        // Veritabanından Secretary silmek için metod
        public void Delete(Secretary secretary)
        {
            _secretaryDAL.Delete(secretary);
        }

        // Veritabanındaki tüm Secretary'leri getirmek için metod, filtre uygulanabilir
        public List<Secretary> GetAll(Expression<Func<Secretary, bool>> obj = null)
        {
            return _secretaryDAL.GetAll(obj);
        }

        // secretaryId değerine göre veritabanından Secretary getirmek için metod
        public Secretary GetById(int secretaryId)
        {
            return _secretaryDAL.GetById(secretaryId);
        }

        //veri tabanında güncelleme yapmak için
        public void Update(Secretary secretary)
        {
            _secretaryDAL.Update(secretary);
        }
    }
}
