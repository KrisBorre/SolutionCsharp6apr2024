using LibraryIndividual27apr2024;

namespace WinFormsSpeciesFormationProblem8_27apr2024
{
    public class Problem8 : Problem27apr2024
    {
        public Problem8() : base(2)
        {
            this.LowerBounds.Add(-1);
            this.UpperBounds.Add(1);

            this.LowerBounds.Add(-1);
            this.UpperBounds.Add(1);
        }

        public override double GetFitness(params double[] genes)
        {
            double x = genes[0];
            double y = genes[1];

            if (x < 0)
            {
                // males prosper when the y gene is positive one.
                return y;
            }
            else // x > 0
            {
                // females prosper when the y gene is negative one.
                return -y;
            }

            // return x * y;
        }

        public override string ToString()
        {
            return "Optimization problem where males and females have a different fitness evaluation functions.";
            //return "Maximization Problem of x*y";
        }
    }
}
