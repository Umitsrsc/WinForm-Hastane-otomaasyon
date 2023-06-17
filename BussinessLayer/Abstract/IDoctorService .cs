
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface IDoctorService
    {
        //Verilen isim ve şifre ile eşleşen doktor nesnesini döndürür.
        public Doctor Login(string name, string password);
        //Doktorların kategori bilgilerini içeren detaylarını döndürür.
        public List<CategoryDto> GetDetails();
        //Tüm doktorları liste olarak döndürür.
        List<Doctor> GetAll(Expression<Func<Doctor, bool>> obj = null);
        // Verilen doktorId ile eşleşen doktor nesnesini döndürür.
        Doctor GetById(int doctorId);
        // Verilen doktor nesnesini veritabanına ekler.
        void Add(Doctor doctor);
        // Verilen doktor nesnesini veritabanındaki eşleşen nesne ile günceller.
        void Update(Doctor doctor);
        // Verilen doktor nesnesini veritabanından siler.
        void Delete(Doctor doctor);
        //Verilen categoryId ile eşleşen doktorları liste olarak döndürür.
        List<Doctor> getDoktorByCategoryId(int categoryId);
    }

}
