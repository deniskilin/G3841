// Задача №2 Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.

// Приглашаем ко вводу информации

Console.WriteLine("Введите два числа для сравнения: ");
// Считываем данные с консоли
string? inputNum1 = Console.ReadLine();
string? inputNum2 = Console.ReadLine();
// Проверяем чтобы данные были не пустые
if(inputNum1!= null && inputNum2!= null)
{
// Парсим введенное значение
    int number1 = int.Parse(inputNum1);
    int number2 = int.Parse(inputNum2);

    if (number2 > number1)
    {
        Console.Write(number2);
    }
    else   
        Console.Write(number1); 
}