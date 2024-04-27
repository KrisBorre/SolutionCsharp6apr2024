using LibrarySpeciesFormation18apr2024;

namespace WinFormsSpeciesFormationProblem4_19apr2024
{
    public class Problem4 : Problem
    {
        public Problem4() : base(2)
        {
            this.LowerBounds.Add(-3);
            this.UpperBounds.Add(12.1);

            this.LowerBounds.Add(4.1);
            this.UpperBounds.Add(5.8);

        }

        public override double GetFitness(params double[] genes)
        {
            double x = genes[0];
            double y = genes[1];

            return 21.5 + x * Math.Sin(4 * Math.PI * x) + y * Math.Sin(20 * Math.PI * y);
        }

        public override string ToString()
        {
            return "Maximization Problem of 21.5 + x * sin(4 Pi x) + y * sin(20 Pi y)";
        }
    }
}
