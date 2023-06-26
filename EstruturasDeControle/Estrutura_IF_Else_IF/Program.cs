// Printando na tela sobre o assunto abordado
Console.WriteLine("Estrutura IF Else IF");

// Pedindo para o usuário informar uma nota e armazenando na variável notaAluno 
Console.Write("\nInforme a nota do aluno:");
double notaAluno = Convert.ToDouble(Console.ReadLine());

// Verificando se a nota do aluno é menor que 5, se sim printe o resultado, se não vá para o else if
if(notaAluno < 5)
{
    Console.WriteLine("Reprovado");
}
// Verificando se a nota do aluno é maior ou igual a 5 e menor que 6, se sim printe o resultado, se não vá para o else if
else if(notaAluno >= 5 && notaAluno < 6)
{
    Console.WriteLine("Recuperação");
}
// Verificano se a nota do aluno é maior ou igual a 6 e menor ou igual a 9, se sim printe o resultado, se não vá para o else
else if (notaAluno >= 6 && notaAluno <=9)
{
    Console.WriteLine("Aprovado");
}
// Como nenhuma verificação acima foi satifeita então sobrou apenas 1 opção, Aprovado com distinção
else
{
    Console.WriteLine("Aproado com distinção");
}