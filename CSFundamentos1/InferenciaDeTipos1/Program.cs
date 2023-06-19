// Printando no console sobre o assunto abordado
Console.WriteLine("Inferencia de Tipos (var)");

// Declarando variáveis usando (var)
var nome = "Clayton";
var idade = 20;
var salario = 500m;

// Printando os valores declarados com (var)
Console.WriteLine($"\nSeu nome é {nome}, você tem {idade} aos e ganha {salario.ToString("c")} por mês");

Console.ReadKey();

/* Limitações do (var)
   1. var salario = null; -> x 
   2. var titulo; -> x
   3. var salario, imposto, renda; -> x 
   4. Não pode mudar o tipo do dado após ser inicializado com (var) */

// OBS: O Tipo var também pode reconhecer tipos declarados pelo programador. Ex: Classe
