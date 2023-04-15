using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_EnciendanMotores
{
    internal class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;
        
        

        private Competencia()
        {
            List<AutoF1> competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores):this ()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }

        public static bool operator ==(Competencia c, AutoF1 a)
        {
            bool result = false;

            foreach (AutoF1 auto in c.competidores)
            {
                if (auto == a)
                {
                    result = true;
                }
            }

            return result;
        }

        public static bool operator !=(Competencia c, AutoF1 a)
        {
            bool result = false;

            foreach(AutoF1 auto in c.competidores)
            {
                if (auto != a)
                {
                    result = true;
                }
            }

            return result;
        }
        public static bool operator +(Competencia c, AutoF1 a)
        {
            bool result = false;

            foreach(AutoF1 auto in c.competidores)
            {
                if (c.competidores.Count <= c.cantidadCompetidores && auto != a)
                {
                    c.competidores.Add(a);
                    a.VueltasRestantes = c.cantidadVueltas;
                    a.EnCompetencia = true;
                    Random numeroRandom = new Random();
                    a.CantidadCombustible = (short)numeroRandom.Next(15, 100);
                    result = true;
                }
            }

            return result;
        }
        
        public static bool operator -(Competencia c, AutoF1 a)
        {
            bool result = false;

            foreach(AutoF1 auto in c.competidores)
            {
                if(auto == a)
                {
                    c.competidores.Remove(a);
                    a.VueltasRestantes = 0;
                    a.EnCompetencia = false;
                    a.CantidadCombustible = 0;
                    result = true;
                }
            }

            return result;
        }



    }
}
