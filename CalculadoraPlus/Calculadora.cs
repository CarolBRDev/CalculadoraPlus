using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraPlus
{
    internal class Calculadora
    {
        public double Numero1 { get; set; }
        public double Numero2 { get; set; }

        public Calculadora ()
        {           
            //Numero1 = numero1;
            //Numero2 = numero2;            
        }


        public double Adicao (double numero1, double numero2)
        {
            return numero1 + numero2;
        }

        public double Subtracao(double numero1, double numero2)
        {
            return numero1 - numero2;
        }

        public double Divisao(double numero1, double numero2)
        {
            return numero1 / numero2;
        }

        public double Multiplicacao(double numero1, double numero2)
        {
            return numero1 * numero2;
        }
    }
}
