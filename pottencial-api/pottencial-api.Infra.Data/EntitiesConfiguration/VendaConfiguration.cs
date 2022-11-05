using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using pottencial-api.Domain.Entities;

namespace pottencial-api.Infra.Data.EntitiesConfiguration
{
    public class VendaConfiguration : IEntityTypeConfiguration<Venda>
    {
        public void Configure(EntityTypeBuilder<Venda> builder)
        {
            builder.HasKey(ven => ven.Id);

            builder.HasOne(venda => venda.Vendedor)
                .WithMany()
                .HasForeignKey(ven => ven.VendedorId);
        }
    }
}
