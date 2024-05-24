namespace LibraryIndividual27apr2024
{
    public class PopulationGenerator27apr2024
    {
        public PopulationGenerator27apr2024()
        { }

        public Population27apr2024 Initialize(Problem27apr2024 maleProblem, Problem27apr2024 femaleProblem, int populationSize)
        {
            Population27apr2024 population = new Population27apr2024(maleProblem, femaleProblem);

            IndividualGenerator27apr2024 individualGenerator = new IndividualGenerator27apr2024(population.NumberOfProblemVariables, population.LowerBounds, population.UpperBounds);

            for (int i = 0; i < populationSize; i++)
            {
                Individual27apr2024 individual = individualGenerator.NewIndividual();

                population.Individuals.Add(individual);
            }

            return population;
        }

        /// <summary>
        /// Precondition: originalPopulation has its fitness evaluated.
        /// </summary>
        /// <param name="originalPopulation"></param>
        /// <returns></returns>
        public Population27apr2024 Next(Population27apr2024 originalPopulation)
        {
            int populationSize = originalPopulation.Count;

            Population27apr2024 newPopulation = new Population27apr2024(originalPopulation.MaleProblem, originalPopulation.FemaleProblem);

            IndividualGenerator27apr2024 individualGenerator = new IndividualGenerator27apr2024(newPopulation.NumberOfProblemVariables, newPopulation.LowerBounds, newPopulation.UpperBounds);

            GeneticDistanceCalculator27apr2024 geneticDistanceCalculator = new GeneticDistanceCalculator27apr2024(newPopulation.NumberOfProblemVariables);

            Random random = new Random();

            double highestFitness = originalPopulation.GetHighestFitness();
            double lowestFitness = originalPopulation.GetLowestFitness();

            for (int member = 0; member < populationSize; member++)
            {
                Individual27apr2024 elder = originalPopulation[member];

                double relativeFitness = (elder.Fitness - lowestFitness) / (highestFitness - lowestFitness);

                if (relativeFitness > random.NextDouble())
                {
                    newPopulation.Individuals.Add(elder);
                    elder.Age++;
                }
            }

            double power = Math.Log10(populationSize);

            for (int member1 = 0; member1 < populationSize; member1++)
            {
                Individual27apr2024 parent1 = originalPopulation[member1];
                double relativeFitness1 = (parent1.Fitness - lowestFitness) / (highestFitness - lowestFitness);

                if (Math.Pow(relativeFitness1, power) > random.NextDouble())
                {
                    for (int member2 = 0; member2 < populationSize; member2++)
                    {
                        if (member1 != member2)
                        {
                            Individual27apr2024 parent2 = originalPopulation[member2];

                            if ((parent1.IsMale() && parent2.IsFemale()) || (parent1.IsFemale() && parent2.IsMale()))
                            {
                                double relativeFitness2 = (parent2.Fitness - lowestFitness) / (highestFitness - lowestFitness);

                                if (Math.Pow(relativeFitness2, power) > random.NextDouble())
                                {
                                    if (geneticDistanceCalculator.CalculateDistance(parent1, parent2) < 1.75 * random.NextDouble())
                                    {
                                        Individual27apr2024 child = individualGenerator.NewIndividual(parent1, parent2);

                                        newPopulation.Individuals.Add(child);
                                    }
                                }
                            }
                        }
                    }
                }
            }

            // Reduce the population size to the initial population size.
            newPopulation.Evaluate();

            newPopulation.Individuals.Sort();

            Population27apr2024 newestPopulation = new Population27apr2024(originalPopulation.MaleProblem, originalPopulation.FemaleProblem);

            for (int member = 0; member < Math.Min(populationSize, newPopulation.Individuals.Count); member++)
            {
                Individual27apr2024 individual = newPopulation.Individuals[member];

                newestPopulation.Individuals.Add(individual);
            }

            return newestPopulation;
        }

    }
}
