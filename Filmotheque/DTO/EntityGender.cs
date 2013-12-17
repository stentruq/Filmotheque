using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class EntityGender
    {
        public int ID { get; set; }
        public string name { get; set; }
        // Uses virtual keyword for lazy loading.
        public virtual ICollection<EntityFilm> Films { get; set; }
    }
}
