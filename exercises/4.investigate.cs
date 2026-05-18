// Snippet A
int[] arr = new int[3];
try
{
    arr[10] = 5;
}
catch (IndexOutOfRangeException)
{
    Console.WriteLine("index out of range");
}


// Snippet B
string s = null!;
try
{
Console.WriteLine(s.Length);
}
catch (NullReferenceException)
{
    Console.WriteLine("null error");
}
// Snippet C
int x = int.MaxValue;
try
{
    checked { x = x + 1; }
}
catch (OverflowException)
{
    Console.WriteLine("overflow error");
}