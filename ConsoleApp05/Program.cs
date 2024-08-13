namespace ConsoleApp05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la medida:");
            double medida = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la escala (C para centímetros, P para pulgadas):");
            char escalaChar = char.ToUpper(Console.ReadKey().KeyChar);

            double resultado;

            if (escalaChar == 'C')
            {
                resultado = CentimetrosAPulgadas(medida);
                Console.WriteLine($"\n{medida} centímetros son equivalentes a {resultado} pulgadas.");
            }
            else if (escalaChar == 'P')
            {
                resultado = PulgadasACentimetros(medida);
                Console.WriteLine($"\n{medida} pulgadas son equivalentes a {resultado} centímetros.");
            }
            else
            {
                Console.WriteLine("\nEscala no válida. Por favor, ingrese 'C' o 'P'.");
            }
        }

        static double CentimetrosAPulgadas(double centimetros)
        {
            return centimetros * 0.39370;
        }

        static double PulgadasACentimetros(double pulgadas)
        {
            return pulgadas / 0.39370;
        }
    }
}