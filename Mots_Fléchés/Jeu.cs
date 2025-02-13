using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;

namespace Mots_Fléchés
{
    internal class Jeu
    {
        private Joueur joueur1;
        private Joueur joueur2;
        private Plateau[] plateaux;
        private Dictionnaire dico;

        public Jeu(Joueur Joueur1, Joueur joueur2)
        {
            this.joueur1= Joueur1;
            this.joueur2 = joueur2;
        }
        public void TourDeJeu(int difficulte,Joueur joueur,string Langue) 
        {
            Console.WriteLine("Au tour de " + joueur.Nom + ",   Difficulté : " + difficulte+"\n");
            Plateau plateau = new Plateau(difficulte,Langue);
            Console.WriteLine(plateau.ToString(difficulte));
            int temps = 1;
            TimeSpan duree = TimeSpan.FromMinutes(temps);  //création du timer de 1min
            DateTime fin = DateTime.Now + duree; //le timer s'arrête quand il atteint l'heure actuelle + 1minute

            while (DateTime.Now < fin)  //tant que l'heure actuelle est inférieur à l'heure finale, on continue la boucle
            {

                TimeSpan restant = fin - DateTime.Now;
                System.Threading.Thread.Sleep(1000); // pause pendant une seconde
                Console.ForegroundColor= ConsoleColor.DarkRed;
                Console.WriteLine("Il reste " + restant.ToString(@"ss") + " secondes");
                Console.ForegroundColor= ConsoleColor.White;
                Console.Write("mot : ");
                string mot = Convert.ToString(Console.ReadLine()).ToUpper();
                Console.Write("ligne : ");
                int ligne = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.Write("colonne : ");
                int colonne = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.Write("direction (E,O,N,S,SE,SO,NO,NE) : ");
                string direction = Convert.ToString(Console.ReadLine()).ToUpper();
                bool déjavu=joueur.Mots_trouves.Contains(mot);
                if (déjavu == true)
                {
                    Console.WriteLine("Mot déja trouvé.");
                }
                else
                {
                    bool résultat = plateau.Test_Plateau(mot, ligne, colonne, direction);

                    if (résultat == true)
                    {
                        Console.ForegroundColor=ConsoleColor.Green;
                        Console.WriteLine("Mot trouvé.");
                        Console.ForegroundColor= ConsoleColor.White;
                        joueur.Add_Mots(mot);
                        joueur.Add_Score(joueur.Score, mot);
                        Console.WriteLine("\n"+joueur.toString());
                    }
                    else if (résultat == false)
                    {
                        Console.ForegroundColor= ConsoleColor.Red;
                        Console.WriteLine("C'est raté !");
                        Console.ForegroundColor= ConsoleColor.White;
                    }
                }              
                Thread.Sleep(1700);
                Console.Clear();
                Console.WriteLine("Au tour de " + joueur.Nom + ",   Difficulté : " + difficulte);
                Console.WriteLine(plateau.ToString(difficulte));
            }
            Console.ForegroundColor= ConsoleColor.DarkRed;
            Console.WriteLine("Temps écoulé !");
            Console.ForegroundColor= ConsoleColor.White;

        }
    }
}