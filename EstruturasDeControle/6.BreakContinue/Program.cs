// Printando no console sobre o assunto abordado
Console.WriteLine("Break Continue");

/* Código que utiliza a função continue e break para se utilizar em estruturas de controle */
for (int i = 1; i <= 10; i++)
{
    if (i == 5)
    {
        continue;
    }

    if (i == 9)
    {
        break;
    }

    Console.WriteLine($"i = {i}");
}
