using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Simple Calculator");

        try
        {
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Select operation (+, -, *, /): ");
            char operation = Console.ReadLine()[0];

            CalculatorLogic calculatorLogic = new CalculatorLogic();

            int result = calculatorLogic.PerformCalculation(num1, num2, operation);

            Console.WriteLine($"Result: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}

class CalculatorLogic
{
    public int PerformCalculation(int num1, int num2, char operation)
    {
        int result = 0;

        switch (operation)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                // *
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Error: Division by zero");
                }
                break;
            default:
                // * 
                Console.WriteLine("Error: Invalid operation selected.");
                break;
        }

        return result;
    }
}

class CalculatorUtility
{
    // * 
    public string ConvertToBinary(int decimalNumber)
    {
        return Convert.ToString(decimalNumber, 2);
    }
}
