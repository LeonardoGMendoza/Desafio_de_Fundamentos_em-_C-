using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentais
{
    // Classe Pessoa com todos os requisitos
    public class Pessoa
    {
        // Classe Pessoa com todos os requisitos

        private string _nome;
        private int _idade;

        // Construtor padrão
        public Pessoa()
        {
        }

        // Construtor com parâmetros
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        // Propriedade Nome
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        // Propriedade Idade com validação
        public int Idade
        {
            get { return _idade; }
            set
            {
                if (value > 0)
                    _idade = value;
                else
                    Console.WriteLine("Idade deve ser maior que zero!");
            }
        }

        // Método para exibir dados
        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }

        // Sobrecarga do método Apresentar
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}");
        }

        public void Apresentar(string sobrenome)
        {
            Console.WriteLine($"Olá, meu nome completo é {Nome} {sobrenome}");
        }

    }
}