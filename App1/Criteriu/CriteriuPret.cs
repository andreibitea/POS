using Entitati;

namespace App1.Criteriu
{
    internal class CriteriuPret : ICriteriu
    {
        public int Pret { get; set; }
        public CriteriuPret(int pret)
        {
            Pret = pret;
        }
        public bool IsIndeplinit(ProdusAbstract produs)
        {
            return produs.Pret == Pret; // verifica daca pretul produsului se potriveste
        }
    }
}
