// Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// Расстояние между точками в трёхмерном пространстве — это число, равное 
// корню из суммы квадратов разностей координат точек или длине разности радиус-векторов точек.

// double Example (double x1, double x2, double y1, double y2, double z1, double z2)
// {
//     return Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) +  Math.Pow(z2-z1, 2));
// }
// Console.WriteLine(Example(7, -5, 0, 1, -1, 9));

double x1 = Plase("x", "A");
double y1 = Plase("y", "A");
double z1 = Plase("z", "A");
double x2 = Plase("x", "B");
double y2 = Plase("y", "B");
double z2 = Plase("z", "B");
double Plase(string pointPosition, string pointName)
{
    Console.Write($"Координаты {pointPosition} точки {pointName}:");
    return Convert.ToInt32(Console.ReadLine());
}
double Point(double x1, double x2, double y1, double y2, double z1, double z2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
}
double Result = Math.Round(Point(x1, x2, y1, y2, z1, z2), 2);
Console.WriteLine($"Длина отрезка {Result}");