// Printando no console sobre o assunto abordado
Console.WriteLine("Operadores Unitários");

// Pedindo para o usuario informar um número e armazenando esse valor informado na variável número
Console.Write("\nInforme um número: ");
int numero = Convert.ToInt32(Console.ReadLine());

// Printando na tela o valor negativo e positivo do valor informado pelo usuario 
Console.WriteLine($"\nO negativo do número informado é:{-numero}\nO número informado foi: {+numero}");

// Esperando o usuario apertar alguma tecla para continuar o programa
Console.ReadKey();

// Printando no console sobre o assunto abordado
Console.WriteLine("\nOperadores Ternários");

// Pedindo para o usuario informar dois números e armazenando esses valores nas variaveis x e y
Console.Write("\nInforme o valor de x: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Informe o valor de y: ");
int y = Convert.ToInt32(Console.ReadLine());

// Utilizando os operadores ternarios para criar uma condição e armazenar o valor correto na variavel resultado
string resultado = x > y ? "x é maior que y" : x < y ? "x é menor que y" : x == y ? "x é igual a y" : "Sem resutado";
Console.WriteLine($"Resultado: {resultado}");