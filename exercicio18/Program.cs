//Escrever um algoritmo que gera e escreve os números ímpares entre 100 e 200.

Console.WriteLine("Números de 100 a 200:"); 

while (true)
{
    for (int i = 100; i <= 200; i++)
    {
        Console.WriteLine($"{i}");
    }
    Console.ReadLine();
}