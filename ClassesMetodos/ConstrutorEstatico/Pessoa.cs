// Código da classe Pessoa do projeto Construtor Estático
public class Pessoa
{
    public string Nome;
    public int Idade;
    public static int IdadeMinima;

    public Pessoa(string nome, int idade)
    {
        Console.WriteLine("Inicializando o construtor parametrizado...");
        Nome = nome;
        Idade = idade;
    }
    public Pessoa()
    {}

    static Pessoa()
    {
        Console.WriteLine("\nInicializando o construtor estático...");
        Console.WriteLine("Inicializando o campo IdadeMinima...");
        IdadeMinima = 18;
    }
}
