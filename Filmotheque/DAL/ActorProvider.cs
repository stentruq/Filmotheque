using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class ActorProvider
    {
        public ActorProvider()
        {

        }

        public List<EntityActor> GetAllActors()
        {
            using (FilmothequeContext context = new FilmothequeContext())
            {
                return context.Actors.ToList();
            }
        }

        public void AddActors(List<EntityActor> actorsToAdd)
        {
            using (FilmothequeContext context = new FilmothequeContext())
            {

                foreach (var actorToAdd in actorsToAdd)
                {
                    if (context.Actors.Find(actorToAdd.ID) == null)
                    {
                        context.Actors.Add(actorToAdd);
                    }
                }
            }
        }


    }
}
