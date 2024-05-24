namespace LibraryIndividual27apr2024
{
    public class Population27apr2024
    {
        public List<Individual27apr2024> Individuals;
        public List<double> LowerBounds;
        public List<double> UpperBounds;
        public int NumberOfProblemVariables;

        public Problem27apr2024 MaleProblem;
        public Problem27apr2024 FemaleProblem;

        public Population27apr2024(Problem27apr2024 maleProblem, Problem27apr2024 femaleProblem)
        {
            this.MaleProblem = maleProblem;
            this.FemaleProblem = femaleProblem;
            this.LowerBounds = maleProblem.LowerBounds;
            this.UpperBounds = maleProblem.UpperBounds;
            this.NumberOfProblemVariables = maleProblem.NumberOfProblemVariables;

            this.Individuals = new List<Individual27apr2024>();
        }

        public Individual27apr2024 this[int i]
        {
            get { return Individuals[i]; }
        }

        public int Count { get { return Individuals.Count; } }

        public void Evaluate()
        {
            for (int member = 0; member < this.Individuals.Count; member++)
            {
                Individual27apr2024 individual = this.Individuals[member];
                
                if (individual.IsMale())
                {
                    individual.Evaluate(this.MaleProblem);
                }
                else if (individual.IsFemale())
                {
                    individual.Evaluate(this.FemaleProblem);
                }
            }
        }

        /// <summary>
        /// Precondition: this population has its fitness evaluated.
        /// </summary>
        /// <returns></returns>
        public double GetHighestFitness()
        {
            double result = double.MinValue;
            foreach (Individual27apr2024 individual in this.Individuals)
            {
                if (individual.Fitness > result)
                {
                    result = individual.Fitness;
                }
            }
            return result;
        }

        /// <summary>
        /// Precondition: this population has its fitness evaluated.
        /// </summary>
        /// <returns></returns>
        public double GetLowestFitness()
        {
            double result = double.MaxValue;
            foreach (Individual27apr2024 individual in this.Individuals)
            {
                if (individual.Fitness < result)
                {
                    result = individual.Fitness;
                }
            }
            return result;
        }

        public IEnumerable<double> Sample(int i = 0)
        {
            foreach (Individual27apr2024 individual in this.Individuals)
            {
                yield return individual.Numbers[i];
            }
        }

    }
}

