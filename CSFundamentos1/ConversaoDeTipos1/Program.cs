// Printando no console sobre o assunto abordado
Console.WriteLine("Convertendo Tipo de dados");

// Convertendo um int -> double/float/decimal. Conversão implicita 
Console.WriteLine("\nConversão Implícita");
int varInt = 12;       // 4 bytes
double varDouble = varInt;  // 8 bytes
float varFloat = varInt; // 4 bytes
decimal varDecimal = varInt; // 16 bytes
Console.WriteLine($"Int: {varInt}");
Console.WriteLine($"Double: {varDouble}");
Console.WriteLine($"Float: {varFloat}");
Console.WriteLine($"Decimal: {varDecimal}");
Console.ReadLine();

// Converetendo um double -> int. Conversão Explícita 
Console.WriteLine("Conversão Explícita");
double varDouble2 = 12.55; // 8 Bytes
int varInt2 = (int)varDouble2; // 4 Bytes
Console.WriteLine($"Double: {varDouble2}");
Console.WriteLine($"Int: {varInt2}");
Console.ReadLine() ;

// Conversão em operações matemáticas
Console.WriteLine("Conversão em operações matemáticas");

// Convertendo de maneira errada para fins experimentais
Console.WriteLine("\nConversão Errada:");
int num1 = 3, num2 = 5;
float varFloat2 = num1 / num2;
Console.WriteLine($"Float(3/5): {varFloat2}");

// Conversão correta 
Console.WriteLine("\nConversão Correta:");
varFloat2 = (float)num1 / num2;
Console.WriteLine($"Float(3/5): {varFloat2}");
