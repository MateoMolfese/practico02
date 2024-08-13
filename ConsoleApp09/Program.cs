namespace ConsoleApp09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bienvenido al juego'adivina el numero'!");
            Console.WriteLine("la consola ha elegido un número entre 1 y 100");

            Random random = new Random();
            int numeroSecreto = random.Next(1, 101);

            int intentos = 0;
            int intentoUsuario;

            do
            {
                Console.Write("ingrese un numero entre 1 y 100: ");
                while (!int.TryParse(Console.ReadLine(), out intentoUsuario))
                {
                    Console.Write("ingrese un numero valido entre 1 y 100: ");
                }

                intentos++;

                if (intentoUsuario < numeroSecreto)
                {
                    Console.WriteLine("demasiado bajo. intenta de nuevo");
                }
                else if (intentoUsuario > numeroSecreto)
                {
                    Console.WriteLine("demasiado alto. intenta de nuevo");
                }
                else
                {
                    Console.WriteLine($"¡felicidades! ¡has adivinado el numero secreto {numeroSecreto} en {intentos} intentos!");
                }
            } while (intentoUsuario != numeroSecreto);

        }
    }
}
