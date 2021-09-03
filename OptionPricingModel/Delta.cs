using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionPricingModel
{
    class Delta
    {
        double bumpSize;

        public Delta(double bumpSize)
        {
            this.bumpSize = bumpSize;
        }

        public double Calculate(IPricer pricer, double spot)
        {
            return (pricer.Calculate(spot + bumpSize)-pricer.Calculate(spot - bumpSize)) / (2 * bumpSize);
        }
    }
}
