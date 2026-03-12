//Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit

Console.Write("Digite a temperatura em graus Celsius: ");
decimal grausCelsius = Convert.ToDecimal(Console.ReadLine());

decimal conversao = 1.8m * grausCelsius + 32;

Console.WriteLine($"{grausCelsius} °C convertido para Fahrenheit é {conversao} °F.");