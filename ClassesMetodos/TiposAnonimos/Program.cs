// Código que mostra o funcionamento dos tipos anonimos
Console.WriteLine("Tipos Anônimos");

var aluno = new
{
    Id = 1,
    Nome = "Clayton",
    Idade = 21,
    Email = "Kledev02@hotmail.com",
    Endereco = new {Id = 1, Cidade = "Aracaju", Pais = "Brasil"}
};

Console.WriteLine("\n" + aluno.Id);
Console.WriteLine(aluno.Nome);
Console.WriteLine(aluno.Idade);
Console.WriteLine(aluno.Email);
Console.WriteLine(aluno.Endereco.Cidade);

var alunos = new[]
{
    new { Id = 1, Nome = "Clayton", Email = "Kledev02@hotmail.com"},
    new { Id = 2, Nome = "João", Email = "Joao@hotmail.com"},
    new { Id = 3, Nome = "Dan", Email = "Dan@hotmail.com"},
};

Console.WriteLine("\n" + alunos[0].Nome);
Console.WriteLine(alunos[0].Email);

Console.WriteLine("\n" + alunos[1].Nome);
Console.WriteLine(alunos[1].Email);

Console.WriteLine("\n" + alunos[2].Nome);
Console.WriteLine(alunos[2].Email);

Console.ReadKey();
