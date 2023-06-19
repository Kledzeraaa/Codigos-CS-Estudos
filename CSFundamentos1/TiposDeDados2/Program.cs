// Printando texto no console sobre o assunto abordado
Console.WriteLine("Declarando variáveis de tipo flutuante");
Console.WriteLine();

// Declarando os TIPOS de VARIÁVEIS
float valor1 = 1.3f;
double valor2 = 1.3, valor3=1.3d;
decimal valor4 = 1.3m;

// Printando no console os valores atribuidos
Console.WriteLine("Float:"+valor1);
Console.WriteLine("Double:"+valor2);
Console.WriteLine("Decimal:"+valor4);

// Comando que espera uma leitura na linha do console
Console.ReadLine();

// Mostrando o grau de precisão entre os tipos float, double e decimal
valor1 = valor1 / 3;
valor3 = valor3 / 3;
valor4 = valor4 / 3;

// Printando no console os valores divididos por 3
Console.WriteLine("Valores após serem divididos por 3");
Console.WriteLine("Float:" + valor1);
Console.WriteLine("Double:" + valor3);
Console.WriteLine("Decimal:" + valor4);

// Comando que espera uma leitura na linha do console
Console.ReadLine();