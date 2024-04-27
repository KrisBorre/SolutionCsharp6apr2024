using LibraryOptimization9apr2024;

namespace ConsoleOptimizationProblem11apr2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double lowerBound = -1;
            const double upperBound = 2;

            const int populationSize = 1000;

            Problem problem = new Problem3();
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

            Console.WriteLine("Minimum is at x=" + theBest + " with fitness=" + fitness);

            /*
            Minimization Problem of x * sin(10 Pi x) + 1.0
            generation         x                    fitness
            0       1,9487300342641443      0,9471792627088391
            1       1,950474002375488       0,9502577489842354
            12      1,9505585743815446      0,9502582575811576
            49      1,950545965205201       0,9502590555107784
            157     1,9505339916565152      0,9502595297787935
            307     1,9505201782800814      0,9502597339178487
            Minimum is at x=1,9505201782800814       with fitness=0,9502597339178487
            */

            Console.ReadLine();
        }
    }
}
