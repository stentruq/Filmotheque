using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public static class ImageManager
    {
        public static List<EntityImage> GetAllImages()
        {
            return new ImageProvider().GetAllImages();
        }
    }
}
