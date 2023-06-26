// Printando no console o assunto abordado
Console.WriteLine("Estrutura IF");

// Pedindo para o usuário informar se ele é vip e armazenando o valor em uma variável string.
Console.WriteLine("\nO cliente é VIP?");
Console.Write(" Responda com sim ou não:");
string resposta = Console.ReadLine();

// Verificando se o usuário é VIP, se sim aplica-se um desconto de 15% na compra, se não apenas realiza a compra sem o desconto.
if (resposta == "sim")
{
    Console.WriteLine("\nO cliente é VIP!");
    Console.WriteLine("15% de desconto aplicado.");
}
Console.WriteLine("\nCompra realizado com sucesso");

// Esperando o usuário apertar alguma tecla no teclado para continuar a execução do programa
Console.ReadKey();

// Realizando uma separação visual no console 
Console.WriteLine("=================================================");

// Pedindo para o cliente informar se ele é VIP e armazenando em uma variável do tipo bool
Console.WriteLine("\nO cliente é VIP?");
Console.Write(" Responda com true ou false:");
bool eVip = Convert.ToBoolean(Console.ReadLine());

// Verificando se o usuário é VIP, se sim aplica-se um desconto de 15% na compra, se não apenas realiza a compra sem o desconto.
if (eVip)
{
    Console.WriteLine("\nO cliente é VIP!");
    Console.WriteLine("15% de desconto aplicado.");
}
Console.WriteLine("\nCompra realizada com sucesso.");

// Realizando uma separação visual no console 
Console.WriteLine("=================================================");

// Pedindo para o usuário informar um valor inteiro para x e y e armazenando em tais variáveis
Console.Write("\nInforme um valor para x:");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("\nInforme um valor para y:");
int y = Convert.ToInt32(Console.ReadLine());

// Verificando se x é maior que y, se sim printo o resultado, se não continuo o código
if (x > y)
{
    Console.WriteLine("x é maior que y");
}

// Verificando se x é menor que y, se sim printo o resultado, se não continuo o código
if (x < y)
{
    Console.WriteLine("x é menor que y");
}

// Verificando se x é igual a y, se sim printo o resultado, se não continuo o código
if (x == y)
{
    Console.WriteLine("x é igual a y");
}