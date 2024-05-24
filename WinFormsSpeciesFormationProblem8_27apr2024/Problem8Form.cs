namespace WinFormsSpeciesFormationProblem8_27apr2024
{
    public partial class Problem8Form : Form
    {
        public Problem8Form()
        {
            InitializeComponent();

            this.ClientSize = new Size(800, 450);
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;

            Problem8 problem = new Problem8();

            this.Text = problem.ToString();

            ControlManager controlManager = new ControlManager();

            foreach (Control control in controlManager.Controls)
            {
                this.Controls.Add(control);
            }
        }
    }
}

