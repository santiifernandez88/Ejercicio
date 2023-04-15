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

        #region Constructores
        private Competencia()
        {
            this.competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores):this ()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }
        #endregion

        #region Metodos
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("--------COMPETENCIA------");
            sb.AppendLine("COMPETIDORES: " + this.cantidadCompetidores);
            foreach (AutoF1 auto in this.competidores)
            {
                sb.AppendLine("----------------------");
                sb.AppendLine(auto.MostrarDatos());
                sb.AppendLine("----------------------");

            }
            return sb.ToString();


        }

        #region Sobrecargas de operadores
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
            return !(c == a);
        }
        public static bool operator +(Competencia c, AutoF1 a)
        {
            bool result = false;
           
            if (c.competidores.Count < c.cantidadCompetidores && c != a)
            {
                c.competidores.Add(a);
                a.VueltasRestantes = c.cantidadVueltas;
                a.EnCompetencia = true;
                Random numeroRandom = new Random();
                a.CantidadCombustible = (short)numeroRandom.Next(15, 100);
                result = true;
            }
          
            return result;
        }
        
        public static bool operator -(Competencia c, AutoF1 a)
        {
            bool result = false;

            if(c == a)
            {
                c.competidores.Remove(a);
                result = true;
            }
            
            return result;
        }
        #endregion

        #endregion
    }
}
