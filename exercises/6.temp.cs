namespace temp;



class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter temp");

        try
        {
            double celcius = double.Parse(Console.ReadLine()!);
            double fahrenheit = ConvertToF(celcius);
            Console.WriteLine(fahrenheit);
        }
        catch (TemperatureException e)
        {
            Console.WriteLine($"temp error, {e.Message}");
            Console.WriteLine($"{e.AttemptedValue} is below absolute zero, minimum is -273.15 C");
        }
        catch (FormatException)
        {
            Console.WriteLine("invalid number");
        }
        static double ConvertToF(double celcius)
        {
            if (celcius < -273.15)
            {
                throw new TemperatureException($"{celcius} invalid, below absolute zero", celcius);
            }
            return (celcius *1.8) + 32;
        }
    }
}

class TemperatureException : Exception
{
    public double AttemptedValue {get;}
    public TemperatureException(string message, double value) : base(message)
    {
        AttemptedValue = value;
    }
    public TemperatureException(string message, double value, Exception inner) : base(message, inner)
    {
        AttemptedValue = value;
    }
}

public class InventoryException : Exception
{
    public InventoryException(string message) : base(message) {}
    public InventoryException(string message, Exception inner) : base(message,  inner) {}
}

public class ItemNotFoundExcpetion : InventoryException
{
    public ItemNotFoundExcpetion(string message) : base(message) {}
    public ItemNotFoundExcpetion(string message, Exception inner) : base(message,  inner) {}
}

public class InsufficientQuantitiyException : InventoryException
{
    public InsufficientQuantitiyException(string message) : base(message) {}
    public InsufficientQuantitiyException(string message, Exception inner) : base(message,  inner) {}
}

