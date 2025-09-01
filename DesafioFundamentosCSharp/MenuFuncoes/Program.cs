static void MenuFuncoes()
{
    Console.Clear();
    Console.WriteLine("=== Exercícios com Funções ===");
    Console.WriteLine("1. Soma de dois números");
    Console.WriteLine("2. Média de um array");
    Console.WriteLine("3. Par ou Ímpar");
    Console.WriteLine("4. Fatorial");
    Console.WriteLine("5. Inverter String");
    Console.WriteLine("6. Contar Vogais");
    Console.WriteLine("7. Verificar Número Primo");
    Console.WriteLine("8. Buscar em Array");
    Console.WriteLine("9. Fibonacci Recursivo");
    Console.WriteLine("0. Voltar");
    Console.Write("Escolha uma opção: ");
    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1": Console.WriteLine(Somar(2, 3)); break;
        case "2": Console.WriteLine(Media(new int[] { 1, 2, 3 })); break;
        case "3": Console.WriteLine(ParOuImpar(5)); break;
        // e assim por diante...
        case "0": return;
    }
}

