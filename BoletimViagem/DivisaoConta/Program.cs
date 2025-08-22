Console.Write("Valor total da refeição: R$ ");
double valorTotal = Convert.ToDouble(Console.ReadLine());

Console.Write("Quantidade de pessoas: ");
int pessoas = Convert.ToInt32(Console.ReadLine());

double valorPorPessoa = valorTotal / pessoas;

Console.WriteLine($"Cada pessoa deve pagar: R$ {valorPorPessoa:F2}");
