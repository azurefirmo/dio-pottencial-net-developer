using pottencial-api.Domain.Entities;

namespace pottencial-api.Domain.Interfaces
{
    public interface IVendaDetalheRepository
    {
        Task<VendaDetalhe> Create(VendaDetalhe vendaDetalhe);
    }
}
