namespace ConsoleApp12.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anio = 0;
            Console.Write("Ingrese un año cualquiera:");
            if (!int.TryParse(Console.ReadLine(), out anio))
            {
                Console.WriteLine("Año mal ingresado!!!");
                return;
            }
            if (!EsValido(anio))
            {
                MostrarInformacion(anio);
            }
        }
        /*
         * Método que realiza tareas y no devuelve ningun resultado
         */
        private static void MostrarInformacion(int anio)
        {
            var anioActual = DateTime.Today.Year;
            if (!EsBisiesto(anio))
            {
                if (anio < anioActual)
                {
                    Console.WriteLine($"{anio} no fue bisiesto");
                }
                else if (anio > anioActual)
                {
                    Console.WriteLine($"{anio} no será bisiesto");
                }
                else
                {
                    Console.WriteLine($"{anio} no es bisiesto");
                }
            }
            else
            {
                if (anio < anioActual)
                {
                    Console.WriteLine($"{anio} fue bisiesto");
                }
                else if (anio > anioActual)
                {
                    Console.WriteLine($"{anio} será bisiesto");
                }
                else
                {
                    Console.WriteLine($"{anio} es bisiesto");
                }

            }
        }

        private static bool EsBisiesto(int anio)
        {
            /*
             * El método IsLeapYear devuelve true si es bisiesto
             * caso contrario devuelve false
             */
            return DateTime.IsLeapYear(anio);
        }

        private static bool EsValido(int anio)
        {
            /*
             * DateTime tipo de dato que trabaja con fechas y horas
             * El método Today devuelve la fecha del sistema
             * Year, devuelve el año de la fecha en cuestión
             */
            return anio > 0 && anio < DateTime.Today.Year;
        }
    }
}
