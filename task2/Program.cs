// Алгоритм на C# для вывода сообщения "Привет, Вячеслав", если введенное имя совпадает с "Вячеслав", иначе - "Нет такого имени":

string name;
Console.WriteLine("Введите имя: ");
name = Console.ReadLine();

if (name == "Вячеслав")
{
Console.WriteLine("Привет, Вячеслав");
}
else
{
Console.WriteLine("Нет такого имени");
}
