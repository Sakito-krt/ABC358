using System;

class Program
{
    static void Main()
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] T = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] ans = new int[input[0]];

        ans[0] = T[0]+input[1];

        for (int i = 1 ; i < input[0]; i++)
        {
            if (ans[i-1] < T[i])
            {
                ans[i] = T[i]+input[1];
            }
            else
            {
                ans[i] = ans[i-1] + input[1];
            }
        }
        
        
    }
}