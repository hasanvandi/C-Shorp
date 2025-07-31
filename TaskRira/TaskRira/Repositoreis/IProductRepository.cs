using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskRira.Models;
using TaskRira.Repositoreis;
using TaskRira.Service;

namespace TaskRira.Service
{
    public interface IProductRepository
    {
        List<Product> GetAllByCategory();
        byte GetMaxPrice();

        int GetSumPrice();

        IEnumerable<IGrouping<Categories,Product>> GetCategories();

        double GetAverage();

    }
}

