// Printando no console sobre o assunto abordado
Console.WriteLine("For");

/* Esse código pede ao usuário para informar um número e imprime a tabuada do 10 desse número utilizando a estrutura for */
Console.Write("\nInforme o número: ");
int numero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\nTabuada do {numero}");
Console.WriteLine("-----------------");
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{numero} x {i} = {numero*i}");
}

Console.WriteLine("Fim do processo...");

Console.ReadKey();

Console.WriteLine("=================================");

/* Esse código pede para o usuário informar um valor maior que zero, caso não seja o programa informa que o valor digitado está errado
   e encerra a execução, caso esteja correto ele vai calcular a tabuada (10) incrementando e multiplicando o valor em 0.5 */
Console.Write("\ninforme um número maior que zero:");
int numeroMaiorQueZero = Convert.ToInt32(Console.ReadLine());
double k = 0;

if (numeroMaiorQueZero > 0)
{
    for (k = 0.5; k <= 10; k+=0.5)
    {
        Console.WriteLine($"{numeroMaiorQueZero} x {k} = {numeroMaiorQueZero*k}");
    }
}
else
{
    Console.WriteLine("Informe um número maior que zero");
}

Console.WriteLine("Fim do processamento...");