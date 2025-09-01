using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentais
{
    public class Administrador : IAutenticavel

    {
        public string Nome { get; set; }
        private string Senha { get; set; } = "admin123";

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }

    }
}
