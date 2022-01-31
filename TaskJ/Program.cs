using System;

class Z
{
    public int val = 5;

    Z(int x, int y)
    {
        val = x * y;
    }

    public Z(int x) : this(x * x, x)
    {
        val *= 3;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Z obj = new Z(3);
        Console.Write(obj);
    }
}