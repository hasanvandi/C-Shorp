string userInput = Console.ReadLine();
while(userInput.Length <= 10)
{
    Console.WriteLine("invalid input lenght.please enter more 10 charachter");
    userInput = Console.ReadLine();
}

Console.WriteLine("thankyou!");

Console.ReadLine();