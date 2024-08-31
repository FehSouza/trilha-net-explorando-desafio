using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = [];

Pessoa p1 = new(nome: "Hóspede 1");
Pessoa p2 = new(nome: "Hóspede 2");
Pessoa p3 = new(nome: "Hóspede 3");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);

// Cria a suíte
Suite suite = new(tipoSuite: "Premium", capacidade: 3, valorDiaria: 300);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new(diasReservados: 1);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);
string desconto = reserva.DiasReservados >= 10 ? "(com desconto de 10%)" : "(sem desconto)";

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Número de hóspedes na Suíte {suite.TipoSuite}: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor da diária: {suite.ValorDiaria.ToString("C")}");
Console.WriteLine($"Tempo da hospedagem: {reserva.DiasReservados}");
Console.WriteLine($"Valor total da hospedagem: {reserva.CalcularValorDiaria().ToString("C")} {desconto}");