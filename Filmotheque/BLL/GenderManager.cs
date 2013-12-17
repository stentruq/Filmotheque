using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public static class GenderManager
    {
        public static List<EntityGender> GetAllGenders()
        {
            return new GenderProvider().GetAllGenders();
        }
    }
}
