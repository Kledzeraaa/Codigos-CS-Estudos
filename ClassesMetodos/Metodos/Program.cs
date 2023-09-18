// Printando no console sobre o assunto abordado
Console.WriteLine("Métodos");

// Declarando um objeto do tipo MetodoTeste e chamando um método "Saudação"
MetodosTeste mt = new();
mt.Saudacao();

Console.ReadKey();

// Criando uma classe "MetodosTeste" e criando dois métodos que deseja um bom dia e a data atual
class MetodosTeste
{
    public void Saudacao()
    {
        Console.WriteLine("\nBem-Vindo!");
        ExibirDataAtual();
    }

    private void ExibirDataAtual()
    {
        Console.WriteLine(DateTime.Now.ToShortDateString());
    }

}
