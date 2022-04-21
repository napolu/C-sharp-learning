/*

//Задача 1.
int FindQvart(int x, int y)
{
    if(x > 0 && y > 0)
        return 1;
    else if(x < 0 && y > 0)
        return 2;
    else if(x < 0 && y < 0)
        return 3;
    else if(x > 0 && y < 0)
        return 4;
    else
        return 0;   
}

Console.Write("Input X coordinate: ");
int xDot = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Y coordinate: ");
int yDot = Convert.ToInt32(Console.ReadLine());

int qvartNum = FindQvart(xDot, yDot);

if(qvartNum == 0)
    Console.WriteLine("Dot located on the axes!");
else
    Console.WriteLine("Number of quart is " + qvartNum);




//Задача 2.

void Coordinates(int qvart)
{
    if(qvart == 1)
        Console.WriteLine("x > 0; y > 0");
    else if(qvart == 2)
        Console.WriteLine("x < 0; y > 0");
    else if(qvart == 3)
        Console.WriteLine("x < 0; y < 0");
    else if(qvart == 4)
        Console.WriteLine("x > 0; y < 0");
    else
        Console.WriteLine("Incorrect number");
      
}

Console.WriteLine("Input qvart number 1 - 4 ");
int qvartNum = Convert.ToInt32(Console.ReadLine());

Coordinates(qvartNum);



//Задача 3.

double FindDistance(double x1, double y1, double x2, double y2)
{
    double distance = Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1));
    return distance;
}

Console.Write("Input Xa coordinate: ");
double xDot1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Ya coordinate: ");
double yDot1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Xb coordinate: ");
double xDot2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Yb coordinate: ");
double yDot2 = Convert.ToInt32(Console.ReadLine());

double distance = FindDistance(xDot1, yDot1, xDot2, yDot2);
Console.Write("The distance between A and B is " + distance);



*/
//Задача 4
void Square( int n)
{
    
    int current = 1;
    while(current <= n)
    {
        int result = current*current;
        Console.Write(result + " ");
        current++;
    }

}
Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
Square(num);

