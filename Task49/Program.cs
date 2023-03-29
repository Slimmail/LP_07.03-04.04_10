// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.


// задача про возведение в квадрат номеров с четными индексами

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{                          // 0       1
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}

void ChangeToSquare(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i+=2)
    {
        for (int j = 0; j < matrix.GetLength(1); j+=2)
        {
            matrix[i,j] *= matrix [i,j];
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 4} ");
        }
        Console.WriteLine("|");
    }
}

int[,] array2d = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(array2d);
Console.WriteLine();
ChangeToSquare(array2d);
PrintMatrix(array2d);

// моё решение

// int[,] CreateMatrixSumIndexes(int rows, int columns)
// {   

//     Random rnd = new Random();
//     int[,] matrix = new int[rows, columns];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         int min = 0;
//         int max = 5;
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(min, max + 1);
//         }

//     }
//     return matrix;
// }


// void MatrixCheckToQuatro(int[,] matrix)
// {   
    
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if ((i +j) % 2 == 0 )
//             {
//               matrix[i, j] = matrix[i, j] * matrix[i, j];
//             }
            
//         }

//     }
   
// }


// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("|");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j], 4} ");
//         }
//         Console.WriteLine("|");
//     }
// }

// int[,] array = CreateMatrixSumIndexes(3, 4);
// PrintMatrix(array);

//  Console.WriteLine();

// MatrixCheckToQuatro(array);
// PrintMatrix(array);