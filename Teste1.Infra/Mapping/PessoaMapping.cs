using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Teste1.Domain.Entidades;

namespace Teste1.Infra.Mapping
{
    public class PessoaMapping : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.HasKey(X=>X.COD_PESSOA);
            builder.Property(X => X.TELEFONE).IsRequired();

            builder.Property(X => X.NOME).IsRequired();
            builder.Property(X => X.NASCIMENTO).IsRequired();
            builder.Property(X => X.CPF).IsRequired();
            builder.Property(X => X.EMAIL).IsRequired();

            builder.HasOne(x => x.ENDERECO).WithMany(x => x.Pessoas).HasForeignKey(x=>x.COD_ENDERECO);

            builder.ToTable(nameof(Pessoa));
        }
    }
}
