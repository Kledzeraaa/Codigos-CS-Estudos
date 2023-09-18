// Código que mostra o funcionammento do tratamento de erros utilizando o bloco try-catch
Console.WriteLine("Tratamento de Erros");

Console.Write("\nInforme do número de x:");
int x =  Convert.ToInt32(Console.ReadLine());

Console.Write("Informe do número de y:");
int y = Convert.ToInt32(Console.ReadLine());

try
{
    int z = x / y;
    Console.WriteLine($"\n{x} / {y} = {z}");
}
catch (Exception ex)
{
    Console.WriteLine("\nImpossível fazer divisão por 0");
    Console.WriteLine($"\nErro:{ex.Message}");
    Console.WriteLine($"Detalhe:{ex.StackTrace}");
}
finally
{
    Console.WriteLine("\nProcesso finalizado");
}

Console.ReadKey();




