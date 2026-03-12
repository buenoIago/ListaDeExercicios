//A padaria Hotpão vende uma certa quantidade de pães franceses e uma quantidade de broas a cada dia. Cada
//pãozinho custa R$ 0,12 e a broa custa R$ 1,50. Ao final do dia, o dono quer saber quanto arrecadou com a venda
//dos pães e broas (juntos), e quanto deve guardar numa conta de poupança (10% do total arrecadado). Você foi
//contratado para fazer os cálculos para o dono. Com base nestes fatos, faça um algoritmo para ler as quantidades
//de pães e de broas, e depois calcular os dados solicitados.

Console.Write("Informe a quantidade de pães franceses vendido no dia: ");
decimal qntdPao = Convert.ToDecimal(Console.ReadLine());

Console.Write("Informe a quantidade de broas vendido no dia: ");
decimal qntdBroas = Convert.ToDecimal(Console.ReadLine());

decimal valorPao = qntdPao * 0.12m;
decimal valorBroas = qntdBroas * 1.50m;

decimal valorArrecadado = valorPao + valorBroas;

decimal poupanca = valorArrecadado * 0.10m;

Console.WriteLine($"O valor arrecadado com a vendas dos pães e das broas foi: R${valorArrecadado}");
Console.WriteLine($"Deve ser guardado na poupança 10% do valor arrecadado, isto é: R${poupanca.ToString("f2")}");

Console.ReadLine();