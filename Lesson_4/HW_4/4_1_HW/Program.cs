// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243

int Degree(int A, int B)
{
    int Step = 1;
    for (int i = 0; i < B; i++)
    {
        Step *= A;
    }
    return Step;
}
int A = int.Parse(Console.ReadLine()!);
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine($" {A}, {B}  -> {Degree(A, B)}");