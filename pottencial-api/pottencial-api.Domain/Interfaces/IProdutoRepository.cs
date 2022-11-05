using pottencial-api.Domain.Entities;

namespace pottencial-api.Domain.Interfaces
{
    public interface IProdutoRepository
    {
        Task<Produto> CreateAsync(Produto produto);
        Task<Produto> GetByIdAsync(int id);
        Task<Produto> UpdateAsync(Produto produto);
        Task<Produto> RemoveAsync(Produto produto);
        Task<IEnumerable<Produto>> GetProdutos();
    }
}
