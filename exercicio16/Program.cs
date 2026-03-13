//Faça um algoritmo para receber um número qualquer e informar na tela 
//se é par ou ímpar.

Console.Write("Digite um número qualquer: ");
double numero = Convert.ToDouble(Console.ReadLine());

if (numero % 2 == 0)
    Console.WriteLine("O número é par");

else 
    Console.WriteLine("Número não é par");