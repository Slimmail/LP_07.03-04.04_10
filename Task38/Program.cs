// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

// Console.Clear();

double[] CreateArrayRndDouble(int size, int min, int max)
{
  double[] arr = new double[size];
  Random rnd = new Random();

  for (int i = 0; i < arr.Length; i++)
  {
    double num = rnd.NextDouble() * (max - min) + min;
    arr[i] = Math.Round(num, 1);
  }
  return arr;
}

void PrintArray(double[] arr)
{
  Console.Write("[");
  for (int i = 0; i < arr.Length; i++)
  {
    if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
    else Console.Write($"{arr[i]}");
  }
  Console.Write("]");
}

double FindMax(double[] arr)
{
  double digMax = arr[0];
  for (int i = 1; i < arr.Length; i++)
  {
    if (arr[i] > digMax)
    {
      digMax = arr[i];
    }
  }
  return digMax;
}

double FindMin(double[] arr)
{
  double digMin = arr[0];
  for (int i = 1; i < arr.Length; i++)
  {
    if (arr[i] < digMin)
    {
      digMin = arr[i];
    }
  }
  return digMin;
}

double DigsDifference(double num1, double num2)
{
  return num1 - num2;
}

double[] array = CreateArrayRndDouble(5, -9, 9); // Создаём массив рандомных вещественных чисел
PrintArray(array);

double numberMax = FindMax(array);
double numberMin = FindMin(array);
double diff = DigsDifference(numberMax, numberMin);
double diffFresh = Math.Round(diff, 1); // округлил результат, чтобы исключить хвосты


Console.WriteLine(" -> " + diffFresh);
