//Crie um programa para verificar se um número é primo.

Console.WriteLine("VERFICICAÇÃO DE NÚMERO PRIMO\nDigite um número: ");
int numero = Convert.ToInt32(Console.ReadLine());

bool primo = true;

for (int i = 2; i < numero; i++)
{
    if (numero % i == 0)
    primo = false;
}
if (primo)
   Console.WriteLine($"{numero} é um número primo");
else
   Console.WriteLine($"{numero} não é um número primo");

Console.ReadLine();