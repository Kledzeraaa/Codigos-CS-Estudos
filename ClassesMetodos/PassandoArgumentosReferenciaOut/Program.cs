// Código que utiliza o modelo de argumentos por referência Out
Console.WriteLine("Passando argumentos por referência Out");

Console.Write("Informe o valor do raio: ");
double raio = Convert.ToDouble(Console.ReadLine());

Circulo circ = new();

Console.WriteLine("\nSem out:");
double area  = circ.CalcularArea(raio);
double perimetro = circ.CalcularPerimetro(raio);
Console.WriteLine("Perímetro da circunferência: " + perimetro);
Console.WriteLine("Área da circunferência: " + area);

Console.WriteLine("\nCom out:");
perimetro = circ.CalcularAreaPerimetro(raio, out double area2);
Console.WriteLine("Perímetro da circunferência: " + perimetro);
Console.WriteLine("Área da circunferência: " + area2);

Console.ReadKey();

public class Circulo
{
    public double CalcularArea(double raio)
    {
        return (Math.PI * Math.Pow(raio,2));
    }

    public double CalcularPerimetro(double raio)
    {
        return 2 * Math.PI * raio;
    }

    public double CalcularAreaPerimetro(double raio, out double area)
    {
        area = Math.PI * Math.Pow(raio,2);
        return 2 * Math.PI * raio;
    }
}