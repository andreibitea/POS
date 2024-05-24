﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entitati
{
    [Serializable]
    public class Produs : ProdusAbstract
    {
        public string? Producator { get; set; }
        public int ProductNumber { get; set; }
        public Produs(int id, string? name, string? codIntern, string? producator, string? categorie, int pret) : base(name, codIntern, id, categorie, pret)
        {
            Producator = producator;
        }
        public Produs() : base() { }

        public override bool CompareObject(ProdusAbstract itemToAdd)
        {
            if (base.CompareObject(itemToAdd) && this.Producator == ((Produs)itemToAdd).Producator)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"Produsul: {Name}[{CodIntern}] {Producator} {Categorie} {Pret}";
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