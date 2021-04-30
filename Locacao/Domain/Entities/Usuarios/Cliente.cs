using System;

namespace Locacao.Domain.Entities.Usuarios
{
    public class Cliente : Usuario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime Data_nasc { get; set; }
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }        
    }
}