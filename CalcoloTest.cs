using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalcolatriceLibreria;

namespace Calcolo_Tests
{
    [TestClass]
    public class CalcTest
    {
        public void SommaPositiviTest()
        { 
            int n1 = 9;
            int n2 = 4;
            int somma_aspettata = 13;
            int somma= Calcolo.Somma(n1, n2);
            Assert.AreEqual(somma_aspettata, somma);
        }
        public void DivisionePositiviTest()
        {
            int n1 = 8;
            int n2 = 4;
            int divisione_aspettata = 2;
            int divisione = Calcolo.Divisione(n1, n2);
            Assert.AreEqual(divisione_aspettata, divisione);
        }
    }
}
