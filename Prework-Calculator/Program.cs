using System;

namespace Prework_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int numOne = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a second number:");
            int numTwo = int.Parse(Console.ReadLine());

            Console.WriteLine($"The sum of {numOne} and {numTwo} numbers is: {Add(numOne, numTwo)}");
            Console.WriteLine($"The difference of {numOne} and {numTwo} is: {Subract(numOne, numTwo)}");
            Console.WriteLine($"The product of {numOne} and {numTwo} is: {Multiply(numOne, numTwo)}");
            Console.WriteLine($"The quotient of {numOne} and {numTwo} is: {Divide(numOne, numTwo)}");
            
        }
        //Method to add numbers
        static int Add(int numOne, int  numTwo)
        {
            return numOne + numTwo;
        }
        //Method to subtract numbers
        static int Subract(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }
        //Method to multiply numbers
        static int Multiply(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }
        //Method to divide numbers
        static int Divide(int numOne, int numTwo)
        {
            return numOne / numTwo;
        }
    }
}
