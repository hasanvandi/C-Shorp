
namespace Check_Id;

    public class Person
    {
    public int ID { get; set; }
    public string Name { get; set; }
    public bool Check(int Id)
    {
        return ID == Id;
    }
}

