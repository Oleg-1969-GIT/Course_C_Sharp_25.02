// 2. Напишите программу, которая выводит случайное число из отрезка 10,99 
// и показывает наибольшую цифру числа.

//int TakeNum(int num)
//{
//    Console.WriteLine(num);
//    int result1 = num % 10;
//    int result2 = num / 10;
//    if (result1 > result2)
//    {
//        return result1;
//    }
//    else
//    {
//        return result2;
//    }
    //Console.WriteLine(num);
    //return num % 10;
//}
//int result = TakeNum(new Random().Next(100, 1000));
//Console.WriteLine(result);

// 2-й вариант:

int MaxNumber(int a)
{
    Console.WriteLine(a);
    
    if (a % 10 > a / 10)
    {
        return a % 10;
    }
    else
    {
        return a / 10;
    }
}
Console.WriteLine(MaxNumber(new Random().Next(10, 100)));