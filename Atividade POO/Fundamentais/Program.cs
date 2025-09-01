// Programa principal
using Fundamentais;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== ATIVIDADE POO ===");

        // 1. Classe básica
        Console.WriteLine("\n1. Classe Pessoa:");
        Pessoa p1 = new Pessoa();
        p1.Nome = "João";
        p1.Idade = 25;
        p1.ExibirDados();

        // Testando validação de idade
        Console.WriteLine("\nTestando validação de idade:");
        p1.Idade = -5; // Deve exibir mensagem de erro

        // 2. Construtor com parâmetros
        Console.WriteLine("\n2. Construtor com parâmetros:");
        Pessoa p2 = new Pessoa("Maria", 30);
        p2.ExibirDados();

        // 3. Herança
        Console.WriteLine("\n3. Herança - Funcionário:");
        Funcionario f1 = new Funcionario("Carlos", 35, 3500.00m);
        f1.ExibirDadosFuncionario();

        // 4. Polimorfismo - Sobrecarga
        Console.WriteLine("\n4. Sobrecarga de métodos:");
        p1.Apresentar();
        p1.Apresentar("Silva");

        // 5. Polimorfismo - Sobrescrita
        Console.WriteLine("\n5. Sobrescrita de métodos:");
        Veiculo carro = new Carro();
        Veiculo bike = new Bicicleta();
        carro.Mover();
        bike.Mover();

        // 6. Interface
        Console.WriteLine("\n6. Interface IAutenticavel:");
        IAutenticavel usuario = new Usuario { Nome = "Ana" };
        IAutenticavel admin = new Administrador { Nome = "Admin" };
        Console.WriteLine($"Autenticação usuário: {usuario.Autenticar("123456")}");
        Console.WriteLine($"Autenticação admin: {admin.Autenticar("senhaerrada")}");

        // 7. Métodos estáticos
        Console.WriteLine("\n7. Métodos estáticos:");
        Console.WriteLine($"5 + 3 = {Calculadora.Somar(5, 3)}");
        Console.WriteLine($"4 × 6 = {Calculadora.Multiplicar(4, 6)}");
        Console.WriteLine($"2.5 + 3.7 = {Calculadora.Somar(2.5, 3.7)}");

        Console.ReadKey();
    }
}
