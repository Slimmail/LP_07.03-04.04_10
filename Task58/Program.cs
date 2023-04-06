// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// если число столбцов первой матрицы совпадает с числом строк второй матрицы, то выполнять умножение


Console.Clear();

int[] oneMatrix = UserDate(1); 
int[] twoMatrix = UserDate(2);

// создадим две матрицы
int[,] matrixOne = CreateMatrixRndInt(oneMatrix[0],oneMatrix[1],0,10);
int[,] matrixTwo = CreateMatrixRndInt(twoMatrix[0],twoMatrix[1],0,10);

// int[,] matrixOne = new int[,] //для проверки
// {
//     {2,3},
//     {4,2}
// };

// int[,] matrixTwo = new int[,] //для проверки
// {
//     {3,3},
//     {4,3}
// };

// выведем их на экран
PrintMatrix(matrixOne);
Console.WriteLine();
PrintMatrix(matrixTwo);
Console.WriteLine();

int[] UserDate(int num) // получаем данные от пользователя по количеству трок и столбцов
{
  int[] userDate = new int[2];
  Console.WriteLine($"Вводим кол-во строк матрицы {num}:");
  userDate[0] = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine($"Вводим кол-во столбиков матрицы {num}:");
  userDate[1] = Convert.ToInt32(Console.ReadLine());
  return userDate;
}

bool result = CheckMatrix(matrixOne, matrixTwo);
Console.WriteLine(result ? "Результат умножения: " : "Решения не существует!");
if (result == false) return;


Console.WriteLine();
int[,] matrixMult = MatrixMultiplication(matrixOne, matrixTwo);
PrintMatrix(matrixMult);

bool CheckMatrix(int[,] arrOne2D, int[,] arrTwo2D) // проверка на возможность умножения
{
   return  arrOne2D.GetLength(1) == arrTwo2D.GetLength(0);
}

int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2) // умножение матриц
{
  int[,] matrixMultiplication = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
  for (int i = 0; i < matrix1.GetLength(0); i++)
  {
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
      matrixMultiplication[i, j] = 0;
      for (int k = 0; k < matrix1.GetLength(1); k++)
      {
        matrixMultiplication[i, j] += matrix1[i, k] * matrix2[k, j];
      }
    }
  }

  return matrixMultiplication;
}

int[,] CreateMatrixRndInt(int rows, int columns, int min =0, int max = 10)
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





