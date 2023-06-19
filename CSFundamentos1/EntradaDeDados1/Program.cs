// Printando no console sobre o assunto abordado
Console.WriteLine("Entrada de Dados");

// Coletando o nome e a idade utilizando o ReadLine
Console.Write("\nInforme seu nome: ");
string nome = Console.ReadLine();

Console.Write("Informe sua idade: ");
byte idade = Convert.ToByte(Console.ReadLine());

//try
//{
//    idade = byte.Parse(Console.ReadLine());
//}
//catch (FormatException exe)
//{
//    Console.WriteLine("zap");
//    throw;
//}

// Printando no Console o nom e a idade
Console.WriteLine($"\nSeu nome é {nome} e você tem {idade} anos");

// Esperando o usuario apertar alguma tecla
Console.ReadKey();
