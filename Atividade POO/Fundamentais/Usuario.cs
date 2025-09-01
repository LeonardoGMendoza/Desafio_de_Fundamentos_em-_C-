using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentais
{
    public class Usuario : IAutenticavel
    {
        public string Nome { get; set; }
        private string Senha { get; set; } = "123456";

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }

    }
}
