internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello and welcome to the temperature converter app!");
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("\n(\"1\" for Celsius to Fahrenheit, \"2\" for Fahrenheit to Celsius)");
        Console.Write("Please select an option: ");
        var conversionType = Console.ReadLine();

        while (1 == 1)
        {
            if (conversionType == "1")
            {
                Console.Write("\nPlease enter a vlaue to convert from celsius to fahrenheit: ");
                var value = Console.ReadLine();

                bool tryParse = Double.TryParse(value, out double newValue);

                if (tryParse)
                {
                    CelciusToFahrenheit(newValue);
                    break;
                }

                else
                {
                    Console.WriteLine("\nPlease enter a valid temperature.");
                    continue;
                }
            }

            else if (conversionType == "2")
            {
                Console.Write("\nPlease enter a vlaue to convert from fahrenheit to celsius: ");
                var value = Console.ReadLine();

                bool tryParse = Double.TryParse(value, out double newValue);

                if (tryParse)
                {
                    FahrenheitToCelcius(newValue);
                    break;
                }

                else
                {
                    Console.WriteLine("\nPlease enter a valid temperature.");
                    continue;
                }
            }

            else
            {
                Console.WriteLine("\nPlease enter a valid option.");
                continue;
            }
        }
    }

    public static void CelciusToFahrenheit(double value)
    {
        double fahrenheit = (value * 1.8) + 32;
        Console.WriteLine($"\n{value} degrees celsius is equal to {fahrenheit} degrees fahrenheit.");
    }

    public static void FahrenheitToCelcius(double value)
    {
        double celsius = (value - 32) * 0.5556;
        Console.WriteLine($"\n{value} degrees fahrenheit is equal to {celsius} degrees celsius.");
    }
}
