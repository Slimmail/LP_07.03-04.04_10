// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.



// метод Ангелины 

int[,] CreateMatrix(int rows, int colums, int min, int max)
{
  int[,] matrix = new int[rows, colums];

  Random random = new Random();

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = random.Next(min, max + 1);
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

    Console.Write("|");
    Console.WriteLine();

  }
}

void ChangeFirstLastLine(int[,] matrix)
{
  int firstLine = 0;
  int lastLine = matrix.GetLength(0) - 1;
  for (int i = 0; i < matrix.GetLength(1); i++)
  {
    int temp = matrix[firstLine, i];
    matrix[firstLine, i] = matrix[lastLine, i];
    matrix[lastLine, i] = temp;
  }
}

int[,] array2d = CreateMatrix(4, 4, -10, 10);
PrintMatrix(array2d);
ChangeFirstLastLine(array2d);
Console.WriteLine();
PrintMatrix(array2d);