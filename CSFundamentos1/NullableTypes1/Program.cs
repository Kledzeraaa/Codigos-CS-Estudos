// Printando no Console sobre o assunto abordado
Console.WriteLine("Atribuindo valores Nulls:");
Console.WriteLine();

Console.WriteLine("Sintaxe Completa:");
Nullable<int> i = null;
Nullable<double> d = null;
Nullable<bool> b = null;

Console.WriteLine("Int: " +i);
Console.WriteLine("Double: " +d);
Console.WriteLine("Bool: " +b);
Console.ReadLine();

// Atribuindo valores Null em uma sintaxe reduzida
Console.WriteLine("Sintaxe Reduzida:");
int? ii = null;
double? dd = null;
bool? bb = null;

Console.WriteLine("Int: " + ii);
Console.WriteLine("Double: " + dd);
Console.WriteLine("Bool: " + bb);
Console.ReadLine();

// Atribuindo um Nullable Type a um tipo "normal"

Console.WriteLine("Atribuindo um valor de uma variável Nullable a uma variável não-Nullable:");
int? a = null; // Mude o valor de "a" para diferentes resultados
int y = a ?? 0; // Se o valor de "a" não for null ele atribui o valor de "a" -> "y", senão "y" -> 0.
Console.WriteLine(y);
Console.ReadLine();

// Expressões com Nullable Types
Console.WriteLine("Expressões com Nullable Types:");
int? x = 3;         // Para realizar operações com expressões todos os tipos de dados envolvidos tem que ser Nullable 
int? k = 2;
int? z = x * k;
Console.ReadLine();

// Propriedade somente leitura: HasValue e Value
Console.WriteLine("Utilizando o HasValue e Value");
int? valor = null; // Mude o valor de "valor" para diferentes resultados.
if (valor.HasValue)
{
    Console.WriteLine($"valor = {valor.Value}");
}
else
{
    Console.WriteLine("Valor não possue valor!");
}

Console.ReadLine();