namespace WinFormsSpeciesFormationProblem9_11may2024
{
    public partial class Problem9Form : Form
    {
        public Problem9Form()
        {
            InitializeComponent();

            this.ClientSize = new Size(800, 450);
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;

            Problem9 problem = new Problem9();

            this.Text = problem.ToString();

            ControlManager controlManager = new ControlManager();

            foreach (Control control in controlManager.Controls)
            {
                this.Controls.Add(control);
            }
        }
    }
}
