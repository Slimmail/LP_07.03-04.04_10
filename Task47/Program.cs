// Задача 47. Задайте двумерный массив размером m×n, заполненный 
// случайными вещественными числами.

// m = 3, n = 4.

// 0,5    7   -2  -0,2
//   1 -3,3    8  -9,9
//   8  7,8  7,1     9

Console.Write("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] arrMy2D = new double[row, columns];
GetMatrix(arrMy2D);
PrintArray2D(arrMy2D);

void PrintArray2D(double[,] arr2D) // выводим 2D массиы
{
  for (int i = 0; i < arr2D.GetLength(0); i++)
  {
    Console.Write("|");
    for (int j = 0; j < arr2D.GetLength(1); j++)
    {
      Console.Write($"{arr2D[i, j],5}");
    }
    Console.WriteLine("|");
  }
}

// метод заполнения 2D массива случайными вещественными числами
void GetMatrix(double[,] arr, int min = 0, int max = 9)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      double num = new Random().NextDouble() * (max - min) + min;
      arr[i, j] = Math.Round(num, 1);
    }
  }
}
