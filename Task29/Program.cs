// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


int[] array = new int[8];

void FillArr(int[] arr)
{
  for (int i = 0; i < array.Length; i++)
{
  arr[i] = new Random().Next(0,99);
}
}

FillArr(array);
var str = string.Join(", ", array);
Console.WriteLine($"[{str}]");


