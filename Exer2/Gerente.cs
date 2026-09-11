using Herança.Exer2;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca.Exer2
{
    internal class Gerente : Funcionario
    {
        public double Bonus { get; set; }
        public Gerente(string nome, double bonus) : base(nome)
        {
            Bonus = bonus;
        }
        public override double CalcularBonusAnual()
        {
            return (Salario * 0.15) + Bonus;
        }
    }
}
