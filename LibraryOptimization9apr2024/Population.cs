namespace LibraryOptimization9apr2024
{
    public class Population
    {
        private List<Genotype> population;
        private double lowerBound = 0;
        private double upperBound = 1;
        private int numberOfProblemVariables = 3;

        private Problem problem;

        public Population(Problem problem, int populationSize, double lowerBound = 0, double upperBound = 1)
        {
            this.problem = problem;
            this.lowerBound = lowerBound;
            this.upperBound = upperBound;
            this.numberOfProblemVariables = problem.NumberOfProblemVariables;

            this.population = new List<Genotype>();

            for (int i = 0; i < populationSize; i++)
            {
                this.population.Add(new Genotype(this.numberOfProblemVariables, lowerBound, upperBound));
            }
        }

        public string TheBest()
        {
            string result = "";
            int current_best_individual = this.GetBestIndividual();
            Genotype best_genotype = this.population[current_best_individual];
            for (int i = 0; i < this.numberOfProblemVariables; i++)
            {
                result += best_genotype.Gene[i] + "\t";
            }
            return result;
        }

        private int GetBestIndividual()
        {
            int current_best_individual = 0;
            double highest_fitness = this.population[0].Fitness;

            for (int member = 1; member < this.population.Count; member++)
            {
                if (this.population[member].Fitness > highest_fitness)
                {
                    current_best_individual = member;
                    highest_fitness = this.population[member].Fitness;
                }
            }
            return current_best_individual;
        }

        public double GetTheHighestFitness()
        {
            int current_best_individual = this.GetBestIndividual();
            double highest_fitness = this.population[current_best_individual].Fitness;
            return highest_fitness;
        }

        public void Repopulate(double chance_to_pass_on_genes)
        {
            int current_best_individual = this.GetBestIndividual();

            Random random = new Random((int)DateTime.Now.Ticks);
            for (int member = 0; member < this.population.Count; member++)
            {
                if (member != current_best_individual)
                {
                    for (int i = 0; i < this.numberOfProblemVariables; i++)
                    {
                        if (random.NextDouble() < chance_to_pass_on_genes)
                        {
                            this.population[member].Gene[i] = this.population[current_best_individual].Gene[i];
                        }
                        else
                        {
                            this.population[member].Gene[i] = (random.NextDouble() * (this.upperBound - this.lowerBound) + this.lowerBound);
                        }
                    }
                }
            }
        }

        public void Evaluate()
        {
            for (int member = 0; member < this.population.Count; member++)
            {
                List<double> chromosomes = this.population[member].Gene;

                this.population[member].Fitness = this.problem.GetFitness(chromosomes.ToArray());
            }
        }

    }
}

