using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teste1.Domain.Entidades;

namespace Teste1.Infra.Mapping
{
    public class EstadoMapping : IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> builder)
        {
            builder.HasKey(x => x.COD_ESTADO);
            builder.Property(x => x.ESTADO).IsRequired();
            builder.Property(x => x.UF).IsRequired();

            builder.HasData(new { COD_ESTADO = 1, ESTADO = "Mato Grosso do Sul", UF = "MS" });

            builder.ToTable(nameof(Estado));
        }
    }
}
