Console.Write("Informe o valor do produto: R$ ");
double valor = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe o percentual de desconto (%): ");
double percentual = Convert.ToDouble(Console.ReadLine());

double desconto = valor * (percentual / 100);
double valorFinal = valor - desconto;

Console.WriteLine($"Valor com desconto: R$ {valorFinal:F2}");