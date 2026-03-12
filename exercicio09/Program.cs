//A imobiliária Imóbilis vende apenas terrenos retangulares. Faça um algoritmo 
//para ler as dimensões de um terreno e depois exibir a área do terreno.

using System.Formats.Asn1;

Console.Write("Informe o comprimento do terreno: ");
decimal comprimento = Convert.ToDecimal(Console.ReadLine());

Console.Write("Informe a largura do terreno: ");
decimal largura = Convert.ToDecimal(Console.ReadLine());

decimal area = comprimento * largura;

Console.WriteLine($"Á área do terreno é {area} m²");

Console.ReadLine();