// Printando no console sobre o assunto abordado
Console.WriteLine("Métodos com parâmetros");

// Declarando um tipo MinhaClasse com nome mc e chamando o método Saudação com parâmetros
MinhaClasse mc = new();
mc.Saudacao("Damasceno", DateTime.Now.ToShortDateString());

Console.ReadKey();

// Criando uma classe com nome Minha classe que possue um método void chamado saudação
class MinhaClasse
{
    public void Saudacao(string nome, string data)
    {
        Console.WriteLine($"\nOlá {nome} a data de hoje é {data}");
    }
}