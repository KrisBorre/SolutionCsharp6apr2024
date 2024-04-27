using LibraryOptimization13apr2024;

namespace WinFormsOptimizationProblem17apr2024
{
    public partial class Problem5Form : Form
    {
        public Problem5Form()
        {
            InitializeComponent();

            Problem problem = new Problem5();

            this.Text = problem.ToString();

            ControlManager controlManager = new ControlManager(problem);

            foreach (Control control in controlManager.Controls)
            {
                this.Controls.Add(control);
            }
        }
    }
}
