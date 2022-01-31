using System;

public class Field
{
    private int[,] matrix;
    private string type;

    public Field(int[,] matrix)
    {
        this.matrix = matrix;
    }

    public void FillIn(string fillType)
    {
        type = fillType;
        if (fillType == "top to bottom")
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i,j] = i + j + 1;
                }
            }
        } else if (fillType == "bottom to top")
        {
            for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
            {
                for (int j = matrix.GetLength(1) -1 ; j >= 0; j--)
                {
                    matrix[i, j] = i + j + 1;
                }
            }
        }
    }

    public override string ToString()
    {
        if (type == "top to bottom")
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                    if (j != matrix.GetLength(1) - 1)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        } else
        {
            for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                    if (j != matrix.GetLength(1) - 1)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        return "";
    }
}