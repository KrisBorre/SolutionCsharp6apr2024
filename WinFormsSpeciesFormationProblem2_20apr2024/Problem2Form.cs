using LibrarySpeciesFormation18apr2024;
using OxyPlot;
using OxyPlot.Series;

namespace WinFormsSpeciesFormationProblem2_20apr2024
{
    public partial class Problem2Form : Form
    {
        private Problem problem;

        public Problem2Form()
        {
            InitializeComponent();

            problem = new Problem2();

            this.Text = problem.ToString();

            PlotModel plotModel = new PlotModel();

            LineSeries series = this.GetFitnessSeries();
            plotModel.Series.Add(series);

            HistogramSeries chs = this.Simulate();
            plotModel.Series.Add(chs);

            this.plotView1.Model = plotModel;
        }


        private LineSeries GetFitnessSeries()
        {
            label1.Text = problem.ToString();

            double lowerBound = problem.LowerBounds[0];
            double upperBound = problem.UpperBounds[0];

            LineSeries series = new LineSeries();

            const int numberOfPlotPoints = 1000;

            for (int i = 1; i < numberOfPlotPoints; i++)
            {
                double x = ((i * (upperBound - lowerBound)) / numberOfPlotPoints) + lowerBound;
                series.Points.Add(new DataPoint(x, problem.GetFitness(x)));
            }

            return series;
        }

        private HistogramSeries Simulate()
        {
            const int populationSize = 1000;
            Population18apr2024 population = new Population18apr2024(problem, populationSize);

            int maximum_number_generations = 5; // 24; // 8;

            string input1 = textBox1.Text;

            System.Globalization.NumberFormatInfo provider = new System.Globalization.NumberFormatInfo();
            provider.NumberDecimalSeparator = ".";

            if (int.TryParse(s: input1, style: System.Globalization.NumberStyles.AllowDecimalPoint, provider: provider, result: out int max_number_generations))
            {
                maximum_number_generations = max_number_generations;
            }
            else
            {
                textBox1.Text = maximum_number_generations.ToString();
            }

            string input2 = textBox2.Text;

            double geneticDistanceThreshold = 0.18;

            if (double.TryParse(s: input2, style: System.Globalization.NumberStyles.AllowDecimalPoint, provider: provider, result: out double double_geneticDistanceThreshold))
            {
                geneticDistanceThreshold = double_geneticDistanceThreshold;
            }
            else
            {
                textBox2.Text = geneticDistanceThreshold.ToString();
            }

            for (int generation = 0; generation < maximum_number_generations; generation++)
            {
                population.Evaluate();
                population.Repopulate20apr2024(geneticDistanceThreshold: geneticDistanceThreshold);
            }

            double lowerBound = problem.LowerBounds[0];
            double upperBound = problem.UpperBounds[0];

            HistogramSeries chs = new HistogramSeries();
            var binningOptions = new BinningOptions(BinningOutlierMode.CountOutliers, BinningIntervalType.InclusiveLowerBound, BinningExtremeValueMode.ExcludeExtremeValues);
            var binBreaks = HistogramHelpers.CreateUniformBins(start: lowerBound, end: upperBound, binCount: 100);
            chs.Items.AddRange(HistogramHelpers.Collect(population.Sample(), binBreaks, binningOptions));
            chs.StrokeThickness = 1;

            // Genetic Algorithms (1999) page 22: x_max=1.850773 with fitness=2.85

            return chs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlotModel plotModel = new PlotModel();

            LineSeries series = this.GetFitnessSeries();
            plotModel.Series.Add(series);

            HistogramSeries chs = this.Simulate();
            plotModel.Series.Add(chs);

            this.plotView1.Model = plotModel;
        }
    }
}
