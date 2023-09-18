// Código que utiliza o modelo de passagem de argumetos por referência
Console.WriteLine("Passando argumentos referência");
Calculo calc = new();

Console.Write("Informe o valor de x: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Valor de x antes de invocar o método: " + x);
calc.Dobrar(ref x);
Console.WriteLine("Valor de x depois de invocar o método: " + x);

Console.ReadKey();

public class Calculo
{
    public void Dobrar(ref int y)
    {
        y *= 2;
        Console.WriteLine("Valor de y no método dobrar: " + y);
    }
}
