// See https://aka.ms/new-console-template for more information
// программа получает на входе два числа и проверяет, является ли второе число квадратом первого

string s_a = Console.ReadLine()!;
string s_b = Console.ReadLine()!;
int a = int.Parse(s_a);
int b = int.Parse(s_b);

if (a == b*b) Console.WriteLine("Yes");
else Console.WriteLine("No");