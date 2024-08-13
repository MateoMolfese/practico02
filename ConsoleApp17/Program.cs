namespace ConsoleApp16.Consola
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la calculadora de días de la semana!");
            Console.WriteLine("Por favor, ingrese un número del 1 al 7 para obtener el día correspondiente.");

            // Solicitar al usuario que ingrese un número del 1 al 7
            Console.Write("Ingrese un número del 1 al 7: ");
            if (!int.TryParse(Console.ReadLine(), out var numeroDia) ||
                (numeroDia < 1 || numeroDia > 7))
            {
                Console.WriteLine("Número no válido");
                return;
            }


            string dia;

            // Determinar el día de la semana correspondiente al número ingresado
            switch (numeroDia)
            {
                case 1:
                    dia = "Lunes";
                    break;
                case 2:
                    dia = "Martes";
                    break;
                case 3:
                    dia = "Miércoles";
                    break;
                case 4:
                    dia = "Jueves";
                    break;
                case 5:
                    dia = "Viernes";
                    break;
                case 6:
                    dia = "Sábado";
                    break;
                case 7:
                    dia = "Domingo";
                    break;
                default:
                    dia = "Número inválido. Por favor, ingrese un número del 1 al 7.";
                    break;
            }

            // Mostrar el día de la semana correspondiente
            Console.WriteLine($"El día correspondiente al número {numeroDia} es: {dia}");

            // Esperar a que el usuario presione una tecla para cerrar la aplicación
            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }

}
