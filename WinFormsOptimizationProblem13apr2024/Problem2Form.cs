using LibraryOptimization13apr2024;

namespace WinFormsOptimizationProblem13apr2024
{
    public partial class Problem2Form : Form
    {
        public Problem2Form()
        {
            InitializeComponent();

            Problem problem = new Problem2();

            this.Text = problem.ToString();

            ControlManager controlManager = new ControlManager(problem);

            foreach (Control control in controlManager.Controls)
            {
                this.Controls.Add(control);
            }
        }
    }
}
