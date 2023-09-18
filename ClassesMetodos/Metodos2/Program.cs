// Criando um método do tipo aluno para realizar o cadastro de um aluno no sistema
static Aluno CadastrarAluno()
{
    Aluno aluno = new Aluno();

    Console.Write("\nQual o nome do aluno? ");
    aluno.nome = Convert.ToString(Console.ReadLine());

    Console.Write("\nQual a idade do aluno? ");
    aluno.idade = Convert.ToInt32(Console.ReadLine());

    Console.Write("\nQual o sexo do aluno? ");
    aluno.sexo = Convert.ToString(Console.ReadLine());

    Console.Write("\nQual foi a média do aluno? ");
    aluno.media = Convert.ToDouble(Console.ReadLine());
    aluno.AlunoAprovado(aluno);
    return aluno;
}

Console.WriteLine("Hello, World!");

Aluno aluno = CadastrarAluno();

Curso curso = new Curso();
curso.Resultado(aluno);

// Criando a classe aluno com um método para saber se ele foi aprovado
class Aluno
{
    public string nome;
    public int idade;
    public string sexo;
    public double media;
    public bool aprovado;

    public void AlunoAprovado(Aluno aluno)
    {
        if (aluno.media >= 6)
        {
             aluno.aprovado = true;
        }
        else
        {
            aluno.aprovado = false;
        }
    }
}

// Criando um curso aluno que contém apenas um método que mostra os dados do aluno e invoca outro método de outra classe(aluno)
// para saber se ele foi aprovado
class Curso
{
    public void Resultado(Aluno aluno)
    {
        Console.WriteLine($"O aluno {aluno.nome} do sexo {aluno.sexo} com {aluno.idade} anos");
        if (aluno.aprovado)
        {
            Console.WriteLine("Foi aprovado");
        }
        else
        {
            Console.WriteLine("Foi Reprovado");
        }
    }
}