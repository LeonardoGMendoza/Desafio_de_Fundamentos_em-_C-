
string[] nomes = new string[3];
int[] idades = new int[3];

for (int i = 0; i < nomes.Length; i++)
{
    Console.Write($"Digite o nome da pessoa {i + 1}: ");
    nomes[i] = Console.ReadLine();

    Console.Write($"Digite a idade de {nomes[i]}: ");
    idades[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("\n--- Pessoas cadastradas ---");
for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($"{nomes[i]} - {idades[i]} anos - {(idades[i] >= 18 ? "Maior de idade" : "Menor de idade")}");
}
