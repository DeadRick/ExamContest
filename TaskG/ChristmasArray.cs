using System;

internal class ChristmasArray : BaseArray
{
    private static int[] arr;

    public ChristmasArray(int[] wow) : base(arr)
    {
        array = wow;
        arr = null;
    }
 
    public override int this[int number] {
        get {
            int find;
            Array.Sort(array);
            foreach (var item in array)
            {
                if (item > number)
                {
                    find = item;
                    return find;
                }
            }
            throw new ArgumentException("Number does not exist.");
        }
    }

    public override double GetMetric()
    {
        int cnt = 0;
        foreach (var item in array)
        {
            if (item % 2 == 0)
            {
                cnt += 1;
            }
        }
        return (double)cnt / (double)(array.Length * 2);
    }
}