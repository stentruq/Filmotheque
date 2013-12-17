using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class GenderProvider
    {
        public GenderProvider()
        {

        }

        public List<EntityGender> GetAllGenders()
        {
            using (FilmothequeContext context = new FilmothequeContext())
            {
                return context.Genders.ToList();
            }
        }
    }
}
