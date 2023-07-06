// Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 3D пространстве.

//Методы

int Prompt(string message)
{
      Console.Write(message);
      string value = Console.ReadLine();  
      int result = Convert.ToInt32(value);
      return result;
}

double Pin3D(double FirstpinX, double FirstpinY, double FirstpinZ, double SecondPinX, double SecondPinY, double SecondPinZ)
{
      return Math.Sqrt(Math.Pow(SecondPinX - FirstpinX, 2) + Math.Pow(SecondPinY - FirstpinY, 2) + Math.Pow(SecondPinZ - FirstpinZ, 2));
}

//Программа
int x1 = Prompt("Please, enter 1 PIN X coordinate:");
int y1 = Prompt("Please, enter 1 PIN Y coordinate:");
int z1 = Prompt("Please, enter 1 PIN Z coordinate:");

int x2 = Prompt("Please, enter 2 PIN X coordinate:");
int y2 = Prompt("Please, enter 2 PIN Y coordinate:");
int z2 = Prompt("Please, enter 2 PIN Z coordinate:");

double distance = Pin3D(x1, y1, z1, x2, y2, z2);
Console.Write($"Distance between your coordinates {distance}");
