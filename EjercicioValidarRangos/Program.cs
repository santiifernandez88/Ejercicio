namespace EjercicioValidarRangos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int acumulador = 0;
            int contador = 0;
            int minimo = 0;
            int maximo = 0;
            float promedio;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                bool rtaParse = int.TryParse(Console.ReadLine(), out numeroIngresado);
                if (Validar(numeroIngresado, -100, 100) == rtaParse)
                {
                    Console.WriteLine("Se ingreso el numero correctamente.");
                }
                else
                {
                    Console.WriteLine("Se ingreso el numero incorrectamente.");
                }

                acumulador += numeroIngresado;
                contador++;

                minimo = BuscarMinimo(numeroIngresado);
                maximo = BuscarMaximo(numeroIngresado);

            }

            promedio = (float)(acumulador/contador);

            Console.WriteLine($"El numero minimo ingresado es {minimo}, el maximo ingresado es {maximo} y el promedio es {promedio}");

        }

        public static int BuscarMinimo(int numero)
        {
            int minimo = 0;

            if(numero < minimo)
            {
                minimo = numero;
            }

            return minimo;
        }

        public static int BuscarMaximo(int numero)
        {
            int maximo = 0;

            if (numero > maximo)
            {
                maximo = numero;
            }

            return maximo;
        }

        public static bool Validar(int valor, int min, int max) 
        {
            while(valor < min && valor > max) 
            {
                return false;
            }

            return true;
        }
    }
}