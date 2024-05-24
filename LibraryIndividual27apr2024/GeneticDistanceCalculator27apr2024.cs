namespace LibraryIndividual27apr2024
{
    public class GeneticDistanceCalculator27apr2024
    {
        public int NumberOfProblemVariables;

        public GeneticDistanceCalculator27apr2024(int numberOfProblemVariables)
        {
            this.NumberOfProblemVariables = numberOfProblemVariables;
        }

        /// <summary>
        /// Euclidean metric
        /// </summary>
        /// <param name="individual1"></param>
        /// <param name="individual2"></param>
        /// <returns></returns>
        public double CalculateDistance(Individual27apr2024 individual1, Individual27apr2024 individual2)
        {
            double distance = 0;

            // We skip the first choromosome, since that is the X or Y chromosome.
            for (int i = 1; i < this.NumberOfProblemVariables; i++)
            {
                distance += Math.Pow(individual1.Numbers[i] - individual2.Numbers[i], 2);
            }

            return Math.Sqrt(distance);
        }
    }
}
