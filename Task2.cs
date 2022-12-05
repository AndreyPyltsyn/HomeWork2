Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);
if (number > 0)
{
    if (number > 100)
    {
        while (number > 1000)
        {
            number = number / 10;
        }
        Console.WriteLine(number % 10);
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }
}
else
{
    number = number * -1;
if (number > 100)
    {
        while (number > 1000)
        {
            number = number / 10;
        }
        Console.WriteLine(number % 10);
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }
}
