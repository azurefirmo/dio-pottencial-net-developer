using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using pottencial-api.Application.Interfaces;
using pottencial-api.Application.Mappings;
using pottencial-api.Application.Services;
using pottencial-api.Domain.Interfaces;
using pottencial-api.Infra.Data.Context;
using pottencial-api.Infra.Data.Repositories;
using FluentValidation;
using pottencial-api.Application.DTOs;
using pottencial-api.Application.Validators;

namespace pottencial-api.Infra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName))
            );
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IProdutoService, ProdutoService>();

            services.AddScoped<IVendedorRepository, VendedorRepository>();
            services.AddScoped<IVendedorService, VendedorService>();

            services.AddScoped<IVendaRepository, VendaRepository>();
            services.AddScoped<IVendaService, VendaService>();

            services.AddAutoMapper(typeof(DomainToDTOMapping));

            services.AddScoped<IValidator<VendaPostDTO>, VendaPostDTOValidator>();
            services.AddScoped<IValidator<ProdutoDTO>, ProdutoDTOValidator>();

            return services;
        }
    }
}
