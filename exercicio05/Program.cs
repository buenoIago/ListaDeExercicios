//Crie um programa para calcular o salário total de um vendedor. //Deverá ser informado 
//o salário base e o total de vendas.
//A comissão é calculada com um percentual (informado pelo usuário) sobre o total de 
//vendas.

Console.Write("Digite o salário base: ");
decimal salarioBase = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite a quantidade de vendas: ");
decimal totalVendas = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite o percentual de comissão: ");
decimal percentual = Convert.ToDecimal(Console.ReadLine());

decimal comissao = totalVendas * (percentual / 100);

decimal salarioTotal = salarioBase + comissao;

Console.Write($"A comisssão é {comissao}.O total do salário do mês é : {salarioTotal}");

Console.ReadLine();