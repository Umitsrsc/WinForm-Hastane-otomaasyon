using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface ISecretaryService
    {
        // Tüm sekreterleri liste olarak döndürür, eğer filtre belirtilmemişse tüm sekreterleri döndürür
        List<Secretary> GetAll(Expression<Func<Secretary, bool>> obj = null);

        // Belirtilen Id'ye sahip sekreteri döndürür
        Secretary GetById(int secretaryId);

        // Verilen sekreteri kaydeder
        void Add(Secretary secretary);

        // Verilen sekreteri günceller
        void Update(Secretary secretary);

        // Verilen sekreteri siler
        void Delete(Secretary secretary);
    }

}
