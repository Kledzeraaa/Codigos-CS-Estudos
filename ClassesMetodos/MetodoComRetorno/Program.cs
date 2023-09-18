// Printando no console sobre o assunto abordado
Console.WriteLine("Métodos com retorno");

// Inicizalizando o objeto calculadora 
Calculadora calc = new();

// Mostrando como alocar a uma váriavel o resultado do "return" do método
//var valorSoma = calc.Somar(3,4);
//var valorSubtracao = calc.Subtrair(3,4);
//var valorMultiplicacao = calc.Multiplicacao(3,4);
//var valorDivisao = calc.Divisao(3,4);

// Printando o valor do "return" de cada método
Console.WriteLine($"Soma entre 3 e 4: {calc.Somar(3, 4)}");
Console.WriteLine($"Subtração entre 3 e 4: {calc.Subtrair(3, 4)}");
Console.WriteLine($"Multiplicação entre 3 e 4: {calc.Multiplicacao(3, 4)}");
Console.WriteLine($"Divisão entre 3 e 4: {calc.Divisao(3, 4)}");
Console.ReadKey();

// Criando a classe "Calculadora" e utilizando métodos com retorno para realizar as operações básica de uma calculadora.
public class Calculadora
{
    public int Somar(int numero1, int numero2)
    {
        return numero1 + numero2;
    }

    public int Subtrair(int numero1, int numero2)
    {
        return numero1 - numero2;
    }

    public int Multiplicacao(int numero1, int numero2)
    {
        return numero1 * numero2;
    }

    public double Divisao(int numero1, int numero2)
    {
        return (double)numero1 / numero2;
    }
}
