// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

string number = Console.ReadLine()!;
void CheckNum(string number)
{
    if (number[0] == number[4] || number[1] == number[3])
    {
        Console.WriteLine($"Палиндром");
    }
    else Console.WriteLine($"НЕ палиндром");
}
if (number!.Length == 5)
{
    CheckNum(number);
}
else Console.WriteLine($"Это не пятизначное число");