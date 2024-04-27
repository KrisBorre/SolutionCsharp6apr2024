namespace LibraryOptimization9apr2024
{
    public abstract class Problem
    {
        public int NumberOfProblemVariables { get; private set; }

        public Problem(int numberOfProblemVariables)
        {
            NumberOfProblemVariables = numberOfProblemVariables;
        }

        public abstract double GetFitness(params double[] genes);
    }
}
