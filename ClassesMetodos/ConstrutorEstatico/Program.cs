// Código que mostra construtores estáticos da classe Pessoa
Console.WriteLine("Construtores Estáticos");

Pessoa p1 = new("Clayton", 21);

Console.WriteLine($"\nNome:{p1.Nome} \nIdade:{p1.Idade}");
Console.WriteLine($"Idade Miníma:{Pessoa.IdadeMinima}");

Console.WriteLine();

Pessoa p2 = new("Zap", 19);
Console.WriteLine($"\nNome:{p2.Nome} \nIdade:{p2.Idade}");
Console.WriteLine($"Idade Miníma:{Pessoa.IdadeMinima}");


Console.ReadKey();
