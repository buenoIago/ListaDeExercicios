//Escreva um algoritmo que leia um valor inicial A e imprima a 
//sequência de valores do cálculo de A! e o seu resultado.

Console.Write("Informe um número: ");
int A = Convert.ToInt32(Console.ReadLine());

int fatorial = 1;

for (int i = 1; i <= A; i++)
{
    fatorial = fatorial * i;
}

Console.Write($"O fatorial de {A}! é: {fatorial}");

Console.ReadLine();