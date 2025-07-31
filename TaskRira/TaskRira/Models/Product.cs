using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskRira.Repositoreis;

namespace TaskRira.Models
{
    public enum Categories
    {
        Category1,
        Category2,
        Category3
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte Price { get; set; }

        public Categories Category { get; set; }

       
    }
}
