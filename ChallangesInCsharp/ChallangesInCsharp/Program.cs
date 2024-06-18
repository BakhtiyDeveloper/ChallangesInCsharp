
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

Console.WriteLine("Enter diametr of cirkle:  ");
string userInputDiametrCircle = Console.ReadLine();
double diametrCirkle = Convert.ToDouble(userInputDiametrCircle);

Console.WriteLine($"Result: {GetDiametrCircle(diametrCirkle)}");

const double PI = 3.14; 
static double GetDiametrCircle(double diametrCircle) 
{
    return double.Pi * diametrCircle;
}

