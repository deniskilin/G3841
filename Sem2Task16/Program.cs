// Задача 16 Принимает на вход 2 числа и проверят
// является ли одно квадратом второго

Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine() ?? "0");
if (num1 * num1 == num2)
{
    Console.WriteLine("Второе число является квадратом первого");
}
else
{
    if (num2 * num2 == num1)
    {
        Console.WriteLine("Первое число является квадратом Второго");
    }
    else
    {
        Console.WriteLine("Ни одно число не явзяется квадратом другого");
    }
}
