//  Console.Write("Informe a velocidade do carro (km/h): ");
int velocidade = Convert.ToInt32(Console.ReadLine());

if (velocidade > 80)
{
    Console.WriteLine("Você foi multado por excesso de velocidade!");
}
else
{
    Console.WriteLine("Velocidade dentro do limite permitido.");
}
