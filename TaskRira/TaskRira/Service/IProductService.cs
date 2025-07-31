using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskRira.Models;

namespace TaskRira.Service
{
    public interface IProductService
    {
        List<Product>  GetGroupCategory();

        void Average();
        void Sum();
        void MaxPrice();

        void GroupbyCategory();
    }
}
