using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OptionPricingModel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Generate();
        }


        public double IntrinsicCalculator(double spot)
        {
            double strike = Convert.ToDouble(textBoxK.Text);
            return Math.Max(0, spot - strike);
        }
        private bool ValidateFields()
        {
            return
                Double.TryParse(textBoxV.Text, out double tempDouble)
                && Double.TryParse(textBoxR.Text, out tempDouble)
                && Double.TryParse(textBoxS.Text, out tempDouble)
                && Double.TryParse(textBoxK.Text, out tempDouble)
                && Double.TryParse(textBoxTS.Text, out tempDouble)
                && int.TryParse(textBoxT.Text, out int tempInt)
                && int.TryParse(textBoxSim.Text, out tempInt);
        }

        public void Generate()
        {
            if (!ValidateFields())
                return;
            MarketData data = new();
            data.Volatility = Convert.ToDouble(textBoxV.Text);
            data.InterestRate = Convert.ToDouble(textBoxR.Text);
            data.Spot = Convert.ToDouble(textBoxS.Text);
            Option option = new();
            option.Strike = Convert.ToDouble(textBoxK.Text);
            option.YearsToExpiry = int.Parse(textBoxT.Text);

            BlackScholesModel modelBS = new();
            textBoxBS.Text = Math.Round(modelBS.Calculate(data, option), 2).ToString();

            ulong numOfSims = UInt64.Parse(textBoxSim.Text);
            double timeStep = Convert.ToDouble(textBoxTS.Text);
            double timesteps = option.YearsToExpiry / timeStep;

            MonteCarlo modelMC = new(timeStep, numOfSims);
            var results = modelMC.Calculate(data, option);
            var price = results.Item1;
            var sims = results.Item2;
            var myModel = new PlotModel { Title = "Monte Carlo Model" , Background = OxyColor.FromRgb(255, 255, 255)};
            myModel.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom, Minimum = 0, Maximum = timesteps });
            for (ulong i = 0; i < numOfSims; i++)
            {
                var scatterSeries = new ScatterSeries { MarkerType = MarkerType.Circle, MarkerSize = 2 };
                for (int j = 0; j < timesteps; j++)
                {
                    scatterSeries.Points.Add(new ScatterPoint(j, sims[i, j]));
                }
                myModel.Series.Add(scatterSeries);
            }
            textBoxMC.Text = Math.Round(price, 2).ToString();


            Delta delta = new(0.01);
            textBoxDelta.Text = Math.Round(delta.Calculate(modelBS, data.Spot), 2).ToString();

            this.plotView1.Model = myModel;

        }


        private void trackBarV_Scroll(object sender, EventArgs e)
        {
            textBoxV.Text = (trackBarV.Value/100.0).ToString();
        }

        private void trackBarR_Scroll(object sender, EventArgs e)
        {
            textBoxR.Text = (trackBarR.Value/100.0).ToString();
        }

        private void trackBarS_Scroll(object sender, EventArgs e)
        {
            textBoxS.Text = trackBarS.Value.ToString();
        }

        private void trackBarK_Scroll(object sender, EventArgs e)
        {
            textBoxK.Text = trackBarK.Value.ToString();
        }

        private void trackBarT_Scroll(object sender, EventArgs e)
        {
            textBoxT.Text = trackBarT.Value.ToString();
        }

        private void textBoxV_TextChanged(object sender, EventArgs e)
        {
            Generate();
        }

        private void textBoxR_TextChanged(object sender, EventArgs e)
        {
            Generate();
        }

        private void textBoxS_TextChanged(object sender, EventArgs e)
        {
            Generate();
        }

        private void textBoxK_TextChanged(object sender, EventArgs e)
        {
            Generate();
        }

        private void textBoxT_TextChanged(object sender, EventArgs e)
        {
            Generate();
        }

        private void textBoxTS_TextChanged(object sender, EventArgs e)
        {
            Generate();
        }

        private void textBoxSim_TextChanged(object sender, EventArgs e)
        {
            Generate();
        }

        private void trackBarTS_Scroll(object sender, EventArgs e)
        {
            textBoxTS.Text = (trackBarTS.Value/1000).ToString();
        }

        private void trackBarSim_Scroll(object sender, EventArgs e)
        {
            textBoxSim.Text = (Math.Pow(2, trackBarSim.Value)).ToString();
        }
    }
}
