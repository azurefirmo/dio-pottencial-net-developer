using pottencial-api.Domain.Entities;
using pottencial-api.Domain.Interfaces;
using pottencial-api.Infra.Data.Context;

namespace pottencial-api.Infra.Data.Repositories
{
    public class VendedorRepository : IVendedorRepository
    {
        private readonly ApplicationDbContext _context;
        public VendedorRepository(ApplicationDbContext context)
        {
            _context = context; 
        }

        public async Task<Vendedor> CreateAsync(Vendedor vendedor)
        {
            _context.Vendedores.Add(vendedor);
            await _context.SaveChangesAsync();
            return vendedor;
        }

        public async Task<Vendedor> GetByIdAsync(int id)
        {
            return await _context.Vendedores.FindAsync(id);
        }

        public async Task<Vendedor> RemoveAsync(Vendedor vendedor)
        {
            _context.Vendedores.Remove(vendedor);
            await _context.SaveChangesAsync();
            return vendedor;
        }

        public async Task<Vendedor> UpdateAsync(Vendedor vendedor)
        {
            _context.Vendedores.Update(vendedor);
            await _context.SaveChangesAsync();
            return vendedor;
        }
    }
}
