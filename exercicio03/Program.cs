//Crie um programa que calcule o consumo de combustível por quilômetro percorrido em uma viagem. O
//programa deve solicitar ao usuário:
//● A quilometragem inicial do veículo no início da viagem.
//● A quilometragem final ao término da viagem.
//● A quantidade de combustível consumida durante a viagem (em litros).

Console.Write("Digite a quilometragem inicial do veículo: ");
decimal kmInicial = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite a quilometragem final do veículo: ");
decimal kmFinal = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite a quantidade de combutível consumido (em litros): ");
decimal combustivelConsumido = Convert.ToDecimal(Console.ReadLine());

decimal distanciaPercorrida = kmFinal - kmInicial;

decimal consumoLitrosKM = distanciaPercorrida / combustivelConsumido;

Console.WriteLine($"O consumo de combustível durante o percurso foi de: {consumoLitrosKM}");

Console.ReadLine();