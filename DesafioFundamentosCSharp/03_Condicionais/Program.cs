Console.Write("Digite uma nota de 0 a 10: ");
double nota = double.Parse(Console.ReadLine());

if (nota >= 7)
{
    Console.WriteLine("Aprovado");
}
else if (nota >= 5)
{
    Console.WriteLine("Recuperação");
}
else
{
    Console.WriteLine("Reprovado");
}
