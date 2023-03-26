// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Clear();

int[] array = new int[5];

FillArr(array); //вызываем массив случаных чисел
var str = string.Join(", ", array); // создаем строку массива случайнх чисел через запятую
Console.Write("[");
Console.Write(str);
Console.Write("]");
int quantityDigits = GetCounteHonestDigs(array);
Console.WriteLine(" -> " + quantityDigits);

void FillArr(int[] arr) // Создали массив случайных 3х чисел
{

  for (int i = 0; i < array.Length; i++)
{
  arr[i] = new Random().Next(100,1000);
}

}

int GetCounteHonestDigs (int[] arr) // определяем размер нового массива подсчитывая только четные числа
{
    int size = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] %  2 == 0)
        size ++;
    }
    return size;
}




