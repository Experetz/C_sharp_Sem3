// Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.

//Methods

int ShowMessage(string message)
{
      Console.Write(message);
      string value = Console.ReadLine();  
      int result = Convert.ToInt32(value);
      return result;
}

void PrintCubedNumber(int num)
{ 
int i = 1;      
for (i = 1; i <= num; i++)
Console.Write((Math.Pow(i, 3)) + "  ");
}

//Programme

int userInput = ShowMessage("Please put a number ");
if (userInput <= 0)
{
   Console.WriteLine("Invalid input. Please enter a positive number.");   
}
else 
{
PrintCubedNumber(userInput);
}