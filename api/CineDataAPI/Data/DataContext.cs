using CineDataAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CineDataAPI.Data 
{
    public class DataContext : DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options)
            :base(options)
        {            
        }

        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<MovieGenre> MovieGenres { get; set; }

        
    }
}