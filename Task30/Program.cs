// 30. Напишите программу, которая выводит массив из 8 элементов, заполненнный нулями и еддиницами в случайном порядке.
// [1,0,1,1,0,1,0,0]


// int[] array = new int[8]; // говорим компилятору сколько нужно выделить памяти  каждый 4 байта, тоесть в сумме 32 байта. 
// // 8 это колличество элементов 0,1,2,3,4,5,6,7
// array[3] = 34;


Console.Clear();

Console.WriteLine("Введите размер массива: ");

int arraySize = Convert.ToInt32(Console.ReadLine());

if(arraySize <= 0)
{
  Console.WriteLine($"Ошибка: введено неверное значение {arraySize}");
  return;
}

int[] arr = CreateArray(arraySize);

PrintArray(arr);

int[] CreateArray(int arrayLength)
{
  int[] newArray = new int[arrayLength];

  Random random = new Random();

  for (int i = 0; i < arrayLength; i++)
  {
    newArray[i] = random.Next(0, 2);
  }

  return newArray;
}

void PrintArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"{array[i]} ");
  }
}

//..................................................................

// int[] array = new int[8];
// array[3] = 34;
// for (int i = 0; i < array.Length; i++)
// {
//   array[i] = new Random().Next(0,2);
//   Console.Write(array[i] + " "); 
// }

// // int[] arr = { 1, 2, 3 } // можно и так, но иногда нужен пустой


// Рабочая версия: 


// int[] array = new int[8];

// void FillArr(int[] arr)
// {
//   for (int i = 0; i < array.Length; i++)
// {
//   arr[i] = new Random().Next(0,2);
// }
// }

// void PrintArr(int[] arr)
// {
// for (int i = 0; i < array.Length; i++)
// Console.Write(array[i] + " ");
// }

// FillArr(array); // генерирует массив, без него будут одни нули
// PrintArr(array); // печатает массив, который нагенерировали из нулей в рандом

// окончание

