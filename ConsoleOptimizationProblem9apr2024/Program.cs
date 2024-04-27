using LibraryOptimization9apr2024;

namespace ConsoleOptimizationProblem10apr2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double lowerBound = 0;
            const double upperBound = 1;

            const double chance_to_pass_on_genes = 0.1;

            const int populationSize = 1000;

            Problem1 problem = new Problem1();
            Console.WriteLine(problem.ToString()); // Maximization Problem of x*(x-y) + z"

            Population population = new Population(problem, populationSize, lowerBound, upperBound);

            Console.WriteLine("generation         x                      y                       z                    fitness");

            const int maximum_number_generations = 50;
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

            Console.WriteLine("Maximum is at (x,y,z)=" + theBest + " with fitness=" + fitness);

            /*
            Maximization Problem of x*(x-y) + z
            generation         x                      y                       z                    fitness
            0       0,9533528955436092      0,10476865438035161     0,9259454579679042      1,7349457013935723
            1       0,9995586778966518      0,1147850850200211      0,9259454579679042      1,8103285807015395
            2       0,9995586778966518      0,1147850850200211      0,9834917997864503      1,8678749225200857
            3       0,9995586778966518      0,062270525871902016    0,9786276919667738      1,9155021980128286
            4       0,9995586778966518      0,009126944471675412    0,9490986531363328      1,9390932871454911
            5       0,9995586778966518      0,009126944471675412    0,9805178572333035      1,970512491242462
            7       0,9995586778966518      0,009126944471675412    0,9969053147346272      1,9868999487437855
            15      0,9995586778966518      0,009126944471675412    0,9991015647533823      1,9890961987625406
            23      0,9999437388032413      0,006405007562788672    0,9991015647533823      1,9925843983157892
            33      0,9999437388032413      0,0038809981215191065   0,9991015647533823      1,995108265753267
            Maximum is at (x,y,z)=0,9999437388032413        0,0038809981215191065   0,9991015647533823       with fitness=1,995108265753267
            */

            Console.WriteLine("x*(x-y)+z is biggest when x=1, y=0, z=1 with the condition that the values are between 0 and 1.");
            Console.ReadLine();
        }
    }
}
