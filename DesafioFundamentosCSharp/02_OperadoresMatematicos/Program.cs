Console.Write("Digite o primeiro número: ");
double num1 = double.Parse(Console.ReadLine());

Console.Write("Digite o segundo número: ");
double num2 = double.Parse(Console.ReadLine());

double soma = num1 + num2;
double produto = num1 * num2;

Console.WriteLine($"Soma: {soma}");
Console.WriteLine($"Produto: {produto}");
