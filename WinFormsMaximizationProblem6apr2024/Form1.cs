using OxyPlot.Series;
using OxyPlot;

namespace WinFormsMaximizationProblem6apr2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Text = "Maximization Problem of x*(x-y) + z";

            const double lowerBound = 0;
            const double upperBound = 1;

            const int numberOfProblemVariables = 3;

            const int populationSize = 1000;

            const int maximum_number_generations = 50;

            PlotModel plotModel = new PlotModel();
            LineSeries series = new LineSeries();

            double chance_to_pass_on_genes_min = 0.1;
            double chance_to_pass_on_genes_max = 0.999;

            const int numberOfPlotPoints = 100;

            for (int i = 1; i < numberOfPlotPoints; i++)
            {
                double chance_to_pass_on_genes = ((i * (chance_to_pass_on_genes_max - chance_to_pass_on_genes_min)) / numberOfPlotPoints) + chance_to_pass_on_genes_min;

                Population population = new Population(populationSize, lowerBound, upperBound, numberOfProblemVariables);

                for (int generation = 0; generation < maximum_number_generations; generation++)
                {
                    population.Evaluate();
                    population.Repopulate(chance_to_pass_on_genes);
                }

                series.Points.Add(new DataPoint(chance_to_pass_on_genes, population.GetTheHighestFitness()));
            }

            plotModel.Series.Add(series);

            this.plotView1.Model = plotModel;
            Console.WriteLine("Conclusions: ");
            Console.WriteLine("Passing on some of the genes from the best some of the time is better than a random search.");
            Console.WriteLine("Always passing on the genes from the best is worse than allowing some mutations some of the time.");
            Console.WriteLine("A genetic algorithm is better than a random search and is also better than an almost fully deterministic search.");
        }
    }
}
