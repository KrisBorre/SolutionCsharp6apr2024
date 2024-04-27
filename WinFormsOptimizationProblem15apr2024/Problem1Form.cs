using LibraryOptimization13apr2024;

namespace WinFormsOptimizationProblem15apr2024
{
    public partial class Problem1Form : Form
    {
        public Problem1Form()
        {
            InitializeComponent();

            Problem problem = new Problem1();

            this.Text = problem.ToString();

            ControlManager controlManager = new ControlManager(problem);

            foreach (Control control in controlManager.Controls)
            {
                this.Controls.Add(control);
            }
        }
    }
}
