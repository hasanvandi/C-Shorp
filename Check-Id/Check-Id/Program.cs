namespace Check_Id
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            for(int i = 0; i < 10; i++)
            {
                people.Add(new Person());
            }

            Person person = null;
            
            for(int i = 0;i < people.Count; i++)
            {
                if (people[i].Check(i))
                {
                    person = people[i];
                }
            }
        
            Console.ReadLine();
        }
    }
}
