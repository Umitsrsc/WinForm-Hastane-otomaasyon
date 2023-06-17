using BussinessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EfCategoryDAL _categoryDAL = new EfCategoryDAL();
        public List<Category> GetAll()
        {
            return _categoryDAL.GetAll();
        }
    }
}
