// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

Console.Clear();

int[,] CreateMatrix(int rows, int min, int max)
{
    int[,] matrix = new int[rows, rows];

    Random random = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(min, max + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }

        Console.Write("|");
        Console.WriteLine();

    }
}

bool Verification(int rows, int colums)
{
    return rows != colums || rows < 0 || colums < 0;
}

int[,] ChangeColumsRows(int[,] matrix)  // замена местами строк со столбцами через создание новой матрицы
{
    int size = matrix.GetLength(0);
    int[,] newMatrix = new int[size, size];
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            newMatrix[j, i] = matrix[i, j];
        }
    }
    return newMatrix;
}

void ChangeColumsRowsOneMatrix(int[,] matrix)  //поменяли местами строки со столбцами
{
    int temp = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int j = i + 1;
        while (j < matrix.GetLength(0))
        {
            temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
            j++;
        }

    }
}

void ChangeColumsAndRows(int[,] matrix)  // 
{
    int size = matrix.GetLength(0);
    for (int i = 0; i < size - 1; i++)
    {
        for (int j = i + 1; j < size; j++)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
}

Console.Write("Введите количество строк:");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов:");
int colum = Convert.ToInt32(Console.ReadLine());

if (Verification(row, colum))
{
    Console.Write("Введены неверные данные");
    return;
}

int[,] array2d = CreateMatrix(row, -10, 10);
int[,] newArray2d = ChangeColumsRows(array2d);   // поменяли местами строки со столбцами
PrintMatrix(array2d); // печатаем рандомный массив
Console.WriteLine("Новый массив");
PrintMatrix(newArray2d);  // печатаем поменяный местами строки со столбцами массив
Console.WriteLine("Изменённый старый");
ChangeColumsRowsOneMatrix(array2d);  // ещё раз поменяли местами строки со столбцами
PrintMatrix(array2d);