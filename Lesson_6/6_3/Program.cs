// 3. Не используя рекурсию, выведите первые N чисел последовательности Фибоначчи.
//    Первые два числа Фибоначчи: 0 и 1.

void Fibo (int num)
{
    int A = 0;
    int B = 1;
    for (int i = 0; i < num; i++)
    {
        Console.Write(A + " ");
        (A, B) = (B, A + B );
    }
}
int res = int.Parse(Console.ReadLine()!);
Fibo (res);