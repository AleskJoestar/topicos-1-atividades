using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.RegrasDeNegocio
{
    public class Professor : Funcionario
    {
        public string Disciplina { get; set; }

        public Professor(string nome, int idade, double salario, string disciplina) 
        { 
            Nome = nome;
            Idade = idade;
            Salario = salario;
            Disciplina = disciplina;    
        }

        public override void CalcularSalario()
        {
            Salario += Salario * 0.1;

        }

    }
}
