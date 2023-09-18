// Esse projeto aborda tudo aprendido nos projeto 1. - 4.
Console.WriteLine("Resumo dos projetos 1-4");

Cadastro cadastro = new();

var cliente = cadastro.Registrar();
cadastro.ExibirDados(cliente);

cliente = cadastro.Registrar(cliente);
cadastro.ExibirDados("Mudança de salário de ", cliente);

Console.ReadKey();

// Criando uma classe "Cliente" que tem 2 construtores. 1 padrão e 1 com 3 parametros para incialização utilizando a palavra chave this
public class Cliente
{
    public string? nome;
    public int idade;
    public decimal salario;

    public Cliente(string nome, int idade, decimal salario)
    {
        this.nome = nome;
        this.idade = idade;
        this.salario = salario;
    }
    public Cliente()
    {}
}

// Criando uma classe Cadastro que possue 4 métodos com sobrecarga entre alguns deles
public class Cadastro
{
    public Cliente Registrar()
    {
        Cliente cliente = new("Clayton", 21, 3000);
        return cliente;
    }
    public Cliente Registrar(Cliente cliente)
    {
        cliente.salario = 3500;
        return cliente;
    }

    public void ExibirDados(Cliente cliente)
    {
        Console.WriteLine($"{cliente.nome} {cliente.idade} {cliente.salario}");
    }

    public void ExibirDados(string texto, Cliente cliente)
    {
        Console.Write($"{texto}");
        Console.Write($"{cliente.nome} {cliente.salario}");
    }
}