using System.Collections.Generic;

namespace Teste1.Domain.Entidades
{
    public class Estado
    {
        public int COD_ESTADO { get; private set; }
        public string ESTADO { get; private set; }
        public string UF { get; private set; }

        public List<Cidade> CIDADES { get; set; }

        protected Estado() { }
    }
}
