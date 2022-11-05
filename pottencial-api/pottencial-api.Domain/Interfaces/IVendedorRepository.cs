using pottencial-api.Domain.Entities;

namespace pottencial-api.Domain.Interfaces
{
    public interface IVendedorRepository
    {
        Task<Vendedor> CreateAsync(Vendedor vendedor);
        Task<Vendedor> GetByIdAsync(int id);
        Task<Vendedor> UpdateAsync(Vendedor vendedor);
        Task<Vendedor> RemoveAsync(Vendedor vendedor);
    }
}
