// Código que mostra a utilização de propriedades e os acessores get e set
Console.WriteLine("Propriedades");

Produto p1 = new Produto();
p1.Nome = "Sushi combo";
p1.Preco = 40;
p1.EstoqueMinimo = 5;

Produto.Exibir(p1);


Console.ReadKey();

public class Produto
{
    private string? nome;
    public string? Nome 
    {
        get { return nome.ToUpper(); }
        set { nome = value; } 
    }

    private double preco;
    public double Preco 
    {
        get { return preco; }
        set 
        {
            if (value < 40)
            {
                preco = 40;
            }
            else
                preco = value;
        } 
    }

    private double desconto = 0.10;
    public double Desconto 
    {
        get { return desconto; }  
    }

    
    public double PrecoFinal 
    {
        get { return preco - preco * desconto; }
    }

    private int estoqueMinimo;
    public int EstoqueMinimo 
    {
        set { estoqueMinimo = value; } 
    }

    public static void Exibir(Produto p)
    {
        Console.WriteLine($"\n{p.Nome} \n{p.Preco.ToString("c")} \n{p.Desconto} \n{p.PrecoFinal.ToString("c")}");
    }
}
