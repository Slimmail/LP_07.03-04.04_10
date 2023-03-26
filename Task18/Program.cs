// 18. Напишите программу, которая по номеру 
// четверти показывает диапазон возможных 
// координат точек по этой четверти (x и y).


Console.Clear();
Console.Write("Введите номер четверти: ");
string quater = Console.ReadLine();

string result = GetCoordinate(quater);
Console.WriteLine(result);

string GetCoordinate(string x)
{
  if (x == "1") return "Диапазон 1 четверти: x > 0, y > 0";
  if (x == "2") return "Диапазон 2 четверти: x < 0, y > 0";
  if (x == "3") return "Диапазон 3 четверти: x < 0, y < 0";
  if (x == "4") return "Диапазон 4 четверти: x > 0, y < 0";
  return "Некорректный номер четверти";
}

