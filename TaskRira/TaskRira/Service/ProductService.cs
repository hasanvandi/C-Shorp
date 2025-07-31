using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskRira.Models;

namespace TaskRira.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public List<Product> GetGroupCategory()
        {
            var list = _productRepository.GetAllByCategory();
            foreach (var item in list) 
            {
                Console.WriteLine($"Name:{item.Name} Price:{item.Price}");
            }

            return list;
        }

        public void Average()
        {
            var ave = _productRepository.GetAverage();
            Console.WriteLine($"Average is :{ave}");

        }

        public void Sum()
        {
            var sum = _productRepository.GetSumPrice();
                Console.WriteLine($"sum is :{sum}");
            
        }

        public void MaxPrice()
        {
            var maxPrice = _productRepository.GetMaxPrice();
            Console.WriteLine($"maxprice is :{maxPrice}");

        }

        public void GroupbyCategory()
        {
            var group = _productRepository.GetCategories();
            foreach (var item in group)
            {
                Console.WriteLine(item.Key);
                foreach (var item2 in item)
                {
                    Console.WriteLine(item2.Name);
                }
                Console.WriteLine();
            }
        }
    }
}
