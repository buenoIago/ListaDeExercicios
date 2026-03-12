//1. Crie um programa para calcular o volume de uma caixa retangular
//multiplique o comprimento x largura x altura (ou profundidade)

Console.WriteLine("Digite o comprimento da caixa: ");
decimal comprimento = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a largura da caixa: ");
decimal largura = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a altura da caixa: ");
decimal altura = Convert.ToInt32(Console.ReadLine());

decimal volume = comprimento * largura * altura;

Console.WriteLine($"O volume da caixa retangular é {volume}.");