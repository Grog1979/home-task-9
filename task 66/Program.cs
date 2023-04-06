// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int RecNumbers(int minNumber, int maxNumber)
{
  if (maxNumber == minNumber) return minNumber;
  return minNumber + RecNumbers(minNumber + 1, maxNumber);
}
Console.Write("enter min number: ");
int a = int.Parse(Console.ReadLine());// Convert.ToInt32(Console.ReadLine())
Console.Write("enter max number: ");
int n = int.Parse(Console.ReadLine());
Console.Write(RecNumbers(a, n));
