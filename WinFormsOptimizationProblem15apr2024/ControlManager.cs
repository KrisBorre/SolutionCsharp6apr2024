using LibraryOptimization13apr2024;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;

namespace WinFormsOptimizationProblem15apr2024
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
        }

        private void Plot()
        {
            labelTop.Text = problem.ToString();
            
            const int numberOfPlotPoints = 200;

            PlotModel plotModel = new PlotModel();
            LineSeries series = new LineSeries();

            double chance_to_pass_on_genes_min = 0.1;
            double chance_to_pass_on_genes_max = 0.999;

            const int populationSize = 1000;

            for (int i = 1; i < numberOfPlotPoints; i++)
            {
                double chance_to_pass_on_genes = ((i * (chance_to_pass_on_genes_max - chance_to_pass_on_genes_min)) / numberOfPlotPoints) + chance_to_pass_on_genes_min;

                Population population = new Population(this.problem, populationSize);

                const int maximum_number_generations = 50;

                for (int generation = 0; generation < maximum_number_generations; generation++)
                {
                    population.Evaluate();
                    population.Repopulate(chance_to_pass_on_genes);
                }

                series.Points.Add(new DataPoint(chance_to_pass_on_genes, population.GetTheHighestFitness()));
            }

            plotModel.Series.Add(series);

            this.plotViews[0].Model = plotModel;

            string s = "Conclusions: " +
                "Passing on some of the genes from the best some of the time is better than a random search. " +
                "Always passing on the genes from the best is worse than allowing some mutations some of the time. " +
                "A genetic algorithm is better than a random search and is also better than an almost fully deterministic search. ";
            labelBottom.Text = s;
        }
    }
}
