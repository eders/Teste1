using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Teste1.Domain.Entidades;
using Teste1.Infra.Mapping;

namespace Teste1.Infra.Context
{
    public class TesteContext : DbContext
    {
        public TesteContext(DbContextOptions<TesteContext> options) : base(options) { }

        public DbSet<Estado> Estados { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Estado>(new EstadoMapping().Configure);
            modelBuilder.Entity<Cidade>(new CidadeMapping().Configure);
            modelBuilder.Entity<Endereco>(new EnderecoMapping().Configure);
            modelBuilder.Entity<Pessoa>(new PessoaMapping().Configure);
        }
    }
}
