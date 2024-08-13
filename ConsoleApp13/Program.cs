using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Verificación y clasificación de triángulos");
        Console.WriteLine("Ingresa las longitudes de los tres lados del triángulo:");

        // Solicitar y leer las longitudes de los lados
        Console.Write("Lado 1: ");
        double lado1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Lado 2: ");
        double lado2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Lado 3: ");
        double lado3 = Convert.ToDouble(Console.ReadLine());

        // Verificar si los lados forman un triángulo válido
        if (EsTriangulo(lado1, lado2, lado3))
        {
            // Determinar el tipo de triángulo
            if (EsTrianguloRectangulo(lado1, lado2, lado3))
            {
                Console.WriteLine("Es un triángulo rectángulo.");
            }
            else if (EsTrianguloObtusangulo(lado1, lado2, lado3))
            {
                Console.WriteLine("Es un triángulo obtusángulo.");
            }
            else
            {
                Console.WriteLine("Es un triángulo acutángulo.");
            }
        }
        else
        {
            Console.WriteLine("Las longitudes de los lados no forman un triángulo válido.");
        }
    }

    // Función para verificar si las longitudes de los lados forman un triángulo
    static bool EsTriangulo(double a, double b, double c)
    {
        // Verificar la desigualdad triangular
        return a + b > c && a + c > b && b + c > a;
    }

    // Función para verificar si un triángulo es rectángulo
    static bool EsTrianguloRectangulo(double a, double b, double c)
    {
        // Ordenar los lados de menor a mayor
        double[] lados = { a, b, c };
        Array.Sort(lados);

        // Aplicar el teorema de Pitágoras (lado más largo al cuadrado = suma de los otros dos al cuadrado)
        return Math.Pow(lados[2], 2) == Math.Pow(lados[0], 2) + Math.Pow(lados[1], 2);
    }

    // Función para verificar si un triángulo es obtusángulo
    static bool EsTrianguloObtusangulo(double a, double b, double c)
    {
        // Ordenar los lados de menor a mayor
        double[] lados = { a, b, c };
        Array.Sort(lados);

        // Aplicar el teorema de Pitágoras (lado más largo al cuadrado > suma de los otros dos al cuadrado)
        return Math.Pow(lados[2], 2) > Math.Pow(lados[0], 2) + Math.Pow(lados[1], 2);
    }
}