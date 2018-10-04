using System.Threading.Tasks;

namespace RepositoryCore.Interface.Interface
{
    public interface IUnitOfWork
    {
        Task Complete();
    }
}
