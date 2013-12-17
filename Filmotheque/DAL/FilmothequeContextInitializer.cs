using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.Entity;
using WatTmdb.V3;

namespace DAL
{
    class FilmothequeContextInitializer : DropCreateDatabaseIfModelChanges<FilmothequeContext>
    {
        // Get all popular movies.
        static WatTmdb.V3.Tmdb api = new Tmdb("apikey", "en");
        TmdbPopular popularMovies = api.GetPopularMovies(1);

        protected override void Seed(FilmothequeContext context)
		{
            int numberOfFilms = popularMovies.total_results;

			List<EntityFilm> filmList = new List<EntityFilm>();
			for(int i=0; i < numberOfFilms; i++) 
			{
				// Save film.
				TmdbMovie infosFilm = api.GetMovieInfo(i);
                filmList.Add(new EntityFilm { title = infosFilm.title, synopsis = infosFilm.overview });
				// Get all actors to the film.
				TmdbMovieCast actorsCasting = api.GetMovieCast(i);
				List<EntityActor> actorList = new List<EntityActor>();

				foreach (var actor in actorsCasting.cast)
				{
					// Get infos to the actor.
					TmdbPerson infosActor = api.GetPersonInfo(actor.id);
                    string actorName = infosActor.name;
                    string actorBiography = infosActor.biography;
					// Save actor.
                    actorList.Add(new EntityActor { name = actorName, biography = infosActor.ToString() });
				}
				// Actors list or list of actors list ?
				actorList.ForEach(entity => context.Actors.Add(entity));
			}
			filmList.ForEach(entity => context.Films.Add(entity));
			context.SaveChanges();
		}
    }
}