using System.Collections.Generic;
using System.Threading.Tasks;

namespace IoCDemo.Models
{
    public interface ISuppliersRepository
    {
        Task DeleteById(int id);
        Task<Supplier> GetById(int id);
        Task Update(Supplier supplier);
        void Create(Supplier supplier);
        Task<IReadOnlyCollection<Supplier>> GetAll();
    }
}