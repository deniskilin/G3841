// : Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.
Console.Write("Введите трехзначное число: ");
string? str = Console.ReadLine();
if (str.Length > 3)
{
    Console.WriteLine(str[2]);
}
else
{
    Console.WriteLine("третьей цифры нет");
}