// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
int n = Console.ReadLine();

object value1 = Console.WriteLine(n > 99 ? n.ToString()[2] : '-');
object value = Console.ReadKey(true);