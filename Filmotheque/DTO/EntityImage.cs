using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class EntityImage
    {
        public int ID { get; set; }
        public byte[] image { get; set; }
        public virtual EntityFilm Film { get; set; }
    }
}
