using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IMeetDAL
    {
        // Belirli bir görüşmeyi ID'sine göre getirir
        Meet GetById(int meetId);
        // Yeni bir görüşme ekler
        void Add(Meet meet);
        // Var olan bir görüşmeyi günceller
        void Update(Meet meet);
        // Belirli bir görüşmeyi siler
        void Delete(Meet meet);
        // Görüşmelerin ayrıntılarını getirir
        public List<MeetDto> GetDetails();
    }

}
