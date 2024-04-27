namespace ConsoleMaximizationProblem8apr2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double lowerBound = -1;
            const double upperBound = 2;

            const double chance_to_pass_on_genes = 0.1;

            const int populationSize = 1000;

            const int maximum_number_generations = 500;

            Problem problem = new Problem2();
            Console.WriteLine(problem.ToString());

            Population population = new Population(problem, populationSize, lowerBound, upperBound);

            Console.WriteLine("generation         x                    fitness");

            double fitness = 0;

            for (int generation = 0; generation < maximum_number_generations; generation++)
            {
                population.Evaluate();
                if (population.GetTheHighestFitness() > fitness)
                {
                    fitness = population.GetTheHighestFitness();
                    Console.Write(generation + "\t"); population.WriteTheBest(); Console.WriteLine(fitness);
                }
                population.Repopulate(chance_to_pass_on_genes);
            }

            /*
            Maximization Problem of x * sin(10 Pi x) + 1.0
            generation         x                    fitness
            0       1,8497498872921567      2,8496927851973126
            1       1,850790377636808       2,8502198535872196
            17      1,8504511913519592      2,850265298946897
            49      1,8505086898107588      2,8502723930800835
            138     1,8505796775457353      2,85027281880988
            374     1,8505398383599427      2,850273713612556
            */

            Console.ReadLine();
        }
    }
}
