using System.Data;
using System.Xml;
using System.Xml.Serialization;
namespace Entitati
{
    [Serializable]
    public class Serviciu : ProdusAbstract
    {
        public int ServiceNumber { get; set; }
        public Serviciu(int id, string? nume, string? codIntern, string? categorie, int pret) : base(nume, codIntern, id, categorie, pret)
        {

        }
        public Serviciu() : base() { }
        public override bool CompareObject(ProdusAbstract itemToAdd)
        {
            return base.CompareObject(itemToAdd);
        }

        public override string ToString()
        {
            return $"Serviciul: {Name}[{CodIntern}] {Categorie} {Pret}";
        }

        public override bool canAddToPackage(List<ProdusAbstract> prodServ)
        {
            foreach (ProdusAbstract e in prodServ)
            {
                if (e.CompareObject(this))
                    return true;
            }
            return false;

        }
    }
}

