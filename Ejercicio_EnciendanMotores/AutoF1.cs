using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_EnciendanMotores
{
    internal class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        #region Propiedades

        public short CantidadCombustible
        { 
            get
            {
                return cantidadCombustible;
            }
            
            set
            {
                cantidadCombustible = value;
            }
        
        }
        
        public bool EnCompetencia
        { 
            get
            {
                return enCompetencia;
            }
            
            set
            {
                enCompetencia = value;
            }
        }

        public short VueltasRestantes 
        { 
            get
            {
                return vueltasRestantes;
            }
            
            set
            {
                vueltasRestantes = value;
            }
        }
        #endregion

        #region Constructor
        public AutoF1(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
        }
        #endregion

        #region Metodos
        public string MostrarDatos()
        {
            return $"ESCUDERIA: {this.escuderia} || NUMERO {this.numero} || COMPETENCIA {this.EnCompetencia} || VUELTAS RESTANTES {this.VueltasRestantes} || CANTIDAD DE COMBUSTIBLE {this.CantidadCombustible}";
        }

        #region Sobrecargas de operadores
        public static bool operator ==(AutoF1 a, AutoF1 b)
        { 
            bool resultado = false;

            if(a.numero == b.numero && a.escuderia == b.escuderia)
            {
                resultado = true;
            }

            return resultado;
        }

        public static bool operator !=(AutoF1 a, AutoF1 b)
        {
            return !(a == b);
        }
        #endregion

        #endregion
    }
}
