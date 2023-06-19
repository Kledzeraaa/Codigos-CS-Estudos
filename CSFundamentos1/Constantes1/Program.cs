// Printando no console sobre o assunto abordado
Console.WriteLine("Constantes");

// Atribuindo valores a uma constante
const int ANO = 1;

// Atribuindo varias variáveis do tipo const na mesma linha
const int SEMANA = 7, MES = 30 , QUINZENA = 15;

// Atribuindo valores a uma variável const pelo calculo de outras duas variaves do tipo const e printando na tela o valor
const int MESES_ANO = 12, DIAS_ANO = 365;
const float DIAS_POR_MES = (float)DIAS_ANO / MESES_ANO;
Console.WriteLine($"Dias em um mês:{DIAS_POR_MES}");

// Esperando o usuário apertar alguma tecla para continuar a execução do codigo
Console.ReadKey();

// Atribuindo uma variavel const PI tendo o valor 3.14.
const double PI = 3.14;

// Pedindo para o usuario informar o valor do raio do círculo e armazenando na variável raio 
Console.Write("\nInforme o raio para calcularmos o perimetro e a área do valor informado: ");
double raio = Convert.ToDouble(Console.ReadLine());

// Calculando perímetro e área sem utilizar a classe math e utilizando a variável const
double perimetro = 2 * PI * raio;
double area = PI * raio * raio;

// Pritando no console o valor do perímetro e da área
Console.WriteLine($"Perímetro: {perimetro} \nÁrea: {area}");

// É possível realizar essa mesma operação utilizando a classe Math
perimetro = 2 * Math.PI * raio;
area = Math.PI * Math.Pow(raio, 2);
Console.WriteLine($"\nPerímetro: {perimetro} \nÁrea: {area}");
// O grau de precisão é maior pois o valor de PI utilizando a classe Math é mais aproximado do que o usando pela const PI;