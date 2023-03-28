// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

Console.Write("Введите номер строки: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] arrMy2D = new int[3, 4];
GetMatrix(arrMy2D);
PrintArray2D(arrMy2D);

bool x = TestPositionInArr(arrMy2D, row, columns);
Console.Write(x ? $"позиции [{row},{columns}] соответствует значение -> {arrMy2D[row, columns]}" : $"[{row},{columns}] -> такого числа в массиве нет");


bool TestPositionInArr(int[,] arr, int rowArr, int columnsArr) // Сверяем на тождественность запрос
{
  if (rowArr <= arr.GetLength(0) && rowArr >= 0 && columnsArr <= arr.GetLength(1) && columnsArr >= 0)
  {
    return true;
  }
  return false;
}

void GetMatrix(int[,] matrix) // генерируем 2д массив случайных натуральных чсел 
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(1, 100);
    }
  }
}

void PrintArray2D(int[,] arr2D) // выводим 2D массиы
{
  for (int i = 0; i < arr2D.GetLength(0); i++)
  {
    Console.Write("|");
    for (int j = 0; j < arr2D.GetLength(1); j++)
    {
      Console.Write($"{arr2D[i, j],3}");
    }
    Console.WriteLine("|");
  }
}
