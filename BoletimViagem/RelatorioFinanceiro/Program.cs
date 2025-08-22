Console.Write("Informe seu salário atual: R$ ");
double salario = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe o valor da despesa mensal: R$ ");
double despesa = Convert.ToDouble(Console.ReadLine());

double saldo = salario - despesa;

Console.WriteLine($"Saldo disponível após a despesa: R$ {saldo:F2}");