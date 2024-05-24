using App1.Criteriu;
using App1.Filtrare;
using Entitati;

namespace App1
{
    public abstract class ProdusAbstractMgr
    {
        public List<ProdusAbstract> elemente = new List<ProdusAbstract>();
        public int Id { get; set; } = 0;

        public void ReadAbsProd(ProdusAbstract item)
        {
            if (!elemente.Contains(item))
            {
                elemente.Add(item);
                Id++;
            }
        }

        public void Sortare()
        {
            elemente.Sort((first, second) =>
            {
                if (first != null && second != null)
                    return first.Pret.CompareTo(second.Pret);
                if (first == null && second == null)
                    return 0;
                if (first != null)
                    return -1;
                return 1;
            });
        }

        public void FiltrareDupaCategorieProd()
        {
            string? cat = Console.ReadLine();
            CriteriuCategorie criteriu = new CriteriuCategorie(cat);
            FIltrareCategorie filtru = new FIltrareCategorie();
            List<ProdusAbstract> rez = filtru.Filtrare(elemente, criteriu);
            if (rez.Any())
            {
                foreach (ProdusAbstract elem in rez)
                {
                    Console.WriteLine(elem.ToString());
                }
            }
        }

        public void FiltrareDupaPretProd()
        {
            int prt = int.Parse(Console.ReadLine() ?? string.Empty);
            CriteriuPret criteriu = new CriteriuPret(prt);
            FiltrarePret filtru = new FiltrarePret();
            List<ProdusAbstract> rez = filtru.Filtrare(elemente, criteriu);
            if (rez.Any())
            {
                foreach (ProdusAbstract elem in rez)
                {
                    Console.WriteLine(elem.ToString());
                }
            }
        }
    }
}
