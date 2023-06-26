// Printando no console sobre o assunto abordado
Console.WriteLine("Estrutura Goto-Label");

// Declarando uma variável do tipo int e alocando o valor 0
int i = 0;

// Utilizando a estrutura goto-label para realizar uma repetição do código (*) que imprime o valor de i e o incrementa
repeticao:

Console.WriteLine($"i -> {i++}"); // (*)

if (i <=10000)
{
    goto repeticao;
}

// Printando o fim do código
Console.WriteLine("Fim do processamento...");