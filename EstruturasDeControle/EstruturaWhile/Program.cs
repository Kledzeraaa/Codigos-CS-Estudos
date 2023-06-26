// Printando na tela sobre o assunto abordado
Console.WriteLine("While");

// Inicializando uma variável inteira i e atribuindo o valor 0
int i = 0;

// Utilizando a estrutura while para realizar um loop que enquanto i for menor que 10 ele vai continuar o laço
while (i < 10)
{
    // Incrementando e printando o valor de i
    Console.WriteLine($"i: {++i}");
}

// Pritando que ocorreu o fim do processo 
Console.WriteLine("Fim do processamento...");

// Esperando o usuário apertar alguma tecla no teclado para continuar a execução do código
Console.ReadKey();

// Separando os dois códigos
Console.WriteLine("=====================================");

// Código para fazer a tabuada de um número 
// Pedindo para o usuário informar um número maior que 0 e alocando esse valor em uma váriavel int chamada número
Console.Write("\nInforme um número inteiro positivo: ");
int numero = Convert.ToInt32(Console.ReadLine());

// Utilizando o if para saber se o número informado foi maior que 0, se não for ele informa o erro e cancela a operação
if (numero > 0)
{
    // Inicializando uma váriavel do tipo byte chamada ate10 que vai ser usado para fazer a tabuada do número informado até 10
    byte ate10 = 0;
    Console.WriteLine("\nTabuada do numero " +numero);

    // Utilizando a estrutura while para imprimir a tabuada do número informado
    while (ate10 < 10)
    {
        Console.WriteLine($"{numero} x {++ate10} = {numero*ate10}");
    }
}
else
{
    Console.WriteLine("\nO número tem que ser maior que zero \nFim do processamento...");
}