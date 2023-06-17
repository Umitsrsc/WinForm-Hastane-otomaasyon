using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ISecretaryDAL
    {
        // Tüm sekreterleri getirir
        List<Secretary> GetAll(Expression<Func<Secretary, bool>> obj = null);
        // Belirli bir sekreteri ID'sine göre getirir
        Secretary GetById(int secretaryId);
        // Yeni bir sekreter ekler
        void Add(Secretary secretary);
        // Var olan bir sekreteri günceller
        void Update(Secretary secretary);
        // Belirli bir sekreteri siler
        void Delete(Secretary secretary);
    }

}
