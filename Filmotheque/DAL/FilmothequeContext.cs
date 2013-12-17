using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    class FilmothequeContext : DbContext , IDisposable
    {
        public DbSet<EntityActor> Actors { get; set; }
        public DbSet<EntityFilm> Films { get; set; }
        public DbSet<EntityGender> Genders { get; set; }
        public DbSet<EntityImage> Images { get; set; }

        public FilmothequeContext()
            : base("FilmothequeBDD")
        {

        }
    }
}
