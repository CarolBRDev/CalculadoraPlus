using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraPlus
{
    internal class CalculadoraCientifica : Calculadora
    {

        

        public CalculadoraCientifica(double numero1) { }

        public double RaizQuadrada(double numero1)
        {
            return Math.Sqrt(numero1);
        }
    }
}
