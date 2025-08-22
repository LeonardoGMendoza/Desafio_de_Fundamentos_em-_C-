int numero, soma = 0, quantidade = 0;

Console.WriteLine("Digite números positivos (número negativo para parar):");

do
{
    numero = int.Parse(Console.ReadLine());

    if (numero >= 0)
    {
        soma += numero;
        quantidade++;
    }

} while (numero >= 0);

if (quantidade > 0)
{
    double media = (double)soma / quantidade;
    Console.WriteLine("Média dos números digitados: " + media.ToString("F2"));
}
else
{
    Console.WriteLine("Nenhum número positivo foi digitado.");
}
