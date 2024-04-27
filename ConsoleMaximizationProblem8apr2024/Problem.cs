namespace ConsoleMaximizationProblem8apr2024
{
    internal abstract class Problem
    {
        public int NumberOfProblemVariables { get; private set; }

        public Problem(int numberOfProblemVariables)
        {
            NumberOfProblemVariables = numberOfProblemVariables;
        }

        public abstract double GetFitness(params double[] genes);
    }
}
