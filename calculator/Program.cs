string operation;
double firstNumber, secondNumber, result;
Console.WriteLine(" Welcome To My Humble Calculator . . . ");

//reading first number
Console.WriteLine("Enter First valid number");
firstNumber = double.Parse(Console.ReadLine());


//reading operation type 
Console.WriteLine("Choose Operator + - * / %");
operation = Console.ReadLine();

//reading second number
Console.WriteLine("Enter second valid number");
secondNumber = double.Parse(Console.ReadLine());


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