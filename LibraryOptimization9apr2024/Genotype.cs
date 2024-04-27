namespace LibraryOptimization9apr2024
{
    internal class Genotype
    {
        public List<double> Gene;
        public double Fitness;

        public Genotype(int numberOfProblemVariables = 3, double lbound = 0, double ubound = 1)
        {
            Gene = new List<double>();
            Random random = new Random((int)DateTime.Now.Ticks);
            for (int i = 0; i < numberOfProblemVariables; i++)
            {
                Gene.Add(random.NextDouble() * (ubound - lbound) + lbound);
            }
        }
    }
}
