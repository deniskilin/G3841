// напишите программу, которая выводит случайное 3-х значное число
// и удаляет вторую цифру этого числа

System.Random numSintezator = new System.Random();

int rndNum = numSintezator.Next(100, 1000);
Console.WriteLine("Random number: " + rndNum);

int digit1 = rndNum / 100;
int digit3 = rndNum % 10;
Console.WriteLine(digit1 + "" + digit3);
