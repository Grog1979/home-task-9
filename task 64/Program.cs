// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


string RecNumbers(int minNumber, int maxNumber)
{
  if (maxNumber >= minNumber) return  $"{maxNumber} " + RecNumbers(minNumber, maxNumber - 1);
  return string.Empty;
}
Console.Write("enter min number: ");
int a = int.Parse(Console.ReadLine());// Convert.ToInt32(Console.ReadLine())
Console.Write("enter max number: ");
int n = int.Parse(Console.ReadLine());
Console.Write(RecNumbers(a, n));