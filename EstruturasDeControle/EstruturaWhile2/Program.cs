// Printando sobre o asunto abordado no console
Console.WriteLine("While 2");

int numeroParImpar = 0;

/* Utilizando um while com uma condição para gerar um loop infinito que pede para o usuário informar um número e checa se ele
 * é impar ou par, caso ele informe o número 0 o loop vai se encerrar e continuar a execução de outro código*/
while (true)
{
    Console.Write("\nInforme um número inteiro(para sair tecle 0): ");
    numeroParImpar = Convert.ToInt32(Console.ReadLine());

    if (numeroParImpar == 0)
    {
        Console.WriteLine("Saindo do loop...");
        break;
    }
    else
    {
        if (numeroParImpar % 2 == 0)
        {
            Console.WriteLine($"O número {numeroParImpar} é par");
        }
        else
        {
            Console.WriteLine($"O número {numeroParImpar} é impar");
        }
    }
}

Console.ReadKey();
Console.WriteLine("Fim do processamento...");
Console.WriteLine("=========================================");

/* Código de exemplo de como imprimir coordenadas em um plano, nesse código utiliza-se duas variáveis (x,y) inteiros para ser 
   as coordenadas do plano, com isso utiliza-se dois whiles aninhados com as condições de que enquanto x e y forem menor que 5
   o código ficara em loop imprimindo os valores das coordenadas*/
Console.WriteLine("Exemplo de coordenadas em um plano");
int x = 0;
int y = 0;
while (x < 5)
{
    y = 0;
    while (y < 5)
    {
        Console.Write($"({x},{y++}) ");
    }
    Console.WriteLine();
    x++;
}

