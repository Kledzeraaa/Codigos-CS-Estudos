// Código que utiliza o modelo de passagem de argumentos por valor
Console.WriteLine("Passando Argumentos - Valor");

Calculo calc = new();

Console.Write("\nInforme o valor de x:");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Valor de x antes de invocar o método: " + x);
calc.Dobrar(x);
Console.WriteLine("Valor de x depois de invocar o método: " + x);

Console.ReadKey();

public class Calculo
{
    public void Dobrar(int y)
    {
        y *= 2;
        Console.WriteLine("Valor de y no método dobrar: " + y);
    }
}
