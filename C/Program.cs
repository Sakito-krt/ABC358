class Program
{
    static void Main()
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        string[] shop = new string[input[1]];
        
        for (int i = 0; i <input[0]; i++)
        {
            shop[i] = Console.ReadLine();
        }

        
    }
}