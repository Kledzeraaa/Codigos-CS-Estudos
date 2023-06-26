// Printando sobre o assunto abordado
Console.WriteLine("Switch");

// Setando um valor para a compra e pedindo para o usuário informar a quantidade de parcelas e armazenando esse valor em um byte
double valorCompra = 550;
Console.WriteLine($"\nValor da compra R$ {valorCompra}");
Console.Write("Informe a quantidade de parcelas(1 a 3):");
byte quantidadeParcelas = Convert.ToByte(Console.ReadLine());

// Utilizando a estrutura switch para calcular o valor de cada parcela da compra
switch (quantidadeParcelas)
{
    case 1: 
        Console.WriteLine($"Valor da Prestação: R$ {valorCompra/quantidadeParcelas}");
        break;

    case 2: 
        Console.WriteLine($"Valor da Prestação: R$ {valorCompra/quantidadeParcelas}");
        break;

    case 3:
        Console.WriteLine($"Valor da Prestação; R$ {valorCompra/quantidadeParcelas}");
        break;

    default:
        Console.WriteLine("Valor informado inválido (informe apenas 1, 2 ou 3)");
        break;
}

// Printando na tela o fim do processamento de compra e esperanod o usuário apertar alguma tecla para continuar o código
Console.WriteLine("\nFim do processamento...");
Console.ReadKey();

Console.WriteLine("====================================================================");

// Pedindo para o usuário informar um número
Console.Write("\nInforme um número:");
int numero = Convert.ToInt32(Console.ReadLine());

// Utilizando a estutura switch para imprimir se o número é par ou impar
switch (numero % 2)
{
    case 0:
        Console.WriteLine($"O número {numero} é par!");
        ; break;

    default:
        Console.WriteLine($"O número {numero} é impar!");
        break;
}

// Printando o fim do processamento
Console.WriteLine("Fim do processamento...");