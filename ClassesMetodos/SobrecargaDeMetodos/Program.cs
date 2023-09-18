// Printando no console sobre o assunto abordado
using System.Threading.Channels;

Console.WriteLine("Sobrecarga de Métodos");

// Instanciando um objeto do tipo "Email"
Email email = new();

// Utilizando todas as possíveis solicitações das sobrecargas de métodos
email.Enviar("Error.com.br");
Console.WriteLine();
email.Enviar("Error.com.br","João Contratado");
Console.WriteLine();
email.Enviar("Error.com.br",0.50m);
Console.WriteLine();
email.Enviar(1.00m,"Error.com.br");
Console.ReadKey();

// Criando uma classe "Email" onde aplico os conceitos de Sobrecarga de métodos
public class Email
{
    public void Enviar(string endereco)
    {
        Console.WriteLine(endereco);
        Console.WriteLine("Assunto Padrão");
    }

    public void Enviar(string endereco, string assunto)
    {
        Console.WriteLine(endereco);
        Console.WriteLine(assunto);
    }
    public void Enviar(string endereco, decimal valor)
    {
        Console.WriteLine(endereco);
        Console.WriteLine("Proposta comercial");
        Console.WriteLine(valor);
    }
    public void Enviar(decimal valor, string endereco)
    {
        Console.WriteLine(endereco);
        Console.WriteLine("Pagamento Fornecedor");
        Console.WriteLine(valor);
    }
}