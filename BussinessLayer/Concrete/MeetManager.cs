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
    public class MeetManager : IMeetService
    {
        // Meet sınıfı için veri erişim katmanı sınıfı 
        EfMeetDAL _meetDAL = new EfMeetDAL();

        // Veritabanına Meet eklemek için metod
        public void Add(Meet meet)
        {
            _meetDAL.Add(meet);
        }

        // Veritabanından Meet silmek için metod
        public void Delete(Meet meet)
        {
            _meetDAL.Delete(meet);
        }

        // meetId değerine göre veritabanından Meet getirmek için metod
        public Meet GetById(int meetId)
        {
            return _meetDAL.GetById(meetId);
        }

        // Veritabanındaki tüm Meet detaylarını getirmek için metod
        public List<MeetDto> GetDetails()
        {
            return _meetDAL.GetDetails();
        }

        // Veritabanındaki Meet güncellemek için metod
        public void Update(Meet meet)
        {
            _meetDAL.Update(meet);
        }
    }

}
