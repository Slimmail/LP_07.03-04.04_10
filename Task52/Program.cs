// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] matrix1 = new int[3,4];
GetMatrix(matrix1);
PrintMatrix(matrix1);

Console.WriteLine("......................");
double[] arithmeticMean = ArithmeticMean(matrix1);

Console.Write("Среднее арифметическое каждой строки: ");
PrintArray(arithmeticMean);


void GetMatrix(int[,] matrix) // генерируем 2д массив случайных натуральных чсел 
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i,j] = new Random().Next(1,10);
    }
  }
}

void PrintMatrix(int[,] matrix) // выводим 2д массив случайных натуральных чсел 
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

double[] ArithmeticMean(int[,] matrix) // метод получает 2д массив и выводит 1д массив где прописана 
// сумма каждой строки, поделённая на колличество символов, то есть среднне арифметическое
{
 double[] arrSize = new double[matrix.GetLength(0)];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    double sum = 0;
    double helhArifmRound = 0;
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
      sum = sum + matrix[i,j]; //  суммируем элементы строки
      }
      helhArifmRound = sum / matrix.GetLength(1); //  сохраняем сумму элементов строки и находим среднее арифметическое
      arrSize[i] = Math.Round(helhArifmRound, 1); //  округляем до десятых среднее арифметическое
  }
  return arrSize;
}

void PrintArray(double[] col) // метод печати 1д массива
{
    Console.Write(string.Join("; ", col));
}
