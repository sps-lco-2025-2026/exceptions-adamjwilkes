namespace inventory;
class Exercise7
{
    static Dictionary<string, int> itemcount;
    public static void Main(string[] args)
    {
        itemcount = new Dictionary<string, int>();
        Console.WriteLine("enter number of swords");
        string swords = Console.ReadLine();
        if (swords != "")
            {itemcount["sword"] = int.Parse(swords);}
        try {TakeSword(3);}
        catch (InventoryException ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
    static void TakeSword(int n)
    {
        bool exists = itemcount.TryGetValue("sword", out int count);
        if (exists)
        {
            if (count >= n)
            {
                itemcount["sword"] = count - n;
                return;
            }
            
            throw new InsufficientQuantitiyException("not enough swords, ");

        }
        throw new ItemNotFoundExcpetion("swords are not in inventory");
    }
}