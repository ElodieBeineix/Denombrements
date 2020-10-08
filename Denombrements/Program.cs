/**
 * 
 * 
 * 
 * 
 */
using System;

namespace Denombrements
{
    class Program
    {
        /// <summary>
        /// calcul du produit de plusieurs entiers successifs, de valeurDepart à valeurArrivee
        /// </summary>
        /// <param name="valeurDepart"></param>
        /// <param name="valeurArrivee"></param>
        /// <returns>resultat du produit ou 0 si dépassement de capacité</returns>
        static long ProduitEntiers (int valeurDepart, int valeurArrivee)
        {
            long produit = 1;
            for (int k = valeurDepart; k<= valeurArrivee; k++)
            {
                produit *= k;
            }
            return produit;
        }
        /// <summary>
        /// Menu permettant de faire plusieurs fois 3 calculs : permutation, arrangement, combinaison
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
                Console.WriteLine("Choix :                            ");
                choix = Console.ReadLine();

                if (choix == "1" || choix == "2" || choix == "3")
                {
                    try
                    {
                        Console.Write("nombre total d'éléments à gérer = ");
                        int nbTotal = int.Parse(Console.ReadLine());
                        //choix permutation
                        if (choix == "1")
                        {
                            long permutation = ProduitEntiers(1, nbTotal);
                            Console.WriteLine(nbTotal + "! = " + permutation);
                        }
                        else
                        {
                            Console.Write("nombre d'éléments dans le sous ensemble = ");
                            int nbSousEnsemble = int.Parse(Console.ReadLine());
                            //calcul de l'arrangement qui sert aussi au calcul de la combinaison
                            long arrangement = ProduitEntiers(nbTotal - nbSousEnsemble + 1, nbTotal);
                            //choix : arrangement
                            if (choix == "2")
                            {
                                Console.WriteLine("A(" + nbTotal + "/" + nbSousEnsemble + ") = " + arrangement);
                            }
                            else
                            {
                                long combinaison = arrangement / ProduitEntiers(1, nbSousEnsemble);
                                Console.WriteLine("C(" + nbTotal + "/" + nbSousEnsemble + ") = " + combinaison);
                            }
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Calcul impossible : valeur(s) incorrecte(s) ou trop grandes.");
                    }
                }
            }
        }
    }
}
