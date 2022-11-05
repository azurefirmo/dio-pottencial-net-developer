using pottencial-api.Application.DTOs;

namespace pottencial-api.Application.Interfaces
{
    public interface IVendedorService
    {
        Task<VendedorDTO> CreateAsync(VendedorDTO vendedor);
        Task<VendedorDTO> GetByIdAsync(int id);
        Task UpdateAsync(VendedorDTO vendedor);
        Task RemoveAsync(int id);
    }
}
