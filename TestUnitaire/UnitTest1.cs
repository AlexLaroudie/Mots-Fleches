using System.Security.Cryptography.X509Certificates;

namespace TestUnitaire
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestRechercheDico()
        {
            Mots_Fléchés.Dictionnaire a = new Mots_Fléchés.Dictionnaire("fr");
            bool r = true;
            bool t = true;
            List<string> mot = new List<string>();
            bool resultat = a.RechercheDicho(a.ReadFile("MotsPossibleFR.txt"), mot, t, "AGE");


            Assert.AreNotEqual(r, resultat);
        }
    }
}