string operation, indecator;
double firstNumber, secondNumber, result;
Console.WriteLine(" Welcome To My Humble Calculator . . . ");


do
{
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
    Console.WriteLine("If you need to make another calculation type yes ");
    indecator = Console.ReadLine();
    indecator = indecator.Trim().ToLower();
} while (indecator == "yes");