// Напишите программу, которая будет преобразовывать
// десятичные число в двоичное
// 45 -> 101101
// 3 -> 11
// 2 -> 10

string Binary(int num)
{
    string res = "";

    while (num > 0)
    {
        res = num % 2 + res;
        num /= 2;
    }
    return res;
}

// 12 - 1100, 4 - 100, 45 - 101101
int n = int.Parse(Console.ReadLine()!);
string result = Binary(n);
Console.WriteLine(result);