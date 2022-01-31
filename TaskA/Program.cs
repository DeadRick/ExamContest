using System;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        List<int> ls = new List<int>();
        string height = null;
        do
        {
            height = Console.ReadLine();
            int.TryParse(height, out int check);
            if (check < 190 || check > 250)
            {
                if (check != 0)
                {
                    Console.WriteLine("Incorrect number");
                }
            } else
            {
                ls.Add(check);
            }
        } while (height != "0");
        ls.Sort();
        int cnt = ls.Count;
        Console.WriteLine(ls[0]);
        Console.WriteLine(ls[1]);
    }
}