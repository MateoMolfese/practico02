namespace ConsoleApp01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Ver Número");
                Console.Write("Ingrese un número entero cualquiera (Ctrl+C para finalizar):");
                var numeroIngresado = int.Parse(Console.ReadLine());
                if (EsPositivo(numeroIngresado))
                {
                    Console.WriteLine($"El número {numeroIngresado} es positivo");
                }
                else
                {
                    Console.WriteLine($"El número {numeroIngresado} es negativo");

                }
                if (EsPar(numeroIngresado))
                {
                    Console.WriteLine($"El número {numeroIngresado} es par");
                }
                else
                {
                    Console.WriteLine($"El número {numeroIngresado} es impar");

                }
                Thread.Sleep(2000);
            }
        }

        private static bool EsPar(int nro)
        {
            return nro % 2 == 0;//% devuelve el resto de la división
        }

        private static bool EsPositivo(int nro)
        {
            return nro >= 0;
        }
    }
}