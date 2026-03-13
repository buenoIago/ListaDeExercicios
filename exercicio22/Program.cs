//Escreva um programa que leia um número e imprima a sequência de 
//Fibonacci até esse número.

Console.Write("Informe um número: ");
int numero = Convert.ToInt32(Console.ReadLine());

int a = 0;
int b = 1;

Console.WriteLine("Sequência de Fibonacci: ");

for( int i = 0; i < numero; i++)
{
    Console.Write(a + " ");

    int proximo = a + b;
    a = b;
    b = proximo;        
}

Console.ReadLine();