using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teste1.Domain.Entidades;

namespace Teste1.Infra.Mapping
{
    public class CidadeMapping : IEntityTypeConfiguration<Cidade>
    {
        public void Configure(EntityTypeBuilder<Cidade> builder)
        {
            builder.HasKey(x => x.COD_CIDADE);
            builder.Property(x => x.NOME_CIDADE).IsRequired();

            builder.HasOne(x => x.ESTADO).WithMany(x => x.CIDADES).HasForeignKey(x => x.COD_ESTADO);

            builder.HasData(new {  COD_CIDADE = 1, NOME_CIDADE="Camp Grande", COD_ESTADO = 1 },
                new { COD_CIDADE = 2, NOME_CIDADE = "Corumbá", COD_ESTADO = 1 }, 
                new { COD_CIDADE = 3, NOME_CIDADE = "Dourados", COD_ESTADO = 1 });


            builder.ToTable(nameof(Cidade));
        }
    }
}
