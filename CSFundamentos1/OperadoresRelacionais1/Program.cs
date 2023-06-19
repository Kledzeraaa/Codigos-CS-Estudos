// Printando no console sobre o assunto abordado
Console.WriteLine("Operadores Relacionais");

// Atribuindo valores a duas variaveis do tipo int que seram usadas para comparação
int x = 10;
int y = 20;

// Printando o valor de x e y
Console.WriteLine($"Valor de x: {x} \nValor de y:{y}");

// Fazendo as comparações de igualdade, maior, menor, maior igual, menor igual e diferente
Console.WriteLine($"\nX é igual a Y: {x==y}");
Console.WriteLine($"X é maior que Y: {x>y}");
Console.WriteLine($"X é menor que Y: {x<y}");
Console.WriteLine($"X é maior igual a Y: {x>=y}");
Console.WriteLine($"X é menor igual a Y: {x<=y}");
Console.WriteLine($"X é diferente de Y: {x!=y}");

// Esperando o usuario apertar alguma tecla
Console.ReadKey();

// Realizando as operações relacionais com strings
Console.WriteLine("\nUtilizando Operadores relacionais em strings");
string a = "Clayton";
string b = "clayton";

Console.WriteLine($"\nValor de a:{a} \nValor de b:{b}");
// Operação de igualdade utilizando "=="
Console.WriteLine($"\nA é igual a B:{a==b}");
// Utilizando o método Equals
Console.WriteLine($"\nA.Equals(B):{a.Equals(b)}");