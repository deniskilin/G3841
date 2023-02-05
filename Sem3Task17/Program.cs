// // Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и
// выдаёт номер четверти плоскости, в которой
// находится эта точка.

int coordinateX = ReadData("Input coordinate X");
int coordinateY = ReadData("Input coordinate Y");
PrintQuterTest();

// Методчитает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}


// Метод определят четверть по координатам
void PrintQuterTest()
{
    if (coordinateX > 0 && coordinateY > 0) Console.WriteLine("Point in 1 quarte");
    if (coordinateX > 0 && coordinateY < 0) Console.WriteLine("Point in 2 quarte");
    if (coordinateX < 0 && coordinateY < 0) Console.WriteLine("Point in 3 quarte");
    if (coordinateX < 0 && coordinateY > 0) Console.WriteLine("Point in 4 quarte");
}
