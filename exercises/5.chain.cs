
int Divide(int a, int b)
{
    try
    {
        return a / b;
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine("division attempted");
        throw new ArgumentException("denominator cannot be 0", ex);
    }
}

int ReadAndDivide()
{
    Console.Write("Numerator: ");
    int a = int.Parse(Console.ReadLine()!);
    Console.Write("Denominator: ");
    int b = int.Parse(Console.ReadLine()!);
    return Divide(a, b);

}

try
{
    Console.WriteLine(ReadAndDivide());
}
catch (ArgumentException e)
{
    Console.WriteLine(e.Message, e.InnerException.Message);
}