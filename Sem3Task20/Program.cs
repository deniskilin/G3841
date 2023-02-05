// Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между
// ними в 2D пространстве.

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Выводим результат пользователю
void PrintData(string msg, double res)
{
    Console.WriteLine(msg + res);
}

// Вычисляем расстояние между точками в 2Д пространстве
double CalcLen(int x1, int y1, int x2, int y2)
{
    double res = 0;
    res = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
    return res;
}


// Вводим координаты точек
int coordinateX1 = ReadData("Input coordinate X1");
int coordinateY1 = ReadData("Input coordinate Y1");
int coordinateX2 = ReadData("Input coordinate X2");
int coordinateY2 = ReadData("Input coordinate Y2");

// Вычисляем длинну
double len = CalcLen(coordinateX1, coordinateY1, coordinateX2, coordinateY2);

// Выводим результат
PrintData("Расстояние между точками: ", len);

