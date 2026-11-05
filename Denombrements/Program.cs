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
            string choix = "1";
            while (choix != "0")
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                choix = Console.ReadLine();

                //choix correct  excluant le choix de quitter
                if (choix == "1" || choix == "2" || choix == "3")
                {

                    try
                    {
                        Console.Write("nombre total d'éléments à gérer = ");
                        int nbTotal = int.Parse(Console.ReadLine());

                        // choix : permutation
                        if (choix == "1")
                        {
                            long r = 1;
                            for (int k = 1; k <= nbTotal; k++)
                            {
                                r *= k;
                            }
                            Console.WriteLine(nbTotal + "! = " + r);
                        }
                        else
                        {
                            Console.Write("nombre d'éléments dans le sous ensemble = ");
                            int nbSousEnsemble = int.Parse(Console.ReadLine());
                            long arrangement = 1;
                            for (int k = (nbTotal - nbSousEnsemble + 1); k <= nbTotal; k++)
                            {
                                arrangement *= k;
                            }
                            // choix : arrangement
                            if (choix == "2")
                            {
                                Console.WriteLine("A(" + nbTotal + "/" + nbSousEnsemble + ") = " + arrangement);
                            }
                            //choix : combinaison
                            else
                            {
                                long factorielle = 1;
                                for (int k = 1; k <= nbSousEnsemble; k++)
                                {
                                    factorielle *= k;
                                }
                                Console.WriteLine("C(" + nbTotal + "/" + nbTotal + ") = " + (arrangement / factorielle));
                            }
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Saisie incorrecte : entre un nombre entier.");
                    }
                }
            }
        }
    }
}