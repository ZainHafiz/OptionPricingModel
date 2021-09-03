using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionPricingModel
{
    class BlackScholesModel : IPricer
    {

        public double Calculate(MarketData md, Option op)
        {
            int yearsToExpiry = op.YearsToExpiry;
            double d1 = 1 / (md.Volatility * Math.Sqrt(yearsToExpiry)) * (Math.Log(md.Spot / op.Strike) + (md.InterestRate + Math.Pow(md.Volatility, 2) / 2) * yearsToExpiry);
            double d2 = d1 - md.Volatility * Math.Sqrt(yearsToExpiry);
            double price = HelperFunctions.CDF(d1) * md.Spot - HelperFunctions.CDF(d2) * op.Strike * Math.Pow(Math.E, -md.InterestRate * yearsToExpiry);
            return price;
        }

        public double Calculate(double spot)
        {
            MarketData md = new() { InterestRate = 0.01, Volatility = 0.03, Spot = spot};
            Option op = new() { YearsToExpiry = 1, Strike = 100 };
            return Calculate(md, op);
        }
    }
}
