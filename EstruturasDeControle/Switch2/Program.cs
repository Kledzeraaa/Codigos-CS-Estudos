// Printando sobre o assunto abordado
Console.WriteLine("Switch 2");

// Pedindo para o usuário informar o nome de um mês do ano
Console.Write("\nInforme o nome de um mês:");
string nomeMes = Console.ReadLine().ToLower();

// Utilizando a estrutura para dizer a quantidade de dias de um mês
switch (nomeMes)
{
    case "janeiro":
    case "março":
    case "maio":
    case "julho":
    case "agosto":
    case "outubro":
    case "dezembro":
        Console.WriteLine("Esse mês tem 31 dias");
        break;

    case "fevereiro":
        Console.WriteLine("Esse mês tem 28 ou 29 dias");
        break;

    case "abril":
    case "junho":
    case "setembro":
    case "novembro":    
        Console.WriteLine("Esse mês tem 30 dias");
        break;

    default:
        Console.WriteLine("Não existe esse mês");
        break;
}

// Informando o fim do processamento e esperando o usuário apertar alguma tecla para continuar a execução do código
Console.WriteLine("\nFim do processamento...");
Console.ReadKey();
Console.WriteLine("==============================================");

// Pedindo para o usuário informar o cargo na empresa digitando 1 para gerente e 2 para programador e armazenando em um tipo byte
Console.Write("\nInforme o seu cargo \n(1)Gerente ou (2)Programador:");
byte numeroCargo = Convert.ToByte(Console.ReadLine());

/* Utilizando a estrutura Switch para imprimir uma mensagem de boas vindas informando o cargo da pessoa e no caso da pessoa ser um
programador utiliza-se outro switch para imprimir a mensagem com o tipo de programador */
switch (numeroCargo)
{
    case 1:
        Console.WriteLine("\nBem-Vindo Gerente.");
        break;

    case 2:
        Console.Write("\n(1)Programador Junior ou (2)Programador Sênior:");
        byte cargoProgramador = Convert.ToByte(Console.ReadLine());

        switch (cargoProgramador)
        {
            case 1:
                Console.WriteLine("Bem-Vindo Programador Junior");
                break;

            case 2:
                Console.WriteLine("Bem-Vindo Programador Sênior");
                break;

            default:
                Console.WriteLine("Não existe esse cargo de programador (informe 1 ou 2)");
                break;
        }
        break;

    default:
        Console.WriteLine("Não existe esse cargo na empresa (informe 1 ou 2)");
        break;
}

// Printando o fim do processamento
Console.WriteLine("Fim do processamento...");