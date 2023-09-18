// Printando no console sobre o assunto abordado
Console.WriteLine("Construtores");
Console.WriteLine();

// Criando um método chamado "MostrarDados" que mostra os dados da classe do tipo aluno
void MostrarDados(Aluno aluno)
{
    Console.WriteLine(aluno.nome == null ? "Null" : aluno.nome);
    Console.WriteLine(aluno.idade == 0 ? "Zero" : aluno.idade);
    Console.WriteLine(aluno.sexo == null ? "Null" : aluno.sexo);
    Console.WriteLine(aluno.aprovado == null ? "Null" : aluno.aprovado);
}
// Inicializando vários objetos utilizando construtores diferentes
Aluno aluno = new();
MostrarDados(aluno);

Console.WriteLine();

Aluno aluno2 = new("Clayton", 21, "Masculino", "S");
MostrarDados(aluno2);

Console.WriteLine();

Aluno aluno3 = new("Clayton");
MostrarDados(aluno3);

Console.WriteLine();

Aluno aluno4 = new(21,"Feminino", "S");
MostrarDados(aluno4);

// Criando uma classe "Aluno" e utilizando diversos estilos de construtores para diversos tipos de inicialização
public class Aluno
{
    public string? nome;
    public int idade;
    public string? sexo;
    public string? aprovado;
    // Construtor Padrão sem parâmetro
    public Aluno(){}
    // Construtor com apenas um parâmetro 
    public Aluno(string Nome) => nome = Nome;
    // Construtor com 3 parâmetros 
    public Aluno(int Idade, string Sexo, string Aprovado)
    {
        idade = Idade;
        sexo = Sexo;
        aprovado = Aprovado;
    }
    // Construtor que utiliza outro construtor com 1 parâmetro utilizando a palavra chave this
    public Aluno(string Nome, int Idade, string Sexo, string Aprovado) : this(Nome) 
    {
        idade = Idade;
        sexo = Sexo;
        aprovado = Aprovado;
    }
}
