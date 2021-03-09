using NewBanco.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBanco.Sistemas
{
    public class Autenticavel : Funcionario
    {
        public string Senha { get; set; }
        public string Autenticar (string senha)
        {
        return Senha == senha;
        }
    }
}
