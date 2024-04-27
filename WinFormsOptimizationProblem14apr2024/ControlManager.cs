using LibraryOptimization13apr2024;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System.Diagnostics;

namespace WinFormsOptimizationProblem14apr2024
{
    internal class ControlManager
    {
        private List<Control> controls;

        public List<Control> Controls
        {
            get { return controls; }
        }

        private List<PlotView> plotViews;

        public List<PlotView> PlotViews
        {
            get { return plotViews; }
        }

        private Label labelTop;
        private Label labelBottom;
        private Problem problem;

        public ControlManager(Problem problem)
        {
            this.problem = problem;

            this.controls = new List<Control>();

            labelTop = new Label();
            labelTop.AutoSize = true;
            labelTop.Location = new Point(10, 7);
            labelTop.Name = "label1";
            labelTop.Size = new Size(38, 15);
            labelTop.TabIndex = 0;            
            Controls.Add(labelTop);

            PlotView plotView1 = new PlotView();
            plotView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            plotView1.Location = new Point(12, 25);
            plotView1.Name = "plotView1";
            plotView1.PanCursor = Cursors.Hand;
            plotView1.Size = new Size(776, 398);
            plotView1.TabIndex = 2;
            plotView1.Text = "plotView1";
            plotView1.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView1.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView1.ZoomVerticalCursor = Cursors.SizeNS;
            Controls.Add(plotView1);

            labelBottom = new Label();
            labelBottom.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelBottom.AutoSize = true;
            labelBottom.Location = new Point(10, 426);
            labelBottom.Name = "label2";
            labelBottom.Size = new Size(38, 15);
            labelBottom.TabIndex = 1;            
            Controls.Add(labelBottom);

            this.plotViews = new List<PlotView>();

            this.plotViews.Add(plotView1);

            this.Plot();

            this.Simulate();
        }

        private void Plot()
        {
            labelTop.Text = problem.ToString();

            const double lowerBound = -1;
            const double upperBound = 2;

            PlotModel plotModel = new PlotModel();
            LineSeries series = new LineSeries();

            const int numberOfPlotPoints = 1000;

            for (int i = 1; i < numberOfPlotPoints; i++)
            {
                double x = ((i * (upperBound - lowerBound)) / numberOfPlotPoints) + lowerBound;
                series.Points.Add(new DataPoint(x, -problem.GetFitness(x))); // x * Math.Sin(10 * Math.PI * x) + 1.0
            }

            plotModel.Series.Add(series);
            this.plotViews[0].Model = plotModel;
        }

        private void Simulate()
        {
            const int populationSize = 1000;
            Population population = new Population(problem, populationSize);
            const double chance_to_pass_on_genes = 0.1;

            Debug.WriteLine("generation         x                    fitness");

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

                    Debug.Write(generation + "\t" + theBest); Debug.WriteLine(fitness);
                }
                population.Repopulate(chance_to_pass_on_genes);
            }

            labelBottom.Text = "Minimum is at x=" + theBest + " with fitness=" + fitness;
            // Minimum is at x=1,9505201782800814       with fitness=0,9502597339178487
        }
    }
}
