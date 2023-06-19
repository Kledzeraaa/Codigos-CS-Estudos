// Printando no console sobre o assunto abordado
Console.WriteLine("Operadores de Incremente e Decremento");

// Declarando uma variavel e incrementando seu valor
int x = 0;
Console.WriteLine($"\nValor de x:{x} \nValor de x++:{++x}");

// Utilizando a maneira padrão para incrementar o valor;
x = 0;
x++;
Console.WriteLine($"\nUtilizando outra maneira. Valor de x++: {x}");

// Esperando o usuário apertar uma tecla
Console.ReadKey();

// Pós Incremento/Decremento -> 1° resolve a expressão e depois incrementa
int y = 0;
int resultado = y++ + 10;
Console.WriteLine($"\nPós-Incremento/Decremento: \nResultado:{resultado}\nValor de y: {y}");

// Pré Incremento/Decremento -> 1° incrementa depois resolve a expressão
y = 0;
resultado = ++y + 10;
Console.WriteLine($"\nPré-Incremento/Decremento: \nResultado:{resultado}\nValor de y: {y}");