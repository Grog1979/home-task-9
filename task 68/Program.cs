// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int function(int a, int b)
{
  if (a == 0)
    return b + 1;
  else if (a != 0 && b == 0)
    return function(a - 1, 1);
  else
    return function(a - 1, function(a, b - 1));
}
Console.Write("enter number: ");
int a = int.Parse(Console.ReadLine());// Convert.ToInt32(Console.ReadLine())
Console.Write("enter number: ");
int b = int.Parse(Console.ReadLine());
Console.Write(function(a, b));