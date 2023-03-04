// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

//int TakeNum(int num)
//{
//    Console.WriteLine("Число: "+num);
//    return num % 10;
//}
//int result = TakeNum(new Random().Next(100, 1000));
//Console.WriteLine("Последняя цифра: "+result);

int TakeNum(int num)
{
    Console.WriteLine("Число: "+num);
//    num = num / 100;
    return num /10 % 10;   
}
int result = TakeNum(new Random().Next(100, 1000));
Console.WriteLine("Вторая цифра: "+result);