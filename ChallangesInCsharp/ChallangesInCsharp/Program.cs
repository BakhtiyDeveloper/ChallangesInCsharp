
/* 
A+B 
It will be necessary to calculate the sum of integers A and B. 
*/

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