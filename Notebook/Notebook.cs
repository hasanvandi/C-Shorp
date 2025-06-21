using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notebook
{
    public class Notebook
    {
        List<string> notes = new List<string>();

        /// <summary>
        /// نمایش لیست دفترچه
        /// </summary>
        public void SeeNotebook()
        {
            for (int i = 0; i < notes.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{notes[i]}");
            }
        }

        /// <summary>
        /// افزودن یادداشت
        /// </summary>
        public void AddNote()
        {
            Console.Write("How many notes do you want to add?");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                Console.Write("Please Enter your note?");
                string input = Console.ReadLine();
                notes.Add(input);
            }

            Console.WriteLine("note added successfully.");
            Console.WriteLine();

        }
        /// <summary>
        /// حذف یادداشت
        /// </summary>
        public void RemoveNote()
        {
            SeeNotebook();
            bool deleted = false;
            while (!deleted)
            {
                Console.WriteLine("Are you sure you want to delete this note(1 = yes,2=no)?");
                string input = Console.ReadLine();
                if (input == "1")
                {
                    Console.Write("which item should be deleted?");

                    int num = int.Parse(Console.ReadLine());
                    notes.RemoveAt(num - 1);
                    Console.WriteLine($"deleted item {num}");
                    deleted = true;

                }
                else if (input == "2")
                {
                    return;
                    deleted = true;

                }
                else
                {
                    Console.WriteLine("Please enter the correct input.");
                }
            }

        }


    }
}
