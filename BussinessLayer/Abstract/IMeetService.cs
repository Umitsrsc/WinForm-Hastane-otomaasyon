using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface IMeetService
    {
        //Id'si verilen randevuyu döndürür.
        Meet GetById(int meetId);
        //Verilen randevuyu ekler
        void Add(Meet meet);
        //Verilen randevuyu günceller
        void Update(Meet meet);
        //Verilen randevuyu siler
        void Delete(Meet meet);
        //Tüm randevuların detaylarını döndürür
        List<MeetDto> GetDetails();
    }


}
