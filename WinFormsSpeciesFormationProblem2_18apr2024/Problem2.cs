using LibrarySpeciesFormation18apr2024;

namespace WinFormsSpeciesFormationProblem2_18apr2024
{
    public class Problem2 : Problem
    {
        public Problem2() : base(1)
        {
            this.LowerBounds.Add(-1);
            this.UpperBounds.Add(2);
        }

        public override double GetFitness(params double[] genes)
        {
            double x = genes[0];

            return x * Math.Sin(10 * Math.PI * x) + 1.0;
        }

        public override string ToString()
        {
            return "Maximization Problem of x * sin(10 Pi x) + 1.0";
        }
    }
}
