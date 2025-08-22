Console.Write("Informe o valor em reais: R$ ");
double reais = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe a cotação atual do dólar: ");
double cotacao = Convert.ToDouble(Console.ReadLine());

double convertido = reais / cotacao;

Console.WriteLine($"Valor em dólares: US$ {convertido:F2}");
