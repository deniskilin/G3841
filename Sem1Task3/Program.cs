// Задача 3 Напишите программу, которая будет выдавать
// название дня недели по заданному номеру

// Считываем данные с консли
string? imputLine = Console.ReadLine();
// Проверяем чтобы данные были не пустые
if (imputLine!=null)
{
// Создаем массив с днями неделями
    string[] dayWeek = new string[7];
    dayWeek[0] = "Sunday";
    dayWeek[1] = "Monday";
    dayWeek[2] = "Tuesday";
    dayWeek[3] = "Wednesday";
    dayWeek[4] = "Thursday";
    dayWeek[5] = "Friday";
    dayWeek[6] = "Saturday";
    // Парсим введенное значение
    int imputNumber = int.Parse(imputLine);
    // Находим название дня недели по введенному номеру
    string outDayWeek = dayWeek[imputNumber - 1];
    Console.WriteLine(outDayWeek);
}