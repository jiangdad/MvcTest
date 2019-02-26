using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectTest
{
    class ShopCart
    {
        IValueCalculator ivalueCa;
        public ShopCart(IValueCalculator ivalueCalculator)
        {
            ivalueCa = ivalueCalculator;
        }
        public decimal CalculateStockValue()
        {
            Product[] products= {
                new Product { Name = "苹果", Price = 1 },
                new Product { Name = "梨", Price = 3 }
            };

            decimal totalValue =ivalueCa.ValueProducts(products);

            return totalValue;
        }
    }
}
