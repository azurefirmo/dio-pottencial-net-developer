using Microsoft.EntityFrameworkCore;
using pottencial-api.Domain.Entities;
using pottencial-api.Domain.Interfaces;
using pottencial-api.Infra.Data.Context;

namespace pottencial-api.Infra.Data.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ApplicationDbContext _context;
        public ProdutoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Produto> CreateAsync(Produto produto)
        {
            _context.Produtos.Add(produto);
            await _context.SaveChangesAsync();
            return produto;
        }

        public async Task<Produto> GetByIdAsync(int id)
        {
            return await _context.Produtos.FindAsync(id);
        }

        public async Task<IEnumerable<Produto>> GetProdutos()
        {
            return await _context.Produtos.Take(10).ToListAsync();
        }

        public async Task<Produto> RemoveAsync(Produto produto)
        {
            _context.Produtos.Remove(produto);
            await _context.SaveChangesAsync();
            return produto;
        }

        public async Task<Produto> UpdateAsync(Produto produto)
        {
            _context.Produtos.Update(produto);
            await _context.SaveChangesAsync();
            return produto;
        }
    }
}
