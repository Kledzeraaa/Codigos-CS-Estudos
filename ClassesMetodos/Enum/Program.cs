// 
using Enum;

Console.WriteLine("Enum");

Console.WriteLine($"\n{DiasDaSemana.Domingo} vale:{(int)DiasDaSemana.Domingo}");
Console.WriteLine($"{DiasDaSemana.Terça} vale:{(int)DiasDaSemana.Terça}");

Console.ReadKey();

Console.WriteLine($"\n{Categorias.Moda} - {(int)Categorias.Moda}");
Console.WriteLine($"{Categorias.Automotivo} - {(int)Categorias.Automotivo}");
Console.WriteLine($"{Categorias.Artes} - {(int)Categorias.Artes}");
Console.WriteLine($"{Categorias.Bebidas} - {(int)Categorias.Bebidas}");
Console.WriteLine($"{Categorias.Livros} - {(int)Categorias.Livros}");
Console.WriteLine($"{Categorias.Brinquedo} - {(int)Categorias.Brinquedo}");

Console.Write("\nSelecione a categoria teclando o seu valor:");
int valor = Convert.ToInt32( Console.ReadLine() );
Console.WriteLine("Você selecionou a categoria "+(Categorias)valor);

