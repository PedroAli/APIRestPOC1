using AR.Domain;
using System.Linq;
using System.Threading.Tasks;

namespace AR.Data.Interfaces
{
    public interface ICategoriaRepository
    {
        IQueryable<Categoria> GetAll();

        Task Add(Categoria entity);
    }
}
