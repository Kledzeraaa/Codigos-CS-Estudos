// Printando no console sobre o assunto abordado
Console.WriteLine("Operadores Lógicos");

// Declarando valores a duas variaveis bool para utilização dos operadores lógicos
bool c1 = 5 > 7; //False
bool c2 = 9 > 8; //True
bool resultado;

// Printando no console o valor de c1 e c2
Console.WriteLine($"\nValor de c1: {c1}");
Console.WriteLine($"Valor de c2: {c2}");

// Operando AND -> &&
resultado = c1 && c2;
Console.WriteLine($"\nOperador AND(&&): {resultado}");

// Operando OR -> ||
resultado = c1 || c2;
Console.WriteLine($"Operador OR(||): {resultado}");

// Operando NOT -> !
Console.WriteLine($"Operador NOT(!): {!c2}");
