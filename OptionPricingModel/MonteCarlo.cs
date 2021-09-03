using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionPricingModel
{
    class MonteCarlo : IPricer
    {
        readonly double timeStep;
        readonly ulong numOfSims;

        public MonteCarlo(double timeStep, ulong numOfSims)
        {
            this.timeStep = timeStep;
            this.numOfSims = numOfSims;
        }

        public (double, double[,]) Calculate(MarketData md, Option op)
        {
            double rate         = md.InterestRate;
            double vol          = md.Volatility;
            double spot         = md.Spot;
            double yearsToExpiry = op.YearsToExpiry;
            double strike       = op.Strike;
            double sum          = 0.0;
            int timeSteps = (int)(yearsToExpiry / timeStep);
            double[,] sims = new double[numOfSims, timeSteps];
            for (ulong i = 0; i < numOfSims; i++)
            {
                double s_t = spot;
                for (int j = 0; j < timeSteps; j++)
                {
                    s_t = s_t * Math.Pow(Math.E, (timeStep * (rate - Math.Pow(vol, 2) / 2) + vol * HelperFunctions.SampleGaussian(0.0, 1.0)*Math.Sqrt(timeStep)));
                    sims[i, j] = s_t;
                }
                sum += Math.Max(0, (s_t - strike));
            }
            double averagePayoff = sum / numOfSims;
            double price = averagePayoff * Math.Pow(Math.E, -rate*yearsToExpiry);
            return (price, sims);
        }

        public double Calculate(double spot)
        {
            MarketData md = new() { InterestRate = 0.01, Volatility = 0.03, Spot = spot };
            Option op = new() { YearsToExpiry = 1, Strike = 100 };
            return Calculate(md, op).Item1;
        }
    }
}
