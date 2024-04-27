namespace LibrarySpeciesFormation18apr2024
{
    public class Genotype18apr2024
    {
        public List<double> Gene;
        public double Fitness;

        public Genotype18apr2024(int numberOfProblemVariables, List<double> lbounds, List<double> ubounds)
        {
            Gene = new List<double>();
            Random random = new Random((int)DateTime.Now.Ticks);
            for (int i = 0; i < numberOfProblemVariables; i++)
            {
                Gene.Add(random.NextDouble() * (ubounds[i] - lbounds[i]) + lbounds[i]);
            }
        }
    }
}
