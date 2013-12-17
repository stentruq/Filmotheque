using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class EntityFilm
    {
        public int ID { get; set; }
        public string title { get; set; }
        public string synopsis { get; set; }
        // Uses virtual keyword for lazy loading.
        public virtual EntityImage Image { get; set; }
        public virtual ICollection<EntityActor> Actors { get; set; }
        public virtual ICollection<EntityGender> Genders { get; set; }
    }
}
