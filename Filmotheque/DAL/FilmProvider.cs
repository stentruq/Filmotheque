using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class FilmProvider
    {
        public FilmProvider()
        {

        }

        public List<EntityFilm> GetAllFilms()
        {
            using (FilmothequeContext context = new FilmothequeContext())
            {
                return context.Films.ToList();
            }
        }
    }
}
