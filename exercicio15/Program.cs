//O IMC – Índice de Massa Corporal é um critério da Organização Mundial de 
//Saúde para dar uma indicação sobre a condição de peso de uma pessoa adulta.
//A fórmula é IMC = peso / (altura) 2. Elabore um algoritmo que leia o
//peso e a altura de um adulto e mostre sua condição de acordo com a 
//listagem abaixo:
//● IMC em adultos Condição
//● Abaixo de 18,5
//● Abaixo do peso
//● Entre 18,5 e 25 Peso normal
//● Entre 25 e 30
//● Acima do peso
//● Acima de 30 obeso

Console.Write("IMC\nInforme o seu peso: ");
double peso = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe a sua altura: ");
double altura = Convert.ToDouble(Console.ReadLine());

double IMC = peso / (altura * altura);

Console.WriteLine($"Sua condição física de acordo com o IMC.\nSeu IMC é {IMC.ToString("f2")}");

if (IMC < 18.5)
{
    Console.WriteLine("Você está abaixo do peso.");
}

else if (IMC < 25)
{
    Console.WriteLine("Você está com o peso normal.");
}

else if (IMC < 30)
{
    Console.WriteLine("Você está acima do peso.");
}

else
{
    Console.WriteLine("Você está obeso.");
}

Console.ReadLine();