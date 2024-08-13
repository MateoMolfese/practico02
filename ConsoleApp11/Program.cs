namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("clasificador de triangulos");
            Console.WriteLine("ingrese las longitudes de los tres lados del triangulo:");

            Console.Write("lado 1: ");
            double lado1=Convert.ToDouble(Console.ReadLine());
            Console.Write("lado 2: ");
            double lado2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("lado 3: ");
            double lado3 = Convert.ToDouble(Console.ReadLine());

            if (esTriangulo(lado1, lado2, lado3))
            {
                if (lado1 == lado2 && lado2 == lado3) 
                {
                    Console.WriteLine("es un trianguo equilatero");
                }
                else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                {
                    Console.WriteLine("es un triangulo isoceles");
                }
                else
                {
                    Console.WriteLine("es un tringulo escaleno");
                }
            }
            else
            {
                Console.WriteLine("las longitudes de los lados no forman un triangulo valido");
            }

            static bool esTriangulo(double lado1, double lado2, double lado3)
            {
                return lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1;
            }
        }
    }
}
