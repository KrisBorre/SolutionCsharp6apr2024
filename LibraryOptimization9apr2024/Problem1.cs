namespace LibraryOptimization9apr2024
{
    public class Problem1 : Problem
    {
        public Problem1() : base(3)
        {
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

