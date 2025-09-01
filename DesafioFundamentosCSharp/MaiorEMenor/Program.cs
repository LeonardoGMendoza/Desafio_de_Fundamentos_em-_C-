int[] numeros = new int[6];
for (int i = 0; i < 6; i++)
{
    Console.Write($"Digite o {i + 1}º número: ");
    numeros[i] = int.Parse(Console.ReadLine());
}
double media = numeros.Average();
Console.WriteLine("Média: " + media);