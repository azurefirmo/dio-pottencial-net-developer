using pottencial-api.Domain.Entities;

namespace pottencial-api.Domain.Interfaces
{
    public interface IVendaRepository
    {
        Task<Venda> CreateAsync(Venda venda);
        Task<Venda> UpdateAsync(Venda venda);
        Task<Venda> GetById(int id);
    }
}
