// Programa que mostra o funcionamento dos Argumentos nomeados
Console.WriteLine("Métodos com argumentos nomeados");

Email email = new();
email.Enviar("Error@hotmail.com","Urgente","Reunião de orcamento");

// Argumentos nomeados

email.Enviar(assunto: "Reunião de orçamento", destino:"Error@hotmail.com", titulo: "Urgente");
email.Enviar(titulo: "Urgente", destino:"Error@hotmail.com", assunto: "Reunião de orçamento");
email.Enviar(titulo: "Urgente", assunto: "Reunião de orçamento", destino: "Error@hotmail.com");

Console.ReadKey();


public class Email
{
    public void Enviar(string destino, string titulo, string assunto)
    {
        Console.WriteLine($"\nPara {destino} - {titulo} \nAssunto:{assunto}");
    }
}
