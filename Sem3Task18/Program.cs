// Напишите программу, которая по заданному номеру
// четверти, показывает диапазон возможных
// координат точек в этой четверти (x и y)

int q_num = ReadData("Input quarte");
PrintQuterTest();

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}


// Метод определят координаты по четверти
void PrintQuterTest()
{
    if (q_num > 0 && q_num < 5)
    {
        if (q_num == 1) Console.WriteLine("X > 0, Y > 0");
        if (q_num == 2) Console.WriteLine("X > 0, Y < 0");
        if (q_num == 3) Console.WriteLine("X < 0, Y < 0");
        if (q_num == 4) Console.WriteLine("X < 0, Y > 0");
    }
    else Console.WriteLine("Вы ввели не номер четверти");
}