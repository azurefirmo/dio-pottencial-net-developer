using pottencial-api.Application.DTOs;

namespace pottencial-api.Application.Interfaces
{
    public interface IProdutoService
    {
        Task<ProdutoDTO> CreateAsync(ProdutoDTO produto);
        Task<ProdutoDTO> GetByIdAsync(int id);
        Task UpdateAsync(ProdutoDTO produto);
        Task RemoveAsync(int id);
        Task<IEnumerable<ProdutoDTO>> GetProdutos();
    }
}
