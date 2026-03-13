//Escrever um algoritmo que leia um valor para uma variável N de 1 
//a 10 e calcule a tabuada de N.

Console.Write("Informe um número de 1 a 10: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"{i} x {N} = {i * N}");
}

Console.ReadLine();