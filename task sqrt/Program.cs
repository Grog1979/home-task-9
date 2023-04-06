// квадратный корень

int Sqrt(int x)
{
  for (int i = 2; i <= x / 2; i++)
    if (i == x / i) return i;
    return 1;
}
Console.Clear();
Console.Write("enter number: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Sqrt = {Sqrt(number)}");
