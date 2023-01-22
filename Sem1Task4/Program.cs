// Задача 4 Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите три числа для сравнения: ");
// Считываем данные с консоли
string? inputNum1 = Console.ReadLine();
string? inputNum2 = Console.ReadLine();
string? inputNum3 = Console.ReadLine();
// Проверяем чтобы данные были не пустые
if(inputNum1!= null && inputNum2!= null && inputNum3!= null)
{
// Парсим введенное значение
    int number1 = int.Parse(inputNum1);
    int number2 = int.Parse(inputNum2);
    int number3 = int.Parse(inputNum3);

    if (number1 > number2)
    {
        if (number1 > number3)
        {
            Console.WriteLine(number1);
        }
        else
        {
            Console.WriteLine(number3);
        }
    }
    else 
        if (number2 > number3)
        {
            Console.WriteLine(number2);
        }
        else
        {
            Console.WriteLine(number3);
        }  
        
}