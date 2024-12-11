namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            
            // *IMPLEMENTADO !!!
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                // *IMPLEMENTADO !!!
                throw new Exception("Capacidade de hóspedes não suportada");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // *IMPLEMENTADO !!!
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // *IMPLEMENTADO !!!
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // *IMPLEMENTADO !!!
            if (DiasReservados >= 10)
            {
                valor = valor - (valor * 10 / 100 );
            }

            return valor;
        }
    }
}