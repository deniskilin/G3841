﻿// Задача 7 Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру этого числа.

// Считываем данные с консоли
string? imputNumLine = Console.ReadLine();
// Проверяем чтобы данные не были пустыми
if (imputNumLine != null)
{
    // Парсим введенное число
    int imputNumberA = int.Parse(imputNumLine);
    int lastDigit = imputNumberA % 10;

Console.WriteLine(lastDigit);
}
//     // Вводим промежуточное значение
//     int imputNumberC = imputNumberA*(-1);
//     // Выходные значения
//         string? outNumLine = string.Empty;
//         while(imputNumberC < imputNumberA)
//         {
//             outNumLine = outNumLine + imputNumberC + ",";
//             imputNumberC++;
//         }
//         outNumLine = outNumLine + imputNumberA;
//         Console.WriteLine(outNumLine);
// }