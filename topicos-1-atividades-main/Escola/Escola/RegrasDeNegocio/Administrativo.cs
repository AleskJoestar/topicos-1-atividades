using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.RegrasDeNegocio
{
    public class Administrativo : Funcionario
    {
        public string Setor { get; set; }

        public Administrativo(string nome, int idade, double salario, string setor)
        {
            Nome = nome;
            Idade = idade;
            Salario = salario;
            Setor = setor;
        }

        public override void CalcularSalario()
        {
            Salario += Salario * 0.05;

        }
    }
}
