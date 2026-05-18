string[] names = { "Alice", "Bob", "Charlie" };
Console.Write("Enter an index: ");
int i = int.Parse(Console.ReadLine()!);
try
{
Console.WriteLine(names[i]);
}
catch (IndexOutOfRangeException)
{
    Console.WriteLine("Enter an index between 0 and 2");
}
catch(FormatException)
{
    Console.WriteLine("enter in an integer");
}
