// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.WriteLine("Введите число N: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine("Чётные в ряду от 1 до N:");
int eveN = 2;

if (number > 1)
{
    while (eveN <= number)
    {
        Console.WriteLine(eveN + " ,");
        eveN = (eveN + 2);
    }
}