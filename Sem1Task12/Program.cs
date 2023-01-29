// Принимет на вход 2 числа и выводить является ли второе число число кратным первому
// Если второе число не кратно первому, программа выводит остаток от деления

int num1 = int.Parse(Console.ReadLine() ?? "0");
int num2 = int.Parse(Console.ReadLine() ?? "0");
int result = num2 % num1;
if (result == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine("Не кратно, остаток от деления: " + result);
}