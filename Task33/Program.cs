// 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int [] array = GreatArrayRndInt(8, -9, 10);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
string result = SearchNum(array, num) == true ? "Есть в массиве" : "Отсутствует в массиве";
Console.WriteLine($"число {num} {result}" );

int[] GreatArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
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

bool SearchNum(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            return true;
        }
    }
    return false;
}



// // Задача 33: Задайте массив. Напишите программу, которая
// // определяет, присутствует ли заданное число в массиве.
// // 4; массив [6, 7, 19, 345, 3] -> нет
// // 3; массив [6, 7, 19, 345, 3] -> да


// Console.Clear();

// int[] CreateArrayRndInt(int size, int min, int max)
// {
//   int[] arr = new int[size];
//   Random rnd = new Random();

//   for (int i = 0; i < arr.Length; i++)
//   {
//     arr[i] = rnd.Next(min, max + 1);
//   }
//   return arr;
// }

// void PrintArray(int[] arr)
// {
//   Console.Write("[");
//   for (int i = 0; i < arr.Length; i++)
//   {
//     if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
//     else Console.Write($"{arr[i]}");
//   }
//   Console.Write("]");
// }


// bool CheckDigit(int[] newArray, int digit)
// {
//     for (int i = 0; i < newArray.Length; i++)
//   {
//     if newArray[i] == digit ? true; 
//   }
//   return false;
  
// }


// int[] array = CreateArrayRndInt(12, -9, 9);
// PrintArray(array);
// Console.WriteLine();

// Console.Write("Введите число для сравнения: ");
// int opositeElem = Convert.ToInt32(Console.ReadLine());

// string result !!!!!!!!!!!!!!!!
// Console.WriteLine($"число {num} {result}");

// // bool GetOppositeElements(array);
// // PrintArray(array);