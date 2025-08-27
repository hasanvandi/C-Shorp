using List_numbers;

List<int> ints = [10, 20, 30, -10, -5];
Calculate calculate = new Calculate();
CalculatePlus calculatePlus= new CalculatePlus();
Calculate plus = new CalculatePlus();

int numbers1 = calculate.SomOfNumbers(ints);
int numbers2 = calculatePlus.SomOfNumbers(ints);
int numbers3 =plus.SomOfNumbers(ints);

Console.WriteLine(numbers1);
Console.WriteLine(numbers2);
Console.WriteLine(numbers3);

Console.ReadLine();