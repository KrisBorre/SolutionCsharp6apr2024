using LibraryOptimization13apr2024;

namespace WinFormsOptimizationProblem14apr2024
{
    public partial class Problem3Form : Form
    {
        public Problem3Form()
        {
            InitializeComponent();

            Problem problem = new Problem3();

            this.Text = problem.ToString();

            ControlManager controlManager = new ControlManager(problem);

            foreach (Control control in controlManager.Controls)
            {
                this.Controls.Add(control);
            }
        }
    }
}
