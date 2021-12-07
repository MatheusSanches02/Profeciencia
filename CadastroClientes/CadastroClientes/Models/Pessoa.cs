using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroClientes.Models
{
    public class Pessoa
    {
        public long Cpf { get; set; }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public int Telefone { get; set; }

        public string Endereco { get; set; }
    }
}
