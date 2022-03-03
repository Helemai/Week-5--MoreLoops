using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb kaks mängijat - arvuti(cpu) ja kasutaja (user);
            //mõlemad mängijad viskavad täringuid;
            //programm kontrollib, kumb mängija viskas rohkem;
            //mängija, kes viskab rohkem, ongimängu võitja;
            //*täringuid visatakse kolm korda;
            //programm kuulutab võitja.


            Random rnd = new Random();
            int cpuScore = 0;
            int userScore = 0;

            Console.WriteLine("Viska suvalist nuppu vajutades täringuid.");
            Console.ReadLine();

            for (int i = 0; i < 3; i++)
            {

                int cpuRandom = rnd.Next(1, 7);
                int userRandom = rnd.Next(1, 7);

                

                cpuScore = cpuScore + cpuRandom;
                userScore = userScore + userRandom;
                

                Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}");

                if (i < 2)
                {
                    Console.WriteLine("" + "");
                    Console.WriteLine("Viska täringuid uuesti:");
                    string userName = Console.ReadLine();
                }
                
            }

                if (cpuScore < userScore)
                {
                    Console.WriteLine($"Arvuti täringute summa on {cpuScore}. Kasutaja täringute summa on {userScore}. Kasutaja on mängu võitnud.");

                }
                else if (cpuScore > userScore)
                {
                    Console.WriteLine($"Arvuti täringute summa on {cpuScore}. Kasutaja täringute summa on {userScore}. Arvuti on mängu võitnud.");

                }
                else
                {
                    Console.WriteLine($"Arvuti täringute summa on {cpuScore}. Kasutaja täringute summa on {userScore}. Viik!");
                }

            Console.WriteLine("Kena päeva!");

        }
    }
}
