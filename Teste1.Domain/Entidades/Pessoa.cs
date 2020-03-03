using System;

namespace Teste1.Domain.Entidades
{
    public class Pessoa
    {
        public int COD_PESSOA { get; set; }
        public int COD_ENDERECO { get; set; }
        public string NOME { get; set; }
        public string CPF { get; set; }
        public DateTime NASCIMENTO { get; set; }
        public string TELEFONE { get; set; }
        public string EMAIL { get; set; }

        public Endereco ENDERECO { get; set; }

        protected Pessoa() { }


        public Pessoa(string nome, string cpf, string telefone, string email, int codEndereco)
        {
            NOME = nome;
            CPF = cpf;
            TELEFONE = telefone;
            EMAIL = email;
            COD_ENDERECO = codEndereco;
        }
    }
}
