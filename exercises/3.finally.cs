// exercise 3
Console.WriteLine("enter a number");
string input = Console.ReadLine();

try
{
    bool parity = Math.Abs(int.Parse(input)) % 2 == 0;
    if (parity == true) {Console.WriteLine("even");}
    else{Console.WriteLine("odd");}
    
}
catch (FormatException)
{
    Console.WriteLine("enter a number");
}
finally
{
    Console.WriteLine("thank you for using the program");
}