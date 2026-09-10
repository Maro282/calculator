string operation;
double firstNumber, secondNumber, result;
Console.WriteLine(" Welcome To My Humble Calculator . . . ");

//reading first number
Console.WriteLine("Enter First valid number");
while (!double.TryParse(Console.ReadLine(), out firstNumber))
{
    Console.WriteLine("Invalid Number, Please enter valid value");
}


//reading operation type 
Console.WriteLine("Choose Operator + - * / %");
operation = Console.ReadLine();
while (operation != "+" && operation != "-" && operation != "*" && operation != "/" && operation != "%")
{
    Console.WriteLine("Invalid operator, please choose  from + - * / %");
    operation = Console.ReadLine();
}

//reading second number
Console.WriteLine("Enter second valid number");
while (!double.TryParse(Console.ReadLine(), out secondNumber))
{
    Console.WriteLine("Invalid Number, Please enter valid value");
}


//check if the second number is zero or not in the division operations
if (secondNumber == 0 && (operation == "/" || operation == "%"))
{
    Console.WriteLine("secondNumber couldn't be Zero, please insert another value");
    while (!double.TryParse(Console.ReadLine(), out secondNumber) || secondNumber == 0)
    {
        Console.WriteLine("secondNumber couldn't be Zero, please insert another value");
    }
}


switch (operation)
{
    case "+": result = firstNumber + secondNumber; break;
    case "-": result = firstNumber - secondNumber; break;
    case "*": result = firstNumber * secondNumber; break;
    case "/": result = firstNumber / secondNumber; break;
    case "%": result = firstNumber % secondNumber; break;
    default: result = 0; break;
}


Console.WriteLine($"the result is => {result}");