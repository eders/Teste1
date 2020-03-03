using System.Collections.Generic;

namespace Teste1.Domain.Entidades
{
    public class Endereco
    {
        public int COD_ENDERECO { get; set; }
        public string LOGRADOURO { get; set; }
        public string BAIRRO { get; set; }
        public string NUMERO { get; set; }
        public int COD_CIDADE { get; set; }

        public Cidade CIDADE { get; set; }

        public List<Pessoa> Pessoas { get; set; }
        protected Endereco() { }
    }
}
