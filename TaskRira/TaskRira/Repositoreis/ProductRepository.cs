using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskRira.Models;
using TaskRira.Repositoreis;
using TaskRira.Service;

namespace TaskRira.Repositoreis
{
    public class ProductRepository : IProductRepository
    {
       List<Product> Products = new List<Product>
       {
           new Product {Id =1,Name="Product A",Category = Categories.Category1, Price=100},
           new Product {Id =2,Name="Product B",Category = Categories.Category1, Price=150},
           new Product {Id =3,Name="Product C",Category = Categories.Category2, Price=120},
           new Product {Id =4,Name="Product D",Category = Categories.Category3, Price=200},
           new Product {Id =5,Name="Product E",Category = Categories.Category1, Price=80},
       };

        /// <summary>
        /// تمام محصولات در کتگوری 1
        /// </summary>
        /// <returns></returns>
        public List<Product> GetAllByCategory()
        {
         return Products
               .Where(c => c.Category == Categories.Category1)
               .ToList();
        }

        /// <summary>
        /// میانگین قیمت محصولات
        /// </summary>
        /// <returns></returns>
        public double GetAverage()
        {
            return Products
                .Average(c => c.Price);
        }

        /// <summary>
        /// گروه بندی محصولات براساس دسته بندی
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IGrouping<Categories, Product>> GetCategories()
        {
            return Products
                .GroupBy(c => c.Category)
                .ToList();
        }

        /// <summary>
        /// محصول با بالاترین قیمت
        /// </summary>
        /// <returns></returns>
        public byte GetMaxPrice()
        {
            return Products
                 .Max(c => c.Price);
            //return Products
            //    .OrderByDescending(c => c.Price)
            //    .FirstOrDefault();
        }

        /// <summary>
        /// مجموع قیمت تمامی محصولات
        /// </summary>
        /// <returns></returns>
        public int GetSumPrice()
        {
            return Products
                .Sum(c => c.Price);
        }
    }
}


