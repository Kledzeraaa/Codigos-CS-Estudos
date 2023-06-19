// Printando texto no console sobre o assunto abordado
Console.WriteLine("Atribuindo valores ao tipo Sting");
Console.WriteLine();

// Atribuindo valores para String
Console.WriteLine("Atribuindo valor Clayton da Paixão Santos:");
string nome = "Clayton da Paixão Santos";
Console.WriteLine("Nome: " +nome);
Console.WriteLine();

// Mudando valor da VARIÁVEL STRING
/* Ruim fazer isso pois o C# vai alocar 2 espaços na memória diferente um para "Clayton da Paixão Santos" e um para "Oi"
   mesmo sendo apenas printado o valor "Oi" o valor anterior ainda está alocado na memória
   Para fazer essa alteração é melhor utilizar StringBuilder*/
Console.WriteLine("Mudando valor para Oi");
nome = "Oi";
Console.WriteLine("Nome: " +nome);

// Esperando uma leitura no console para avançar o assunto de OBJECT e DYNAMIC
Console.ReadLine();

// Printando texto no console sobre o assunto abordado
Console.WriteLine("Atribuindo valores ao tipo OBJECT/DYNAMIC");
Console.WriteLine();

object obj = true;
object valor1 = 10;
object valor2 = 20f;
object nome1 = "Clayton da Paixão Santos";
object letra = 'c';

/* O tipo DYNAMIC é usado para a mesma finalidade, porém ele é mais utilizado para quando está envolvido recursos avançados 
   como reflection ou usar recursos das linguagen dinamicas */

Console.WriteLine("Bool: " + obj);
Console.WriteLine("Int: " + valor1);
Console.WriteLine("Float: " + valor2);
Console.WriteLine("Strign: " + nome1);
Console.WriteLine("Char: " + letra);

Console.ReadLine();