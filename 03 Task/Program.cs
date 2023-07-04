// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой 
//четверти (x и y).


void ShowAreaRange(int k)
{
      switch (k)
      {
            case 1:
                  Console.WriteLine ("Range of possible coordinates is x > 0 and y > 0");
                  break;
            case 2:
                  Console.WriteLine ("Range of possible coordinates is x < 0 and y > 0");
                  break;
            case 3:
                  Console.WriteLine ("Range of possible coordinates is x < 0 and y < 0");
                  break;
            case 4:    
                  Console.WriteLine ("Range of possible coordinates is x > 0 and y < 0");  
                  break;
            default:  
                  Console.WriteLine("Area number could be only from 1 to 4");
                  break;
      }
}      
//------------------------------------------

Console.Write("Put Area number ");
int area = int.Parse(Console.ReadLine());
 
ShowAreaRange(area);


