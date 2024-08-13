

namespace ConsoleApp01.consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("Ver Numero");
                Console.Write("ingrese un numero entero cualquiera (Ctrl+c para finalizar): ");
                var numeroIngresado = int.Parse(Console.ReadLine());
                if (esPositivo(numeroIngresado))
                {
                    Console.WriteLine($"el numero {numeroIngresado} es positivo");
                }
                else
                {
                    Console.WriteLine($"el numero {numeroIngresado} es negativo");
                }
                if (esPar(numeroIngresado))
                {
                    Console.WriteLine($"el numero {numeroIngresado} es par");
                }
                else
                {
                    Console.WriteLine($"el numero {numeroIngresado} es impar");
                }
                Thread.Sleep(2000);
            }
        }

        private static bool esPar(int nro)
        {
            return nro % 2 == 0;//% devuelve el resto de la division
        }

        private static bool esPositivo(int nro)
        {
            return nro >= 0;
        }
    }
}
