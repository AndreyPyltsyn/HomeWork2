Console.WriteLine("Введите цифру, обозначающую день недели ");
int number = int.Parse(Console.ReadLine()!);
if (number < 6 || number > 8)
{
    Console.WriteLine("Нет");
}
else if (number == 6 || number == 7)
{
    Console.WriteLine("Да");
}