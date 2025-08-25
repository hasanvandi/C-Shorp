PcGuess pc = new();
var rand = pc.randomPc(1, 10);
int numberGuess = 2;
for (int i = 0; i < numberGuess; i++)
{
    Console.Write($"Please enter guess {i + 1}:");
    int num = int.Parse(Console.ReadLine());
    if(num == rand)
    {
        Console.WriteLine("verey good you are win!");
        break;
    }
    else
    {
        Console.WriteLine("try agian!");
    }
    if(i == 2)
    {
        Console.WriteLine("Oh you are not win...");
        break;
    }

}

Console.ReadLine();
