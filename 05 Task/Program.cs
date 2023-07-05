// Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу квадратов чисел от 1 до N.

void PrintSquare(int num)
{ 
int i = 1;      
for (i = 1; i <= num; i++)
Console.Write(i*i + "  ");
}


Console.Write("Please put a number ");
int a = int.Parse(Console.ReadLine());
if (a <= 0)
{
   Console.WriteLine("Invalid input. Please enter a positive number.");   
}
else 
{
PrintSquare(a);
}