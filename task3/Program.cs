// Алгоритм на C# для вывода элементов числового массива, кратных 3:
int[] numbers = { 1, 3, 5, 6, 9, 12, 15, 18 };

foreach (int number in numbers)
{
if (number % 3 == 0)
{
Console.WriteLine(number);
}
}