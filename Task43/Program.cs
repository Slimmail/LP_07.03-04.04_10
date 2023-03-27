// Задача 43: Напишите программу, которая найдёт точку пересечения 
// двух прямых, заданных уравнениями 
    // y = k1 * x + b1, 
    // y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double b1 = 2;
double k1 = 5;
double b2 = 4;
double k2 = 9;


// y = k1 * x + b1, 
// y = k2 * x + b2; 

// y-y = k1 * x + b1 - k2 * x - b2
// 0 = (k1 - k2) * x + b1 - b2
// (b1 + b2) = (k1 - k2) * x
//double x = -(b1 - b2) / (k1 - k2);

double x = (b2 - b1) / (k1 - k2);
double xF = Math.Round(x, 1);

// Console.WriteLine(xF);

double y = k2 * xF + b2;

// Console.WriteLine(y);

Console.WriteLine($"При b1 = {b1}, k1 = {k1}, k2 = {b2}, k2 = {k2} -> ({xF}; {y})");