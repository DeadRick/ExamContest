using System;
using System.IO;
using System.Text;

internal static class Reader
{
    public static string[] ReadFile(string fileName)
    {


        string[] str = File.ReadAllLines(fileName);
        string[] ready = new string[str.Length];
        int cnt = 0;
        foreach (var item in str)
        {
            StringBuilder res = new StringBuilder();
            if (item.Length == 1)
            {
                res.Append(item[0]);
            }
            else
            {
                for (int i = 1; i < item.Length; i++)
                {
                    if (i == 1)
                    {
                        res.Append(item[0]);
                    }
                    else if (item[i - 1] != item[i])
                    {
                        if (res[res.Length - 1] != item[i - 1])
                        {
                            res.Append(item[i - 1]);
                        }
                        res.Append(item[i]);
                    }
                }
            }
            ready[cnt] = res.ToString();
            cnt += 1;
        }
        return ready;
    }
}