using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security;

namespace Mots_Fléchés
{
    internal class Joueur
    {
        private string name;
        private int score;
        private List<string> mots_trouves;

        public Joueur(string Name, int Score, List<string> Mots_Trouves)
        {
            this.name = Name;
            this.score = Score;
            this.mots_trouves = Mots_Trouves;
        }

        public string Nom
        {
            get { return name; }
        }

        public List<string> Mots_trouves
        {
            get { return mots_trouves;}
        }
        public string toString()
        {
            string v = "";
            for (int i=0;i<mots_trouves.Count;i++)
            {
                v = v + mots_trouves[i] +" ";
            }
            return ("\n" + "Score : " + this.score + "\nMots trouvés : " + v);
        }
        public void Add_Mots(string mot)
        {
            mots_trouves.Add(mot);
        }
        public void Add_Score(int score, string mot)
        {
            Score += mot.Length;
        }

        public int Score
        {
            get { return score; }
            set { score = value; }
        }
    }
}
