using System.Text;

namespace Ejercicio.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero: ");
            int numeroIngresado = int.Parse(Console.ReadLine());

            Console.WriteLine(ListarNumerosPrimos(numeroIngresado));     
        }

        public static string ListarNumerosPrimos(int hasta)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 2; i <= hasta; i++) 
            {
                if(EsPrimo(i))
                {
                    //sb.Append("{0}, ", i);
                    sb.Append($"{i}, ");
                }
            }

            return sb.ToString();
        }

        public static bool EsPrimo(int numeroTope)
        {
            for(int i = 2; i < numeroTope; i++)
            {
                if(numeroTope % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}