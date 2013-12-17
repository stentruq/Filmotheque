using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public static class FilmManager
    {
        public static List<EntityFilm> GetAllFilms()
        {
            return new FilmProvider().GetAllFilms();
        }

        public static void AddActors(List<EntityActor> actorsToAdd)
        {
            ActorProvider actorProvider = new ActorProvider();
            actorProvider.AddActors(actorsToAdd);
        }
    }
}
