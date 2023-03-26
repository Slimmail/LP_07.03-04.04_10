// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.Clear();

int[] array = CreateArrayRndInt(15, 3, 5);
PrintArray(array);

int[] newArr = Multiplication(array);
PrintArray(newArr);


int[] Multiplication(int[] array)
{
    int size = array.Length % 2 > 0 ? (array.Length / 2) + 1 : array.Length / 2; // определяем размер нового массива который получится. Если изначальный был нечетным, 
                                                                                 //то к половине прибавим 1 для того, чтобы вписать центральное символ, которое не прибавляется
    int[] newArray = new int[size]; // создаем новый массив и вставляем в него размер который у нас получится исходя из предыдущей операции

    for (int i = 0; i < array.Length /2; i++) // проходим позиции до середины
    {
        int number = array[i] * array[array.Length - 1 - i]; // вызываем ячейку и умножая её на противоположную с другого конца
        newArray[i] = number;    // присваиваем в ячейку получившийся результат    
    }
    
    if(array.Length % 2 > 0) // возвращаемся в 18 строчке в которой мы добавяляли размер для неяётного массива и вбиваем туда центральное нечетное значение с первого массива
    {
        int indexMed = array.Length / 2;
        newArray[size - 1] = array[indexMed]; // помещая его на последнюю позицию в массиве
    }

    return newArray; // возвращаем получивщийся свежий массив
}


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random random = new Random();

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max +1);
    }

    return array;
}

void PrintArray(int[] arr)
{
    Console.WriteLine("{0}", string.Join(", ", arr));
    Console.WriteLine();
}