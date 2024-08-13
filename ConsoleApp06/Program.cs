using System.Threading.Channels;

namespace ConsoleApp06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int primerNumero, segundoNumero;

            Console.Write("ingrese el primer numero: ");
            if (!int.TryParse(Console.ReadLine(),out primerNumero)) 
            {
                Console.WriteLine("error: ingrese un numero valido para el primer numero");
                return;
            }
            Console.Write("ingrese el segundo numero: ");
            if (!int.TryParse(Console.ReadLine(), out segundoNumero))
            {
                Console.WriteLine("error: ingrese un numero valido para el segundo numero numero");
                return;
            }

            if (segundoNumero % primerNumero == 0)
            {
                Console.WriteLine("El segundo número es múltiplo del primero.");
            }
            else
            {
                Console.WriteLine("El segundo número NO es múltiplo del primero.");
            }
        }
    }
}
