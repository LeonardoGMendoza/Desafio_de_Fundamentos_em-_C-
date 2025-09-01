using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentais
{
    // Classe Funcionario que herda de Pessoa
    public class Funcionario : Pessoa
    {
        public decimal Salario { get; set; }

        public Funcionario(string nome, int idade, decimal salario) : base(nome, idade)
        {
            Salario = salario;
        }

        public void ExibirDadosFuncionario()
        {
            ExibirDados();
            Console.WriteLine($"Salário: R$ {Salario}");
        }

    }
}
