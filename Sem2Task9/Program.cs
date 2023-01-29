// Напишите программу, которая выводит случайное число из отрезка [10,99]
// и показывает наибольшую цифру числа

System.Random numSintezator = new System.Random();

int rndNum = numSintezator.Next(10, 100);
Console.WriteLine("Random number: " + rndNum);

int digit1 = rndNum / 10;
int digit2 = rndNum % 10;

if (digit1 > digit2)
{
    Console.WriteLine(digit1);
}
else
{

    Console.WriteLine(digit2);
}


