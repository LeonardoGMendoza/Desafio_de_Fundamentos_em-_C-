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

