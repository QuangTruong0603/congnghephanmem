using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public  class BLL_Category
    {
        private DAL_Category dAL_Category = new DAL_Category();
        public BLL_Category() { }


        public List<string> getNameCatgory()
        {
            return dAL_Category.getNameCatgory();
        }

        public int getIdNameCategory(String name)
        {
            return dAL_Category.getIdByName(name);
        }

        public DTO_Category getCategoryById(int id)
        {
            return dAL_Category.getCategoryById(id);
        }

    }
}
