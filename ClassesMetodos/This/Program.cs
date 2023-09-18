// Printando no console sobre o assunto abordado
Console.WriteLine("Palavra Chave \"This\"");

// Inicializando os objetos do tipo "Teste" e utilizando os métodos e construtores da classe "Teste"
Teste t1 = new();
t1.numero1 = 1;
t1.numero2 = 2;
t1.Exibir();

Teste t2 = new();
t2.numero1 = 14;
t2.numero2 = 22;
t2.Exibir();

Teste t3 = new(255);

Console.ReadKey();

/* Criando uma classe "Cliente" que utiliza "this" para alocar valores na hora da inicialização e com isso permite utilizar
 o nome da váriavel igual ao nome do parâmetro */
public class Cliente
{
    public string? nome;
    public int idade;
    public Cliente(string? nome, int idade)
    {
        this.nome = nome;
        this.idade = idade;
    }
}
// Criando uma classe "Teste" que utiliza diversos métodos utilizando a palavra chave "this"
public class Teste
{
    public int numero1;
    public int numero2;
    // Método "PassarParametro" que receber um objeto do tipo "Teste" e imprime os seus valores
    private void PassarParametro(Teste t)
    {
        Console.WriteLine($"\nthis = {this}");
        Console.WriteLine($"Número 1 : {t.numero1}");
        Console.WriteLine($"Número 2 : {t.numero2}");
        
    }
    // Método que invoca "PassarParametro" e passa o parâmetro utilizando a palavrea chave "this"
    public void Exibir()
    {
        PassarParametro(this);
    }
    // Construtor Padrão
    public Teste(){}
    // Construtor que pede dois parâmetros inteiros e imprime tais valores
    private Teste(int numero1, int numero2) 
    {
        Console.WriteLine($"\nConstrutor com dois parâmetros {numero1} e {numero2}");
    }
    // Construtor que chama outro construtor por meio da palavra chave "this"
    public Teste(int numero) : this(777, 888)
    {
        Console.WriteLine($"Construtor com um parâmetro {numero}");
    }
}