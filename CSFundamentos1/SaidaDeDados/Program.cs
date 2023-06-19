// Printando na tela sobre o assunto abordado
Console.WriteLine("Saída de dados: Formatação");
Console.WriteLine();

// Definindo duas variáveis: idade e nome.
int idade = 20;
string nome = "Clayton";

// Método convencional
Console.WriteLine("WriteLine");
Console.WriteLine(nome);
Console.WriteLine(idade);
Console.WriteLine("========================================================");

// Método convencional (Write)
Console.WriteLine("Write");
Console.Write(nome);
Console.WriteLine(idade);
Console.WriteLine("========================================================");

// Método convencional (Write separado)
Console.WriteLine("Write separado");
Console.Write(nome);
Console.Write(" tem ");
Console.Write(idade);
Console.Write(" anos");
Console.WriteLine();
Console.WriteLine("========================================================");

// Método da Concatenção
Console.WriteLine("Concatenação");
Console.WriteLine(nome + " tem " + idade + " anos");
Console.WriteLine("========================================================");

// Método da Interpolação
Console.WriteLine("Interpolação");
Console.WriteLine($"{nome} tem {idade} anos");
Console.WriteLine("========================================================");

// Método Place Holders
Console.WriteLine("Place Holders");
Console.WriteLine("{0} tem {1} anos", nome, idade);
Console.WriteLine("========================================================");