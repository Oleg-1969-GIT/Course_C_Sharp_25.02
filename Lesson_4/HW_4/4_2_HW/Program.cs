// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 9012 -> 12

int SumNum(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num = num / 10;
    }
    return sum;
}
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма всех цифр = {SumNum(num)}");