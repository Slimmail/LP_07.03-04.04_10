// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

//.....................................................

Console.Clear();
int[] array = new int[4];

FillArr(array); //вызываем массив случаных чисел
// var str = string.Join(", ", array); // создаем строку массива случайнх чисел через запятую

PrintArray(array);

// Console.WriteLine(str); // выводим на экран строку массива случайных чисел
Console.WriteLine(" -> сумма элементов, стоящих на нечётных позициях: " + GetSum(array));



//.............Methods...............................................

void FillArr(int[] arr) // Создали массив случайных 3х чисел
{
  for (int i = 0; i < array.Length; i++)
{
  arr[i] = new Random().Next(0,10);
}
}

int GetSum (int[] arr)
{
  int sum = 0;
  for (int i = 1; i < arr.Length; i += 2) // Если про какие-то другие четные позиции, то i = 0 изначально
  {
    sum += arr[i]; 
  }
  return sum;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}