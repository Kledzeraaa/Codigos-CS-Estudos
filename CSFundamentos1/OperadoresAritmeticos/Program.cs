// Printando no console sobre o assunto abordado
Console.WriteLine("Operadores Aritméticos");

// Pedindo para o usuário informar dois valores um para x e outro para y 
Console.Write("\nInforme o valor de x: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Informe o valor de y: ");
int y = Convert.ToInt32(Console.ReadLine());

// Realizando operações de soma, subtração, divisão, multiplicação e módulo com as variáveis x e y
Console.WriteLine($"\nSoma entre x e y: {x+y}");
Console.WriteLine($"Subtração entre x e y: {x-y}");
Console.WriteLine($"Divisão entre x e y: {(float)x /y}");
Console.WriteLine($"Multiplicação entre x e y: {x*y}");
Console.WriteLine($"Módulo entre x e y: {x%y}");

// Esperando o usuário apertar alguma tecla no teclado
Console.ReadKey();

// Realizando as operações de soma, subtração, divisão, multipicação e módulo utilizando a classe math
Console.WriteLine("\nUtilizando a classe math");
Console.WriteLine($"\nRaiz quadrada de x: {Math.Sqrt(x)}");
Console.WriteLine($"Potência de x elevado a y: {Math.Pow(x,y)}");
Console.WriteLine($"Valor mínimo entre x e y: {Math.Min(x,y)}");
Console.WriteLine($"Valor Máximo entre x e y: {Math.Max(x,y)}");
Console.WriteLine($"Coseno de x: {Math.Cos(x)}");
Console.WriteLine($"Seno de x: {Math.Sin(x)}");
Console.WriteLine($"Tangente de x: {Math.Tan(x)}");