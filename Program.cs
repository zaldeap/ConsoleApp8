using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        bool userExit = false;

        while (!userExit)
        {
            Console.WriteLine("Welcome to the calculator!");
            Console.WriteLine(
                "1. Addition/n"+
                "2.Substaction/n"+ "" +
                "3. Multiplication/n" +
                "4. Division" +
                "5.Modulo" +
                "6. Square" +
                "7. Cube" +
                "8. Square Root" +
                "9. Factorial" +
                "10. Perimeter and area of trapezoid" +
                "11. Volume of a sphere" +
                "0.Exit");

            Console.Write("Please enter your choice: ");
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    CalculateAddition;
                case "2":
                    CalculateSubstraction;
                case "3":
                    CalculateMultiplication;
                case "4":
                    CalculateDivision;
                case "5":
                    CalculateModulo;
                case "6":
                    CalculateSquare;
                case "7":
                    CalculateCube;
                case "8":
                    CalculateSquareRoot;
                case "9":
                    CalculateFactorial;
                case "10":
                    CalculatePerimeterAndAreaOfTrapezoid;
                case "11":
                    CalculateVolumeOfASphere;
                case "0":
                    userExit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;

            }




        }
    static void CalculateAddition()
        {
        Console.WriteLine("Please enter the first number: ");
        string firstNumberInput = Console.ReadLine();
        int firstNumber = int.Parse(firstNumberInput);

        Console.WriteLine("Please enter the second number: ");
        string secondNumberInput = Console.ReadLine();
        int secondNumber = int.Parse(secondNumberInput);

        int result = firstNumber + secondNumber;
        Console.WriteLine("The result is: " + result);
        }
    static void CalculateSubstraction()
        {
        Console.WriteLine("Please enter the first number: ");
        string firstNumberInput = Console.ReadLine();
        int firstNumber = int.Parse(firstNumberInput);

        Console.WriteLine("Please enter the second number: ");
        string secondNumberInput = Console.ReadLine();
        int secondNumber = int.Parse(secondNumberInput);

        int result = firstNumber - secondNumber;
        Console.WriteLine("The result is: " + result);
        }
    static void CalculateMultiplication()
        {
        Console.WriteLine("Please enter the first number: ");
        string firstNumberInput = Console.ReadLine();
        int firstNumber = int.Parse(firstNumberInput);

        Console.WriteLine("Please enter the second number: ");
        string secondNumberInput = Console.ReadLine();
        int secondNumber = int.Parse(secondNumberInput);

        int result = firstNumber * secondNumber;
        Console.WriteLine("The result is: " + result);
        }
    static void CalculateDivision()
        {
        Console.WriteLine("Please enter the first number: ");
        string firstNumberInput = Console.ReadLine();
        int firstNumber = int.Parse(firstNumberInput);

        Console.WriteLine("Please enter the second number: ");
        string secondNumberInput = Console.ReadLine();
        int secondNumber = int.Parse(secondNumberInput);

        int result = firstNumber / secondNumber;
        Console.WriteLine("The result is: " + result);
        }
    static void CalculateModulo()
        {
        Console.WriteLine("Please enter the first number: ");
        string firstNumberInput = Console.ReadLine();
        int firstNumber = int.Parse(firstNumberInput);

        Console.WriteLine("Please enter the second number: ");
        string secondNumberInput = Console.ReadLine();
        int secondNumber = int.Parse(secondNumberInput);

        int result = firstNumber % secondNumber;
        Console.WriteLine("The result is: " + result);
        }
    static void CalculateSquare()
        {
        Console.WriteLine("Please enter the number: ");
        string firstNumberInput = Console.ReadLine();
        int firstNumber = int.Parse(firstNumberInput);

        int result = firstNumber * firstNumber;
        Console.WriteLine("The result is: " + result);
        }
    static void CalculateCube()
        {
        Console.WriteLine("Please enter the number: ");
        string firstNumberInput = Console.ReadLine();
        int firstNumber = int.Parse(firstNumberInput);

        int result = firstNumber * firstNumber * firstNumber;
        Console.WriteLine("The result is: " + result);
        }
    static void CalculateSquareRoot()
        {
        Console.WriteLine("Please enter the number: ");
        string firstNumberInput = Console.ReadLine();
        int firstNumber = int.Parse(firstNumberInput);

        double result = Math.Sqrt(firstNumber);
        Console.WriteLine("The result is: " + result);
        }
    static void CalculateFactorial()
        {
        Console.WriteLine("Please enter the number: ");
        string firstNumberInput = Console.ReadLine();
        int firstNumber = int.Parse(firstNumberInput);

        int result = 1;
        for (int i = 1; i <= firstNumber; i++)
            {
            result = result * i;
        }
        Console.WriteLine("The result is: " + result);
        }
    static void CalculatePerimeterAndAreaOfTrapezoid()
        {
        Console.WriteLine("Please enter the first base: ");
        string firstNumberInput = Console.ReadLine();
        int firstNumber = int.Parse(firstNumberInput);

        Console.WriteLine("Please enter the second base: ");
        string secondNumberInput = Console.ReadLine();
        int secondNumber = int.Parse(secondNumberInput);

        Console.WriteLine("Please enter the first side: ");
        string thirdNumberInput = Console.ReadLine();
        int thirdNumber = int.Parse(thirdNumberInput);

        Console.WriteLine("Please enter the second side: ");
        string fourthNumberInput = Console.ReadLine();
        int fourthNumber = int.Parse(fourthNumberInput);

        Console.WriteLine("Please enter the height: ");
        string fifthNumberInput = Console.ReadLine();
        int fifthNumber = int.Parse(fifthNumberInput);

        int result = firstNumber + secondNumber + thirdNumber + fourthNumber;
        Console.WriteLine("The perimeter is: " + result);

        int result2 = ((firstNumber + secondNumber) / 2) * fifthNumber;
        Console.WriteLine("The area is: " + result2);
        }
    static void CalculateVolumeOfASphere()
        {
        Console.WriteLine("Please enter the radius: ");
        string firstNumberInput = Console.ReadLine();
        int firstNumber = int.Parse(firstNumberInput);

        double result = (4 * Math.PI * firstNumber * firstNumber * firstNumber) / 3;
        Console.WriteLine("The volume is: " + result);
        }
    }
}