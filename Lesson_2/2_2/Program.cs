﻿// 3. Напишите программу которая будет принимать на вход числа и выводить, 
// является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деление.
//    34, 5 -> не кратно, остаток 4
//    16, 4 -> кратно

void Find(int num1, int num2)
{
    if (num1 % num2 == 0)
        Console.WriteLine("кратно");
    else Console.WriteLine($"не кратно {num1 % num2}");
}
Find(16,4);