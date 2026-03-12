//Crie um programa para calcular a média ponderada 
//de duas provas realizadas por um aluno.

using System.Diagnostics.CodeAnalysis;

Console.Write("Digite a primeira nota: ");
decimal n1 = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite o peso da Primeira nota: ");
decimal p1 = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite a segunda nota: ");
decimal n2 = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite o peso da segunda nota: ");
decimal p2 = Convert.ToDecimal(Console.ReadLine());

decimal mediaPonderada = ((n1 * p1) + (n2 * p2)) / (p1 + p2);

Console.WriteLine($"A média ponderada é {mediaPonderada.ToString("F2")}");

Console.ReadLine();
