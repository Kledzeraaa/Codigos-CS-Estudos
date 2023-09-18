/* 
1.O que é uma classe e qual a sua composição ?
    R: É um tipo estruturado de dados que contém membros (Atributos e Métodos). 
       Também pode ser entendida como um modelo/template que contém valores e conjunto de regas.

2.O que é um objeto e como pode ser criado ?
    R: Um objeto é uma instância de uma classe e é com ela que conseguimos manipular os membros da classe 
       e é criado utilizando a palavra chave "new".

3.Qual a diferença entre classe e objeto ?
    R: Uma classe é como se fosse a planta de uma casa onde nela fica toda a estrututa de como ela vai ser montada 
       e o objeto seria a casa montanda seguindo todas as instruções de uma classe.

4.O que é um método e como pode ser criado e chamado ?
    R: Um método representa os comportamentos das classes e são usadas para executar ações e a comunicação entre objetos e classes.
       Para criar um método precisamos de um tipo de retorno, um nome e parâmetros além claro de suas instruções que vão ser realizadas 
       quando o nome do método for chamado em uma parte do código pelo seu nome e seus parâmetros.

5.O que é um parâmetro de método ?
    R: Um parâmetro de um método são variáveis(valores) que devem ser informadas para serem manipuladas dentro do método invocado 
       sendo informado o tipo e o nome do parâmetro.

6.O que é um argumento ?
    R:  Um argumento é o valor que tem que ser informado na chamada do método seguindo as regras do tipo de dado 
        e sequência imposta pelo parâmetro.

7.O que é um construtor e qual o seu objetivo ?
    R:  Um construtor é um tipo específico de método que é inicializado junto do objeto e realiza intruções apenas nessa faixa de tempo 
        e o seu objetivo é permitir que o programador crie objetos da classe, defina valores padrão, limitar a instanciação e 
        gravar códigos fléxiveis e fáceis de ler. 

8.Quais os usos da palavra chave this ?
    R:  A palavra chave This é usada para se referir a instância atual da classe e é usada como modificador do primeiro parâmetro 
        de um método de extensão.
        Representa o objeto que está em execução, e assim, usando "this", de forma implícita chamamos o objeto que está sendo usado.
        Pode ser usada para diferenciar entre os parâmetros dos métodos e os campos quando eles tiverem o mesmo nome.
        Pode ser usada para passar um objeto da instância atual como parâmetro para outros métodos.
        Pode ser usada para invocar outro construtor da mesma classe.

9.O que é um método com retorno ?
    R:  É um método normal que ao final de sua instrução retorna para o chamador um valor do tipo de dado do método.

10.O que é sobrecarga de método ?
    R: É quando temos dois ou mais métodos com mesmo nome mas com suas assinaturas (N° de parâmetros, tipo dos parâmetros 
       e a ordem dos parâmetros) diferentes.  

11.Como é feita a passagem de parâmetros por valor ?
    R:  Uma cópia do valor do argumento é feita e passada para o parâmetro do método chamado e as alterações na cópia 
        não afetam o valor da variável original do chamador.

12.Como é feita a passagem de parâmetros por referência ?
    R:  Passa a referência ao mesmo llocal da memória dos argumentos para os parâmetros, o chamador da o método a capacidade de acessar 
        e modificar a variável original do chamador e para isso se utiliza as palavras chaves "ref" e "out".

13.Qual a diferença entre os parâmetros out e o parâmetro ref ?
    R:  A principal diferença entre eles é que o parâmetro "out" transfere os dados para fora do método o que ocorre 
        o contrario no parâmetro "ref" que transfere os dados para dentro do método

14.O que são argumentos nomeados ?
    R:  Permite que você especifique um argumento para um parâmetro correspondendo o argumento com seu nome em vez da sua posição 
        na lista de parâmetros, ou seja, libera você da necessidade de combinar a ordem dos argumentos com a ordem dos parâmetos nas 
        listas de parâmetros de métodos chamados.

15.O que são parâmetros opcionais ?
    R:  São parâmetros que tem valor padrão que caso não seja dito no argumento ira assumir o valor padrão informado no parâmetro

16.Qual o efeito da palavra-chave static ?
    R:  Retira a necessidade de se ter um objeto para conseguir invocar um método.

17.O que é método estático e qual o seu comportamento ?
    R:  São métodos que pertecem a uma classe e não a um objeto com isso ele não pode usar variáveis de instância, 
        que são variáveis do objeto.

18.O que é um campo estático e qual o seu comportamento ?
    R: Um é campo estático é um campo que é compartilhado com todas as instâncias da classe e todas as instâncias acessam o mesmo 
       local da memória.

19.O que são propriedades ?
    R:  É um membro da classe que fornece um mecanismo para ller, gravar ou calcular o valor de um campo privado.

20.Qual a diferença entre campos e propriedades ?
    R:  As propriedades são como se fossem membros de dados públicos, mas que possuem métodos especiais chamados acessadores 
        que permite que os dados sejam acessados com facillidade e ainda promovam a segurança e a flexibilidade dos métodos por meio 
        dos acessadores; "get" e "set".

21.O que é uma struct ?
    R:  É um tipo de dado definido pelo usuário que é composto por outros tipos de dados e funcionalidades relacionadas 
        (semelhante a uma classe). 

22.Qual a diferença entre uma struct e uma classe ?
    R:  A principal diferença entre uma struct e uma classe são que as structs são tipos por valor e não de referência.

23.O que é uma Enum ?
    R:  É um tipo de dado especial definido pelo usuário, são classes especiais que definem um conjunto de constantes do tipo númerico.

24.Quais são e qual o escopo dos modificadores de acesso ?
    R: PUBLIC: Indica que o tipo ou membro pode ser acessado por qualquer lugar do assembly ou outro que o referencia
       PRIVATE: Indica que o tipo ou membro pode ser acessado somente pelo código na mesma classe ou struct.
       INTERNAL: Indica que o tipo ou membro pode ser acessado por qualquer código no mesmo assembly mas não de outro.
       PROTECTED: Indica que o tipo ou membro pode ser acessado por qualquer código no mesmo assembly no qual ele é declarado 
                  ou de um classe derivada em outro assembly.
       FILE: Restringe o escopo e a visibilidade de um tipo de nível superior apenas ao arquivo que ele foi declarado
 
 
 */