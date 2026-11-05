using System;

namespace Denombrements
{
    /// <summary>
    /// Application console de calculs de dénombrements :
    /// permutation, arrangement et combinaison
    /// </summary>
    class Program
    {
        /// <summary>
        /// Affiche un menu en boucle et lance le calcul choisi
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string c = "1";
            while (c != "0")
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                c = Console.ReadLine();

                if (c == "0")
                {
                    Environment.Exit(0);
                }

                try
                {
                    // choix : permutation
                    if (c == "1")
                    {
                        Console.Write("nombre total d'éléments à gérer = ");
                        int n = int.Parse(Console.ReadLine());
                        // calcul de r
                        long r = 1;
                        for (int k = 1; k <= n; k++)
                        {
                            r *= k;
                        }
                        Console.WriteLine(n + "! = " + r);
                    }
                    else
                    {
                        // choix : arrangement
                        if (c == "2")
                        {
                            Console.Write("nombre total d'éléments à gérer = ");
                            int t = int.Parse(Console.ReadLine());
                            Console.Write("nombre d'éléments dans le sous ensemble = ");
                            int n = int.Parse(Console.ReadLine());
                            // calcul de r
                            long r = 1;
                            for (int k = (t - n + 1); k <= t; k++)
                            {
                                r *= k;
                            }
                            Console.WriteLine("A(" + t + "/" + n + ") = " + r);
                        }
                        //choix : combinaison
                        else if (c == "3")
                        {
                            Console.Write("nombre total d'éléments à gérer = ");
                            int t = int.Parse(Console.ReadLine());
                            Console.Write("nombre d'éléments dans le sous ensemble = ");
                            int n = int.Parse(Console.ReadLine());
                            // calcul de r1
                            long r1 = 1;
                            for (int k = (t - n + 1); k <= t; k++)
                            {
                                r1 *= k;
                            }
                            // calcul de r2
                            long r2 = 1;
                            for (int k = 1; k <= n; k++)
                            {
                                r2 *= k;
                            }
                            Console.WriteLine("C(" + t + "/" + n + ") = " + (r1 / r2));
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Saisie incorrecte : entre un nombre entier.");
                }
            Console.ReadLine();
            }
        }
    }
}
