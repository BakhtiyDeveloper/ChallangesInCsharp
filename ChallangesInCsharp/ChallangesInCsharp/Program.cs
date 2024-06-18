
/* 
A+B 
It will be necessary to calculate the sum of integers A and B. 
*/

/*
Console.WriteLine("Enter first number: ");
string A = Console.ReadLine();
int firstNumber = Convert.ToInt32(A);

Console.WriteLine("Enter second number: ");
string B = Console.ReadLine();
int secondNumber = Convert.ToInt32(B);

Console.WriteLine($"Result: {GetSumTwoNumbers(firstNumber, secondNumber)}");

static int GetSumTwoNumbers(int firstNumber, int secondNumber)
{
    return firstNumber + secondNumber;
}
*/


/* 
A rectangle: 
You are given the sides a and b of a rectangle,  
you need to find its area and perimeter and check the following condition. 
*/

/*
Console.WriteLine("Enter first side of rectangle: "); 
string userInputsideA = Console.ReadLine(); 
int sideA = Convert.ToInt32(userInputsideA); 

Console.WriteLine("Enter second side of rectangle: "); 
string userInputsideB = Console.ReadLine(); 
int sideB = Convert.ToInt32(userInputsideB); 
 
Console.WriteLine($"Result : {GetParameterRectangle(sideA,sideB)}"); 
 
static int GetParameterRectangle(int sideA,int sideB) 
{ 
    return sideA * sideB; 
}
*/

/*
 * The sides of a rectangle are given by a and b. Determine its surface.
*/

/*
Console.WriteLine("Enter the first side of the rectangle: ");
string userInputsurfaceA = Console.ReadLine();
int surfaceA = Convert.ToInt32(userInputsurfaceA);

Console.WriteLine("Enter the first side of the rectangle: ");
string userInputsurfaceB = Console.ReadLine();
int surfaceB = Convert.ToInt32(userInputsurfaceB);

Console.WriteLine($"Result : {GetSurfaceRectangle(surfaceA, surfaceB)}");

static int GetSurfaceRectangle(int surfaceA, int surfaceB)
{
    return 2 * (surfaceA + surfaceB);
}

*/

/*
Console.WriteLine("Enter diametr of cirkle:  ");
string userInputDiametrCircle = Console.ReadLine();
double diametrCirkle = Convert.ToDouble(userInputDiametrCircle);

Console.WriteLine($"Result: {GetDiametrCircle(diametrCirkle)}");

const double PI = 3.14; 
static double GetDiametrCircle(double diametrCircle) 
{
    return double.Pi * diametrCircle;
}
*/

/*
Find the volume and total surface area of ​​a cube given side a
*/

/*
Console.WriteLine("Enter the side of cube :");

string userInputSideA = Console.ReadLine();
double sideA = Convert.ToDouble(userInputSideA);

Console.WriteLine($"The Volume : {GetVolume(sideA)}");
Console.WriteLine($"The total surface area : {GetTotalSurfaceArea(sideA)}");

static double GetVolume(double sideA)
{
    return Math.Pow(sideA, 3);
}

static double GetTotalSurfaceArea(double sideA)
{
    return 6 * (sideA * sideA);
}
*/

/* The sides of a parallelepiped are a, b, c, given.
   Determine its volume and total surface area
*/


Console.WriteLine("Enter the first roof of the parallelepiped: ");
string userInputParalOne = Console.ReadLine();
int sideParalOne = Convert.ToInt32(userInputParalOne);

Console.WriteLine("Enter the second roof of the parallelepiped: ");
string userInputParalTwo = Console.ReadLine();
int sideParalTwo = Convert.ToInt32(userInputParalTwo);

Console.WriteLine("Enter the tree roof of the parallelepiped: ");
string userInputParalThree = Console.ReadLine();
int sideParalThree = Convert.ToInt32(userInputParalThree);

Console.WriteLine($"Volume parallelepipe: {GetVolumeParallelepiped(sideParalOne, sideParalTwo, sideParalThree)}");
Console.WriteLine($"Full surface parallelepipe: {GetFullSurfaceParallelepiped(sideParalOne, sideParalTwo, sideParalThree)}");


static int GetVolumeParallelepiped(int sideParalOne, int sideParalTwo, int sideParalThree)
{
    return sideParalOne * sideParalTwo * sideParalThree;
}

static int GetFullSurfaceParallelepiped(int sideParalOne, int sideParalTwo, int sideParalThree) 
{
    return 2 * (sideParalOne * sideParalTwo + sideParalTwo * sideParalThree + sideParalOne * sideParalThree); 
}
















