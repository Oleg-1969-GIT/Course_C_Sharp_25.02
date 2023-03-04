// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из них
// 2, 3, 7 -> 7
// 44 5 78 -> 78

string s_a = Console.ReadLine()!;
string s_b = Console.ReadLine()!;
string s_c = Console.ReadLine()!;
int a = int.Parse(s_a);
int b = int.Parse(s_b);
int c = int.Parse(s_c);

int Max = a;
{
if (b > Max) Max = b;
else if (c > Max) Max = c;
}
Console.WriteLine("Max = " + Max);