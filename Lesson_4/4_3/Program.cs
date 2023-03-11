// Напишите программу, которая принимает на вход число N,
// а на выходе выдает произведение чисел от 1 до N.

int ProdNum(int num)
{
    int all_prod = 1;
    for (int i = 1; i <= num; i++)
       all_prod = i;
    
    return all_prod;
}
int A = int.Parse(Console.ReadLine()!);
int result = ProdNum(A);
Console.WriteLine(ProdNum(result));