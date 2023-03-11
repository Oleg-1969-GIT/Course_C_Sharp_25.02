// Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

//int Prompt(string message)
//{
//    Console.Write(message);
//    string value = Console.Readline();
//    int result = Convert.ToInt32(value);
//    return result;
//}
//bool IsWeekEnd(int weekDay)
//{
//    if (weekDay > 5)
//    {
//        return true;
//    }
//    return false;
//}
//bool ValidateWeekday(int number)
//{
//    if (number > 0 && number <= 7)
//    {
//        return true;
//    }
//    Console.WriteLine("ERR");
//    return false;
//}
//int weekDay = Prompt("Введите день недели > ");
//if (ValidateWeekday(weekDay))
//{
//    if (IsWeekEnd(weekDay))
//    {
//        Console.WriteLine("Выходной");
//    }
//    else
//    {
//        Console.WriteLine("Придется поработать");
//    }
//}
//string num = Console.ReadLine()!;
int num = int.Parse(Console.ReadLine()!);
if (num >= 1 && num <= 5)
{
    Console.WriteLine("Рабочий день");
}
    else if (num >= 6 && num <= 7)
{
    Console.WriteLine("Выходной");
}
    else Console.WriteLine("Это не день недели");