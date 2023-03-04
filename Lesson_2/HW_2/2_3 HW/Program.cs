// Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int TakeNum(int (num))
if (num < 100)
{
    Console.WriteLine("Число: " + num);
    {
        Console.Writeline("Третьей цифры нет");
        return num % 10;
    }
}
int result = TakeNum(new Random().Next(100, 1000));
Console.WriteLine("Третья цифра: " + result);