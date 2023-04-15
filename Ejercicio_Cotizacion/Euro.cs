using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Cotizacion
{
    internal class Euro
    {
        private double _cantidad;
        private static double _cotzRespectoDolar;

        static Euro()
        {
            _cotzRespectoDolar = 1.17;
        }

        public Euro(double cantidad, double cotizacion):this(cantidad)
        {
            _cotzRespectoDolar = cotizacion;
        }

        public Euro(double cantidad)
        {
            _cantidad = cantidad;
            
        }

        public double EuroADolar()
        {
            double resultado;
            resultado = _cantidad * _cotzRespectoDolar;

            return resultado;
        }

        public static bool operator ==(Euro e1, Euro e2)
        {
            bool result = false;

            if(e1._cantidad == e2._cantidad)
            {
                result = true;
            }

            return result;
        }

        public static bool operator !=(Euro e1, Euro e2) 
        {
            return !(e1._cantidad == e2._cantidad);   
        }



    }
}
