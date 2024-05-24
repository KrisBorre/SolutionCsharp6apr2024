﻿namespace LibraryIndividual27apr2024
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
            int initialPopulationSize = originalPopulation.Individuals.Count;

            Population27apr2024 newPopulation = new Population27apr2024(originalPopulation.MaleProblem, originalPopulation.FemaleProblem);

            IndividualGenerator27apr2024 individualGenerator = new IndividualGenerator27apr2024(newPopulation.NumberOfProblemVariables, newPopulation.LowerBounds, newPopulation.UpperBounds);

            Random random = new Random();

            double highestFitness = originalPopulation.GetHighestFitness();
            double lowestFitness = originalPopulation.GetLowestFitness();

            for (int member = 0; member < originalPopulation.Count; member++)
            {
                Individual27apr2024 elder = originalPopulation[member];

                double relativeFitness = (elder.Fitness - lowestFitness) / (highestFitness - lowestFitness);

                if (relativeFitness > random.NextDouble())
                {
                    newPopulation.Individuals.Add(elder);
                    elder.Age++;
                }
            }

            double power = Math.Log10(originalPopulation.Count);
            //power = 1;

            for (int member1 = 0; member1 < originalPopulation.Count; member1++)
            {
                Individual27apr2024 parent1 = originalPopulation[member1];
                double relativeFitness1 = (parent1.Fitness - lowestFitness) / (highestFitness - lowestFitness);

                //if (relativeFitness1 > random.NextDouble())
                if (Math.Pow(relativeFitness1, power) > random.NextDouble())
                {
                    for (int member2 = 0; member2 < originalPopulation.Count; member2++)
                    {
                        if (member1 != member2)
                        {
                            Individual27apr2024 parent2 = originalPopulation[member2];

                            if ((parent1.IsMale() && parent2.IsFemale()) || (parent1.IsFemale() && parent2.IsMale()))
                            {
                                double relativeFitness2 = (parent2.Fitness - lowestFitness) / (highestFitness - lowestFitness);

                                //if (relativeFitness2 > random.NextDouble())
                                if (Math.Pow(relativeFitness2, power) > random.NextDouble())
                                {
                                    Individual27apr2024 child = individualGenerator.NewIndividual(parent1, parent2);

                                    newPopulation.Individuals.Add(child);
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

            for (int member = 0; member < originalPopulation.Count; member++)
            {
                Individual27apr2024 individual = newPopulation.Individuals[member];

                newestPopulation.Individuals.Add(individual);
            }

            return newestPopulation;
        }

    }
}