using Calculator;

Numbers numbers = new Numbers();
numbers.GetNumber();


Console.WriteLine("Please Enter Oprator:");
Console.WriteLine("Sum [+ a A]:");
Console.WriteLine("Sub [- s S]:");
Console.WriteLine("Maliple [* m M]");
string operat = Console.ReadLine();

switch (operat)
{
    case "+":
    case "a":
    case "A":
        if(operat == "+" || operat == "a" || operat == "A")
        Console.WriteLine(numbers.sum());
        break;
    case "-":
    case "s":
    case "S":
        if (operat == "-" || operat == "s" || operat == "S")
        Console.WriteLine(numbers.sub());
        break;
    case "*":
    case "m":
    case "M":
        if (operat == "*" || operat == "m" || operat == "M")
        Console.WriteLine(numbers.multiple());
        break;
    default:
        Console.WriteLine("please Enter the correct phrase!");
        break;
}
Console.ReadLine();