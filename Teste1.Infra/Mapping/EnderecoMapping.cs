using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Teste1.Domain.Entidades;

namespace Teste1.Infra.Mapping
{
    public class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(x => x.COD_ENDERECO);
            builder.Property(x => x.LOGRADOURO).IsRequired();
            builder.Property(x => x.NUMERO).IsRequired();

            builder.HasOne(x => x.CIDADE).WithMany(x => x.Enderecos).HasForeignKey(x => x.COD_CIDADE);

            builder.HasData(
                new { COD_ENDERECO = 1, COD_CIDADE = 1, LOGRADOURO = "Centro", BAIRRO = "CENTRO", NUMERO = "1" },
                new { COD_ENDERECO = 2, COD_CIDADE = 1, LOGRADOURO = "Bairro", BAIRRO = "BAIRRO", NUMERO = "2" },
                new { COD_ENDERECO = 3, COD_CIDADE = 2, LOGRADOURO = "Centro", BAIRRO = "CENTRO", NUMERO = "1" },
                new { COD_ENDERECO = 4, COD_CIDADE = 2, LOGRADOURO = "Bairro", BAIRRO = "BAIRRO", NUMERO = "2" },
                new { COD_ENDERECO = 5, COD_CIDADE = 3, LOGRADOURO = "Centro", BAIRRO = "CENTRO", NUMERO = "1" },
                new { COD_ENDERECO = 6, COD_CIDADE = 3, LOGRADOURO = "Bairro", BAIRRO = "BAIRRO", NUMERO = "2" });

            builder.ToTable(nameof(Endereco));
        }
    }
}
