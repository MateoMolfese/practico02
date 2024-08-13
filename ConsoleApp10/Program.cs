using System;

class ConvertidorTemperaturas
{
    public static double CelsiusToFahrenheit(double celsius)
    {
        return 1.8 * celsius + 32;
    }

    public static double CelsiusToReaumur(double celsius)
    {
        return 0.8 * celsius;
    }

    public static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) / 1.8;
    }

    public static double ReaumurToCelsius(double reaumur)
    {
        return reaumur / 0.8;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido al convertidor de temperaturas!");
        Console.WriteLine("Por favor, elige la conversión que deseas realizar:");
        Console.WriteLine("1. Celsius a Fahrenheit");
        Console.WriteLine("2. Celsius a Reaumur");
        Console.WriteLine("3. Fahrenheit a Celsius");
        Console.WriteLine("4. Reaumur a Celsius");

        Console.Write("Ingresa el número de la conversión deseada (1/2/3/4): ");
        string opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                ConvertirCelsiusAFahrenheit();
                break;
            case "2":
                ConvertirCelsiusAReaumur();
                break;
            case "3":
                ConvertirFahrenheitACelsius();
                break;
            case "4":
                ConvertirReaumurACelsius();
                break;
            default:
                Console.WriteLine("Opción no válida. Por favor, ingresa un número válido.");
                break;
        }
    }

    static void ConvertirCelsiusAFahrenheit()
    {
        Console.Write("Ingresa la temperatura en grados Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());
        double resultado = ConvertidorTemperaturas.CelsiusToFahrenheit(celsius);
        Console.WriteLine($"{celsius} grados Celsius equivalen a {resultado} grados Fahrenheit.");
    }

    static void ConvertirCelsiusAReaumur()
    {
        Console.Write("Ingresa la temperatura en grados Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());
        double resultado = ConvertidorTemperaturas.CelsiusToReaumur(celsius);
        Console.WriteLine($"{celsius} grados Celsius equivalen a {resultado} grados Reaumur.");
    }

    static void ConvertirFahrenheitACelsius()
    {
        Console.Write("Ingresa la temperatura en grados Fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());
        double resultado = ConvertidorTemperaturas.FahrenheitToCelsius(fahrenheit);
        Console.WriteLine($"{fahrenheit} grados Fahrenheit equivalen a {resultado} grados Celsius.");
    }

    static void ConvertirReaumurACelsius()
    {
        Console.Write("Ingresa la temperatura en grados Reaumur: ");
        double reaumur = Convert.ToDouble(Console.ReadLine());
        double resultado = ConvertidorTemperaturas.ReaumurToCelsius(reaumur);
        Console.WriteLine($"{reaumur} grados Reaumur equivalen a {resultado} grados Celsius.");
    }
}