// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] array = GetArrSpiral(4,4);
PrintMatrix(array);

int[,] GetArrSpiral(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    int maxDigit = matrix.Length;
    int i = 0;
    int j = 0;
    int num = 1;
    string route = "GoToRight";

    while (num <= maxDigit)
    {
        if (route == "GoToRight")
        {
            matrix[i, j] = num;
            num++;
            if (j + 1 >= matrix.GetLength(1) || matrix[i, j + 1] != 0)
            {
                i++;
                route = "GoToDown";
            }
            else
            {
                j++;
            }
        }
        else if (route == "GoToDown")
        {
            matrix[i, j] = num;
            num++;
            if (i + 1 >= matrix.GetLength(0) || matrix[i + 1, j] != 0)
            {
                j--;
                route = "GoToLeft";
            }
            else
            {
                i++;
            }
        }
        else if (route == "GoToLeft")
        {
            matrix[i, j] = num;
            num++;
            if (j - 1 < 0 || matrix[i, j - 1] != 0)
            {
                i--;
                route = "GoToUp";
            }
            else
            {
                j--;
            }
        }
        else if (route == "GoToUp")
        {
            matrix[i, j] = num;
            num++;
            if (i - 1 < 0 || matrix[i - 1, j] != 0)
            {
                j++;
                route = "GoToRight";
            }
            else
            {
                i--;
            }
        }
        else
        {
            break;
        }
    }
    return matrix;
}


void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    Console.Write("|");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i, j],4} ");
    }
    Console.WriteLine("|");
  }
}
