int[] numeros = new int[5];
int soma = 0;
for (int i = 0; i < 5; i++)
{
    Console.Write($"Digite o {i + 1}º número: ");
    numeros[i] = int.Parse(Console.ReadLine());
    soma += numeros[i];
}
Console.WriteLine("Soma total: " + soma);
