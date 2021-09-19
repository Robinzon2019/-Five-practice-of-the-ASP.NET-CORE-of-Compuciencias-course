using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using five_practice.core;

namespace five_practice.data
{
    public interface IProductRepository
    {
        public IEnumerable<Producto> getProductsByCategory();
        public IEnumerable<Producto> getProductshigher3000AndLess5000();
        public IEnumerable<Categoria> getCategoryName();
    }
}
