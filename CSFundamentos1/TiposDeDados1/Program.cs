// Printando texto no console sobre o assunto abordado
Console.WriteLine("Declarando variáveis numéricas");
Console.WriteLine();

// Declarando os TIPOS de VARIÁVEIS 
byte valor1 = 255;
sbyte valor2 = -125;
short valor3 = -1000;
ushort valor4 = 5000;
int valor5 = -100000;
uint valor6 = 200000;
long valor7 = -29521099;
ulong valor8 = 25982190852;

// Declarando uma constante
const int valor9 = 1;

// Declarando varios valores do mesmo tipo na mesma linha

int valor10 = 2; int valor11 = 3;  int valor12 = 4;

// Printando os valores alocado em cada variável
Console.WriteLine("Byte:" +valor1);
Console.WriteLine("sByte:" +valor2);
Console.WriteLine("Short:" +valor3);
Console.WriteLine("uShort:" +valor4);
Console.WriteLine("Int:" +valor5);
Console.WriteLine("uInt:" +valor6);
Console.WriteLine("Long:" +valor7);
Console.WriteLine("uLong:" +valor8);
Console.WriteLine("Constante:" +valor9);
Console.WriteLine("Valores da mesma linha:" +valor10+ " " +valor11+ " " +valor12);

// Comando que espera uma leitura na linha do console
Console.ReadLine();