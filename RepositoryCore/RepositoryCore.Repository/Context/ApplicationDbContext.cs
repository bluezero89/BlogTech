using Microsoft.EntityFrameworkCore;
using RepositoryCore.Repository.Models;

namespace RepositoryCore.Repository.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Asset> Assets { get; set; }
        //public DbSet<CustomField> CustomFields { get; set; }
        //public DbSet<Profiles> Profiles { get; set; }
        public DbSet<PostCategory> PostCategories { get; set; }
        public DbSet<Tag> Tags { get; set; }
        
    }
}
