//Crie um programa para calcular a média harmônica 
//das notas de um Aluno.

using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Digite a primeira nota: ");
decimal n1 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a segunda nota: ");
decimal n2 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a terceira nota: ");
decimal n3 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a quarta nota: ");
decimal n4 = Convert.ToDecimal(Console.ReadLine());

decimal mediaHarmonica = 4 / ((1.0m / n1) + (1.0m / n2) + (1.0m / n3) + (1.0m / n4));

Console.WriteLine($"A média harmônica é {mediaHarmonica.ToString("F2")}");

Console.ReadLine();