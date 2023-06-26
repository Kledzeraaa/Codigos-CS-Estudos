// Projeto voltado para a resolução de atividades 

/* 1. Escreva um programa para receber 3 números inteiros e a seguir calcular e exibir qual deles é o maior */  
Console.WriteLine("1. ");

Console.WriteLine("Informe o valor de um número");
int numero1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de um número");
int numero2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de um número");
int numero3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\nPrimeiro Número: {numero1} \nSegundo número: {numero2} \nTerceiro número: {numero3}");

if (numero1 > numero2 && numero1 > numero3)
{
    Console.WriteLine($"\nO primeiro número: {numero1} é o maior");
}
else if (numero2 > numero1 && numero2 > numero3)
{
    Console.WriteLine($"\nO segundo número: {numero2} é o maior");
}
else
{
    Console.WriteLine($"\nO terceiro número: {numero3} é o maior");
}
Console.WriteLine("===============================================================");

/* 2.Escreva um programa para calcular a raiz da equação quadrática : ax^2 + bx + c = 0
   Considere a, b e c números inteiros (positivos, negativos e o zero)
   Para calcular as raízes use a fórmula de Báskara
   Solicite a entrada de a , b e c e informe se existe ou não raiz real*/

Console.WriteLine("\n2. ");
Console.WriteLine("Cálculo da equação do segundo grau(ax^2+bx+c): ");

Console.Write("\nInforme o valor de a: ");
int valorA = Convert.ToInt32(Console.ReadLine());

Console.Write("\nInfore o valor de b: ");
int valorB = Convert.ToInt32(Console.ReadLine());

Console.Write("\nInforme o valor de c: ");
int valorC = Convert.ToInt32(Console.ReadLine());

double delta = Math.Pow(valorB, 2) - 4*valorA*valorC;

if (delta > 0)
{
    Console.WriteLine("Ambas as raízes são reais e diferentes");
    double raizX1 = (-valorB + Math.Sqrt(delta))/2 * valorA; 
    double raizX2 = (-valorB - Math.Sqrt(delta))/2 * valorA;
    Console.WriteLine($"Primeira raiz x1 = {raizX1}");
    Console.WriteLine($"Segunda raiz x2 = {raizX2}");
}
else
{
    Console.WriteLine("As raízes são imaginárias;");
    Console.WriteLine("Sem solução para os números reais");
}
Console.WriteLine("===============================================================");

/*3. Escreva um programa para exibir os 10 primeiros números naturais e calcular a sua soma usando os loop 
while, do-while e for.*/
Console.WriteLine("\n3. ");

// Utilizando While
int somaNumeros = 0;
int numerosNaturais = 0;

while (numerosNaturais < 10){
    ++numerosNaturais;
    somaNumeros = numerosNaturais + somaNumeros;
    Console.Write($"{numerosNaturais} ");
}

Console.WriteLine($"\nSoma dos números naturais: {somaNumeros}");

Console.WriteLine();
// Utilizando Do While
somaNumeros = 0;
numerosNaturais = 0;

do
{
    numerosNaturais++;
    somaNumeros = numerosNaturais + somaNumeros;
    Console.Write($"{numerosNaturais} ");
} while (numerosNaturais < 10);

Console.WriteLine($"\nSoma dos números naturais: {somaNumeros}");

Console.WriteLine();
// Utilizando for

somaNumeros = 0;

for (numerosNaturais = 0; numerosNaturais <= 10; ++numerosNaturais)
{
    somaNumeros = numerosNaturais + somaNumeros;
    Console.Write($"{numerosNaturais} ");
}

Console.WriteLine($"\nSoma dos números naturais: {somaNumeros}");

Console.WriteLine("===============================================================");

/* 4.Escreva um programa para exibir a tabela de multiplicação de um número natural maior que zero recebido via teclado
- Verifique se o número é maior que zero e emita uma mensagem
- Considere a tabela de multiplicação de 1 até 10
- Após exibir a tabela torne a solicitar outro número 
- Para sair do loop defina uma condição de saída */

Console.WriteLine("\n4.");
while(true)
{
    Console.Write("Informe um valor inteiro positivo: ");
    int numeroPositivo = Convert.ToInt32(Console.ReadLine());

    if (numeroPositivo > 0)
    {
        Console.WriteLine("Tabuada do 10");
        for(int i = 0; i<=10; i++)
        {
            Console.WriteLine($"{numeroPositivo} x {i} = {numeroPositivo*i}");
        }
    }
    else if (numeroPositivo == 0)
    {
        Console.WriteLine("Saindo...");
        break;
    }
    else
    {
        Console.WriteLine("Informe um número positivo");
    }
}
Console.WriteLine("===============================================================");

/*  5. Escreva um programa para solicitar ao usuário que escolha a resposta correta de uma lista de opções de 
    resposta de uma pergunta. O usuário pode optar por continuar respondendo a pergunta ou parar de responder.
    Não utilize a instrução break */

Console.WriteLine("\n5. ");
bool saida = true;
do
{
    Console.WriteLine("Qual a instrução para sair de um loop?");
    Console.WriteLine("a.quit");
    Console.WriteLine("b.continue");
    Console.WriteLine("c.break");
    Console.WriteLine("d.exit");
    Console.Write("\nQual a opção correta?(tecle x para sair): ");
    char opcaoCorreta = Convert.ToChar(Console.ReadLine());

    if (opcaoCorreta == 'x')
    {
        Console.WriteLine("Saindo...");
        saida = false;
    }
    else if (opcaoCorreta == 'c')
    {
        Console.WriteLine("Resposta correta");
        saida = false;
    }
    else
    {
        Console.WriteLine("Resposta incorreta");
    }
  
} while (saida );

Console.WriteLine("===============================================================");

/* 6.Crie um programa para exbir no console os números pares de 10 a 20, ambos incluídos, exceto 16, de 3 
maneiras diferentes: 
- Incrementando 2 em cada passo
- Incrementando 1 em cada passo 
- Com e loop infinito (use "break" e "continue") */

Console.WriteLine("\n6.");
Console.WriteLine("Incrementando 2 em cada passo");

int numerosPares;

for (numerosPares = 10; numerosPares <= 20; numerosPares += 2)
{
    if (numerosPares == 16)
    {
        continue;
    }
    else
    {
        Console.Write($"{numerosPares} ");
    }
}

Console.WriteLine("\nIncrementando 1 em cada passo");
for (numerosPares = 10; numerosPares <= 20; numerosPares++)
{
    if (numerosPares % 2 != 0 || numerosPares == 16)
    {
        continue;
    }
    else
    {
        Console.Write($"{numerosPares} ");
    }
}

Console.WriteLine("\nIncrementando com loop infinito");
numerosPares = 9;
while (true)
{
    numerosPares++;
    if (numerosPares % 2 != 0 || numerosPares == 16)
    {
        continue;
    }
    else
    {
        Console.Write($"{numerosPares} ");
        if (numerosPares == 20)
        {
            break;
        }
    }
}
Console.WriteLine("\n===============================================================");

/* 7. Escreva um programa para exibir o padrão como triângulo de ângulo reto usando asterisco (*). Ex:
*
**
***
***** */

Console.WriteLine("\n7.");

for (int i = 0; i <= 4; i++)
{
    for (int j = 0; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

Console.WriteLine("===============================================================");
/* 8.Escreva um programa para calcular o fatorial de um número inteiro. 
     O fatorial de um número é representado por : n! => n * (n – 1) * (n – 2) ....2*1 
     Exemplo : fatorial de 6 é representado por 6! = 6*5*4*3*2*1 */

Console.WriteLine("\n8.");
Console.Write("Informe um número que deseja saber seu fatorial:");
int numeroFatorial = Convert.ToInt32(Console.ReadLine());

int resultadoFatorial = numeroFatorial;

for (int i = (numeroFatorial - 1); i > 1; i--)
{
    resultadoFatorial = resultadoFatorial * i;
}

Console.WriteLine($"{numeroFatorial}! = {resultadoFatorial}");

Console.WriteLine("===============================================================");

/* 9. Escreva um programa para exibir as tabelas de multiplicação do 2 ao 6 usando o loop do-while aninhado */

int saidaDoWhile = 2;
do
{
    int i = 1;

    do
    {
        Console.WriteLine($"{saidaDoWhile}x{i} = {saidaDoWhile*i}");
        i++;
    } while (i != 11);

    Console.WriteLine();
    saidaDoWhile++;

} while (saidaDoWhile != 7);

Console.WriteLine("===============================================================");

/* 10. Crie um programa que recebe na entrada de dados um número inteiro de 0 a 10 que representa a nota de 
um aluno. Com base na tabela a seguir imprima no console qual o resultado da avaliação do aluno. (Use a 
instrução switch, break e default em um loop infinito e defina uma condição de saida.) */

Console.WriteLine("\n10. ");
while (true)
{
    Console.Write("\nInforme a nota do aluno:");
    int notaAluno = Convert.ToInt32(Console.ReadLine());
    if (notaAluno > 10 || notaAluno < 0)
    {
        Console.WriteLine("A nota informada está errada, digite um valor entre 0 e 10");
        continue;
    }
    else
    {
        switch (notaAluno)
        {
            case 5:
                Console.WriteLine("Resultado da avaliação: E");
                break;

            case 6:
                Console.WriteLine("Resultado da avaliação: C");
                break;

            case 7:
            case 8:
                Console.WriteLine("Resultado da avaliação: B");
                break;

            case 9:
                Console.WriteLine("Resultado da avaliação: A");
                break;

            case 10:
                Console.WriteLine("Resultado da avaliação: A+");
                break;

            default:
                Console.WriteLine("Resultado da avaliação: F");
                break;
        }
    }

    Console.Write("\nDeseja informar mais alguma nota?(s/n)");
    char condicao = Convert.ToChar(Console.ReadLine());

    if (condicao == 'n')
    {
        Console.WriteLine("Saindo...");
        break;
    }
}
Console.WriteLine("===============================================================");

/* 11. Crie um programa para realizar as operações de adição, subtração, multiplicação e divisão de números 
inteiros. (considere que na divisão podemos ter números fracionários e que não existe divisão por zero e 
quando isso ocorrer exibir uma mensagem de alerta) */

Console.WriteLine("11. ");

Console.Write("\nInforme o primeiro número: ");
int primeiroNumero = Convert.ToInt32(Console.ReadLine());

Console.Write("\nInforme o operando (+ , - , / , *): ");
char operando = Convert.ToChar(Console.ReadLine());

Console.Write("\nInforme o segundo número: ");
int segundoNumero = Convert.ToInt32(Console.ReadLine());

switch (operando)
{
    case '+':
        Console.WriteLine($"{primeiroNumero} + {segundoNumero} = {primeiroNumero+segundoNumero}");
        break;

    case '-':
        Console.WriteLine($"{primeiroNumero} - {segundoNumero} = {primeiroNumero - segundoNumero}");
        break;

    case '*':
        Console.WriteLine($"{primeiroNumero} x {segundoNumero} = {primeiroNumero * segundoNumero}");
        break;

    case '/':
        if (primeiroNumero == 0 || segundoNumero == 0)
        {
            Console.WriteLine("Não existe divisão com número 0");
        }
        else
        {
            Console.WriteLine($"{primeiroNumero} / {segundoNumero} = {(float)primeiroNumero / segundoNumero}");
        }
        break;
}