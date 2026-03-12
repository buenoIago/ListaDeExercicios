//Escreva um algoritmo que leia três valores inteiros e diferentes e mostre-os em 
//ordem decrescente.

while (true)
{

    Console.WriteLine("Informe o primeiro número inteiro: ");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Informe o segundo número inteiro: ");
    int b = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Informe o terceiro número inteiro: ");
    int c = Convert.ToInt32(Console.ReadLine());

    if (a > b && a > c)
    {
    if (b > c)
        {
            Console.WriteLine($"Os números em ordem decrescente são: {a}, {b}, {c}");
            continue;
        }    
    else
        {
            Console.WriteLine($"Os números em ordem decrescente são: {b}, {c}, {a}");
            continue;
        }    
    }

    else if (b > a && b > c)
    {
    if (a > c)
        {
            Console.WriteLine($"Os números em ordem decrescente são: {b}, {a}, {c}");
            continue;
        }    
    else
        {
            Console.WriteLine($"Os números em ordem decrescente são: {b}, {c}, {a}");
            continue;
        }   
    }

    else
    {
    if (a > b)
        {
            Console.WriteLine($"Os números em ordem decrescente são: {c}, {a}, {b}");
            continue;
        }
        else
        {
            Console.WriteLine($"Os números em ordem decrescente são: {c}, {b}, {a}");
            continue;
        }  
    }
}