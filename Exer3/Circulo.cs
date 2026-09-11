using System;
using System.Collections.Generic;
using System.Text;

namespace Herança.Exer3
{
    internal class Circulo : FormaGeometrica
    {
        public double Raio { get; set; }

        public override double CalcularArea()
        {
            return Raio*Raio * Math.PI;
        }
    }
}
