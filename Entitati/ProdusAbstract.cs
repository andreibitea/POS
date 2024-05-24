using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entitati
{
    [Serializable]
    [XmlInclude(typeof(Produs))]
    [XmlInclude(typeof(Serviciu))]
    public abstract class ProdusAbstract : IPackageable, IComparer<ProdusAbstract>
    {
        public string? Name { get; set; }
        public string? CodIntern { get; set; }
        public int Id { get; set; }
        public string? Categorie { get; set; }
        public int Pret { get; set; }
        public ProdusAbstract(String? name, String? codIntern, int id, string? categorie, int pret)
        {
            Name = name;
            CodIntern = codIntern;
            Id = id;
            Categorie = categorie;
            Pret = pret;
        }

        public ProdusAbstract() { }

        public virtual bool CompareObject(ProdusAbstract itemToAdd)
        {
            if (this.Name == itemToAdd.Name && this.CodIntern == itemToAdd.CodIntern)
            {
                return true;
            }
            return false;
        }

        public virtual bool canAddToPackage(List<ProdusAbstract> prodServ)
        {
            return false;
        }
        public override string ToString()
        {
            return $"{Name}[{CodIntern}] {Categorie} {Pret}";
        }
    }
}