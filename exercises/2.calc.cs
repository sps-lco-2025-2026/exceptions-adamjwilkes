Console.Write("Enter a number: ");

try
{
    int n = int.Parse(Console.ReadLine()!);
}
catch (FormatException)
{
    Console.WriteLine("enter a number");
}
try
{
    Console.WriteLine(100 / n);
}
catch(DivideByZeroException)
{
    Console.WriteLine("enter a non-zero number");
}



