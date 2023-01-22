// Напишите программу, которая на вход принимает число и выдает его квадрат

// Приглашаем ко вводу информации
Console.WriteLine("Введите число: ");
// Считываем данные с консоли
string? inputNum = Console.ReadLine();
// Проверяем чтобы данные были не пустые
if(inputNum!= null)
{
// Парсим введенное значение
    int number = int.Parse(inputNum);
// Находим квадрат числа
    int result  = number*number;
// Выводим результат
    Console.WriteLine(result);
    
}