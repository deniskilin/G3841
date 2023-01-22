// See https://aka.ms/new-console-template for more information

// Считываем данные с консоли
string? imputNumLine = Console.ReadLine();
int N = int.Parse(imputNumLine);
string? result = string.Empty;
for(int i=2; i<N; i=i+2)
{
    result = result + i + ',';
}
if(N%2==0)
{
    result = result + 2;
}

Console.WriteLine(result);