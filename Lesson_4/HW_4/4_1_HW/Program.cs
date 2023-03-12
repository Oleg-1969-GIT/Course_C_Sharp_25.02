// Напишите цикл, который принимает на вход два числа (А и В) 
// и возводит число А в натуральную степень В.

int A = Count("A");
int B = Count("B");
int Count(string countName)
{
    Console.Write($"Число {countName}:");
    return Convert.ToInt32(Console.ReadLine());
}
int Degree(int B)
{
    int a_degree = 1;
    for (int i = 1; i <= B; i++)
        a_degree = a_degree * A;
    //A = a_degree;

    return a_degree;
}
// int A = int.Parse(Console.ReadLine()!);
int result = Degree(A);
Console.WriteLine($" -> " + Degree(result));