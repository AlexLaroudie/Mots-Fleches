using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace Mots_Fléchés
{
    public class Dictionnaire
    {
        
        private string langue;
        private List<string>[] dico;  
        

        public Dictionnaire(string Langue)
        {
            
            this.langue = Langue;
            this.dico = dico;                     
        }
        public string Langue
        {
            get { return langue; }
        }
        public List<string>[] ReadFile(string Fichier)
        {
            List<string>[] dico = new List<string>[15];
            List<string> test =new List<string>();
            StreamReader flux = null;  // on creer un stream reader pour lire le fichier
            string line;
            int i = 0;
            char[] separateur = { ' ' };   // dès que un espace est lu, on changera de case dans le tableau s
            try
            {
                flux = new StreamReader(Fichier);
                while ((line = flux.ReadLine()) != null)
                {
                    dico[i] = new List<string>();
                    string[] s = line.Split(separateur);                            // on créé un tableau de list pour chaque taille
                    for (int j = 0; j < s.Length; j++)
                    {
                        test.Add(s[j]);
                    }
                    
                    i++;
                }
                
                
                i = 0;
                while (test[i] != "3")
                {                                                                       // chaque case du tableau est remplie par tous les mots d'une certaine taille
                    dico[0].Add(test[i]);
                    i++;
                }
                
                while (test[i] !="4") 
                {
                    dico[1].Add(test[i]);
                    i++;
                }
                while (test[i] != "5")
                {
                    dico[2].Add(test[i]);
                    i++;
                }
                while (test[i] != "6")
                {
                    dico[3].Add(test[i]);
                    i++;
                }
                while (test[i] != "7")
                {
                    dico[4].Add(test[i]);
                    i++;
                }
                while (test[i] != "8")
                {
                    dico[5].Add(test[i]);
                    i++;
                }
                while (test[i] != "9")
                {
                    dico[6].Add(test[i]);
                    i++;
                }
                while (test[i] != "10")
                {
                    dico[7].Add(test[i]);
                    i++;
                }
                while (test[i] != "11")
                {
                    dico[8].Add(test[i]);
                    i++;
                }
                while (test[i] != "12")
                {
                    dico[9].Add(test[i]);
                    i++;
                }
                while (test[i] != "13")
                {
                    dico[10].Add(test[i]);
                    i++;
                }
                while (test[i] != "14")
                {
                    dico[11].Add(test[i]);
                    i++;
                }
                while (test[i] != "15")
                {
                    dico[12].Add(test[i]);
                    i++;
                }


            }
            catch (Exception e)
            {
                Console.WriteLine("Erreur dans le ReadFile" + e.Message);             // si il y a une erreur pour éviter de crasher
            }
            finally
            {
                if (Fichier != null)
                {
                    flux.Close();
                }

            }
            return dico;
            
        }
   
        public string toString()
        {
            return "Langue choisie : " + this.langue + "\nPour la longueur 2 il y a " + dico[0].Count + " mots" + "\nPour la longueur 3 il y a " + dico[1].Count + " mots" + "\nPour la longueur 4 il y a " + dico[2].Count + " mots" + "\nPour la longueur 5 il y a " + dico[3].Count + " mots" + "\nPour la longueur 6 il y a " + dico[4].Count + " mots" + "\nPour la longueur 7 il y a " + dico[5].Count + " mots" + "\nPour la longueur 8 il y a " + dico[6].Count + " mots" + "\nPour la longueur 9 il y a " + dico[7].Count + " mots";       
        }
        public void Affichedico()
        {
            List<string>[] test = ReadFile("MotsPossiblesFR.txt");
            if (test.Length == 0)
            {
                Console.WriteLine("Problème de taille");
            }
            else
            {
                for (int i=0;i<test.Length;i++)
                {
                    for(int j = 0; j < test[i].Count;j++)
                    {
                        Console.Write(test[i][j]+ " ");
                    }
                    Console.WriteLine(" ");
                }
            }
        }
        public static int Compare(string stra, string strb)
        {
            int l = stra.Length;
            int a = 0;
            if (stra.Length > strb.Length)
            {
                l = strb.Length;
            }
            for (int i = 0; i < l && a == 0; i++)
            {
                if (stra[i] > strb[i])
                {
                    a = 1;
                }
                else if (stra[i] < strb[i])
                {
                    a = -1;
                }
            }
            return a;
        }

        public bool RechercheDicho(List<string>[] dico, List<string> mot , bool result, string cible) 
        {
            for (int i=0;i< dico.Length;i++)
            {
                for (int j = 0; j < dico[i].Count; j++)         // on met le dico sous forme de une seule list pour plus de facilité à la manipulation
                {
                    mot.Add(dico[i][j]);
                }
            }
            if (mot.Count == 1 && mot[0] != cible)
            {
                return false;                                   // si un seul mot différent de celui cherhcé on sors faux
            }
            if (mot[mot.Count/2]==cible)
            {
                return true;                                  // si la moitié du tableau c'est le bon mot on sort vrai
            }
            else
            {
                if (cible.Length< mot[mot.Count/2].Length || (cible.Length == mot[mot.Count/2].Length && Compare(cible, mot[mot.Count/2])>1))
                {
                    List<string> list = new List<string>();
                    for (int i=0;i<mot.Count/2;i++)                                   // on créé une autre list composé de la première moitié de la première list et on part en récursivité
                    {
                        list.Add(mot[i]);
                    }
                    return RechercheDicho(dico, list, result, cible);

                }
                else
                {
                    List<string> list = new List<string>();
                    for (int i=mot.Count/2;i<mot.Count;i++)
                    {                                                             // idem avec l'autre partie du tableau
                        list.Add(mot[i]);
                    }
                    return RechercheDicho(dico, list, result,cible);
                }
            }
        }
    }
}

