// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Double x1=0;
Double x2=0;
Double y1=0;
Double y2=0;
Double z1=0;
Double z2=0;
Console.Write("x1:");
x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("y1:");
y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("z1:");
z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("x2:");
x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("y2:");
y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("z2:");
z2 = Convert.ToDouble(Console.ReadLine());
double result = Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1) + (z2-z1)*(z2-z1));
Console.WriteLine(Math.Round(result, 2));
