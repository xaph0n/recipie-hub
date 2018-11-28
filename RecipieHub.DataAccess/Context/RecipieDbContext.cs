using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecipieHub.DataAccess.Models;

namespace RecipieHub.DataAccess.Context
{
    public class RecipieDbContext : DbContext
    {
        public RecipieDbContext(DbContextOptions<RecipieDbContext> options) : base(options) { }

        public DbSet<RecipieModel> Recipies { get; set; } 
        
        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new RecipieMap(modelBuilder.Entity<RecipieModel>());
        }
    }

    public class RecipieMap
    {
        public RecipieMap(EntityTypeBuilder<RecipieModel> entityBuilder)
        {
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.ToTable("recipie");

            entityBuilder.Property(x => x.Id).HasColumnName("id");
            entityBuilder.Property(x => x.Title).HasColumnName("title");
            entityBuilder.Property(x => x.Description).HasColumnName("description");
        }
    }
}