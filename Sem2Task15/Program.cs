// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
Console.WriteLine("Введите день недели: ");
int day = int.Parse(Console.ReadLine() ?? "0");
if (day > 0 && day < 8)
{
    if (day > 5 && day < 8)
    {
        Console.WriteLine("Выходной");
    }
    else 
    {
        Console.WriteLine("Рабочий день");
    }
}
else
{
    Console.WriteLine("Введен некорректный день недели");
}
