// Напишите программу, которая 
//1.на вход принимает число
//2. выдает его квадрат (число умноженное на само себя) 
// принимает число и выдаёт его квадрат (число
// умноженное на само себя).

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

// string input = Console.ReadLine();
// int number = Convert.ToInt32(input);
Console.Write("Введите целое число: ");

int number = Convert.ToInt32(Console.ReadLine());
//int number = int.Parse(Console.ReadLine()); // не проверяет

int square = number * number;
//Console.WriteLine("квадрат числа number = square");
Console.WriteLine($"квадрат числа {number} = {square}");