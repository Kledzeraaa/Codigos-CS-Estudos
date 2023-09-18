// Printando no console sobre o assunto abordado
Console.WriteLine("Classes");

// Declarando uma classe do tipo Pessoa com nome p1
Pessoa p1 = new Pessoa();
p1.nome = "Clayton";
p1.idade = 21;
p1.sexo = "Masculino";

// Declarando uma classe do tipo Pessoa com nome p2 e alocando p1 em p2
Pessoa p2 = p1;
//Pessoa p2 = new Pessoa();
//p2.nome = "Sla";
//p2.idade = 35;
//p2.sexo = "Feminino";

Console.WriteLine($"Olá {p1.nome} e {p2.nome}, a soma das suas idades são {p1.idade + p2.idade}");

// Declarando uma classe do tipo Pessoa com nome p3, utilizando outra sintaxe
Pessoa p3 = new();
p3.nome = "Monkey D. Luffy";
p3.idade = 19;
p3.sexo = "Masculino";

Console.WriteLine($"\nNome:{p3.nome} \nIdade:{p3.idade} \nSexo:{p3.sexo}");

Console.ReadKey();

// Declarando a Classe Pessoa de fato
class Pessoa
{
    public string? nome;
    public int idade;
    public string? sexo;
}