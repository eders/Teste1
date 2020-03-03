using System.Collections.Generic;

namespace Teste1.Domain.Entidades
{
    public class Cidade
    {
        public int COD_CIDADE { get; private set; }
        public int COD_ESTADO { get; private set; }
        public string NOME_CIDADE { get; private set; }

        public Estado ESTADO { get; private set; }
        public List<Endereco> Enderecos { get; private set; }

        protected Cidade() { }
    }
}
