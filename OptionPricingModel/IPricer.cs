using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionPricingModel
{
    interface IPricer
    {
        public double Calculate(double spot);
    }
}
