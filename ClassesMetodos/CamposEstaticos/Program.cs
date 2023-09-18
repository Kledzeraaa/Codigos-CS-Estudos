// Código que mostra o funcionamento de campos estáticos de uma classe A
Console.WriteLine("Campos Estáticos");

A a1 = new();
a1.x = 1;

A a2 = new();
a2.x = 2;

A.y = 3;

Console.WriteLine($"a1.x = {a1.x}, a2.x = {a2.x} e A.y = {A.y}");

Console.ReadKey();

public class A
{
    public int x;
    public static int y;
    //...
}
