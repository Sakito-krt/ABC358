using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        if (input[0] == "AtCoder" && input[1] == "Land")
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}