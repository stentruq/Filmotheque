using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class ImageProvider
    {
        public ImageProvider()
        {

        }

        public List<EntityImage> GetAllImages()
        {
            using (FilmothequeContext context = new FilmothequeContext())
            {
                return context.Images.ToList();
            }
        }
    }
}
