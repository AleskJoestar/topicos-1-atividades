﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.RegrasDeNegocio
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Salario { get; set; }

        public abstract void CalcularSalario();
    }
}
