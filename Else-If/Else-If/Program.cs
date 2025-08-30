int mahdiAge = 30;
int rezaAge = 30;

if (mahdiAge > rezaAge)
{
    Console.WriteLine("Mahdi is Grater than Reza");
}
else if(mahdiAge < rezaAge)
{
    Console.WriteLine("Reza is Grater than Mahdi");
}
else
{
    Console.WriteLine($"age mahdi:{mahdiAge} and age reza:{rezaAge} so \nage mahdi == age reza");
}

Console.Read();