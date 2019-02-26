using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel ninjectKernel = new StandardKernel();
            ninjectKernel.Bind<IValueCalculator>().To<ValueCalculator>();
            ninjectKernel.Bind<IDiscountHelper>().To<DiscountHelp>();
            IValueCalculator iva = ninjectKernel.Get<IValueCalculator>();
            
            ShopCart cart = new ShopCart(iva);
            decimal a= cart.CalculateStockValue();
            Console.Write(a);
            Console.Read();
        }
    }
}
