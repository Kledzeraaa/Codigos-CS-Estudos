// Printando no console sobre o assunto abordado
Console.WriteLine("For 2");

/* Código mostra outro meio de utilização da estrutura for, que pegar duas variaveis inteiras e as utiliza como 
   inicialização, condição e incrementação na estrutura for*/
for (int i = 0, j = 0; i+j <=20; i++,j++)
{
    Console.WriteLine($"{i} + {j} = {i+j}");
}

Console.WriteLine("Fim do processamento...");
Console.ReadKey();
Console.WriteLine("======================");

/* Código que imp´rime as coordenadas em um plano utilizando a estutura for aninhada */
Console.WriteLine("Coordenadas em um plano");
for (int k = 0; k < 5; k++)
{
    for (int l = 0; l < 5; l++)
    {
        Console.Write($"({k},{l}) ");
    }
    Console.WriteLine();
}
