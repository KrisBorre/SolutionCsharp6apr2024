﻿namespace LibraryIndividual27apr2024
{
    public class IndividualGenerator27apr2024
    {
        public int NumberOfProblemVariables;

        public List<double> LowerBounds;
        public List<double> UpperBounds;

        public IndividualGenerator27apr2024(int numberOfProblemVariables, List<double> lbounds, List<double> ubounds)
        {
            this.NumberOfProblemVariables = numberOfProblemVariables;

            LowerBounds = lbounds;
            UpperBounds = ubounds;
        }

        /// <summary>
        /// The first value: Negative values correspond with males, positive values correspond with females.
        /// </summary>
        public Individual27apr2024 NewIndividual()
        {
            Individual27apr2024 individual = new Individual27apr2024();

            Random random = new Random();
            for (int i = 0; i < this.NumberOfProblemVariables; i++)
            {
                individual.Numbers.Add(random.NextDouble() * (UpperBounds[i] - LowerBounds[i]) + LowerBounds[i]);
            }
            return individual;
        }

        public Individual27apr2024 NewIndividual(Individual27apr2024 parent1, Individual27apr2024 parent2)
        {
            double geneticDeviation = 0.1; //0.5; //0.01; //0.1; // 0.5; // 0.1;

            Random random = new Random();

            Individual27apr2024 child = new Individual27apr2024();

            int i = 0;
            child.Numbers.Add(random.NextDouble() * (UpperBounds[i] - LowerBounds[i]) + LowerBounds[i]);

            for (i = 1; i < this.NumberOfProblemVariables; i++)
            {
                Individual27apr2024 parent = parent1;
                if (random.NextDouble() < 0.5)
                {
                    parent = parent2;
                }

                while (true)
                {
                    double number = this.SampleNormal(random, parent.Numbers[i], geneticDeviation);

                    if (number >= this.LowerBounds[i] && number <= this.UpperBounds[i])
                    {
                        child.Numbers.Add(number);
                        break;
                    }
                }
            }
            return child;
        }

        private double SampleNormal(Random rnd, double mean, double std)
        {
            // http://en.wikipedia.org/wiki/Box%E2%80%93Muller_transform
            var u1 = 1.0 - rnd.NextDouble();
            var u2 = rnd.NextDouble();
            return Math.Sqrt(-2 * Math.Log(u1)) * Math.Cos(2 * Math.PI * u2) * std + mean;
        }
    }
}
