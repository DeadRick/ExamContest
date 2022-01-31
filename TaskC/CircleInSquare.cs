using System;

internal static class CircleInSquare
{
    public static double CircumFerence(double side)
    {
        double l = 2 * Math.PI * (side / 2);
        return l;
    }

    public static double Square(double side)
    {
        double S = Math.PI * (side/2 * side/2);
        return S;
    }

    public static double FreeSpace(double side)
    {
        return (side * side) - (Square(side));
    }
}