// Напишите программу, которая принимает на вход координаты 
//точки (X и Y), причем X ≠ 0 и Y ≠ 0 
//и выдаёт номер четверти плоскости, 
//в которой находится эта точка.


int GetAreaNumber(int x, int y)
{
      int NumberArea = 0;

      if (x > 0 && y > 0) NumberArea = 1;

      if (x < 0 && y > 0) NumberArea = 2;

      if (x < 0 && y < 0) NumberArea = 3;

      if (x > 0 && y < 0) NumberArea = 4;

      return NumberArea;
}
//------------------------------------------

Console.Write("Put cordinate X:");
int x = int.Parse(Console.ReadLine());

Console.Write("Put cordinate Y:");
int y = int.Parse(Console.ReadLine());

if (x == 0 || y == 0)
{
      Console.WriteLine("Coordinates cannot be equal to 0");
}      

else 
{
      int result = GetAreaNumber(x, y);
      Console.WriteLine($"Your pin is in {result} area");
}


