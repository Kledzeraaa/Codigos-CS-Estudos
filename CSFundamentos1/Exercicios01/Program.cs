// Projeto para a resolução de alguns exercícios que aborda (Tipos de dados, Nullable Type e Identificadoes).

// 1. Crie uma variável chamada "idade" e atribua a ela o valor "35" e exiba seu valor.
Console.WriteLine("1.");
short idade = 35;
Console.WriteLine("Idade: " +idade);
Console.WriteLine("=================================================");

// 2. Crie uma variável chamada "nome" e atribua o valor "Maria" e exiba o seu valor.
Console.WriteLine("2.");
string nome = "Maria";
Console.WriteLine("Nome: " +nome);
Console.WriteLine("=================================================");

// 3. Crie uma variável chamada "altura" e atribua a ela o valor "3.45".
float altura = 3.45f;

// 4. Crie uma variável chamada "data" e atribua a ela a data "04/09/1999" e exiba o seu valor.
Console.WriteLine("4.");
DateTime data = new DateTime(1999,09,04);
Console.WriteLine("Data: " +data);
Console.WriteLine("=================================================");

// 5. Crie uma constante chamada "ano" e atribua a ela o valor "12" e exiba o seu valor.
Console.WriteLine("5.");
const short ANO = 12;
Console.WriteLine("Ano: " +ANO);
Console.WriteLine("=================================================");

// 6. Declare uma variável "nota" do tipo "double" como sendo do tipo "Nullable type" e atribua o valor "7.80" e exiba o seu valor.
Console.WriteLine("6.");
double? nota = 7.80;
Console.WriteLine("Nota: " +nota);
Console.WriteLine("=================================================");

/* 7. Quais as diferenças entre os tipos por valor e os tipos por referência? 
      R: Os tipos por valor são armazenados na memória STACK, diferente dos tipos de dados por referencia que são armazenados 
         na memória HEAP.
      R complemento: Tipos por valor – Armazenam os dados diretamente onde cada variável tem a cópia dos dados e são 
                    armazenados na memória Stack.
                 Tipos por referência – Não armazenam os dados diretamente e cada variável contém uma referência 
                    ao local da memória onde os dados estão. São armazenados na memória Heap.*/

/* 8. Inclua o tipo de dados correto entre os parênteses nas seguintes declarações de variáveis:
( int ) x = 10;
( double ) numero = 7.99;
( char ) letra = 'C';
( float ) temperatura = 27.4f;
( bool ) ativo = false;
( string ) nome = "Manoel";
( decimal ) salario = 950.99m;
( datetime ) hoje = DateTime.Now; */

/* 9. Dada as variáveis declaradas a seguir classifique-as em tipos por valor(V) e tipos por 
referência (R) :
( v ) int n = 1;
( r ) string titulo = "A vida";
( v ) float f = 12.45f;
( v ) double d = 5.45;
( v ) decimal valor = 10.99m;
( v ) char sexo = ‘M’;
( r ) object o = null; */

/* 10.  O que é um nullable type e qual a sua utilidade
        R: São tipos de dados que podem ser anulaveis, ou seja podem ser atribuidos o valor null a eles. 
        R complemento: São usados para representar um valor indefinido/ausente para um um tipo de valor ou para tratar com 
                       valores null em cenários onde podemos ter ou não valores atribuídos como informações de um banco 
                       de dados*/

/* 11. O que é Camel Case ? Dê um exemplo de sua aplicação.
       R: Camel Case é uma conveniencia de formatação de escrita, onde a primeira letra da palavra vai ser minuscula
          e a inicial das demais maiúscula e é aplicada em nome de variáveis, parâmetros e campos internos. 
          Ex: valorPedido, impostoDeRenda.*/

/* 12. O que é Pascal Case ? Dê um exemplo de sua aplicação.
       R: Pascal Case é uma conveniecnai de formatação de escrita, onde a primeira letra de cada palavra vai ser maiúscula
          e é aplicada em classes, métodos, interfaes e propriedades. Ex: CalcularImpostoDeRenda, MediaPonderada, ValorDoDesconto*/

/* 13. Declare duas variáveis "x" e "y" como sendo do tipo "int" e atribua a ela os valores "77" e "66" e a 
seguir imprima o valor da soma de x com y. (Use o operador aritmético + para realizar a 
operação de soma)
 */
Console.WriteLine("13.");
int x = 77, y = 66;
Console.WriteLine("Soma de x+y: "+(x+y));
Console.WriteLine("=================================================");

/* 14. Quais os valores padrões dos tipos de dados bool, char, int, double, float, decimal e string
       R: bool = false
          char = caracter unicode(U+0000) para null
          int, double, float e decimal = 0
          string = null */

/* 15. Indique verdadeiro(V) ou falso(F) para as seguintes declarações de variáveis 
considerando a nomenclatura usada:
( f ) double 1valor = 12.45;
( f ) string #nome = "Pedro"; 
( v ) float _temperatura = 12.45f;
( f ) double int = 5;
( f ) decimal renda extra = 91.45m;
( f ) bool status$conta = false;
( v ) string titulo3 = “Tópico 1”;
( v ) float salario_mensal = 1999.55f; obs: poderia usar o camel case, mas não está errado.
( v ) int percentualValorDesconto = 5;
( v ) const bool MENSALIDADE_EM_DIA = true;
*/
