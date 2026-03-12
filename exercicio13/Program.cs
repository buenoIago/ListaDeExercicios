//Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é 
//menor que C.

Console.Write("Informe o valor de A: ");
decimal valorA = Convert.ToDecimal(Console.ReadLine());

Console.Write("Informe o valor de B: ");
decimal valorB = Convert.ToDecimal(Console.ReadLine());

Console.Write("Informe o valor de C: ");
decimal valorC = Convert.ToDecimal(Console.ReadLine());

decimal soma = valorA + valorB;

if (soma < valorC)
{
    Console.Write("A soma de A + B é menor que C.");
}
else 
 Console.WriteLine("Encerrando o programa...");
 
Console.ReadLine();
