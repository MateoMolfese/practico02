namespace ConsoleApp07.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el primer número:");
            if (!int.TryParse(Console.ReadLine(), out int numero1))
            {
                Console.WriteLine("Número 1 mal ingresado");
                return;
            }
            Console.Write("Ingrese el segundo número:");
            if (!int.TryParse(Console.ReadLine(), out int numero2))
            {
                Console.WriteLine("Número 2 mal ingresado");
                return;
            }
            Console.Write("Ingrese el tercer número:");
            if (!int.TryParse(Console.ReadLine(), out int numero3))
            {
                Console.WriteLine("Número 3 mal ingresado");
                return;
            }
            if (!SonDistintos(numero1, numero2, numero3))
            {
                Console.WriteLine("No se puede trabajar hay números iguales");
                return;
            }
            int mayor = Math.Max(numero1, numero2);
            mayor = Math.Max(numero3, mayor);

            int menor = Math.Min(numero1, numero2);
            menor = Math.Min(numero3, menor);
            Console.WriteLine(menor);
            Console.WriteLine(mayor);
        }

        private static bool SonDistintos(int numero1, int numero2,
            int numero3)
        {
            return numero1 != numero2 &&
                numero1 != numero3 &&
                numero2 != numero3;
        }
    }
}
