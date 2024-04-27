using LibraryOptimization9apr2024;

namespace ConsoleOptimizationProblem10apr2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double lowerBound = -1;
            const double upperBound = 2;

            const int populationSize = 1000;

            Problem problem = new Problem2();
            Console.WriteLine(problem.ToString());

            Population population = new Population(problem, populationSize, lowerBound, upperBound);
            const double chance_to_pass_on_genes = 0.1;

            Console.WriteLine("generation         x                    fitness");

            const int maximum_number_generations = 500;
            string theBest = "";
            double fitness = 0;

            for (int generation = 0; generation < maximum_number_generations; generation++)
            {
                population.Evaluate();
                if (population.GetTheHighestFitness() > fitness)
                {
                    theBest = population.TheBest();
                    fitness = population.GetTheHighestFitness();
                    Console.Write(generation + "\t" + theBest); Console.WriteLine(fitness);
                }
                population.Repopulate(chance_to_pass_on_genes);
            }

            Console.WriteLine("Maximum is at x=" + theBest + " with fitness=" + fitness);

            /*
            Maximization Problem of x * sin(10 Pi x) + 1.0
            generation         x                    fitness
            0       1,8474575792660275      2,841567675896612
            1       1,8514733323135757      2,849490385337552
            3       1,8509367689727512      2,850135284740325
            4       1,850533876032817       2,85027359803468
            303     1,8505534184400707      2,8502737343979234
            485     1,8505481238712314      2,8502737663727618
            Maximum is at x=1,8505481238712314       with fitness=2,8502737663727618
            */

            // Genetic Algorithms (1999) page 22: x_max=1.850773 with fitness=2.85
            Console.ReadLine();
        }
    }
}
