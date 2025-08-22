int numero, maior = int.MinValue;

do
{
    Console.Write("Digite um número (0 para sair): ");
    numero = Convert.ToInt32(Console.ReadLine());

    if (numero > maior && numero != 0)
    {
        maior = numero;
    }

} while (numero != 0);

Console.WriteLine("Maior número digitado: " + maior);
