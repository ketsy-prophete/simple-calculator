﻿try
{
    Console.WriteLine("Please enter a number:");
    int num1 = int.Parse(Console.ReadLine() ?? "");
    Console.WriteLine("Enter another number:");
    int num2 = int.Parse(Console.ReadLine() ?? "");

    Console.WriteLine("Enter Your Option (1-4) \n \t 1. Add \n \t 2. Multiply \n \t 3. Odd/Even \n \t 4. Exit");
    int choice = int.Parse(Console.ReadLine() ?? "") ;

    switch (choice)
    {
        case 1:
            Console.WriteLine($"The sum is: {addNumbers(num1, num2)}");
            break;
        case 2:
            Console.WriteLine($"The product is: {multiplyNumbers(num1, num2)}");
            break;
        case 3:
            Console.WriteLine($"The first number is {oddOrEven(num1)} and the second number is {oddOrEven(num2)}");
            break;
        case 4:
        default:
            break;
    }
}

catch (Exception)
{
    Console.WriteLine("You need to enter a number, please try again.");
}


int addNumbers(int input1, int input2)
{
    int answer = input1 + input2;
    return answer;
}

int multiplyNumbers(int input1, int input2)
{
    int answer = input1 * input2;
    return answer;
}

string oddOrEven(int input)
{
    if (input % 2 == 0)
    {
        return "even";
    }
    else
    {
        return "odd";
    }
}