namespace ConsoleMaximizationProblem7apr2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double lowerBound = 0;
            const double upperBound = 1;

            const double chance_to_pass_on_genes = 0.1;

            const int populationSize = 1000;

            const int maximum_number_generations = 50;

            Problem1 problem = new Problem1();
            Console.WriteLine(problem.ToString()); // Maximization Problem of x*(x-y) + z"

            Population population = new Population(problem, populationSize, lowerBound, upperBound);

            Console.WriteLine("generation         x                      y                       z                    fitness");

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
            Maximization Problem of x*(x-y) + z
            generation         x                      y                       z                    fitness
            0       0,9484209217822277      0,06192304243423186     0,9679561336375568      1,8087292695267732
            1       0,9484209217822277      0,019798974050115315    0,9791882838956957      1,8599127675509934
            2       0,9513727640506685      0,01722020470407801     0,9791882838956957      1,8679155863262675
            3       0,9684519297296423      0,01722020470407801     0,9791882838956957      1,90041048361676
            4       0,9684519297296423      0,013821953914045334    0,9791882838956957      1,9037015261520724
            5       0,9983287523492839      0,013821953914045334    0,9489993406222199      1,9318607843834594
            6       0,9995699431745195      0,013821953914045334    0,9489993406222199      1,934323402231709
            11      0,9995699431745195      0,016597555958012843    0,9612878393201566      1,9438374925522819
            12      0,9995699431745195      0,012941623112625266    0,9982183179809797      1,984422331799619
            14      0,9995699431745195      0,012659520382368714    0,9982183179809797      1,984704313209671
            19      0,9995699431745195      0,0012458050629337342   0,9982183179809797      1,9961131199829287
            28      0,9995699431745195      0,0012458050629337342   0,9989406540984943      1,9968354561004433
            */

            Console.WriteLine("x*(x-y)+z is biggest when x=1, y=0, z=1 with the condition that the values are between 0 and 1.");
            Console.ReadLine();
        }
    }
}
