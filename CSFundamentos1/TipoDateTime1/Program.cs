// Printando no Console sobre o assunto abordado
Console.WriteLine("Atribuindo valores ao tipo DateTime");
Console.WriteLine();

// Pegando a Data e hora atual e alocando a uma variável 
Console.WriteLine("Dia e Hora Atual:");
DateTime Atual = DateTime.Now;
Console.WriteLine(Atual);
Console.ReadLine();

// Atribuindo uma data especifica usando o formato(aaaa,dd,mm)
Console.WriteLine("Data de ontem atribuido manualmente:");
DateTime dataOntem = new DateTime(2023, 5, 30);
Console.WriteLine(dataOntem);
Console.ReadLine();

// Atribuindo uma data e hora especifica usando o formato(aaaa,dd,mm,hh,mm,ss)
Console.WriteLine("Data e Hora de ontem atribuido manualmente:");
DateTime datahora = new DateTime(2023,5,30,14,20,3);
Console.WriteLine(datahora);
Console.ReadLine();

// Extraindo informações da Data ATUAL
Console.WriteLine("Pegando informações específicas da variável ATUAL:");
Console.WriteLine("Ano: " +Atual.Year);
Console.WriteLine("Minuto: " +Atual.Minute);
Console.WriteLine("Dia: " +Atual.Day);
Console.WriteLine("Segundo: " +Atual.Second);
Console.WriteLine("Dia do ano: " +Atual.DayOfYear);
Console.WriteLine("Hora: " +Atual.Hour);
Console.ReadLine();

// Adicionando valores a Data ATUAL
Console.WriteLine("Adicionando valores específicos a variável ATUAL:");
Console.WriteLine("+1 Ano: " +Atual.AddYears(1));
Console.WriteLine("+20 Minutos: " +Atual.AddMinutes(20));
Console.WriteLine("+2 Dias: " +Atual.AddDays(2));
Console.WriteLine("+15 Segundos: " +Atual.AddSeconds(15));
Console.WriteLine("+2 Horas: " +Atual.AddHours(2));
Console.ReadLine();

// Data no formato longo e curto
Console.WriteLine("Data no formato LONGO e CURTO:");
Console.WriteLine(Atual.ToLongDateString());
Console.WriteLine(Atual.ToShortDateString());

// Separando os textos
Console.WriteLine();

// Hora no fomato longo e curto
Console.WriteLine("Hora no formato LONGO e CURTO:");
Console.WriteLine(Atual.ToLongTimeString());
Console.WriteLine(Atual.ToShortTimeString());
