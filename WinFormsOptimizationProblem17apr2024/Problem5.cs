using LibraryOptimization13apr2024;

namespace WinFormsOptimizationProblem17apr2024
{
    // Genetic Algorithms (1999) page 75
    // The same function as Problem2
    // The Bounds are different from Problem 2
    public class Problem5 : Problem
    {
        public Problem5() : base(1)
        {
            this.LowerBounds.Add(-2);
            this.UpperBounds.Add(1);
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
