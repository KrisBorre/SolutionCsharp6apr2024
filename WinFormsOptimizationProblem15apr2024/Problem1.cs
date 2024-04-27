using LibraryOptimization13apr2024;

namespace WinFormsOptimizationProblem15apr2024
{
    public class Problem1 : Problem
    {
        public Problem1() : base(3)
        {
            this.LowerBounds.Add(0);
            this.UpperBounds.Add(1);

            this.LowerBounds.Add(0);
            this.UpperBounds.Add(1);

            this.LowerBounds.Add(0);
            this.UpperBounds.Add(1);
        }

        public override double GetFitness(params double[] genes)
        {
            double x = genes[0];
            double y = genes[1];
            double z = genes[2];

            return x * (x - y) + z;
        }

        public override string ToString()
        {
            return "Maximization Problem of x*(x-y) + z";
        }
    }
}

