//2. Crie um programa para calcular o volume de um cilindro
// V = PI . r² . h

Console.WriteLine("Digite o raio do cilindro: ");
double raio = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a altura do cilindro: ");
double altura = Convert.ToInt32(Console.ReadLine());

//double areaBase = Math.PI * Math.Pow(raio, 2);

double areaBase = 3.14 * raio * raio;
double volume = areaBase * altura;

Console.WriteLine($"O volume do cilindro é: {volume} cm³");