using pottencial-api.Application.DTOs;

namespace pottencial-api.Application.Interfaces
{
    public interface IVendaService
    {
        Task<VendaDTO> CreateAsync(VendaPostDTO venda);
        Task<VendaDTO> GetById(int id);
        Task<bool> UpdateAsync(int id, VendaStatusDTO vendaStatus);
    }
}
