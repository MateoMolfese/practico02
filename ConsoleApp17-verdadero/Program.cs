namespace ConsoleApp17.Consola
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al verificador de contraseñas!");
            Console.Write("Por favor, ingrese una contraseña: ");
            string? contrasenia = Console.ReadLine();

            if (contrasenia?.Length < 8)
            {
                Console.WriteLine("La contraseña es demasiado corta. Debe tener al menos 8 caracteres.");
            }
            else if (!ContieneNumero(contrasenia))
            {
                Console.WriteLine("La contraseña debe incluir al menos un número.");
            }
            else
            {
                Console.WriteLine("La contraseña es válida.");
            }

            // Esperar a que el usuario presione una tecla para cerrar la aplicación
            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }

        static bool ContieneNumero(string? texto)
        {
            return texto?.Any(char.IsDigit) ?? false;
        }
    }
}