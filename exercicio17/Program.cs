//Faça um algoritmo que leia dois valores inteiros A e B, se os valores 
//forem iguais deverá se somar os dois, caso contrário multiplique A por B.
//Ao final de qualquer um dos cálculos deve-se atribuir o resultado para 
//uma variável C e mostrar seu conteúdo na tela.

Console.Write("Informe um número: ");
double A = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe um segundo número: ");
double B = Convert.ToDouble(Console.ReadLine());

double C;

if (A == B)
{
    C = A + B;
}
else
{
    C = A * B;
}

Console.WriteLine($"Resultado da variável C: {C}");

Console.ReadLine();