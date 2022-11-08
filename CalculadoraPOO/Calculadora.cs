using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPOO
{
    internal class Calculadora
    {
        public double Valor1 { get; set; }
        public double Valor2 { get; set; }      

        public double Somar(double v1, double v2)
        {            
            return Valor1 + Valor2;
        }

        public double Subtrair(double v1, double v2)
        {
            return Valor1 - Valor2;
        }

        public double Multiplicacao(double v1, double v2)
        {
            return Valor1 * Valor2;
        }
        public double Divisao(double v1, double v2)
        {
            return Valor1 / Valor2;
        }


    }
}
