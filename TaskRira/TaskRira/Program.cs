using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TaskRira.Models;
using TaskRira.Repositoreis;
using TaskRira.Service;

namespace TaskRira
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var userRepository = new ProductRepository();
            var userService = new ProductService(userRepository);
            userService.GetGroupCategory();
            userService.Average();
            userService.Sum();
            userService.MaxPrice();
            userService.GroupbyCategory();
     

            Console.ReadKey();

        }
    }
}
