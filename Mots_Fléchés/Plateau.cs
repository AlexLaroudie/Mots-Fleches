using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Mots_Fléchés
{
    public class Plateau
    {
        private char[,] plateau;
        private int difficulte;
        private string[] mots;

        public Plateau(int difficulte, string Langue)
        {
            char[] separator = { ';' };
            if (Langue == "Français")
            {
                if (difficulte == 1)
                {
                    Random rand = new Random();
                    int grille = rand.Next(1, 4);  // On va choisir aléatoirement l'une  des grilles parmi celles disponibles dans des fichiers déja créés
                    string[] fichier = File.ReadAllLines("Cas1_1.csv");
                    switch (grille)
                    {
                        case 1:
                            fichier = File.ReadAllLines("Cas1_1.csv");
                            break;
                        case 2:
                            fichier = File.ReadAllLines("Cas1_2.csv");
                            break;
                        case 3:
                            fichier = File.ReadAllLines("Cas1_3.csv");
                            break;
                    }
                    this.difficulte = fichier[0][0];          //on lit la difficulté sur la ligne 1 et la colonne 1 de notre fichier
                    this.mots = fichier[1].Split(separator);
                    int lignes = 7;
                    int colonnes = 6;
                    ToRead(fichier, lignes, colonnes);
                    this.plateau = plateau;
                }
                if (difficulte == 4)
                {
                    Random rand = new Random();
                    int grille = rand.Next(1, 3);
                    string[] fichier = File.ReadAllLines("Cas4_1.csv");
                    switch (grille)
                    {
                        case 1:
                            fichier = File.ReadAllLines("Cas4_1.csv");
                            break;
                        case 2:
                            fichier = File.ReadAllLines("Cas4_2.csv");
                            break;
                    }
                    this.difficulte = fichier[0][0];          //on lit la difficulté sur la ligne 1 et la colonne 1 de notre fichier
                    this.mots = fichier[1].Split(separator);
                    int lignes = 12;
                    int colonnes = 12;
                    ToRead(fichier, lignes, colonnes);
                    this.plateau = plateau;
                }
                if (difficulte == 5)
                {
                    Random rand = new Random();
                    int grille = rand.Next(1, 5); //on choisit une grille de difficulté 5 de manière aléatoire parmi les 3 proposés
                    string[] fichier = File.ReadAllLines("Cas5_1.csv");
                    switch (grille)
                    {
                        case 1:
                            fichier = File.ReadAllLines("Cas5_1.csv");
                            break;
                        case 2:
                            fichier = File.ReadAllLines("Cas5_2.csv");
                            break;
                        case 3:
                            fichier = File.ReadAllLines("Cas5_3.csv");
                            break;
                        case 4:
                            fichier = File.ReadAllLines("Cas5_4.csv");
                            break;
                    }
                    this.difficulte = fichier[0][0];
                    this.mots = fichier[1].Split(separator);
                    int lignes = 13;
                    int colonnes = 13;
                    ToRead(fichier, lignes, colonnes);
                    this.plateau = plateau;
                }
                if (difficulte == 3)
                {
                    Random rand = new Random();
                    int grille = rand.Next(1, 3); //on choisit une grille de difficulté 5 de manière aléatoire parmi les 3 proposés
                    string[] fichier = File.ReadAllLines("Cas3_1.csv");
                    switch (grille)
                    {
                        case 1:
                            fichier = File.ReadAllLines("Cas3_1.csv");
                            break;
                        case 2:
                            fichier = File.ReadAllLines("Cas3_2.csv");
                            break;
                    }
                    this.difficulte = fichier[0][0];
                    this.mots = fichier[1].Split(separator);
                    int lignes = 11;
                    int colonnes = 11;
                    ToRead(fichier, lignes, colonnes);
                    this.plateau = plateau;
                }
                if (difficulte == 2)
                {
                    Random rand = new Random();
                    int grille = rand.Next(1, 3); //on choisit une grille de difficulté 5 de manière aléatoire parmi les 3 proposés
                    string[] fichier = File.ReadAllLines("Cas2_1.csv");
                    switch (grille)
                    {
                        case 1:
                            fichier = File.ReadAllLines("Cas2_1.csv");
                            break;
                        case 2:
                            fichier = File.ReadAllLines("Cas2_2.csv");
                            break;
                    }
                    this.difficulte = fichier[0][0];
                    this.mots = fichier[1].Split(separator);
                    int lignes = 10;
                    int colonnes = 10;
                    ToRead(fichier, lignes, colonnes);
                    this.plateau = plateau;
                }
            }
            else if(Langue=="Anglais")
            {
                if (difficulte == 1)
                {
                    Random rand = new Random();
                    int grille = rand.Next(1, 3);
                    string[] fichier = File.ReadAllLines("CasA1_1.csv");
                    switch (grille)
                    {
                        case 1:
                            fichier = File.ReadAllLines("CasA1_1.csv");
                            break;
                        case 2:
                            fichier = File.ReadAllLines("CasA1_2.csv");
                            break;
                    }
                    this.difficulte = fichier[0][0];          //on lit la difficulté sur la ligne 1 et la colonne 1 de notre fichier
                    this.mots = fichier[1].Split(separator);
                    int lignes = 7;
                    int colonnes = 6;
                    ToRead(fichier, lignes, colonnes);
                    this.plateau = plateau;
                }
                if (difficulte == 4)
                {
                    Random rand = new Random();
                    int grille = rand.Next(1, 3);
                    string[] fichier = File.ReadAllLines("CasA4_1.csv");
                    switch (grille)
                    {
                        case 1:
                            fichier = File.ReadAllLines("CasA4_1.csv");
                            break;
                        case 2:
                            fichier = File.ReadAllLines("CasA4_2.csv");
                            break;
                    }
                    this.difficulte = fichier[0][0];          //on lit la difficulté sur la ligne 1 et la colonne 1 de notre fichier
                    this.mots = fichier[1].Split(separator);
                    int lignes = 12;
                    int colonnes = 12;
                    ToRead(fichier, lignes, colonnes);
                    this.plateau = plateau;
                }
                if (difficulte == 5)
                {
                    Random rand = new Random();
                    int grille = rand.Next(1, 3); //on choisit une grille de difficulté 5 de manière aléatoire parmi les 3 proposés
                    string[] fichier = File.ReadAllLines("CasA5_1.csv");
                    switch (grille)
                    {
                        case 1:
                            fichier = File.ReadAllLines("CasA5_1.csv");
                            break;
                        case 2:
                            fichier = File.ReadAllLines("CasA5_2.csv");
                            break;
                    }
                    this.difficulte = fichier[0][0];
                    this.mots = fichier[1].Split(separator);
                    int lignes = 13;
                    int colonnes = 13;
                    ToRead(fichier, lignes, colonnes);
                    this.plateau = plateau;
                }
                if (difficulte == 3)
                {
                    Random rand = new Random();
                    int grille = rand.Next(1, 3); //on choisit une grille de difficulté 5 de manière aléatoire parmi les 3 proposés
                    string[] fichier = File.ReadAllLines("CasA3_1.csv");
                    switch (grille)
                    {
                        case 1:
                            fichier = File.ReadAllLines("CasA3_1.csv");
                            break;
                        case 2:
                            fichier = File.ReadAllLines("CasA3_2.csv");
                            break;
                    }
                    this.difficulte = fichier[0][0];
                    this.mots = fichier[1].Split(separator);
                    int lignes = 11;
                    int colonnes = 11;
                    ToRead(fichier, lignes, colonnes);
                    this.plateau = plateau;
                }
                if (difficulte == 2)
                {
                    Random rand = new Random();
                    int grille = rand.Next(1, 3); //on choisit une grille de difficulté 5 de manière aléatoire parmi les 3 proposés
                    string[] fichier = File.ReadAllLines("CasA2_2.csv");
                    switch (grille)
                    {
                        case 1:
                            fichier = File.ReadAllLines("CasA2_1.csv");
                            break;
                        case 2:
                            fichier = File.ReadAllLines("CasA2_2.csv");
                            break;
                    }
                    this.difficulte = fichier[0][0];
                    this.mots = fichier[1].Split(separator);
                    int lignes = 10;
                    int colonnes = 10;
                    ToRead(fichier, lignes, colonnes);
                    this.plateau = plateau;
                }
            }
        }

        public void ToRead(string[]fichier,int lignes,int colonnes)  //méthode créant une grille à partir d'un fichier déja existant
        {
            char[,] plateau = new char[lignes, colonnes];
            for (int i = 0; i < lignes; i++)
            {
                for (int j = 0, k = 0; j < colonnes; j++, k += 2)       //on pose la variable K qui s'incrémente de deux en deux pour eviter les ;
                {
                    plateau[i, j] = fichier[i + 2][k];
                }
            }
            this.plateau = plateau;
        }

        public string ToString(int difficulte)    //methode affichant le plateau en fonction de la difficulte imposée
        {
            int lignes   =  0;
            int colonnes = 0;
            switch (difficulte)         //on a contourné un problème avec les fichiers csv
            {
                case 1:
                    lignes   = 7;
                    colonnes = 6;
                    break;
                case 2:
                    lignes = 10;
                    colonnes = 10;
                    break;
                case 3:
                    lignes   =  11;
                    colonnes = 11;
                    break;
                case 4:
                    lignes   =   12;
                    colonnes = 12;
                    break;
                case 5:
                    lignes = 13;
                    colonnes = 13;
                    break;                     
            }
            string affichage = "";
            
            for(int i = 0; i < mots.Length; i++) //on affiche les mots à chercher
            {
                affichage += mots[i] + " ";
            }
            affichage += "\n";
            Console.WriteLine(affichage);
  
            string affich = "";
            int num_lignes = 0;
            for (int i = 0; i < lignes; i++) 
            {
                if (i >= 10)                        //on affiche les numéros des colonnes 
                {
                    Console.Write(i  + "   ");
                }
                else if (i == 0)
                {
                    Console.Write("     ");
                }
                else
                {
                    Console.Write(i + "    ");
                }
                if (difficulte != 1)                //la matrice n'est pas carré en difficulté 1 donc cas particulier
                {
                    if (i == lignes - 1)
                    {
                        Console.Write(i + 1);
                    }
                }
                if (i == lignes-1) Console.WriteLine("\n");
                
                for (int j = 0; j < colonnes; j++)
                {
                    if (j == 0)
                    {
                        num_lignes = i + 1;
                        if (num_lignes >= 10)
                        {
                           
                            affich += Convert.ToString(num_lignes) + "   " + plateau[i, j] + "    ";       //on affiche les numéros des lignes
                        }
                        else
                        {
                            affich += Convert.ToString(num_lignes) + "    " + plateau[i, j] + "    ";
                        }
                    }
                    else
                    {
                        affich +=plateau[i, j] + "    ";

                    }
                }

                affich += "\n";
            }
            return affich;
        } 

        public bool Test_Plateau(string mot, int ligne,int colonne, string direction)
        {
            bool resultat = true;

            if (colonne > plateau.GetLength(1) || ligne > plateau.GetLength(0))     //on vérifie que les lignes et colonnes rentrés par le joueur ne sont pas en dehors de la matrice
            {
                resultat = false;
            }
            else
            {
                bool presence = mots.Contains(mot);
                if (presence==true)
                {
                    if (direction != "E" && direction != "N" && direction != "S" && direction != "O" && direction != "NO" && direction != "SO" && direction != "NE" && direction != "SE")
                    {
                        resultat = false;
                    }
                    else
                    {
                        if (direction == "E")
                        {
                            if (mot.Length + colonne > plateau.GetLength(1) + 1)  //si le mot + le numéro de la colonne est plus long que la matrice, l'emplacement n'est pas bon
                            {
                                resultat = false;
                            }
                            else
                            {
                                for (int j = 0; j < mot.Length; j++)
                                {
                                    if (plateau[ligne, j + colonne] != mot[j])  //on va vers l'est, donc la position à la ligne ne bouge pas, on incrémente seulement les colonnes de 1 jusqu'à la fin du mot
                                    {
                                        resultat = false;
                                    }
                                }
                            }

                        }
                        if (direction == "O")
                        {
                            if (colonne - mot.Length > 0)
                            {
                                resultat = false;
                            }
                            else
                            {
                                for (int j = 0; j < mot.Length; j++)
                                {
                                    if (plateau[ligne, colonne - j] != mot[j])
                                    {
                                        resultat = false;
                                    }
                                }
                            }
                        }
                        if (direction == "N")
                        {
                            if (ligne - mot.Length < 0)
                            {
                                resultat = false;
                            }
                            else
                            {
                                for (int i = 0; i < mot.Length; i++)
                                {
                                    if (plateau[ligne - i, colonne] != mot[i])
                                    {
                                        resultat = false;
                                    }
                                }
                            }
                        }
                        if (direction == "S")
                        {
                            if (mot.Length + ligne > plateau.GetLength(0) + 1)
                            {
                                resultat = false;
                            }
                            else
                            {
                                for (int i = 0; i < mot.Length; i++)
                                {
                                    if (plateau[ligne + i, colonne] != mot[i])
                                    {
                                        resultat = false;
                                    }
                                }
                            }
                        }
                        if (direction == "SE")
                        {
                            if (mot.Length + ligne > plateau.GetLength(0) + 1 || mot.Length + colonne > plateau.GetLength(1))
                            {
                                resultat = false;
                            }
                            else
                            {
                                for (int i = 0; i < mot.Length; i++)
                                {
                                    if (plateau[ligne + i, colonne + i] != mot[i])
                                    {
                                        resultat = false;
                                    }
                                }
                            }
                        }
                        if (direction == "SO")
                        {
                            if (mot.Length + ligne > plateau.GetLength(0) + 1 || mot.Length + colonne > plateau.GetLength(1))
                            {
                                resultat = false;
                            }
                            else
                            {
                                for (int i = 0; i < mot.Length; i++)
                                {
                                    if (plateau[ligne + i, colonne - i] != mot[i])
                                    {
                                        resultat = false;
                                    }
                                }
                            }
                        }
                        if (direction == "NO")
                        {
                            if (mot.Length + ligne > plateau.GetLength(0) + 1 && mot.Length + colonne > plateau.GetLength(1))
                            {
                                resultat = false;
                            }
                            else
                            {
                                for (int i = 0; i < mot.Length; i++)
                                {
                                    if (plateau[ligne - i, colonne - i] != mot[i])
                                    {
                                        resultat = false;
                                    }
                                }
                            }
                        }
                        if (direction == "NE")
                        {
                            if (mot.Length + ligne > plateau.GetLength(0) + 1 && mot.Length + colonne > plateau.GetLength(1))
                            {
                                resultat = false;
                            }
                            else
                            {
                                for (int i = 0; i < mot.Length; i++)
                                {
                                    if (plateau[ligne - i, colonne + i] != mot[i])
                                    {
                                        resultat = false;
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    resultat   =   false  ;
                }
            }
            return resultat;
        }
    }
}
