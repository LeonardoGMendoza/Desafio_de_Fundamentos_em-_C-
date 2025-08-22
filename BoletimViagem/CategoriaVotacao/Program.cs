Console.Write("Informe sua idade: ");
int idade = Convert.ToInt32(Console.ReadLine());

if (idade < 16)
{
    Console.WriteLine("Voto não permitido.");
}
else if ((idade >= 16 && idade < 18) || idade > 70)
{
    Console.WriteLine("Voto facultativo.");
}
else
{
    Console.WriteLine("Voto obrigatório.");
}