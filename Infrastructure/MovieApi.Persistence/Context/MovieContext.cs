using Microsoft.EntityFrameworkCore;
using MovieApi.Domain.Entities;


namespace MovieApi.Persistence.Context
{
    public class MovieContext : DbContext
    {
        public DbSet<Cast> Cast { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Review> Review { get; set; }
        public DbSet<Tag> Tag { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=CSAHIN\\MSSQLSERVER2022; database=ApiMovieDb; integrated security=true; MultipleActiveResultSets=true; Trusted_Connection=True; TrustServerCertificate=True;");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}