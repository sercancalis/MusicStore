using MusicStore.DAL.Concrete.Mapping;
using MusicStore.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.DAL.Concrete
{
    public class MusicStoreDbContext:DbContext
    {
        public MusicStoreDbContext():base("server=DESKTOP-4I3I6U1 ; database=MusicStoreDB; integrated security=true")
        {
            Database.SetInitializer<MusicStoreDbContext>(new MyStrategy());
        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Genre>  Genres { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AlbumMapping());
            modelBuilder.Configurations.Add(new ArtistMapping());
            modelBuilder.Configurations.Add(new GenreMapping());
            modelBuilder.Configurations.Add(new OrderDetailMapping());
            modelBuilder.Configurations.Add(new OrderMapping());
            modelBuilder.Configurations.Add(new UserMapping());
        }
    }
}
