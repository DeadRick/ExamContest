using System;
using System.Collections.Generic;

public class Mushroom
{
    private string Name { get; }
    private double Weight { get; }
    private double Diameter { get; }

    private Mushroom(string name, double weight, double diameter)
    {
        Name = name;
        Weight = weight;
        Diameter = diameter;
    }

    public static Mushroom Parse(string line)
    {

        string[] str = line.Split();
        if (str.Length != 3 || !double.TryParse(str[1], out double massa) || !double.TryParse(str[2], out double diam) || massa <= 0 || diam <= 0)

        {
            throw new ArgumentException("Incorrect input");
        }
        return new Mushroom(str[0], massa, diam);

    }

    public static double GetMinimalDiameter(List<Mushroom> mushrooms, double m)
    {
        double min = double.MaxValue;
        bool flag = false;
        foreach (var item in mushrooms)
        {
            if (item.Weight <= m)
            {
                min = Math.Min(min, item.Diameter);
                flag = true;
            }
        }
        if (flag == true)
        {
            return min;
        }
        return 0;
    }
}