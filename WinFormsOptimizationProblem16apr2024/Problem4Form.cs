using LibraryOptimization13apr2024;

namespace WinFormsOptimizationProblem16apr2024
{
    public partial class Problem4Form : Form
    {
        public Problem4Form()
        {
            InitializeComponent();

            Problem problem = new Problem4();

            this.Text = problem.ToString();

            ControlManager controlManager = new ControlManager(problem);

            foreach (Control control in controlManager.Controls)
            {
                this.Controls.Add(control);
            }
        }
    }
}
