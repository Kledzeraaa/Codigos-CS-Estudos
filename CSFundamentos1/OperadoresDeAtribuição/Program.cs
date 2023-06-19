// Printando no console sobre o assunto abordado
Console.WriteLine("Operadores de Atribuição");

// Declarando a variável
var x = 10;

// Utilizando os operadores de atribuição
Console.WriteLine($"\nValor inicial de x: {x}");
Console.WriteLine($"x+=5 -> {x+=5}");
Console.WriteLine($"x-=5 -> {x-+5}");
Console.WriteLine($"x*=4 -> {x*=4}");
Console.WriteLine($"x/=5 -> {x/=5}");
Console.WriteLine($"x%=5 -> {x%=5}");

// Esperando o usuário apertar uma tecla no teclado
Console.ReadKey();

// Utilizando os operadores de atribuição em string
var y = "123";
Console.WriteLine($"\nValor inicial de y: {y}");
Console.WriteLine($"y+=\"456\" -> {y+="456"}");