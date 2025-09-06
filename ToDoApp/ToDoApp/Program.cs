

Console.WriteLine("welcome to 'ToDoApp'");

bool IsValied = false;

List<string> listToDo = [];

while (!IsValied)
{
    Console.WriteLine();
    Console.WriteLine("[A or a] add to list");
    Console.WriteLine("[R or r] remove than list");
    Console.WriteLine("[S or s] see the list");
    Console.WriteLine("[E or e] Exit than list");
    string inputCharacter = Console.ReadLine();
    switch (inputCharacter)
    {
        case "a":
        case "A":
            AddToDo();
            break;
        case "r":
        case "R":
            RemoveToDo();
            break;
        case "e":
        case "E":
            IsValied = true;
            break;
        case "s":
        case "S":
            SeeAllList();
            break;
        default:
            Console.WriteLine("Please try again! and enter the correct character.");
            Console.WriteLine("please Enter the desireb character: ");
            inputCharacter = Console.ReadLine();
            break;
    }
}

void RemoveToDo()
{
    bool isValiedMessage = false;
    while (!isValiedMessage)
    {
        if (!AllowContinue())
        {
            return;
        }

        Console.WriteLine("Are you sure you want to delete the item?[1 = yes,2 = no]");
        SeeAllList();
        Console.Write("Select index:");
        string inputIndex = Console.ReadLine();
        if (inputIndex == "")
        {
            Console.WriteLine("Invalid index:index can not be empty!");
            continue;
        }
        if (int.TryParse(inputIndex, out int value))
        {
            if (value >= 1 && value <= listToDo.Count)
            {
                isValiedMessage = true;
                string toDoForDelete = listToDo[value - 1];
                listToDo.RemoveAt(value - 1);
                Console.WriteLine($"todo removed:{toDoForDelete}");
            }
            else
            {
                Console.WriteLine("index in your range is not correct.");
            }
        }
        else
        {
            Console.WriteLine("Invalid index:index foramt is invalid.");
        }
    }
}

bool AllowContinue()
{
    if (listToDo.Count == 0)
    {
        Console.WriteLine("No items found in the list!");
        return false;
    }
    return true;
}

Console.ReadLine();


void AddToDo()
{
    bool isValiedMessage = false;
    while (!isValiedMessage)
    {
        Console.WriteLine();
        Console.WriteLine("Please enter item:");
        string inputMessage = Console.ReadLine();
        if (inputMessage == "")
        {
            Console.WriteLine("Invalid message:message can not be empty!");
        }
        else if (listToDo.Contains(inputMessage))
        {
            Console.WriteLine("Invalid message:message can not be dupticate!");
        }
        else
        {
            isValiedMessage = true;
            listToDo.Add(inputMessage);
        }

    }

}

void SeeAllList()
{
    if (!AllowContinue())
        return;

    Console.WriteLine("All List ToDo:");
    for (int i = 0; i < listToDo.Count; i++)
    {
        Console.WriteLine($"item{i + 1}:{listToDo[i]}");
    }


}