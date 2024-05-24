using App1.Criteriu;
using Entitati;

namespace App1.Filtrare
{
    internal class FiltrarePret : IFiltrare
    {
        public List<ProdusAbstract> Filtrare(List<ProdusAbstract> produse, ICriteriu criteriu)
        {
            if (criteriu is CriteriuPret)
            {
                CriteriuPret pretCriteriu = (CriteriuPret)criteriu;
                List<ProdusAbstract> rezultate = new List<ProdusAbstract>();
                foreach (ProdusAbstract produs in produse)
                {
                    if (pretCriteriu.IsIndeplinit(produs))
                    {
                        rezultate.Add(produs);
                    }
                }
                return rezultate;
            }
            else
            {
                Console.WriteLine("Criteriul trebuie sa fie de tipul CriteriuPret");
                return new List<ProdusAbstract>();
            }
        }
    }
}
