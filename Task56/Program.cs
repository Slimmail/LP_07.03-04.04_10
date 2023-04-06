// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка


int[,] arr2D = CreateMatrixRndInt(3,3,0,5);
PrintMatrix(arr2D);
Console.WriteLine();
int[] sumArrRows = SumArrRows(arr2D);
PrintArray(sumArrRows); 

Console.WriteLine();
int min = MaxDigit(sumArrRows);
Console.WriteLine($"номер строки с наименьшей суммой элементов:  {min}");

// пишем метод на поиск максимального значения в 1Д массиве
// вывод на экран максимального значения с теккстом


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{                          // 0       1
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix) // метод печати 2D массива целых чисел
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 4} ");
        }
        Console.WriteLine("|");
    }
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write(array[array.Length - 1]);
    Console.Write("]");
}


int MaxDigit(int[] arr) // поиск минимального числа в массиве
{
  int min = arr[0];
  for (int i = 1; i < arr.Length; i++)
  {
    if (arr[i] < min) min = arr[i];
  }
  return min;
}

int[] SumArrRows(int[,] matrix)  // массив из суммы элементов каждой строки 2Д массива
{
    int[] arrSize = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i,j]; //  суммируем элементы строки
        }
        arrSize[i] = sum;
    }
    return arrSize;
}
