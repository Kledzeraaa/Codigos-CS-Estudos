// Printando no console sobre o assunto abordado.
Console.WriteLine("Conversão de tipos de dados");
Console.WriteLine("\nClasse Convert.To");

// Declarando variáveis.
int valorInt = 10;
double valorDouble = 35.75;
bool valorBool = true;

// Printando os valores das variáveis acima.
Console.WriteLine($"\nValor Int:{valorInt} \nValor Double: {valorDouble} \nValor Bool: {valorBool}");

// Utilizando o Método Convert.To
Console.WriteLine("Convertendo INT -> STRING: " + Convert.ToString(valorInt));
Console.WriteLine("Convertendo INT -> DOUBLE: " + Convert.ToDouble(valorInt));
Console.WriteLine("Convertendo BOOL -> STRING: " + Convert.ToString(valorBool));
Console.WriteLine("Convertendo BOOL -> INT: " + Convert.ToInt32(valorBool));
Console.WriteLine("Convertendo DOUBLE -> INT: " + Convert.ToInt32(valorDouble));

// Causando uma OverFlorException com o método Convert.To
short valorInt2 = 1000;
Console.WriteLine($"Valor Int: {valorInt2}");
Console.WriteLine("Convertendo INT -> BYTE" + Convert.ToByte(valorInt2));
// Isso ocorre pois, o tipo byte só suporta valores de 0 a 255 e como int=1000, é impossível ele armazenar esse valor em um tipo Byte.
