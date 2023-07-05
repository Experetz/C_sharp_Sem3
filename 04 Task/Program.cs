// Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 
//2D пространстве.

double GetDistanceBetweenTwoPoints(double x1, double x2, double y1, double y2)
{
      return Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2));

}

//--------------------------------------
Console.Write("Please, enter X1:");
double x1 = double.Parse(Console.ReadLine());

Console.Write("Please, enter X2:");
double x2 = double.Parse(Console.ReadLine());

Console.Write("Please, enter Y1:");
double y1 = double.Parse(Console.ReadLine());

Console.Write("Please, enter Y2:");
double y2 = double.Parse(Console.ReadLine());

double distance = GetDistanceBetweenTwoPoints(x1, y1, x2, y2);

Console.Write($"Distance between your coordinates {distance}");
