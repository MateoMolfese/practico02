using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Calculadora de BMI (Índice de Masa Corporal)");
        Console.WriteLine("--------------------------------------------");

        // Solicitar al usuario el peso en kilogramos
        Console.Write("Ingrese su peso en kilogramos: ");
        double peso;
        while (!double.TryParse(Console.ReadLine(), out peso) || peso <= 0)
        {
            Console.WriteLine("Ingrese un peso válido en kilogramos (mayor que 0).");
            Console.Write("Ingrese su peso en kilogramos: ");
        }

        // Solicitar al usuario la altura en metros
        Console.Write("Ingrese su altura en metros: ");
        double altura;
        while (!double.TryParse(Console.ReadLine(), out altura) || altura <= 0)
        {
            Console.WriteLine("Ingrese una altura válida en metros (mayor que 0).");
            Console.Write("Ingrese su altura en metros: ");
        }

        // Calcular el BMI
        double bmi = peso / (altura * altura);

        // Mostrar el BMI calculado
        Console.WriteLine($"\nSu BMI es: {bmi:F2}");

        // Determinar la categoría según el BMI
        if (bmi < 18.5)
        {
            Console.WriteLine("Estado ponderal: Bajo peso");
        }
        else if (bmi < 25)
        {
            Console.WriteLine("Estado ponderal: Peso normal");
        }
        else if (bmi < 30)
        {
            Console.WriteLine("Estado ponderal: Sobrepeso");
        }
        else
        {
            Console.WriteLine("Estado ponderal: Obeso");
        }

        Console.ReadLine(); // Para que la consola no se cierre inmediatamente
    }
}

