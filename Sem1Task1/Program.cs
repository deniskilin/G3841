// Напишите программу которая на вход принимает два чилса
// и проверяет является ли первое число квадратом второго

// Напишите программу, которая на вход принимает число и выдает его квадрат

// Приглашаем ко вводу информации
Console.WriteLine("Введите число: ");
// Считываем данные с консоли
string? inputNum1 = Console.ReadLine();
string? inputNum2 = Console.ReadLine();
// Проверяем чтобы данные были не пустые
if(inputNum1!= null && inputNum2!= null)
{
// Парсим введенное значение
    int number1 = int.Parse(inputNum1);
    int number2 = int.Parse(inputNum2);

    if (number2 == number1*number1)
    {
        Console.WriteLine("Первое число квадрат второго");
    }
    else   
        Console.WriteLine("Первое число не квадрат второго"); 

}