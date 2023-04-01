string nome, sobrenome;
Console.Write("Escreva seu primeiro nome___: ");
nome = Console.ReadLine()!;

Console.Write("Agora digite seu sobrenome___: ");
sobrenome = Console.ReadLine()!;

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"Nome completo: {nome} {sobrenome}");

Console.WriteLine($"Nome de catálogo: {sobrenome.ToUpper()}, {nome}");
Console.ForegroundColor = ConsoleColor.Cyan;

