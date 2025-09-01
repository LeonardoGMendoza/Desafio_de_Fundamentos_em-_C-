using System;
using System.Collections.Generic;
using System.Linq;

namespace ExerciciosArraysEFuncoes
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuPrincipal();
        }

        static void MenuPrincipal()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== MENU PRINCIPAL ===");
                Console.WriteLine("1. Exercícios com Arrays");
                Console.WriteLine("2. Exercícios com Funções");
                Console.WriteLine("0. Sair");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        MenuArrays();
                        break;
                    case "2":
                        MenuFuncoes();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                Console.WriteLine("Pressione ENTER para continuar...");
                Console.ReadLine();
            }
        }

        static void MenuArrays()
        {
            Console.Clear();
            Console.WriteLine("=== Exercícios com Arrays ===");
            Console.WriteLine("1. Soma dos Elementos");
            Console.WriteLine("2. Maior e Menor Valor");
            Console.WriteLine("3. Média dos Valores");
            Console.WriteLine("4. Contagem de Pares");
            Console.WriteLine("5. Inversão dos Elementos");
            Console.WriteLine("6. Frequência de um Número");
            Console.WriteLine("7. Remover Duplicatas");
            Console.WriteLine("8. Ordenação Crescente");
            Console.WriteLine("9. Interseção de Arrays");
            Console.WriteLine("0. Voltar");

            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1": SomaDosElementos(); break;
                case "2": MaiorEMenor(); break;
                case "3": MediaValores(); break;
                case "4": ContarPares(); break;
                case "5": InverterElementos(); break;
                case "6": FrequenciaNumero(); break;
                case "7": RemoverDuplicatas(); break;
                case "8": OrdenarCrescente(); break;
                case "9": IntersecaoArrays(); break;
                case "0": return;
                default: Console.WriteLine("Opção inválida!"); break;
            }
        }

        static void SomaDosElementos()
        {
            int[] numeros = new int[5];
            int soma = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                numeros[i] = int.Parse(Console.ReadLine());
                soma += numeros[i];
            }
            Console.WriteLine("Soma total: " + soma);
        }

        static void MaiorEMenor()
        {
            int[] numeros = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Maior: " + numeros.Max());
            Console.WriteLine("Menor: " + numeros.Min());
        }

        static void MediaValores()
        {
            int[] numeros = new int[6];
            for (int i = 0; i < 6; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            double media = numeros.Average();
            Console.WriteLine("Média: " + media);
        }

        static void ContarPares()
        {
            int[] numeros = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            int quantidadePares = numeros.Count(n => n % 2 == 0);
            Console.WriteLine("Quantidade de números pares: " + quantidadePares);
        }

        static void InverterElementos()
        {
            int[] numeros = new int[8];
            for (int i = 0; i < 8; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ordem inversa:");
            for (int i = numeros.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(numeros[i]);
            }
        }

        static void FrequenciaNumero()
        {
            int[] numeros = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Digite o número para buscar frequência: ");
            int buscado = int.Parse(Console.ReadLine());
            int frequencia = numeros.Count(n => n == buscado);
            Console.WriteLine($"O número {buscado} aparece {frequencia} vezes.");
        }

        static void RemoverDuplicatas()
        {
            int[] numeros = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            int[] semDuplicatas = numeros.Distinct().ToArray();
            Console.WriteLine("Números sem duplicatas:");
            foreach (var n in semDuplicatas)
            {
                Console.WriteLine(n);
            }
        }

        static void OrdenarCrescente()
        {
            int[] numeros = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(numeros);
            Console.WriteLine("Números em ordem crescente:");
            foreach (var n in numeros)
            {
                Console.WriteLine(n);
            }
        }

        static void IntersecaoArrays()
        {
            int[] array1 = new int[5];
            int[] array2 = new int[5];

            Console.WriteLine("Digite os 5 números do primeiro array:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Posição {i + 1}: ");
                array1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite os 5 números do segundo array:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Posição {i + 1}: ");
                array2[i] = int.Parse(Console.ReadLine());
            }

            var intersecao = array1.Intersect(array2).ToArray();
            Console.WriteLine("Números que aparecem em ambos os arrays:");
            foreach (var n in intersecao)
            {
                Console.WriteLine(n);
            }
        }


    }


}

