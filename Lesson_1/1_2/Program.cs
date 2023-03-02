// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Напишите программу, которая будет выдавать название дня недели по заданному номеру

string a = Console.ReadLine()!;

if (a == "1")
{
    Console.WriteLine("ПНД");
}
else if (a == "2")
{
    Console.WriteLine("ВТР");
}
else if (a == "3")
{
    Console.WriteLine("СРД");
}
else if (a == "4")
{
    Console.WriteLine("ЧТВ");
}
else if (a == "5")
{
    Console.WriteLine("ПТН");
}
else if (a == "6")
{
    Console.WriteLine("СБТ");
}
else if (a == "7")
{
    Console.WriteLine("ВСК");
}
else
{
    Console.WriteLine("ERR");
}