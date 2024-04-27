using LibrarySpeciesFormation18apr2024;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;

namespace WinFormsSpeciesFormationProblem2_19apr2024
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

        private Label label1;
        private Problem problem;

        public ControlManager(Problem problem)
        {
            this.problem = problem;

            this.controls = new List<Control>();

            label1 = new Label();
            label1.AutoSize = true;
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            Controls.Add(label1);

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

            this.plotViews = new List<PlotView>();

            this.plotViews.Add(plotView1);

            PlotModel plotModel = new PlotModel();

            LineSeries series = this.GetFitnessSeries();
            plotModel.Series.Add(series);

            HistogramSeries chs = this.Simulate();
            plotModel.Series.Add(chs);

            this.plotViews[0].Model = plotModel;
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

            const int maximum_number_generations = 24; // 8;

            for (int generation = 0; generation < maximum_number_generations; generation++)
            {
                population.Evaluate();
                population.Repopulate19apr2024();
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
    }
}
