namespace Ejercicio_EnciendanMotores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AutoF1 autoUno = new AutoF1(1, "Ferrari");
            AutoF1 autoDos = new AutoF1(33, "Red Bull");
            AutoF1 autoTres = new AutoF1(7, "Mercedes Benz");
            AutoF1 autoCuatro = new AutoF1(18, "Alpine");
            AutoF1 autoCinco = new AutoF1(12, "Aston Martin");
            AutoF1 autoSeis = new AutoF1(4, "Ferrari");

            Competencia FormulaUno = new Competencia(10, 10);

            if(FormulaUno + autoUno)
            {
                Console.WriteLine(FormulaUno.MostrarDatos());
            }
            else
            {
                Console.WriteLine("No se pudo agregar el corredor a la competicion.");
            }

            if (FormulaUno + autoDos)
            {
                Console.WriteLine(FormulaUno.MostrarDatos());
            }
            else
            {
                Console.WriteLine("No se pudo agregar el corredor a la competicion.");
            }

            if(FormulaUno - autoUno)
            {
                Console.WriteLine(autoUno.MostrarDatos());
                Console.WriteLine($"Se elimino correctamente \n");
            }
            else
            {
                Console.WriteLine("No se pudo eliminar.");
            }

            if( FormulaUno == autoDos)
            {
                Console.WriteLine(autoDos.MostrarDatos());
                Console.WriteLine("Forma parte de la competicion. \n");
            }
            else
            {
                Console.WriteLine("No forma parte de la comepeticion. \n");
            }

            Console.WriteLine(FormulaUno.MostrarDatos());
        }
    }
}