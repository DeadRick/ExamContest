using System;
internal class Program
{
    private static void Main(string[] args)
    {
        string[] salary = Console.ReadLine().Split();
        int len = salary.Length;
        int[] arr = new int[len];

        for (int i = 0; i < len; i++)
        {
            arr[i] = int.Parse(salary[i]);
        }

        int sum = 0;

        foreach (var item in arr)
        {
            sum += item;
        }
        sum *= 10;

        string s = sum + ".000";
        double a = 1.2 + 2.002;
        Console.WriteLine(a.ToString(".00"));

    }
}