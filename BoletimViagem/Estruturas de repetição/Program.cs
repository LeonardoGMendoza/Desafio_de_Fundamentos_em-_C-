
        int opcao;

        do
        {
            Console.Clear();
            Console.WriteLine("=== MENU DE ATIVIDADES ===");
            Console.WriteLine("1 - Boletim de Viagem");
            Console.WriteLine("2 - Diário do Clima");
            Console.WriteLine("3 - Relatório Financeiro");
            Console.WriteLine("4 - Conversor de Moedas");
            Console.WriteLine("5 - Cálculo de Desconto");
            Console.WriteLine("6 - Divisão de Conta");
            Console.WriteLine("7 - Velocidade da Via");
            Console.WriteLine("8 - Categoria de Votação");
            Console.WriteLine("9 - Classificação de Números");
            Console.WriteLine("10 - Validação de Senha");
            Console.WriteLine("11 - Contagem de Pares");
            Console.WriteLine("12 - Quadrados de Números");
            Console.WriteLine("13 - Sequência de Fibonacci");
            Console.WriteLine("14 - Caça ao Número");
            Console.WriteLine("15 - Média de Vários Números");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
            opcao = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            switch (opcao)
            {
                case 1: BoletimViagem(); break;
                case 2: DiarioClima(); break;
                case 3: RelatorioFinanceiro(); break;
                case 4: ConversorMoeda(); break;
                case 5: CalculoDesconto(); break;
                case 6: DivisaoConta(); break;
                case 7: VelocidadeVia(); break;
                case 8: CategoriaVotacao(); break;
                case 9: ClassificacaoNumero(); break;
                case 10: ValidacaoSenha(); break;
                case 11: ContagemPares(); break;
                case 12: QuadradosNumeros(); break;
                case 13: SequenciaFibonacci(); break;
                case 14: CacaNumero(); break;
                case 15: MediaNumeros(); break;
                case 0: Console.WriteLine("Encerrando..."); break;
                default: Console.WriteLine("Opção inválida."); break;
            }

            if (opcao != 0)
            {
                Console.WriteLine("\nPressione ENTER para continuar...");
                Console.ReadLine();
            }

        } while (opcao != 0);


    static void BoletimViagem()
    {
    //string destino = "Rio de Janeiro";
    //double distanciaKm = 450.5;
    //double valorPassagem = 120.75;

    //Console.WriteLine("=== Boletim de Viagem ===");
    //Console.WriteLine($"Destino: {destino}");
    //Console.WriteLine($"Distância: {distanciaKm} km");
    //Console.WriteLine($"Valor da Passagem: R$ {valorPassagem:F2}");

  
    Console.WriteLine("=== Boletim de Viagem ===");
    string destino = Console.ReadLine();
    double distanciaKm = Convert.ToDouble(Console.ReadLine());
    double valorPassagem = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine($"Destino: {destino}");
    Console.WriteLine($"Distância: {distanciaKm} km");
    Console.WriteLine($"Valor da Passagem: R$ {valorPassagem:F2}");
}

    static void DiarioClima()
    {
        Console.Write("Temperatura mínima do dia: ");
        double min = Convert.ToDouble(Console.ReadLine());

        Console.Write("Temperatura máxima do dia: ");
        double max = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Temperaturas registradas: mínima {min}°C, máxima {max}°C");
    }

    static void RelatorioFinanceiro()
    {
        Console.Write("Informe seu salário atual: R$ ");
        double salario = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe o valor da despesa mensal: R$ ");
        double despesa = Convert.ToDouble(Console.ReadLine());

        double saldo = salario - despesa;
        Console.WriteLine($"Saldo disponível após a despesa: R$ {saldo:F2}");
    }

    static void ConversorMoeda()
    {
        Console.Write("Informe o valor em reais: R$ ");
        double reais = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe a cotação atual do dólar: ");
        double cotacao = Convert.ToDouble(Console.ReadLine());

        double convertido = reais / cotacao;
        Console.WriteLine($"Valor em dólares: US$ {convertido:F2}");
    }

    static void CalculoDesconto()
    {
        Console.Write("Informe o valor do produto: R$ ");
        double valor = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe o percentual de desconto (%): ");
        double percentual = Convert.ToDouble(Console.ReadLine());

        double desconto = valor * (percentual / 100);
        double valorFinal = valor - desconto;

        Console.WriteLine($"Valor com desconto: R$ {valorFinal:F2}");
    }

    static void DivisaoConta()
    {
        Console.Write("Valor total da refeição: R$ ");
        double valorTotal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Quantidade de pessoas: ");
        int pessoas = Convert.ToInt32(Console.ReadLine());

        double valorPorPessoa = valorTotal / pessoas;
        Console.WriteLine($"Cada pessoa deve pagar: R$ {valorPorPessoa:F2}");
    }

    static void VelocidadeVia()
    {
        Console.Write("Informe a velocidade do carro (km/h): ");
        int velocidade = Convert.ToInt32(Console.ReadLine());

        if (velocidade > 80)
            Console.WriteLine("Você foi multado por excesso de velocidade!");
        else
            Console.WriteLine("Velocidade dentro do limite permitido.");
    }

    static void CategoriaVotacao()
    {
        Console.Write("Informe sua idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        if (idade < 16)
            Console.WriteLine("Voto não permitido.");
        else if ((idade >= 16 && idade < 18) || idade > 70)
            Console.WriteLine("Voto facultativo.");
        else
            Console.WriteLine("Voto obrigatório.");
    }

    static void ClassificacaoNumero()
    {
        Console.Write("Informe um número: ");
        double numero = Convert.ToDouble(Console.ReadLine());

        if (numero > 0)
            Console.WriteLine("O número é positivo.");
        else if (numero < 0)
            Console.WriteLine("O número é negativo.");
        else
            Console.WriteLine("O número é zero.");
    }

    static void ValidacaoSenha()
    {
        Console.Write("Digite a senha: ");
        string senha = Console.ReadLine();

        if (senha == "12345")
            Console.WriteLine("Acesso Permitido");
        else
            Console.WriteLine("Acesso Negado");
    }

    static void ContagemPares()
    {
        Console.Write("Digite um número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Números pares de 0 até " + numero + ":");
        for (int i = 0; i <= numero; i++)
        {
            if (i % 2 == 0)
                Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    static void QuadradosNumeros()
    {
        Console.Write("Digite um número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Quadrados dos números de 1 até {numero}:");
        for (int i = 1; i <= numero; i++)
            Console.WriteLine($"{i}² = {i * i}");
    }

    static void SequenciaFibonacci()
    {
    //Console.Write("Quantos termos da sequência de Fibonacci deseja? ");
    //int termos = Convert.ToInt32(Console.ReadLine());

    //int a = 0, b = 1;
    //Console.Write("Sequência de Fibonacci: ");
    //for (int i = 0; i < termos; i++)
    //{
    //    Console.Write(a + " ");
    //    int temp = a;
    //    a = b;
    //    b = temp + b;
    //}
    //Console.WriteLine();

    Console.WriteLine("Quantos termos voce deseja imprimir:");

    int quantudadeTermos = Convert.ToInt32(Console.ReadLine());
    int numeroAtual = 0;
    int numeroAnterior = 1;
    int intermediario = 0;

    for (int i = 1; i >= quantudadeTermos; i++) {    
`    Console.Write($"{numeroAtual}");
        intermediario = numeroAtual;
        numeroAtual = numeroAtual + numeroAnterior;
        numeroAnterior = intermediario;

    }

    static void CacaNumero()
    {
        int numero, maior = int.MinValue;

        do
        {
            Console.Write("Digite um número (0 para sair): ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero > maior && numero != 0)
                maior = numero;

        } while (numero != 0);

        Console.WriteLine("Maior número digitado: " + maior);
    }

    static void MediaNumeros()
    {
        int numero, soma = 0, quantidade = 0;

        Console.WriteLine("Digite números positivos (número negativo para parar):");
        do
        {
            numero = int.Parse(Console.ReadLine());

            if (numero >= 0)
            {
                soma += numero;
                quantidade++;
            }

        } while (numero >= 0);

        if (quantidade > 0)
        {
            double media = (double)soma / quantidade;
            Console.WriteLine("Média dos números digitados: " + media.ToString("F2"));
        }
        else
        {
            Console.WriteLine("Nenhum número positivo foi digitado.");
        }
    }
