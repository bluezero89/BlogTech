using RepositoryCore.Interface.Interface;
using RepositoryCore.Repository.Context;
using System.Threading.Tasks;

namespace RepositoryCore.Repository.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            this._context = context;
        }
        public async Task Complete()
        {
            await _context.SaveChangesAsync();
        }
    }
}
