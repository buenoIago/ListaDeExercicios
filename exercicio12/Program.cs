//Faça um algoritmo para ler o salário de um funcionário e aumentá-lo em 15%. Após o 
//aumento, desconte 8% de impostos. Imprima o salário inicial, o salário com o aumento 
//e o salário final.

Console.Write("Informe seu salario: ");
decimal salarioBase = Convert.ToDecimal(Console.ReadLine());

decimal aumento = salarioBase * 0.15m;
decimal salarioComAumento = salarioBase + aumento;

decimal desconto = salarioComAumento * 0.08m;

Console.WriteLine($"Seu salário inicial é: {salarioBase}");
Console.WriteLine($"Seu salário após o aumento é: {salarioComAumento}");
Console.WriteLine($"Seu salário com desconto é: {salarioComAumento - desconto}");

Console.ReadLine();