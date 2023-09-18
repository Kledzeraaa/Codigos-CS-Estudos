// 
Console.WriteLine("Métodos com parâmetros opcionais");

Console.Write("\nInforme o destino: ");
string destino = Console.ReadLine();

Console.Write("Informe o assunto: ");
string assunto = Console.ReadLine();

Console.Write("Informe o titulo: ");
string titulo = Console.ReadLine();

Email email = new();

email.Enviar();
email.Enviar(destino);
email.Enviar(destino, assunto);
email.Enviar(destino, assunto, titulo);

// Não posso fazer:
// emial.Enviar(destino, , titulo); -> Erro
email.Enviar(destino, titulo:titulo);


Console.ReadKey();

public class Email
{
    public void Enviar(string destino="Destino padrão", string assunto = "Assunto padrão", string titulo = "Titulo Padrão")
    {
        Console.WriteLine($"\nPara {destino} - {titulo} \nAssunto:{assunto}");
    }
}
