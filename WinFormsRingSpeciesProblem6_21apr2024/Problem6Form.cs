using LibraryRingSpecies21apr2024;
using OxyPlot;
using OxyPlot.Series;

namespace WinFormsRingSpeciesProblem6_21apr2024
{
    public partial class Problem6Form : Form
    {
        public Problem6Form()
        {
            InitializeComponent();

            Text = "Ring species";

            const int populationSize = 2000;

            Problem problem = new Problem6();

            Population21apr2024 population = new Population21apr2024(problem, populationSize);

            PlotModel plotModel = new PlotModel();
            LineSeries series1 = new LineSeries();
            series1.LineStyle = LineStyle.Dot;
            series1.StrokeThickness = 1;
            series1.MarkerType = MarkerType.Circle;
            series1.MarkerSize = 3;

            for (int i = 0; i < population.Count; i++)
            {
                var populationItem = population[i];
                double x = populationItem.Gene[0];
                double y = populationItem.Gene[1];

                series1.Points.Add(new DataPoint(x, y));
            }

            plotModel.Series.Add(series1);

            LineSeries series2 = new LineSeries();
            series2.LineStyle = LineStyle.Dot;
            series2.StrokeThickness = 1;
            series2.MarkerType = MarkerType.Circle;
            series2.MarkerSize = 3;

            int maximum_number_generations = 500; // 200; // 100; // 50;

            double geneticDistanceThreshold = 0.5; // 2; // 0.2;

            for (int generation = 0; generation < maximum_number_generations; generation++)
            {
                population.Evaluate();
                population.Repopulate21apr2024(geneticDistanceThreshold: geneticDistanceThreshold);
            }


            for (int i = 0; i < population.Count; i++)
            {
                var populationItem = population[i];
                double x = populationItem.Gene[0];
                double y = populationItem.Gene[1];

                series2.Points.Add(new DataPoint(x, y));
            }

            plotModel.Series.Add(series2);

            this.plotView1.Model = plotModel;
        }
    }
}
