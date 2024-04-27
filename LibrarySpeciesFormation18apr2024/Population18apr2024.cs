﻿namespace LibrarySpeciesFormation18apr2024
{
    public class Population18apr2024
    {
        private List<Genotype18apr2024> population;
        private List<double> lowerBounds;
        private List<double> upperBounds;
        private int numberOfProblemVariables;

        private Problem problem;

        public Population18apr2024(Problem problem, int populationSize)
        {
            this.problem = problem;
            this.lowerBounds = problem.LowerBounds;
            this.upperBounds = problem.UpperBounds;
            this.numberOfProblemVariables = problem.NumberOfProblemVariables;

            this.population = new List<Genotype18apr2024>();

            for (int i = 0; i < populationSize; i++)
            {
                this.population.Add(new Genotype18apr2024(this.numberOfProblemVariables, this.lowerBounds, this.upperBounds));
            }
        }

        /// <summary>
        /// Euclidean metric
        /// </summary>
        /// <param name="genotype1"></param>
        /// <param name="genotype2"></param>
        /// <returns></returns>
        public double CalculateGeneticDistance(Genotype18apr2024 genotype1, Genotype18apr2024 genotype2)
        {
            double distance = 0;

            for (int i = 0; i < this.numberOfProblemVariables; i++)
            {
                distance += Math.Pow(genotype1.Gene[i] - genotype2.Gene[i], 2);
            }

            return Math.Sqrt(distance);
        }


        public void Repopulate21apr2024(double geneticDistanceThreshold = 0.1)
        {
            Random random = new Random((int)DateTime.Now.Ticks);

            double highestFitness = GetHighestFitness();
            double lowestFitness = GetLowestFitness();

            for (int member = 0; member < this.population.Count; member++)
            {
                var m = this.population[member];

                for (int candidate = 0; candidate < this.population.Count; candidate++)
                {
                    var c = this.population[candidate];

                    if (member != candidate)
                    {
                        double comparedfitness = (c.Fitness - m.Fitness) / (highestFitness - lowestFitness);
                        if (comparedfitness > 0 && comparedfitness > random.NextDouble())
                        {
                            double distance = CalculateGeneticDistance(m, c);
                            if (distance < Math.Abs(this.SampleNormal(random, 0, geneticDistanceThreshold)))
                            {
                                for (int i = 0; i < this.numberOfProblemVariables; i++)
                                {
                                    while (true)
                                    {
                                        m.Gene[i] = this.SampleNormal(random, c.Gene[i], geneticDistanceThreshold / 10.0);
                                        if (m.Gene[i] >= this.lowerBounds[i] && m.Gene[i] <= this.upperBounds[i])
                                        {
                                            break;
                                        }
                                    }
                                }

                                candidate = this.population.Count;
                            }
                        }
                    }
                }
            }
        }

        public void Repopulate20apr2024(double geneticDistanceThreshold = 0.1)
        {
            Random random = new Random((int)DateTime.Now.Ticks);

            double highestFitness = GetHighestFitness();
            double lowestFitness = GetLowestFitness();

            for (int member = 0; member < this.population.Count; member++)
            {
                var m = this.population[member];

                for (int candidate = 0; candidate < this.population.Count; candidate++)
                {
                    var c = this.population[candidate];

                    if (member != candidate)
                    {
                        double comparedfitness = (c.Fitness - m.Fitness) / (highestFitness - lowestFitness);
                        if (comparedfitness > 0 && comparedfitness > random.NextDouble())
                        {
                            double distance = CalculateGeneticDistance(m, c);
                            if (distance < Math.Abs(this.SampleNormal(random, 0, geneticDistanceThreshold)))
                            {
                                for (int i = 0; i < this.numberOfProblemVariables; i++)
                                {
                                    while (true)
                                    {
                                        m.Gene[i] = this.SampleNormal(random, c.Gene[i], geneticDistanceThreshold / 10.0);
                                        if (m.Gene[i] >= this.lowerBounds[i] && m.Gene[i] <= this.upperBounds[i])
                                        {
                                            break;
                                        }
                                    }
                                }

                                candidate = this.population.Count;
                            }
                        }
                    }
                }
            }
        }

        private double SampleNormal(Random rnd, double mean, double std)
        {
            // http://en.wikipedia.org/wiki/Box%E2%80%93Muller_transform
            var u1 = 1.0 - rnd.NextDouble();
            var u2 = rnd.NextDouble();
            return Math.Sqrt(-2 * Math.Log(u1)) * Math.Cos(2 * Math.PI * u2) * std + mean;
        }

        public void Repopulate19apr2024(double geneticDistanceThreshold = 0.1)
        {
            Random random = new Random((int)DateTime.Now.Ticks);

            double highestFitness = GetHighestFitness();
            double lowestFitness = GetLowestFitness();

            for (int member = 0; member < this.population.Count; member++)
            {
                var m = this.population[member];

                for (int candidate = 0; candidate < this.population.Count; candidate++)
                {
                    var c = this.population[candidate];

                    if (member != candidate)
                    {
                        if ((c.Fitness - m.Fitness) / (highestFitness - lowestFitness) > random.NextDouble())
                        {
                            if (CalculateGeneticDistance(m, c) < geneticDistanceThreshold)
                            {
                                for (int i = 0; i < this.numberOfProblemVariables; i++)
                                {
                                    m.Gene[i] = c.Gene[i] + geneticDistanceThreshold * (random.NextDouble() - 0.5);
                                    if (m.Gene[i] < this.lowerBounds[i] || m.Gene[i] > this.upperBounds[i])
                                    {
                                        m.Gene[i] = (random.NextDouble() * (this.upperBounds[i] - this.lowerBounds[i]) + this.lowerBounds[i]);
                                    }
                                }
                            }
                        }
                    }
                }

            }
        }

        public void Repopulate()
        {
            Random random = new Random((int)DateTime.Now.Ticks);

            double highestFitness = GetHighestFitness();
            double lowestFitness = GetLowestFitness();

            for (int member = 0; member < this.population.Count; member++)
            {
                var m = this.population[member];

                double parameter = 2.0;
                // if the parameter is 1.0, then "if (m.Fitness < highestFitness)" is almost always true.
                // if the parameter is 1.0, then we change the best often.

                // if the parameter is 10.0, then "if (m.Fitness < highestFitness / 10)" is "if(m.Fitness < 0.28)"
                // if the parameter is 10.0, then we don't do much.

                //if (m.Fitness < highestFitness / parameter)
                if ((1 / parameter) - (m.Fitness / highestFitness) > 0)
                {
                    for (int candidate = 0; candidate < this.population.Count; candidate++)
                    {
                        var c = this.population[candidate];
                        if (member != candidate)
                        {
                            //if (c.Fitness < highestFitness / parameter)
                            if (0 < (1 / parameter) - (c.Fitness / highestFitness))
                            {
                                for (int i = 0; i < this.numberOfProblemVariables; i++)
                                {
                                    m.Gene[i] = (random.NextDouble() * (this.upperBounds[i] - this.lowerBounds[i]) + this.lowerBounds[i]);
                                }
                            }
                            else
                            {
                                if (CalculateGeneticDistance(m, c) < 0.1)
                                {
                                    for (int i = 0; i < this.numberOfProblemVariables; i++)
                                    {
                                        m.Gene[i] = c.Gene[i];
                                    }
                                }
                            }
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

        public double GetHighestFitness()
        {
            double result = double.MinValue;
            foreach (Genotype18apr2024 genotype in this.population)
            {
                if (genotype.Fitness > result)
                {
                    result = genotype.Fitness;
                }
            }
            return result;
        }

        public double GetLowestFitness()
        {
            double result = double.MaxValue;
            foreach (Genotype18apr2024 genotype in this.population)
            {
                if (genotype.Fitness < result)
                {
                    result = genotype.Fitness;
                }
            }
            return result;
        }

        public IEnumerable<double> Sample(int i = 0)
        {
            foreach (Genotype18apr2024 genotype in this.population)
            {
                yield return genotype.Gene[i];
            }
        }

    }
}

