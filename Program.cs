// See https://aka.ms/new-console-template for more information
//1.Calculator
/*int firstNumber, secondNumber;
string operation;
Console.Write("Enter firstNumber : ");
firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("operation : ");
operation = Console.ReadLine();
Console.Write("Enter secondNumber : ");
secondNumber = Convert.ToInt32(Console.ReadLine());
double result;

switch(operation)
{
    case "+" : result = firstNumber+secondNumber; break;
    case "-" : result = firstNumber-secondNumber; break;
    case "*" : result = firstNumber*secondNumber; break;
    case "/" : result = firstNumber/secondNumber; break;
    default: result = 0; break;
}
Console.WriteLine("Result : "+ result);*/

//2. Raqamlar qatorining yig‘indisini hisoblash:
/*Console.Write("Enter number : ");
int number,sum = 0;
number = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i <= number; i++)
{
    sum += i;
}
Console.WriteLine("Sum From 1 to number : "+sum);*/

//3.  Paritet tekshiruvi:
Console.Write("Enter number : ");
int number;
number = Convert.ToInt32(Console.ReadLine());
if(number % 2 == 0) Console.WriteLine("Juft");
else Console.WriteLine("Toq");
Console.ReadKey();