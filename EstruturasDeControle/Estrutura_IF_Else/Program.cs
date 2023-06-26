// Printando na tela sobre o assunto abordado
Console.WriteLine("Estrutura IF Else");

// Pedindo para o usuário informar a nota do aluno e armazenando numa variável int notaAluno
Console.Write("\nInforme a nota do aluno:");
int notaAluno = Convert.ToInt32(Console.ReadLine());

// Verificando se a nota do aluno é igual ou maior que 5, se sim o aluno está aprovado, se não o aluno está reprovado
if (notaAluno >= 5)
{
    Console.WriteLine("Aluno aprovado!");
}
else
{
    Console.WriteLine("Aluno Reprovado!");
}

// Esperando o usuário apertar uma tecla no teclado para continuar a execução do código
Console.ReadKey();

// Realizando uma separação visual no console 
Console.WriteLine("=============================================");

// Pedindo para o usuário informar um valor para x e y e armazenando em tais variáveis
Console.Write("\nInforme um valor para x:");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("\nInforme um valor para y:");
int y = Convert.ToInt32(Console.ReadLine());

// Verificando se x é maior que y, se sim printe na tela o resultado, se não execute o else
if (x > y)
{
    Console.WriteLine("x é maior que y");
}
else
{
    // Verificando se x é menor que y, se sim printe na tela o resultado, se não execute o else
    if (x < y)
    {
        Console.WriteLine("x é menor que y");
    }
    else
    {
        // Como x > y é false ; x < y é false; então x só pode ser igual a y 
        Console.WriteLine("x é igual a y");
    }
}