﻿namespace LibraryOptimization9apr2024
{
    public class Problem3 : Problem
    {
        public Problem3() : base(1)
        {
        }

        public override double GetFitness(params double[] genes)
        {
            double x = genes[0];

            return -(x * Math.Sin(10 * Math.PI * x) + 1.0);
        }

        public override string ToString()
        {
            return "Minimization Problem of x * sin(10 Pi x) + 1.0";
        }
    }
}
