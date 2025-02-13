
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Mots_Fléchés;
using System.Runtime.CompilerServices;
using System.Threading;

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("         ***********************************************");
Console.WriteLine("         *                                             * ");
Console.WriteLine("         *           Le Jeu de Mots Fléchés !          *");
Console.WriteLine("         *           par Marine et Alexandre           *");             // affichage de présentation
Console.WriteLine("         *                                             * ");
Console.WriteLine("         *********************************************** ");
Console.WriteLine(" ");
Console.ForegroundColor = ConsoleColor.White;
                                          
List<string> mots1 = new List<string>();
List<string> mots2 = new List<string>();

int score1 = 0, score2 = 0;
Console.Write("\nEntrer nom joueur 1 : ");
Joueur joueur1 = new Joueur(Console.ReadLine(), score1, mots1);

Console.Write("\nEntrer nom joueur 2 : ");
Joueur joueur2 = new Joueur(Console.ReadLine(), score2, mots2);

Console.Write("\nChoisissez la langue de jeu (Français ou Anglais) : ");                        // choix de la langue et des plateaux de jeu
string langue = Convert.ToString(Console.ReadLine());
while(langue !="Anglais" && langue != "Français")
{
    Console.WriteLine("Réponse non valide. Veuillez rentrer une autre réponse : Français ou Anglais");
    langue   =   Convert.ToString(Console.ReadLine());
}
Console.Write("\nChoisissez une difficulté de départ, à chaque tour de jeu la difficulté augmentera de 1 jusqu'au niveau 5 : ");
int difficulte = Convert.ToInt32(Console.ReadLine());
Console.Clear();

Jeu partie = new Jeu(joueur1,joueur2);
for (int i = difficulte;i<=5;i++)
{
    Console.WriteLine(" ");
    partie.TourDeJeu(i,joueur1,langue);
    Console.WriteLine(" ");
    Console.WriteLine("Bien joué "+joueur1.Nom+", tu as maintenant "+joueur1.Score+" points!");
    Console.WriteLine(" ");
    Console.WriteLine("C'est le tour de "+joueur2.Nom);
    Thread.Sleep(4000);
    Console.Clear();
    Console.WriteLine(" ");
    partie.TourDeJeu(i,joueur2,langue);
    Console.WriteLine(" ");
    Console.WriteLine("Belle manche " + joueur2.Nom + ", ton score est de " + joueur2.Score);
    Thread.Sleep(4000);
    Console.Clear();
}
Console.WriteLine(" C'est la fin de la partie !!");
Console.Clear();
Console.WriteLine("Le gagnant de cette partie est ...");
for (int i = 0; i < 5; i++)
{
    Thread.Sleep(1000);
    Console.WriteLine(".");
}
if (joueur1.Score>joueur2.Score)
{
    Console.WriteLine("Le gagnant est " + joueur1.Nom + "!");
}
else
{
    if (joueur1.Score == joueur2.Score)
    {
        Console.WriteLine(" Oh mon dieu c'est une égalité !!!");
    }
    else
    {
        Console.WriteLine("Le gagnant est " + joueur2.Nom + "!");
    }
}




