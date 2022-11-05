using pottencial-api.Domain.Entities;
using pottencial-api.Domain.Interfaces;
using pottencial-api.Infra.Data.Context;

namespace pottencial-api.Infra.Data.Repositories
{
    public class VendaDetalheRepository : IVendaDetalheRepository
    {
        private readonly ApplicationDbContext _context;
        public VendaDetalheRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<VendaDetalhe> Create(VendaDetalhe vendaDetalhe)
        {
            _context.VendaDetalhe.Add(vendaDetalhe);
            await _context.SaveChangesAsync();
            return vendaDetalhe;
        }
    }
}
