using LibrarySpeciesFormation18apr2024;
using OxyPlot.Series;
using OxyPlot;

namespace WinFormsSpeciesFormationProblem2_21apr2024
{
    public partial class Problem2Form : Form
    {
        private Label label1;
        private OxyPlot.WindowsForms.PlotView plotView1;
        private Label label2;
        private Button button1;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;

        private Problem problem;

        public Problem2Form()
        {
            InitializeComponent();

            label1 = new Label();
            plotView1 = new OxyPlot.WindowsForms.PlotView();
            label2 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();

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

            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(712, 422);
            button1.Name = "button1";
            button1.Size = new Size(76, 23);
            button1.TabIndex = 3;
            button1.Text = "Simulate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;

            textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox1.Location = new Point(149, 423);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(39, 23);
            textBox1.TabIndex = 4;
            textBox1.Text = "5";

            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(251, 426);
            label3.Name = "label3";
            label3.Size = new Size(153, 15);
            label3.TabIndex = 5;
            label3.Text = "genetic distance parameter:";

            textBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox2.Location = new Point(410, 423);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(39, 23);
            textBox2.TabIndex = 6;
            textBox2.Text = "0.18";

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(plotView1);
            Controls.Add(label1);
            Name = "Problem2Form";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
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
                textBox1.Text = geneticDistanceThreshold.ToString();
            }

            for (int generation = 0; generation < maximum_number_generations; generation++)
            {
                population.Evaluate();
                population.Repopulate21apr2024(geneticDistanceThreshold: geneticDistanceThreshold);
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
