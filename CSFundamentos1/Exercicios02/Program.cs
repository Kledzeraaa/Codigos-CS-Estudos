// Projeto para a resolução de alguns exercícios que aborda 

/* 1.Declare as variáveis "nome", "idade" e "nota" atribuindo os valores “Paulo”, 17 e 7.5 e exiba a saída no formato :
     Aluno<nome> tem<idade> anos e nota<nota> usando a concatenação e a interpolação de strings.*/

Console.WriteLine("1. ");
string nome = "Paulo";
byte idade = 17;
float nota = 7.5f;

Console.WriteLine("Concatenação: Aluno "+nome+" tem "+idade+" anos e nota "+nota);
Console.WriteLine($"Interpolação de String: Aluno {nome} tem {idade} anos e nota {nota}");

Console.WriteLine("===========================================================================");

// 2.Para o exercício anterior exiba o nome a idade e a nota em linhas separadas usando as sequências de escapes.
Console.WriteLine("2. ");
Console.WriteLine($"Aluno {nome}\ntem {idade} anos\ne nota {nota}");

Console.WriteLine("===========================================================================");

/* 3.Para qual tipo de dados você pode converter um float implicitamente ?
(f) int
(v) double
(f) long
(v) decimal */

/* 4.Em qual conversão numérica você precisaria realizar o casting (convesão forçada) ?
(f) int para long
(v) double para long
(v) double para float
(v) decimal para float
(v) long para int
(v) double para decima */

/*5.Escreva um programa que recebe 3 letras via teclado e as exiba na ordem reversa usando 
a concatenação e também a interpolação de strings*/
Console.WriteLine("5. ");
Console.WriteLine("Informe 3 letras em sequência: ");
char letra1 = Convert.ToChar(Console.ReadLine());
char letra2 = Convert.ToChar(Console.ReadLine());
char letra3 = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Concatenação: "+letra3+" "+letra2+" "+letra1);
Console.WriteLine($"Interpolação: {letra3} {letra2} {letra1}");

Console.WriteLine("===========================================================================");

/*6.Marque verdadeiro(V) ou falso(F) para os códigos abaixo:
(f) long resultado = 1.32;
(v) var nome = “Maria”;
(v) string resultado = 100.ToString();
(v) A sequência de escape \n inclui uma nova linha
(f) float f = 5.45;
(v) decimal valor = (decimal)10.99f;
(f) var status = null;
(v) object o = 12.45m;
(v) string titulo = true.ToString();
(f) A sequencia \t inclui uma tabulação vertical*/

/*7.Escreva um programa para receber dois valores via teclado do tipo double e a seguir 
realize as operações de soma, subtração, multiplicação, exponenciação, divisão e módulo 
exibindo o resultado:*/
Console.WriteLine("7. ");
Console.Write("Informe o valor de x: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Informe o valor de y: ");
double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"X+Y: {x+y}");
Console.WriteLine($"X-Y: {x-y}");
Console.WriteLine($"X*Y: {x*y}");
Console.WriteLine($"X^Y: {Math.Pow(x,y)}");
Console.WriteLine($"X/Y: {x/y}");
Console.WriteLine($"Modulo de x e y: {x%y}");

Console.WriteLine("===========================================================================");

// 8.Faça um programa para calcular o resultado da fórmula de baskara dados os valores de a b e c . a=1, b=12 e c = -13
Console.WriteLine("8. ");

int a = 1, b = 12, c = -13;

double delta = Math.Pow(b,2) - (4*a*c);

double x1 = ((-b) + Math.Sqrt(delta))/2*a;
double x2 = ((-b) - Math.Sqrt(delta))/2*a;

Console.WriteLine($"Valor de x1: {x1}");
Console.WriteLine($"Valor de x2: {x2}");

Console.WriteLine("===========================================================================");

/*9.Escreva um programa que receba um nome e uma senha via teclado. Nome é uma string e 
Senha é um inteiro. Se o nome for igual a ‘admin’ ou ‘maria’ e a senha for igual a ‘123’ 
então exiba a mensagem ‘Login feito com sucesso’ caso contrário exiba a mensagem ‘Login 
inválido’: (use o operador condicional ternário)*/

Console.WriteLine("9. ");
Console.Write("Informe um nome: ");
string nome1 = Console.ReadLine();
Console.Write("Informe uma senha: ");
int senha = Convert.ToInt32(Console.ReadLine());

string mensagem = nome1 == "admin" || nome1 == "Maria" && senha == 123 ? "Login feito com sucesso":"Login inválido";
Console.WriteLine(mensagem);

Console.WriteLine("===========================================================================");

/*10.Indique verdadeiro(V) ou falso(F) para as seguintes declarações de variáveis considerando 
a nomenclatura usada:
(v) string? nome; é um exemplo de nullable reference type;
(f) para x igual a 0 , Console.WriteLine(x++); imprime o valor 1
(f) A ordem de precedência dos operadores lógicos é : ! , || e && (NOT, OR e AND)
(v) para y igual a 0 , Console.WriteLine(++y); imprime o valor 1
(f) (10 % 2 == 0) ? “Par” : “Impar”; Vai retornar “Impar”
(f) Para x = 25 e y=5 , a expressão ( y >= x ) && (y <= x); retorna true;
(v) Os nullable reference types emitem um alerta em tempo de compilação para uso do null
(f) Para x = 10, o código Console.WriteLine(x+=x); imprime o valor 10;
(f) Para x = 5, a expressão !(9 >= x) && x <= 7 || x == 5); retorna false;
(v) O operador ?. permite verificar se um objeto é null e evitar o NullReferenceException
(v) Qualquer tipo de dado pode ser declarado como anulável com a ajuda do operador "?"*/

/*11.Escreva um programa que recebe via teclado dois números inteiros x e y e imprima no 
console se x é par ou não e se y é par ou não. Use o operador condicional ternário (? :)*/

Console.Write("11. ");
Console.Write("Informe o valor de xx: ");
int xx = Convert.ToInt32(Console.ReadLine());
Console.Write("Informe o valor de yy: ");
int yy = Convert.ToInt32(Console.ReadLine());

string resultadoxx = xx % 2 == 0 ? "xx é par":"xx não é par";
string resultadoyy = yy % 2 == 0 ? "yy é par":"yy não é par";

Console.WriteLine($"{resultadoxx}\n{resultadoyy}");

Console.WriteLine("===========================================================================");

/*12.Crie um programa que receba um numero inteiro x via teclado e calcule e imprima no 
console o resultado das seguintes operações : (x ^ 2->x ao quadrado) (pi = 3.1415)
-6 + x * 5
(13-2) * x
(x + -2) * (20 / x)
(12 + x) / (x - 4)
3 x^2 + x + 10
pi * x^2
*/

Console.WriteLine("12. ");
Console.Write("Informe o valor de xxx:");
int xxx = Convert.ToInt32(Console.ReadLine());
const double PI = 3.1415;

Console.WriteLine($"-6 + xxx * 5 = {-6 + xxx * 5}");
Console.WriteLine($"(13-2) * xxx = {(13-2)*xxx}");
Console.WriteLine($"(xxx + -2) * (20/xxx) = {(xxx + -2) * (20 / xxx)}");
Console.WriteLine($"(12 + xxx) / (xxx - 4) = {(12 + xxx) / (xxx - 4)}");
Console.WriteLine($"3 * xxx^2 + xxx + 10 = {3 * Math.Pow(xxx,2) + xxx + 10}");
Console.WriteLine($"PI * x^2 = {PI * Math.Pow(xxx,2)}");

Console.WriteLine("===========================================================================");

/*13. Considere o seguinte trecho de código:
int y = 5;
y = (y++) + y + (++y); ou y = y++ + y + ++y;
Console.WriteLine(y); 

 R: O valor de y será 18.
    y++ vai retornar 5 e então incrementará para 6 ->primeiro resolve e depois incrementa
    ++y vai incrementar 6 para 7 ->primeiro incrementa depois resolve
    logo: y = (5+6+7) = 18
*/

/*14. Escreva um programa que solicite a temperatura em graus Celsius e converta para 
Kelvin e Farhenheit usando as fórmulas a seguir:
-Converter para Kelvin => K = C + 273;
-Converter para Farhenheit => F = (C * 9) / 5 + 32;*/

Console.WriteLine("14. ");
Console.Write("\nInforme a temperatura em °c:");

int temperatura = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Convertendo para Kelvin: {temperatura + 273}");
Console.WriteLine($"Convertendo para Farhenheit: {temperatura * 9 / 5 + 32}");

/*15. Escolha a opção que representa a exibição do resultado para o código usando os 
operadores de decremento e incremento (pré e pós) 

var numero = 5;
Console.WriteLine(numero++);
numero = 1;
Console.WriteLine(++numero);
numero = 2;
Console.WriteLine(numero--);
numero = 3;
Console.WriteLine(--numero);
Console.ReadKey();

 (x)  ( )  ( )  ( )
  5    6    5    6
  2    3    2    2
  2    2    1    1
  2    2    2    3  */