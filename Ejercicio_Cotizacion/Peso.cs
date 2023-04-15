using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Ejercicio_Cotizacion
{
    internal class Peso
    {
        private double _cantidad;
        private static double _cotzRespectoDolar;

        static Peso()
        {
            _cotzRespectoDolar = 102.65;
        }

        public Peso(double cantidad, double cotizacion):this(cantidad)
        {
            _cotzRespectoDolar = cotizacion;
        }

        public Peso(double cantidad)
        {
            _cantidad = cantidad;
        }

        public double PesoADolar()
        {
            double resultado;

            resultado = _cantidad * _cotzRespectoDolar;

            return resultado;
        }

        public static bool operator ==(Peso p1, Peso p2)
        {
            bool result = false;

            if (p1._cantidad == p2._cantidad)
            {
                result = true;
            }

            return result;
        }

        public static bool operator !=(Peso p1, Peso p2)
        {
            return !(p1._cantidad == p2._cantidad);
        }

    }
}
