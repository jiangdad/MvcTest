using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectTest
{
    interface IValueCalculator
    {
        decimal ValueProducts(params Product[] products);
    }
}
