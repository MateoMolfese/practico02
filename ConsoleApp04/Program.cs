namespace ConsoleApp04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la temperatura:");
            double temperatura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la escala (C para Celsius, F para Fahrenheit):");
            char escalaChar = char.ToUpper(Console.ReadKey().KeyChar);

            double resultado;

            if (escalaChar == 'C')
            {
                resultado = CelsiusAFahrenheit(temperatura);
                Console.WriteLine($"\n{temperatura} grados Celsius son equivalentes a {resultado} grados Fahrenheit.");
            }
            else if (escalaChar == 'F')
            {
                resultado = FahrenheitACelsius(temperatura);
                Console.WriteLine($"\n{temperatura} grados Fahrenheit son equivalentes a {resultado} grados Celsius.");
            }
            else
            {
                Console.WriteLine("\nEscala no válida. Por favor, ingrese 'C' o 'F'.");
            }
        }

        static double CelsiusAFahrenheit(double celsius)
        {
            return 1.8 * celsius + 32;
        }

        static double FahrenheitACelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
