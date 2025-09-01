string[] nomes = new string[3];

for (int i = 0; i < nomes.Length; i++)
{
    Console.Write($"Digite o nome {i + 1}: ");
    nomes[i] = Console.ReadLine();
}

Console.WriteLine("\nNomes digitados:");
foreach (string nome in nomes)
{
    Console.WriteLine(nome);
}