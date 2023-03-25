// Алгоритм на C# для вывода сообщения "Привет", если введенное число больше 7:
int number;
Console.WriteLine("Введите число: ");
number = Convert.ToInt32(Console.ReadLine());

if (number > 7)
{
Console.WriteLine("Привет");
}
