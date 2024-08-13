namespace ConsoleApp15.Consola
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al verificador y calculador de áreas de triángulos!");

            // Solicitar al usuario que ingrese las longitudes de los lados del triángulo
            Console.Write("Ingrese la longitud del lado a: ");
            if (!double.TryParse(Console.ReadLine(), out var a) ||
                (a < 0))
            {
                Console.WriteLine("Lado a no válido");
                return;
            }
            Console.Write("Ingrese la longitud del lado b: ");

            if (!double.TryParse(Console.ReadLine(), out var b) ||
                (b < 0))
            {
                Console.WriteLine("Lado b no válido");
                return;
            }

            Console.Write("Ingrese la longitud del lado c: ");
            if (!double.TryParse(Console.ReadLine(), out var c) ||
                (c < 0))
            {
                Console.WriteLine("Lado c no válido");
                return;
            }

            // Calcular el semiperímetro
            double p = CalcularSemiperimetro(a, b, c);

            // Verificar si los lados pueden formar un triángulo
            if (VerificarTriangulo(a, b, c, p))
            {
                // Calcular el área utilizando la fórmula de Herón
                double area = CalcularArea(a, b, c, p);
                Console.WriteLine($"Los lados ingresados pueden formar un triángulo.");
                Console.WriteLine($"El área del triángulo es: {area:F2}");
            }
            else
            {
                Console.WriteLine("Los lados ingresados no pueden formar un triángulo.");
            }

            // Esperar a que el usuario presione una tecla para cerrar la aplicación
            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }

        private static double CalcularArea(double a, double b, double c, double p)
        {
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        private static bool VerificarTriangulo(double a, double b, double c, double p)
        {
            return p > a && p > b && p > c;
        }

        private static double CalcularSemiperimetro(double a, double b, double c)
        {
            return (a + b + c) / 2;
        }
    }
}