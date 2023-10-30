using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Unit
    {

        private DAL_Unit dAL_Unit = new DAL_Unit();
        public BLL_Unit() { }


        public List<string> getNameUnit()
        {
            return dAL_Unit.getNameUnit();
        }

        public int getIdUnitName(String name)
        {
            return dAL_Unit.getIdUnitName(name);
        }


        public DTO_Unit getUnitById(int id)
        {
            return dAL_Unit.getUnitById(id);
        }

    }
}
