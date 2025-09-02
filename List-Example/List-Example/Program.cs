List<int> ints = new List<int>();
int sum = 0;


do
{
    Console.Write($"please enter{ints.Count + 1} element of list:");
    int number = int.Parse(Console.ReadLine());
    ints.Add(number);
    sum += number;
}
while (sum < 1000);

Console.WriteLine($"total count of items:{ints.Count}");

Console.ReadLine();