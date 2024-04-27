using OxyPlot.Series;
using OxyPlot;

namespace WinFormsMaximizationProblem8apr2024
{
    public partial class Problem2Form : Form
    {
        public Problem2Form()
        {
            InitializeComponent();

            Problem problem = new Problem2();

            Text = problem.ToString();
            label1.Text = problem.ToString();

            const double lowerBound = -1;
            const double upperBound = 2;

            PlotModel plotModel = new PlotModel();
            LineSeries series = new LineSeries();

            const int numberOfPlotPoints = 1000;

            for (int i = 1; i < numberOfPlotPoints; i++)
            {
                double x = ((i * (upperBound - lowerBound)) / numberOfPlotPoints) + lowerBound;
                series.Points.Add(new DataPoint(x, problem.GetFitness(x)));
            }

            plotModel.Series.Add(series);
            this.plotView1.Model = plotModel;

            const int populationSize = 1000;
            Population population = new Population(problem, populationSize, lowerBound, upperBound);
            const double chance_to_pass_on_genes = 0.1;

            Console.WriteLine("generation         x                    fitness");

            const int maximum_number_generations = 50;
            string theBest = "";
            double fitness = 0;

            for (int generation = 0; generation < maximum_number_generations; generation++)
            {
                population.Evaluate();
                if (population.GetTheHighestFitness() > fitness)
                {
                    theBest = population.TheBest();
                    fitness = population.GetTheHighestFitness();

                    Console.Write(generation + "\t" + theBest); Console.WriteLine(fitness);
                }
                population.Repopulate(chance_to_pass_on_genes);
            }

            label2.Text = "Maximum is at x=" + theBest + " with fitness=" + fitness;
        }
    }
}
