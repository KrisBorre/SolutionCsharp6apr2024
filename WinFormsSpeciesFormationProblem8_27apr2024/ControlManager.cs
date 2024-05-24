using LibraryIndividual27apr2024;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System.Globalization;

namespace WinFormsSpeciesFormationProblem8_27apr2024
{
    internal class ControlManager
    {
        private readonly List<Control> controls;

        public List<Control> Controls
        {
            get { return controls; }
        }

        private Label label1;
        private PlotView plotView1;
        private Label label2;
        private Button button1;
        private TextBox textBox1;

        private Problem27apr2024 problem;

        private int j = 1; // 0;

        public ControlManager()
        {
            problem = new Problem8();

            this.controls = new List<Control>();

            label1 = new Label();
            plotView1 = new PlotView();
            label2 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();

            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";

            plotView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            plotView1.Location = new Point(12, 27);
            plotView1.Name = "plotView1";
            plotView1.PanCursor = Cursors.Hand;
            plotView1.Size = new Size(776, 389);
            plotView1.TabIndex = 1;
            plotView1.Text = "plotView1";
            plotView1.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView1.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView1.ZoomVerticalCursor = Cursors.SizeNS;

            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(12, 426);
            label2.Name = "label2";
            label2.Size = new Size(131, 15);
            label2.TabIndex = 2;
            label2.Text = "number of generations:";

            textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox1.Location = new Point(149, 423);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(39, 23);
            textBox1.TabIndex = 4;
            textBox1.Text = "2";

            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(712, 422);
            button1.Name = "button1";
            button1.Size = new Size(76, 23);
            button1.TabIndex = 3;
            button1.Text = "Simulate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;

            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(plotView1);
            Controls.Add(label1);

            PlotModel plotModel = new PlotModel();

            LineSeries series = this.GetFitnessSeries(this.j);
            plotModel.Series.Add(series);

            HistogramSeries histogramSeries = this.Simulate(this.j);
            plotModel.Series.Add(histogramSeries);

            this.plotView1.Model = plotModel;
        }


        private LineSeries GetFitnessSeries(int j = 1)
        {
            label1.Text = problem.ToString();

            double lowerBound0 = problem.LowerBounds[0];
            double upperBound0 = problem.UpperBounds[0];

            double lowerBound1 = problem.LowerBounds[1];
            double upperBound1 = problem.UpperBounds[1];

            LineSeries series = new LineSeries();

            const int numberOfPlotPoints = 1000;

            for (int i = 1; i < numberOfPlotPoints; i++)
            {
                if (j == 0)
                {
                    double x = ((i * (upperBound0 - lowerBound0)) / numberOfPlotPoints) + lowerBound0;
                    double y = lowerBound1;
                    series.Points.Add(new DataPoint(x, problem.GetFitness(x, y)));
                }
                else //j > 0
                {
                    double x = lowerBound0;
                    double y = ((i * (upperBound1 - lowerBound1)) / numberOfPlotPoints) + lowerBound1;
                    series.Points.Add(new DataPoint(y, problem.GetFitness(x, y)));
                }
            }

            return series;
        }

        private HistogramSeries Simulate(int j = 1)
        {
            int populationSize = 1000;
            PopulationGenerator27apr2024 populationGenerator = new PopulationGenerator27apr2024();
            Population27apr2024 population = populationGenerator.Initialize(this.problem, this.problem, populationSize);

            int default_number_generations_to_simulate = 2;

            string input1 = textBox1.Text;

            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ".";

            if (int.TryParse(s: input1, style: NumberStyles.AllowDecimalPoint, provider: provider, result: out int number_generations_to_simulate_int))
            {
                default_number_generations_to_simulate = number_generations_to_simulate_int;
            }
            else
            {
                textBox1.Text = default_number_generations_to_simulate.ToString();
            }

            for (int generation = 0; generation < default_number_generations_to_simulate; generation++)
            {
                population.Evaluate();
                population = populationGenerator.Next(population);
            }

            double lowerBound = problem.LowerBounds[j];
            double upperBound = problem.UpperBounds[j];

            HistogramSeries histogramSeries = new HistogramSeries();
            var binningOptions = new BinningOptions(BinningOutlierMode.CountOutliers, BinningIntervalType.InclusiveLowerBound, BinningExtremeValueMode.ExcludeExtremeValues);
            var binBreaks = HistogramHelpers.CreateUniformBins(start: lowerBound, end: upperBound, binCount: 300);
            histogramSeries.Items.AddRange(HistogramHelpers.Collect(population.Sample(j), binBreaks, binningOptions));
            histogramSeries.StrokeThickness = 1;

            return histogramSeries;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlotModel plotModel = new PlotModel();

            LineSeries series = this.GetFitnessSeries(this.j);
            plotModel.Series.Add(series);

            HistogramSeries histogramSeries = this.Simulate(this.j);
            plotModel.Series.Add(histogramSeries);

            this.plotView1.Model = plotModel;
        }
    }
}
