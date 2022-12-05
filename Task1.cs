Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine()!);
int result = (number / 10) % 10;
if (result < 0)
{
    Console.WriteLine(result * -1);
}
else
{
    Console.WriteLine(result);
}
