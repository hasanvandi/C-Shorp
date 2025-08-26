using Inheritance_Example;
using System.Text.Json;
using Newtonsoft.Json;
Parent p = new Parent(5);
Child c = new Child(5, 3);

Parent p2 = new Child(5, 3);
Console.WriteLine(p2.Show());


Child c2 = (Child)p2;
Console.WriteLine(c2.Show());
Console.ReadKey();