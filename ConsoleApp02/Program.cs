namespace ConsoleApp02
{
    internal class Program
    {
        static bool EsOrigenDeCoordenadas(int x, int y)
        {
            return x == 0 && y == 0;
        }

        static int InformarCuadrante(int x, int y)
        {
            if (x >= 0 && y >= 0)
                return 1;
            else if (x >= 0 && y < 0)
                return 2;
            else if (x <= 0 && y <= 0)
                return 3;
            else
                return 4;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese las coordenadas del punto:");
            Console.Write("Coordenada X: ");
            int coordX = Convert.ToInt32(Console.ReadLine());
            Console.Write("Coordenada Y: ");
            int coordY = Convert.ToInt32(Console.ReadLine());

            if (!EsOrigenDeCoordenadas(coordX, coordY))
            {
                Console.WriteLine($"({coordX},{coordY}) se encuentra en cuadrante {InformarCuadrante(coordX, coordY)}.");
            }
            else
            {
                Console.WriteLine($"({coordX},{coordY}) es el origen de coordenadas.");
            }
        }
    }
}
