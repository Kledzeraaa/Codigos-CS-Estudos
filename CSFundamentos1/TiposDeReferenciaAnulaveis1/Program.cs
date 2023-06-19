// Printando no console sobre o assunto abordado
Console.WriteLine("Tipos de Referencia anulaveis");

// Declarando uma variavel do tipo nullable
string? nome = null;

// Printando no console o valor null e conseguindo realizar funções com tal valor, o que não é possível sem "?"
Console.WriteLine(nome?.ToUpper());

// Esperando o usuário apertar uma tecla no teclado
Console.ReadKey();

// Mesmo não apresentando erro de compilação, o erro ocorre em tempo de execução
string nome2 = null;
Console.WriteLine(nome.ToUpper());