namespace DesafioProjetoHospedagem.Models
{
	public class Reserva(int diasReservados)
	{
		public List<Pessoa> Hospedes { get; set; }
		public Suite Suite { get; set; }
		public int DiasReservados { get; set; } = diasReservados;

		public void CadastrarHospedes(List<Pessoa> hospedes)
		{
			bool temCapacidade = hospedes.Count <= Suite.Capacidade;

			if (!!temCapacidade) Hospedes = hospedes;
			if (!temCapacidade) throw new Exception($"\nA capacidade da Suíte {Suite.TipoSuite} é menor que o número de hóspedes recebido. \nCapacidade da Suíte: {Suite.Capacidade} \nNúmero de hóspedes: {hospedes.Count}");
		}

		public void CadastrarSuite(Suite suite)
		{
			Suite = suite;
		}

		public int ObterQuantidadeHospedes()
		{
			int quantidadeHospedes = Hospedes.Count;
			return quantidadeHospedes;
		}

		public decimal CalcularValorDiaria()
		{
			decimal valorDiaria = DiasReservados * Suite.ValorDiaria;
			decimal valor = valorDiaria;

			if (DiasReservados >= 10) valor *= 0.9M;
			return valor;
		}
	}
}