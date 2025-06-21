using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notebook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Notebook\n");
        
            Console.WriteLine("[1]Add notebook");
            Console.WriteLine("[2]see notebook");
            Console.WriteLine("[3]remove notebook");
            Console.WriteLine("[4]Exit");
           

            Notebook notebook = new Notebook();

            bool IsValaild = false;
            while (!IsValaild)
            {
                Console.Write("Enter your choice:");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        notebook.AddNote();
                        break;
                    case "2":
                        notebook.SeeNotebook();
                        break;
                    case "3":
                        notebook.RemoveNote();
                        break;
                    case "4":
                       IsValaild=false;
                        break;
                    default:
                        Console.WriteLine("Please enter the correct input.");
                        break;

                }
            }


        }

 
    }
}
