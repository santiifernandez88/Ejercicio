using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Cotizacion
{
    internal class Dolar
    {
        private double _cantidad;
        private static double _cotzRespectoDolar;

        public static double Cotizacion { get { return _cotzRespectoDolar; } }
        public double Cantidad{ get { return _cantidad; }}

        static Dolar()
        {
            _cotzRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            _cantidad = cantidad;
        }

        public static bool operator ==(Dolar d1, Dolar d2)
        {
            bool result = false;

            if (d1._cantidad == d2._cantidad)
            {
                result = true;
            }

            return result;
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1._cantidad == d2._cantidad);
        }
    }
}
