// Printando no console sobre o assunto abordado
Console.WriteLine("Precedencia de operadores");

// Declarando uma variavel x que vai utilizar a precedencia de operadores para printar resultado no console
int x = 10 - 2 * 3;
Console.WriteLine($"Valor de x: {x}");

// Usando o operador () para dar prioridade na conta e mudar o resultado
x = (10 - 2) * 3;
Console.WriteLine($"Valor de x: {x}");

// Esperando o usuário apertar uma tecla no teclado
Console.ReadKey();

// Declarando uma variavel b que vai utilizar a precedencia de operadores para printar o resultado no console
bool b = !(9 != 8) && 5 >= 7 || 8 >= 6;
Console.WriteLine($"\nValor de b: {b}");

// Usando o operador () para dar prioridade na conta e mudar o resultado
b = !(9 != 8) && (5 >=7 || 8 >= 6);
Console.WriteLine($"Valor de b: {b}");

// Esperando o usuário apertar uma tecla no teclado
Console.ReadKey();

// Declarando as variaveis a,b2,c que vão utilizar a precedencia de operadores para printar o resultado no console
int a = 5, b2 = 6, c = 4;
int r = --a * b2 - ++c;
Console.WriteLine($"\nValor de r:{r}");

// Esperando o usuário apertar uma tecla no teclado
Console.ReadKey();

// Declarando as variaveis d,e,f que vão utilizar a precedencia de operadores para printar o resultado no console
int d = 5, e = 6, f = 3;
int resultado = d = e = f;
Console.WriteLine($"\nValor de resultado: {resultado}");