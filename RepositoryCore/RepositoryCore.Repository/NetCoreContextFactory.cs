using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using RepositoryCore.Repository.Context;

namespace RepositoryCore.Repository
{
    class NetCoreContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public NetCoreContextFactory()
        {
        }


        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
            builder.UseSqlite("Data Source=blog.db");
            //builder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=pinchdb;Trusted_Connection=True;MultipleActiveResultSets=true");
            return new ApplicationDbContext(builder.Options);
        }
    }

}
