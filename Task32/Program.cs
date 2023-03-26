// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]



Console.Clear();

int[] CreateArrayRndInt(int size, int min, int max)
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


void GetOppositeElements(int[] newArray)
{
  for (int i = 0; i < newArray.Length; i++)
  {
    newArray[i] *= -1;
  }
}

int[] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);
Console.WriteLine();

GetOppositeElements(array);
PrintArray(array);



/////// показывал студент

          // Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
// int[] mas = GreatArrayRndInt(5, -9, 9);
// PrintArray(mas);
// Console.WriteLine();
// InverseArray(mas);
// PrintArray(mas);

// int[] GreatArrayRndInt(int size, int min, int max)
// {
//     int[] arr = new int[size];
//     Random rnd = new Random();

//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(min, max + 1);
//     }
//     return arr;
// }

// void PrintArray(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
//         else Console.Write($"{arr[i]}");
//     }
//     Console.Write("]");
// }

// void InverseArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] *= -1;
//     }
// }





