// Printando na tela sobre o assunto abordado
Console.WriteLine("Do While");

/* Código que utiliza a estrutura do-while para imprimir a incrementação de uma variavel i de 1 a 10, porém é utilizado uma
   estrutura if para para a estrutura do-while quando a varivavel i chegar a 7*/
int i = 0;
do
{
    Console.WriteLine($"i:{++i}");

    if (i == 7)
    {
        Console.WriteLine("Saindo da estrutura...");
        break;
    }

}while (i < 10);

Console.WriteLine("Fim do processamento...");

Console.ReadKey();
Console.WriteLine("===========================================");

/* Código que imprime as coordenadas em um plano utilizando a estrutura do while*/
Console.WriteLine("\nDo While aninhados");

int x = 0;
int y = 0;
do
{
    y = 0;
    do
    {
        Console.Write($"({x},{y++}) ");
    } while (y < 5);

    Console.WriteLine();
    x++;

}while (x < 5);
