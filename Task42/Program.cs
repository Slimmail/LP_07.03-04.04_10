// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


int decimal1 = 46; // Это число в десятичной будет преобразовано в двоичную чистему
int result = DecToBinInt(decimal1);
Console.WriteLine(result);


int DecToBinInt(int decimalNumber)
{
    if (decimalNumber == 0 || decimalNumber == 1)
    {
        return decimalNumber;
    } 

    int dec = 0;
    for (int i = 1; decimalNumber > 0; i *= 10 )
    {
      dec = dec + decimalNumber % 2 * i;        
      decimalNumber /= 2; 
    }
    return dec;
}


// Тоже рабочая формула просто расписана широко
// int DecToBinInt(int decimalNumber)
// {
//     if (decimalNumber == 0 || decimalNumber == 1)
//     {
//         return decimalNumber;
//     } 

//     int dec = 0;
//     int i = 1;
//     while (decimalNumber > 0)
//     {
//         dec = dec + decimalNumber % 2 * i;        
//         decimalNumber /= 2; 
//         i *= 10;               
//     }
//     return dec;
// }



