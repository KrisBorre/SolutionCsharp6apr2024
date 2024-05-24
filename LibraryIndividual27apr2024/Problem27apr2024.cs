namespace LibraryIndividual27apr2024
{
    public abstract class Problem27apr2024
    {
        public int NumberOfProblemVariables { get; private set; }

        public List<double> UpperBounds { get; set; }
        public List<double> LowerBounds { get; set; }

        public Problem27apr2024(int numberOfProblemVariables)
        {
            NumberOfProblemVariables = numberOfProblemVariables;
            UpperBounds = new List<double>();
            LowerBounds = new List<double>();
        }

        public abstract double GetFitness(params double[] genes);
    }
}
