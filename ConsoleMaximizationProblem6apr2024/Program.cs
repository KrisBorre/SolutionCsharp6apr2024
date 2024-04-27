namespace ConsoleMaximizationProblem6apr2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maximization Problem of x*(x-y) + z");

            const int numberOfProblemVariables = 3;

            const double lowerBound = 0;
            const double upperBound = 1;

            const double chance_to_pass_on_genes = 0.1;

            const int populationSize = 1000;

            const int maximum_number_generations = 50;

            List<Genotype> population = new List<Genotype>();
            for (int i = 0; i < populationSize; i++)
            {
                population.Add(new Genotype(numberOfProblemVariables, lowerBound, upperBound));
            }

            Console.WriteLine("generation         x                      y                       z                    fitness");

            double fitness = 0;
            for (int generation = 0; generation < maximum_number_generations; generation++)
            {
                evaluate(population);
                int current_best_indivual = get_the_best(population);

                if (population[current_best_indivual].Fitness > fitness)
                {
                    Console.Write(generation + "\t");
                    Console.Write(population[current_best_indivual].Gene[0] + "\t");
                    Console.Write(population[current_best_indivual].Gene[1] + "\t");
                    Console.Write(population[current_best_indivual].Gene[2] + "\t");
                    Console.WriteLine(population[current_best_indivual].Fitness);
                }

                fitness = population[current_best_indivual].Fitness;

                repopulate(lowerBound, upperBound, numberOfProblemVariables, population, current_best_indivual, chance_to_pass_on_genes);
            }

            /*
Maximization Problem of x*(x-y) + z
generation         x                      y                       z                    fitness
0       0,9799791318271212      0,0278566815088767      0,8388667566882757      1,77192688894426
1       0,9799791318271212      0,016968474731300247    0,9299463610769931      1,8736767087580213
2       0,9799791318271212      0,016968474731300247    0,9976574913587689      1,941387839039797
3       0,9918410251810407      0,016968474731300247    0,9976574913587689      1,9645760812176953
8       0,9918410251810407      0,014133352327222634    0,9976574913587689      1,9673880719294692
10      0,9940047995159424      0,014133352327222634    0,9976574913587689      1,9716544127729887
16      0,9940047995159424      0,0002774144524137557   0,9976574913587689      1,9854272815223435
46      0,9979024706398614      0,0002774144524137557   0,9976574913587689      1,9931899997004534
47      0,9991118493485786      0,001194121316631381    0,9976574913587689      1,9946889181104994
*/
            Console.WriteLine("x*(x-y)+z is biggest when x=1, y=0, z=1 with the condition that the values are between 0 and 1.");
            Console.ReadLine();
        }

        static void repopulate(double lbound, double ubound, int numberOfProblemVariables, List<Genotype> population, int current_best_indivual, double chance_to_pass_on_genes)
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            for (int member = 0; member < population.Count; member++)
            {
                if (member != current_best_indivual)
                {
                    for (int i = 0; i < numberOfProblemVariables; i++)
                    {
                        if (random.NextDouble() < chance_to_pass_on_genes)
                        {
                            population[member].Gene[i] = population[current_best_indivual].Gene[i];
                        }
                        else
                        {
                            population[member].Gene[i] = (random.NextDouble() * (ubound - lbound) + lbound);
                        }
                    }
                }
            }
        }

        static void evaluate(List<Genotype> population)
        {
            for (int member = 0; member < population.Count; member++)
            {
                List<double> chromosomes = population[member].Gene;
                double x = chromosomes[0];
                double y = chromosomes[1];
                double z = chromosomes[2];

                population[member].Fitness = x * (x - y) + z;
            }
        }

        static int get_the_best(List<Genotype> population)
        {
            int current_best_individual = 0;
            double highest_fitness = population[0].Fitness;

            for (int member = 1; member < population.Count; member++)
            {
                if (population[member].Fitness > highest_fitness)
                {
                    current_best_individual = member;
                    highest_fitness = population[member].Fitness;
                }
            }
            return current_best_individual;
        }
    }
}
