namespace ConsoleApp14.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su dia de nacimiento:");
            if (!DateTime.TryParse(Console.ReadLine(), out DateTime fechaNacimiento))
            {
                Console.WriteLine("Fecha no válida");
                return;
            }
            if (fechaNacimiento < DateTime.Today.Date)
            {
                var edad = CalcularEdad(fechaNacimiento);
                Console.WriteLine($"Su edad es {edad}");

            }
            else
            {
                Console.WriteLine("Fecha ingresada superior a la actual!!!");
            }
        }
        private static int CalcularEdad(DateTime fechaNacimiento)
        {
            return (int)Math.Truncate(DateTime
                .Today.Subtract(fechaNacimiento)
                .TotalDays / 365.25);
        }
    }
}
