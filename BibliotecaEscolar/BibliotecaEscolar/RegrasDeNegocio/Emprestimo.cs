using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEscolar.RegrasDeNegocio
{
    internal class Emprestimo
    {
        public Usuario Usuario { get; set; }
        public Livro Livro { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucaoPrevista { get; set; }
        public DateTime? DataDevolucaoReal { get; set; } // Nullable DateTime

        public void RegistrarDevolucao(DateTime dataDevolucaoReal)
        {
            if (DataDevolucaoReal == null)
            {
                DataDevolucaoReal = dataDevolucaoReal;
                Console.WriteLine("Devolução registrada com sucesso.");
            }
            else
            {
                Console.WriteLine("Este empréstimo já foi devolvido anteriormente.");
            }
        }

        public decimal CalcularMulta()
        {
            if (DataDevolucaoReal.HasValue)
            {
                int diasAtraso = (int)(DataDevolucaoReal.Value - DataDevolucaoPrevista).TotalDays;
                if (diasAtraso > 0)
                {
                    // Implementar lógica para calcular a multa (exemplo: R$ 2,00 por dia de atraso)
                    decimal multa = diasAtraso * 2.00M;
                    Console.WriteLine($"Multa calculada: R$ {multa}");
                    return multa;
                }
            }

            Console.WriteLine("Sem multa, devolução dentro do prazo.");
            return 0; // Sem multa
        }
    }
}
