// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Массив размером 2 x 2 x 2
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)



int[, ,] arr3D = CreateMatrixRndInt(2,2,2,10);
PrintMatrix3D(arr3D);


// метод заполнения 3D массива случайными целыми числами
int[,,] CreateMatrixRndInt(int rows, int columns, int depth, int min)
{
  int[,,] matrix = new int[rows, columns, depth];
  int rnd = min;

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      for (int k = 0; k < matrix.GetLength(2); k++)
      {
        matrix[i, j, k] = rnd;
        rnd++;
      }
    }
  }
  return matrix;
}


void PrintMatrix3D(int[,,] matrix) // печатаем 3D массив
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    // Console.Write("|");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      for (int k = 0; k < matrix.GetLength(2); k++)
      {
        Console.Write($"{matrix[i, j, k], 4} ({i}, {j}, {k})");
      }
    }
    Console.WriteLine();
  }
}
