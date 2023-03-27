// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Clear();
 
// int quantity = 0;

Console.Write("Введите колличество вводимых чисел: ");
int arraySize = Convert.ToInt32(Console.ReadLine()); // получаем размер массива
int[] array = new int[arraySize];
int[] howDigits = HowDigits(array);
PrintArray(howDigits);
int howPositDigs = HowPositDigs(howDigits);
Console.Write(" -> " + howPositDigs);

int HowPositDigs(int[] nums)
{
  int count = 0;
  for (int i = 0; i < nums.Length; i++)
  {
    if (nums[i] > 0) count++;
  }
  return count;
}

void PrintArray(int[] arr) // метод печати массива
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int[] HowDigits(int[] arr)
{
int count = 1; 
int temp = 0;
arr = new int[arr.Length];
for (int i = 0; i < arr.Length; i++)
{
  Console.Write("Введите число " + count + " : ");
  temp = Convert.ToInt32(Console.ReadLine());
  arr[i] = temp;
  count++;
}
return arr;
}

