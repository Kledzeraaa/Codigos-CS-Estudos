// Código para a realização dos exercícios da UDEMY

Console.WriteLine("Cores:\n1.Branco\n2.Vermelho\n3.Preto\n4.Cinza\n5.Prata\n6.Azul");

Console.Write("Escolha a cor do carro da chevrolet:");
int cor1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Escolha a cor do carro da ford:");
int cor2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("=====================================================================================");

Carro chevrolet = new("Sedan","Chevrolet","Onix",1999,110,cor1);
Carro ford = new("SUV","Ford","EcoSport",2023,120,cor2);

Carro.exibir(chevrolet);
Carro.exibir(ford);

Console.WriteLine("Velocidade maxima do chevrolet: " + Carro.VelocidadeMaxima(chevrolet));
Console.WriteLine("Velocidade maximo do ford: " + Carro.VelocidadeMaxima(ford));
Console.WriteLine("=====================================================================================");

Console.WriteLine("Potencia antiga do chevrolet: " + chevrolet.potencia);
var novaPotenciaChevrolet = chevrolet.AumentarPotencia(chevrolet.potencia);
Console.WriteLine("Potencia atual do chevrolet: " + novaPotenciaChevrolet);

Console.WriteLine("\nPotencia antiga do Ford: " + ford.potencia);
var novaPotenciaFord = ford.AumentarPotencia(ref ford.potencia);
Console.WriteLine("Potencia atual do Ford: " + ford.potencia);
Console.WriteLine("=====================================================================================");

chevrolet.AumentarPotenciaVelocidade(ref chevrolet.potencia, out double velocidade);
Console.WriteLine("Potencia atual do chevrolet: " + ford.potencia);
Console.WriteLine("Velocidade atual do chevrolet: " + velocidade);
Console.WriteLine("=====================================================================================");

chevrolet.ExibirInfo(modelo:chevrolet.modelo, marca:chevrolet.marca, montadora:chevrolet.montadora, potencia:chevrolet.potencia, cor: chevrolet.Cor);
Console.WriteLine();
ford.ExibirInfo(potencia: ford.potencia, modelo: ford.modelo, marca: ford.marca, ano: ford.ano, montadora: ford.montadora, cor:ford.Cor);
Console.WriteLine("=====================================================================================");

//Carro.ObeterValorIpva();
Console.WriteLine("Valor do IPVA: " + Carro.ValorIpva);
Console.WriteLine("=====================================================================================");

Cliente c1 = new("Clayton","Kledev02@hotmail.com", 21);
Cliente.ExibirInfo(nome:"Clayton", idade:21, email:"kleitonp.2016@hotmail.com");
Cliente.ExibirInfo(email:"kleitonp.2016@hotmail.com", nome: "Clayton");
Console.WriteLine("=====================================================================================");

Console.ReadKey();

struct Cliente
{
    public string? Nome;
    public string? Email;
    private int idade;
    public int Idade 
    {
        get { return idade; }
        set 
        {
            if (value < 18)
            {
                value = 18;
            }
            else
            {
                idade = value;
            }
        }
    }

    public Cliente(string? nome, string? email, int idade)
    {
        this.Nome = nome;
        this.Email = email;
        this.idade = idade;
    }

    public static void ExibirInfo(string? nome, string? email, int idade = 18)
    {
        Console.WriteLine($"\n{nome}\n{email}\n{idade}");
    }
}
class Carro
{
    public string? modelo;
    public string? montadora;
    public string? marca;
    private int Ano;
    public int ano 
    {
        get { return Ano; }
        set
        {
            if (value < 2000)
            {
                Ano = 2000;
            }
            else if (value > 2022)
            {
                Ano = 2022;
            }
            else
            {
                Ano = value;
            }
        }
    }
    public int potencia;
    public static double ValorIpva;
    public int Cor;

    public Carro(string Modelo, string Montadora)
    {
        modelo = Modelo;
        montadora = Montadora;
    }
    public Carro(string modelo, string montadora, string marca, int ano, int potencia, int cor) : this(modelo, montadora)
    {
        this.marca = marca;
        this.ano = ano;
        this.potencia = potencia;
        Cor = cor;
    }
    static Carro()
    {
        ObeterValorIpva();
    }
    public void Acelerar(Carro carro)
    {
        Console.WriteLine($"Acelerando o meu {carro.marca}");
    }

    public int AumentarPotencia(int potencia)
    {
        potencia += 3;
        return potencia;
    }

    public int AumentarPotencia(ref int potencia)
    {
        potencia += 5;
        return potencia;
    }

    public int AumentarPotenciaVelocidade(ref int potencia, out double velocidade)
    {
        velocidade = potencia * 1.75;
        return potencia += 7;
    }

    public void ExibirInfo(string modelo, string montadora, string marca, int potencia, int ano=0, int cor = 1)
    {
        Console.WriteLine($"Modelo:{modelo}\nMontadora:{montadora}\nMarca:{marca}\nAno:{ano}\nPotencia:{potencia}\nCor:{(Cores)cor}");
    }
    public static void exibir(Carro carro)
    {
        Console.WriteLine($"Modelo:{carro.modelo}\nMontadora:{carro.montadora}\nMarca:{carro.marca}\nAno:{carro.ano}\nPotencia:{carro.potencia}");
        carro.Acelerar(carro);
        Console.WriteLine("=====================================================================================");
    }
    public static double VelocidadeMaxima(Carro carro)
    {
        return carro.potencia * 1.75;
    }
    public static void ObeterValorIpva() => ValorIpva = 4;
}

/* h- Criando o construtor com 2 parâmetros, permitimos a criação de um objeto com apenas esses dois parâmetros 
 * e conseguimos implementar esse construtor com 2 parâmetros em outro para conseguir inicializar o objeto com todas as váriaveis 
 * inicializadas e com valor
 * 
 * j- O return é uma instrução que retorna um tipo de dado específico definido no método
 * 
 * m- Passando os argumentos por valor criasse uma cópia da váriavel passada no método e as manipulações ocorrem apenas na cópia 
 * mantendo a original sem alterações
 * 
 * o- Sobrecarga de métodos é quando se utilza dois ou mais métodos com mesmo nome mas que se diferenciam pela 
 * quantidade e tipo de parâmetros que são passados e servem para atender diversas necessidades que uma função pode realizar 
 * utilizando outros parâmetros
 * 
 * p- Passando o argumento por referência em vez de criar uma cópia da variáel passada, criasse uma cópia da referência da memória 
 * do argumento que faz com que o método consiga manipular a variável original
 * 
 * s- O parâmetro out permite você retornar uma ou mais váriaveis em um método além da função return 
 * 
 * v- Parâmetros opcionais são parâmetros pré setados dentro do método da classe, onde caso não seja informado o valor na chamada 
 * do método será inserido o valor pré setado. 
 * Já os Argumentos nomeados é uma forma de invocar o método com uma ordem de parâmetros diferentes da setada no método da classe.
 * 
 * z- A palavra-chave static retira o campo ValorIpva do objeto instanciado e associa a classe, fazendo com que qualquer 
 * objeto instanciado tenha um cópia do local da memória do campo static o que o torna único para todo novo objeto 
 * 
 * w8- A principal diferença de uma struct para uma classe é o local na memória onde os dados ficam armazenados 
 * struct: stack que é uma memória rápida e com pouco espaço, com isso uma struct serve para criar tipos menores e mais simples.
 * 
 * -Mudando o modificador de acesso de public para internal será possível ver e acessar o código apenas dentro do projeto que ele está.
 *  Mudando o modificador de acesso de public para private será possíel ver e acessar o código apenas dentro da própria classe.*/