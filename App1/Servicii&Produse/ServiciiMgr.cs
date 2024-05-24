using Entitati;
using System.Xml;

namespace App1
{
    public class ServiciiMgr : ProdusAbstractMgr
    {
        internal Serviciu userInputData(int id)
        {
            string? nume;
            string? codIntern;
            string? categorie;
            int pret;

            Console.WriteLine("Introdu un Serviciu");
            Console.Write("Numele:");
            nume = Console.ReadLine();

            Console.Write("Codul intern:");
            codIntern = Console.ReadLine();
            Console.WriteLine("Categoria: ");
            categorie = Console.ReadLine();
            Console.Write("Pret: ");
            pret = int.Parse(Console.ReadLine() ?? string.Empty);

            return new Serviciu(id, nume, codIntern, categorie, pret);
        }
    }
}
