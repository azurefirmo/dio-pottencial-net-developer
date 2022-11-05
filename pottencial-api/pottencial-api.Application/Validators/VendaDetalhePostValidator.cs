using FluentValidation;
using pottencial-api.Application.DTOs;

namespace pottencial-api.Application.Validators
{
    public class VendaDetalhePostValidator : AbstractValidator<VendaDetalhePostDTO>
    {
        public VendaDetalhePostValidator()
        {
            RuleFor(vde => vde.Quantidade).GreaterThan(0);
            RuleFor(vde => vde.PrecoUnitario).GreaterThan(0);
            RuleFor(vde => vde.ProdutoId).GreaterThan(0);
        }
    }
}
