


Console.Clear();
Console.Write("Введите номер четверти: ");
int quater = Convert.ToInt32(Console.ReadLine());

string result = GetCoordinate(quater);
Console.WriteLine(result);

string GetCoordinate(int x)
{
  if(x == 1) return "Диапазон 1 четверти: x > 0, y > 0";
  if(x == 2) return "Диапазон 2 четверти: x < 0, y > 0";
  if(x == 3) return "Диапазон 3 четверти: x < 0, y < 0";
  if(x == 4) return "Диапазон 4 четверти: x > 0, y < 0";
  return "Некорректный номер четверти";
}

