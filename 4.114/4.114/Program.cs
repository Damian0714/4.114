Console.Write("Введите год: ");
int yearY = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер месяца: ");
int mounth = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите день: ");
int day = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Дата предыдущего дня: {day - 1}.{mounth}.{yearY}");
Console.WriteLine($"Дата следующего дня: {day + 1}.{mounth}.{yearY}");

if (yearY % 4 == 0 && (yearY % 100 != 0 || yearY % 400 == 0))
{
    Console.WriteLine("Год високосный");
}
else
{
    Console.WriteLine("Год не високосный");
}