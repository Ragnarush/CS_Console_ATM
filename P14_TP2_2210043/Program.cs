/*
 Algorithme: le guichet
 * Description: Algorithme qui saisit une somme de dollar entier et affiche le nombre minimum de billet(s) et piece(s) pour arriver a cette somme. 
 * fait par:Francois Gignac
 * date: 02/05/2022
 * revision:  0
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14_TP2_no1_2210043
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //variable
            string str_recommencer;
            string str_somme;
            char recommencer;

            //demander une somme a l'utilisateur et saisir la donner
            do
            {
                //variables (je met les variables ici dans la boucle principale afin qu'elle 'reset' a 0 si l'usager recommence le program
                int somme = 0, somme_initial = 0, billet_100 = 0, billet_50 = 0, billet_20 = 0, billet_10 = 0, billet_5 = 0, piece_2 = 0, piece_1 = 0, cpt1 = 0, cpt2 = 0;

                //validation de la saisie de l'utilisateur
                do
                {
                    switch (cpt1)
                    {
                        case 0:
                            Console.Write("Veuillez entrer une somme de dollar entier (les cents ne seront pas tenu comptes) : ");
                            str_somme = Console.ReadLine();
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Vous n'avez pas entrer un nombre entier, veuillez svp entrer un nombre entier: ");
                            Console.ResetColor();
                            str_somme = Console.ReadLine();
                            break;
                    }
                    cpt1++;
                }
                while (int.TryParse(str_somme, out somme) == false || somme < 0);



                //je conserve ma somme initial afin de la re-afficher a l'utilisateur vers la fin de l'algorithme
                somme_initial = somme;

                //calculer le nombre de billet minimum pour arriver a cette somme
                billet_100 = Convert.ToInt32(somme / 100);
                somme = somme - (billet_100 * 100);
                billet_50 = Convert.ToInt32(somme / 50);
                somme = somme - (billet_50 * 50);
                billet_20 = Convert.ToInt32(somme / 20);
                somme = somme - (billet_20 * 20);
                billet_10 = Convert.ToInt32(somme / 10);
                somme = somme - (billet_10 * 10);
                billet_5 = Convert.ToInt32(somme / 5);
                somme = somme - (billet_5 * 5);
                piece_2 = Convert.ToInt32(somme / 2);
                somme = somme - (piece_2 * 2);
                piece_1 = Convert.ToInt32(somme / 1);
                somme = somme - (piece_1 * 1);

                //le text a gauche, le nombre de billet a droite
                //afficher le resultat a l'utilisateur
                Console.Clear();
                Console.WriteLine("Selon la somme mentionner, {0}$, nous avons calculer le nombre minimal de billet(s) et de piece(s) necessaire pour arriver a cette somme, sans tenir compte des cents, voici le resultat:", somme_initial);
                Console.WriteLine("");
                Console.WriteLine("{0,20} {1,3}", "nombre de billet(s) de 100$:", billet_100);
                Console.WriteLine("{0,20} {1,3}", "nombre de billet(s) de 50$: ", billet_50);
                Console.WriteLine("{0,20} {1,3}", "nombre de billet(s) de 20$: ", billet_20);
                Console.WriteLine("{0,20} {1,3}", "nombre de billet(s) de 10$: ", billet_10);
                Console.WriteLine("{0,20} {1,3}", "nombre de billet(s) de 5$   ", billet_5);
                Console.WriteLine("{0,20} {1,3}", "nombre de piece(s) de 2$:   ", piece_2);
                Console.WriteLine("{0,20} {1,3}", "nombre de piece(s) de 1$:   ", piece_1);
                Console.WriteLine("");

                do
                {
                    switch (cpt2)
                    {
                        case 0:
                            Console.Write("Voulez-vous recommencer ? ('O' pour recommencer , 'N' pour quitter): ");
                            str_recommencer = Console.ReadLine().ToUpper();
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Vous n'avez pas entrer une reponse valide, entrer 'O' pour recommencer ou 'N' pour quitter: ");
                            Console.ResetColor();
                            str_recommencer = Console.ReadLine().ToUpper();
                            break;
                    }
                    cpt2++;
                }
                while (char.TryParse(str_recommencer, out recommencer) == false || recommencer != 'O' &&  recommencer != 'N');

                if (recommencer == 'N')
                {
                    Console.Write("Appuyez une touche pour quitter ");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                else
                    continue;
            }
            while (recommencer == 'O');
        }
    }
}
